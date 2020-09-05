using Exir.Framework.Common;
using Exir.Framework.Common.Linq;
using Exir.Framework.Service.ActionResponses;
using SeatDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatDomain.Services
{
    public partial interface IBigDealService
    {
        DataPageResponse<BigDeal> SearchByInsCode(long insCode, BigDealSearchModel searchModel);
        DataPageResponse<BigDeal> Search(BigDealSearchModel searchModel);
        Task<int> ExtractBigDealsAsync(IEnumerable<ClientType> clientTypes);
    }
    public partial class BigDealService
    {
        public BigDealService(IRepository<BigDeal> repository, IReadOnlyRepository<BigDeal> readOnlyRepository) : base(repository, readOnlyRepository)
        {
        }

        public async Task<int> ExtractBigDealsAsync(IEnumerable<ClientType> clientTypes)
        {
            const long min_money = 1_000_000_000;
            var bigDeals = clientTypes.Where(x => x.Buy_CountI - x.Prev_Buy_CountI > 0 &&
              (x.Buy_I_Volume - x.Prev_Buy_I_Volume) / (x.Buy_CountI - x.Prev_Buy_CountI) * x.Pl > min_money)
                  .Select(x => CreateBigDeal(x,
                  x.Buy_CountI - x.Prev_Buy_CountI,
                  x.Buy_I_Volume - x.Prev_Buy_I_Volume,
                  Constants.BigDeals.DealTypes.Buy,
                  Constants.BigDeals.TraderTypes.Individual)).ToList();

            bigDeals.AddRange(clientTypes.Where(x => x.Sell_CountI - x.Prev_Sell_CountI > 0 &&
            (x.Sell_I_Volume - x.Prev_Sell_I_Volume) / (x.Sell_CountI - x.Prev_Sell_CountI) * x.Pl > min_money)
                 .Select(x => CreateBigDeal(x,
                  x.Sell_CountI - x.Prev_Sell_CountI,
                  x.Sell_I_Volume - x.Prev_Sell_I_Volume,
                  Constants.BigDeals.DealTypes.Sell,
                  Constants.BigDeals.TraderTypes.Individual)));

            bigDeals.AddRange(clientTypes.Where(x => x.Buy_CountN - x.Prev_Buy_CountN > 0 &&
              (x.Buy_N_Volume - x.Prev_Buy_N_Volume) / (x.Buy_CountN - x.Prev_Buy_CountN) * x.Pl > min_money)
                  .Select(x => CreateBigDeal(x,
                  x.Buy_CountN - x.Prev_Buy_CountN,
                  x.Buy_N_Volume - x.Prev_Buy_N_Volume,
                  Constants.BigDeals.DealTypes.Buy,
                  Constants.BigDeals.TraderTypes.Legal)));

            bigDeals.AddRange(clientTypes.Where(x => x.Sell_CountN - x.Prev_Sell_CountN > 0 &&
            (x.Sell_N_Volume - x.Prev_Sell_N_Volume) / (x.Sell_CountN - x.Prev_Sell_CountN) * x.Pl > min_money)
                 .Select(x => CreateBigDeal(x,
                  x.Sell_CountN - x.Prev_Sell_CountN,
                  x.Sell_N_Volume - x.Prev_Sell_N_Volume,
                  Constants.BigDeals.DealTypes.Sell,
                  Constants.BigDeals.TraderTypes.Legal)));

            if (bigDeals.Count > 0)
            {
                await Repository.BulkInsertAsync(bigDeals);

                LogInfo("successfuly {0} big deals was added", bigDeals.Count);
            }

            return bigDeals.Count;
        }

        private static BigDeal CreateBigDeal(ClientType x, int count, long vol, byte dealType, byte traderType)
        {
            var row = x.DataRow as TsetmcDataRow;
            return new BigDeal()
            {
                AmountAvg = vol / count * x.Pl,
                Count = count,
                DayDt = x.DayDt,
                DealType = dealType,
                Price = x.Pl,
                InsCode = x.InsCode,
                TraderType = traderType,
                Volume = vol,
                CSecVal = row.cs.ToString(),
                pc = row.pc,
                plc = row.plc,
                plp = row.plp,
                py = row.py,
                eps = row.eps,
                pcc = row.pcc,
                pcp = row.pcp,
                pd1 = row.pd1,
                pe = row.pe,
                pf = row.pf,
                po1 = row.po1,
                pmax = row.pmax,
                pmin = row.pmin,
                qd1 = row.qd1,
                tmax = row.tmax,
                qo1 = row.qo1,
                tmin = row.tmin,
                tno = row.tno,
                tval = row.tval,
                tvol = row.tvol,
                zd1 = row.zd1,
                zo1 = row.zo1,
                visitcount = row.visitcount
            };
        }
        public DataPageResponse<BigDeal> SearchByInsCode(long insCode, BigDealSearchModel searchModel)
        {
            if (searchModel == null)
                searchModel = new BigDealSearchModel();
            searchModel.InsCode = insCode;
            if (!searchModel.FromDt.HasValue)
            {
                var hSrv = ServiceFactory.Create<IHolidayService>();
                if (hSrv.IsWorkingDay(DateTime.Now.Date))
                {
                    searchModel.FromDt = GetDefaultQuery()
                        .Where(x => x.InsCode == insCode)
                        .OrderByDescending(x => x.DayDt)
                        .Select(x => x.DayDt)
                        .FirstOrDefault();
                }
                else
                    searchModel.FromDt = DateTime.Now.Date;
            }

            if (!searchModel.MinMoney.HasValue)
                searchModel.MinMoney = Constants.BigDealsMinMoney;

            return Search(searchModel);
        }
        public DataPageResponse<BigDeal> Search(BigDealSearchModel searchModel)
        {
            var predicate = PredicateBuilder.New<BigDeal>(x => true);

            if (searchModel.InsCode.HasValue)
                predicate = predicate.And(x => x.InsCode == searchModel.InsCode.Value);

            if (!String.IsNullOrEmpty(searchModel.CSecVal))
                predicate = predicate.And(x => x.CSecVal == searchModel.CSecVal);

            if (searchModel.MinMoney.HasValue)
                predicate = predicate.And(x => x.AmountAvg >= searchModel.MinMoney || x.AmountAvg >= searchModel.MinMoney);

            if (searchModel.FromDt.HasValue)
                predicate = predicate.And(x => x.DayDt >= searchModel.FromDt);

            if (searchModel.TraderType.HasValue)
                predicate = predicate.And(x => x.TraderType == searchModel.TraderType.Value);

            if (searchModel.DealType.HasValue)
                predicate = predicate.And(x => x.DealType == searchModel.DealType.Value);

            if (searchModel.ToDt.HasValue)
                predicate = predicate.And(x => x.DayDt <= searchModel.ToDt);

            var query = GetDefaultQuery().Where(predicate);

            if (searchModel.Sorting != null &&
                (searchModel.Sorting[0].Name == nameof(BigDeal.Time) ||
                searchModel.Sorting[0].Name == nameof(BigDeal.Date)))
                searchModel.Sorting[0].Name = nameof(BigDeal.DayDt);

            var count = query.Count();

            query = ApplySortingRule(query, searchModel, x => x.DayDt);
            query = ApplyPagingRule(query, searchModel);

            var data = query.ToList();

            if (!searchModel.InsCode.HasValue)
            {
                var iSrv = ServiceFactory.Create<IInstrumentService>();
                var ins = iSrv.GetAll();
                for (var i = 0; i < data.Count; ++i)
                {
                    var instrument = ins.FirstOrDefault(x => x.InsCode == data[i].InsCode);
                    if (instrument != null)
                    {
                        data[i].Symbol = instrument.Symbol;
                    }
                }
            }

            return new DataPageResponse<BigDeal>()
            {
                Data = data,
                Filterable = false,
                PageNumber = searchModel.PageNumber,
                TotalRecordCount = count,
                Success = true
            };
        }
    }
}
