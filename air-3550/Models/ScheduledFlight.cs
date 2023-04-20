using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class ScheduledFlight
    {
        public int ScheduledFlightID { get; set; }
        public string OriginAirportID { get; set; }
        public string DestinationAirportID { get; set;}
        public int? AircraftID { get; set;}
        public string DepartureTime { get; set;}
        public string ArrivalTime { get; set;}
        public double Distance { get; set;}
    }
}
