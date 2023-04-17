using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Repositories
{
    public class AircraftRepository
    {
        private readonly string connectionString;

        public AircraftRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

    }
}
