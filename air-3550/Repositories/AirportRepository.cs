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
    public class AirportRepository
    {
        private readonly string connectionString;

        public AirportRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method to return airport database table
        public List<Airport>? GetAll()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.Query<Airport>("SELECT * FROM Airports").AsList();
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
