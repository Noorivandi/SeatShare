using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatDomain.Models
{
    public partial class ClientType
    {
        public ClientType()
        {
        }

        public ClientType(TsetmcDataRow row)
        {
            Prev_Buy_CountI = row.prev_Buy_CountI;
            Prev_Buy_CountN = row.prev_Buy_CountN;
            Prev_Buy_I_Volume = row.prev_Buy_I_Volume;
            Prev_Pl = row.prev_pl;
            Prev_Buy_N_Volume = row.prev_Buy_N_Volume;
            Prev_Sell_CountI = row.prev_Sell_CountI;
            Prev_Sell_CountN = row.prev_Sell_CountN;
            Prev_Sell_I_Volume = row.prev_Sell_I_Volume;
            Prev_Sell_N_Volume = row.prev_Sell_N_Volume;
            Prev_TVol = row.prev_tvol;
            Buy_CountI = row.Buy_CountI;
            Buy_CountN = row.Buy_CountN;
            Buy_I_Volume = row.Buy_I_Volume;
            Buy_N_Volume = row.Buy_N_Volume;
            if (row.DEven > DateTime.Now.Date)
                DayDt = row.DEven;
            else
                DayDt = DateTime.Now;
            InsCode = row.inscode;
            Pl = row.pl;
            Sell_CountI = row.Sell_CountI;
            Sell_CountN = row.Sell_CountN;
            Sell_I_Volume = row.Sell_I_Volume;
            Sell_N_Volume = row.Sell_N_Volume;
            TVol = row.tvol;
            heven = row.LastTradeTime;
            VisitCount = row.visitcount;
            DataRow = row;
        }

        public object DataRow { get; set; }

    }
}
