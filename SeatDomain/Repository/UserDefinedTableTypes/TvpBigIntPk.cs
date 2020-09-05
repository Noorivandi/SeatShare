using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatDomain.Repository.UserDefinedTableTypes
{
    [Table("BigIntList")]
    public class BigIntList
    {
        public BigIntList(long x)
        {
            Item = x;
        }
        public BigIntList()
        {
        }
        public long Item { get; set; }
    }
}
