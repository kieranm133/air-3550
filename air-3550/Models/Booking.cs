using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int FlightID1 { get; set; }
        public int FlightID2 { get; set; }
        public int FlightID3 { get; set; }
        public string TripType { get; set; }
        public string BookingDate { get; set; }
        public string PaymentMethod { get; set; }
        public int PointsUsed { get; set; }
        public double PricePaid { get; set; }
        public bool IsCancelled { get; set; }
    }
}
