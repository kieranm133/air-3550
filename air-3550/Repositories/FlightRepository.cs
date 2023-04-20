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
    public class FlightRepository
    {
        private readonly string connectionString;

        public FlightRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Flight>? GetAll()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.Query<Flight>("SELECT * FROM Flights").AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }


        public void DeleteByID(int flightID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Execute("DELETE FROM Flights WHERE FlightID = @flightID", new { flightID = flightID });
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }

        public void DeleteByScheduledFlightID(int scheduledFlightID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Execute("DELETE FROM Flights WHERE ScheduledFlightID = @scheduledFlightID", new { scheduledFlightID = scheduledFlightID });
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }

        public void InsertFlights(List<Flight> flights)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = "INSERT INTO Flights (ScheduledFlightID, DepartureDate, ArrivalDate, EmptySeats) " +
                                 "VALUES (@ScheduledFlightID, @DepartureDate, @ArrivalDate, @EmptySeats)";
                    connection.Execute(sql, flights); 
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }

    }
}
