using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Repositories
{
    public class BookingRepository
    {
        private readonly string connectionString;

        public BookingRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

    }
}
