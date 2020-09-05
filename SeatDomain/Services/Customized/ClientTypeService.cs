using Exir.Framework.Common;
using Exir.Framework.Service;
using SeatDomain.Models;
using Exir.Framework.Service.Auditer;
using SeatDomain.Repository;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeatDomain.Services
{
    public partial interface IClientTypeService : IAuditerService<ClientType>
    {
        Task BulkInsertAsync(List<ClientType> clientTypes);
    }
    [IgnoreT4Template]
    public partial class ClientTypeService : ReadOnlySupportAuditerService<ClientType, IClientTypeRepository, IReadOnlyClientTypeRepository, IClientTypeService>, IClientTypeService
    {

        protected new IClientTypeService This { get { return base.This<IClientTypeService>(); } }

        public ClientTypeService(IClientTypeRepository repository, IReadOnlyClientTypeRepository readOnlyRepository)
            : base(repository, readOnlyRepository)
        {
        }

        public async Task BulkInsertAsync(List<ClientType> clientTypes)
        {
            var zero_client_types = clientTypes.Where(x => x.Prev_Buy_CountI == 0 && x.Prev_Buy_CountN == 0 && x.Prev_Pl == 0)
               .ToList();
            if (zero_client_types.Count > 0)
            {
                var insCodes = zero_client_types.Select(x => x.InsCode).ToList();
                var date = zero_client_types[0].DayDt.Date;
                var last_db_client_types = Repository.GetLastClientTypes(insCodes, date);

                if (last_db_client_types.Count > 0)
                    foreach (var z in zero_client_types)
                    {
                        var db = last_db_client_types.FirstOrDefaultFast(x => x.InsCode == z.InsCode);
                        if (db != null)
                        {
                            if (z.TVol > db.TVol || z.heven > db.heven)
                            {
                                z.Prev_Buy_CountI = db.Buy_CountI;
                                z.Prev_Buy_CountN = db.Buy_CountN;
                                z.Prev_Buy_I_Volume = db.Buy_I_Volume;
                                z.Prev_Buy_N_Volume = db.Buy_N_Volume;
                                z.Prev_Pl = db.Pl;
                                z.Prev_Sell_CountI = db.Sell_CountI;
                                z.Prev_Sell_CountN = db.Sell_CountN;
                                z.Prev_Sell_I_Volume = db.Sell_I_Volume;
                                z.Prev_Sell_N_Volume = db.Sell_N_Volume;
                                z.Prev_TVol = db.TVol;
                            }
                            else
                            {
                                clientTypes.Remove(z);
                            }
                        }
                    }
            }

            if (clientTypes.Count > 0)
            {
                await Repository.BulkInsertAsync(clientTypes);

                LogInfo("successfuly {0} client types was added", clientTypes.Count());
            }
        }
    }

}
