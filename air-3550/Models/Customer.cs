using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class Customer
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int PointsUsed { get; set; }
        public int PointsAvailable { get; set; }
        public string CreditCard { get; set; }
    }
}
