using air_3550.Logging;
using air_3550.Models;
using Dapper;
using Microsoft.Data.Sqlite;
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

        public List<ScheduledFlight>? GetAll()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.Query<ScheduledFlight>("SELECT * FROM ScheduledFlights").AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }

    }
}
