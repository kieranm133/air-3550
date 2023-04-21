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
        public List<Flight>? GetByScheduledFlightID(int scheduledFlightID)
        {
            return GetByScheduledFlightID(new List<int> { scheduledFlightID });
        }
        public List<Flight>? GetByScheduledFlightID(List<int> scheduledFlightIDs)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = "SELECT * FROM Flights WHERE ScheduledFlightID IN @scheduledFlightIDs";
                    return connection.Query<Flight>(sql, new { scheduledFlightIDs = scheduledFlightIDs }).AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }

        public List<Flight>? GetByScheduledFlightIDAndDate(int scheduledFlightID, string departureDate)
        {
            return GetByScheduledFlightIDAndDate(new List<int> { scheduledFlightID }, departureDate);
        }

        public List<Flight>? GetByScheduledFlightIDAndDate(List<int> scheduledFlightIDs, string departureDate)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = "SELECT * FROM Flights WHERE ScheduledFlightID IN @scheduledFlightIDs AND DepartureDate = @departureDate";
                    return connection.Query<Flight>(sql, new { scheduledFlightIDs = scheduledFlightIDs, departureDate =  departureDate }).AsList();
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
                    connection.Execute("DELETE FROM Flights WHERE ScheduledFlightID IN @scheduledFlightIDs", new { scheduledFlightIDs = scheduledFlightIDs });
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }
        public void UpdateSeatsByAircraftAndScheduledFlightID(Aircraft aircraft, int scheduledFlightID)
        {
            UpdateSeatsByAircraftAndScheduledFlightID(aircraft, new List<int> { scheduledFlightID });
        }
        public void UpdateSeatsByAircraftAndScheduledFlightID(Aircraft aircraft, List<int> scheduledFlightIDs)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = "UPDATE Flights SET EmptySeats = @emptySeats WHERE ScheduledFlightID IN @scheduledFlightIDs";
                    connection.Execute(sql, new { emptySeats = aircraft.Capacity, scheduledFlightIDs = scheduledFlightIDs });
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }

        public void Insert(List<Flight> flights)
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
