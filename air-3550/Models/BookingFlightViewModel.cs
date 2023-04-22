using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class BookingFlightViewModel
    {
        public double Price { get; set; }
        public int Connections { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public List<int> FlightIDs { get; set; }
    }
}
