using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Repositories
{
    public class ScheduledFlightRepository
    {
        private readonly string connectionString;

        public ScheduledFlightRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

    }
}
