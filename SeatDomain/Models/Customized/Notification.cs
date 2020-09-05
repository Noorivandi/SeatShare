using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatDomain.Models
{
    public partial class Notification
    {
        public bool PhoneNumberConfirmed { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
