using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class ScheduleViewModel
    {
        public ScheduledFlight ScheduledFlight { get; set; }
        public Airport OriginAirport { get; set; }
        public Airport DestinationAirport { get; set; }
        public Aircraft Aircraft { get; set; }
    }
}
