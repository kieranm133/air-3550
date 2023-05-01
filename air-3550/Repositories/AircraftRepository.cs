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
    public class AircraftRepository
    {
        private readonly string connectionString;

        public AircraftRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method to return the aircraft database table
        public List<Aircraft>? GetAll()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.Query<Aircraft>("SELECT * FROM Aircraft").AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }

        public Aircraft GetByID(int aircraftID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.QuerySingle<Aircraft>("SELECT * FROM Aircraft WHERE @aircraftID = aircraftID", new { aircraftID = aircraftID });
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