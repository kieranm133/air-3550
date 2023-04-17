using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Repositories
{
    public class FlightRepository
    {
        private readonly string connectionString;

        public FlightRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

    }
}
