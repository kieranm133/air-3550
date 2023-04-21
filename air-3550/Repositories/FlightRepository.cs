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
            DeleteByScheduledFlightID(new List<int>{ scheduledFlightID });
        }
        public void DeleteByScheduledFlightID(List<int> scheduledFlightIDs)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Execute("DELETE FROM Flights WHERE ScheduledFlightID = @scheduledFlightIDs", new { scheduledFlightIDs = scheduledFlightIDs });
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
                    connection.Open();
                    using (SqliteTransaction transaction = connection.BeginTransaction())
                    {
                        string sql = "INSERT INTO Flights (ScheduledFlightID, DepartureDate, ArrivalDate, EmptySeats) " +
                                     "VALUES (@ScheduledFlightID, @DepartureDate, @ArrivalDate, @EmptySeats)";
                        connection.Execute(sql, flights, transaction);
                        transaction.Commit();
                    }
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }

    }
}
