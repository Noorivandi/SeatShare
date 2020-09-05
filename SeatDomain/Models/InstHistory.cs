using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatDomain.Models
{
    public class InstHistory
    {
        public int PClosing { get;  set; } // قیمت پایانی
        public int PDrCotVal { get;  set; } // قیمت آخرین معامله
        public long ZTotTran { get;  set; } // تعداد معاملات
        public long QTotTran5J { get;  set; } // حجم معاملات
        public long QTotCap { get;  set; } // ارزش معاملات
        public int PriceMin { get;  set; } // حداقل قیمت
        public int PriceMax { get;  set; } // حداکثر قیمت
        public int PriceYesterday { get;  set; } // قیمت روز قبل
        public int PriceFirst { get;  set; } // قیمت آغازین
    }
}
