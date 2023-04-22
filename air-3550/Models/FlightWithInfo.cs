using air_3550.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class FlightWithInfo
    {
        public Flight Flight { get; set; }
        public ScheduledFlight ScheduledFlight { get; set; }
        public Airport OriginAirport { get; set; }
        public Airport DestinationAirport { get; set; }
    }
}
