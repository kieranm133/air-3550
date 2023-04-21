using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class Aircraft
    {
        public int AircraftID { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string ModelAndCapacity => $"{Model} - {Capacity} seats";
    }
}
