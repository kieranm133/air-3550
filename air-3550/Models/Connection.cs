using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class Connection
    {
        public int ConnectionID { get; set; } 
        public int ScheduledFlightID1 { get; set; } 
        public int ScheduledFlightID2 { get; set; } 
        public int LayoverTime { get; set; } 
    }
}
