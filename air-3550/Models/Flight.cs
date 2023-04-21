using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class Flight
    {
        public int FlightID { get; set; }
        public int ScheduledFlightID { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public int? EmptySeats { get; set; }

    }
}
