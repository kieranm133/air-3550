using air_3550.Logging;
using air_3550.Models;
using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        // GGets all of the flights from the flights table in the database
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
        // Gets flights by flight ID
        public Flight GetByID(int flightID)
        {
            return GetByID(new List<int> { flightID }).First();
        }
        public List<Flight>? GetByID(List<int> flightIDs)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = "SELECT * FROM Flights WHERE FlightID IN @flightIDs";
                    return connection.Query<Flight>(sql, new { flightIDs = flightIDs }).AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
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
        // Gets all of the flights by the scheduled flight id and the departure date for the search button in customer
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
        // Inserts a flight into the flight table in database
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
        // Updates the lfight with info model to be used to get all information from flight
        public  List<FlightWithInfo> GetFlightsWithInfo(List<int> flightIDs)
        {
            // Replace with your SQLite connection string
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = @"
                            SELECT f.*, sf.*, oa.*, da.*
                            FROM Flight f
                            JOIN ScheduledFlight sf ON f.ScheduledFlightID = sf.ScheduledFlightID
                            JOIN Airport oa ON sf.OriginAirportID = oa.AirportID
                            JOIN Airport da ON sf.DestinationAirportID = da.AirportID
                            WHERE f.FlightID IN @FlightIDs";

                    var result = connection.Query<Flight, ScheduledFlight, Airport, Airport, FlightWithInfo>(
                        sql,
                        (flight, scheduledFlight, originAirport, destinationAirport) =>
                        {
                            return new FlightWithInfo
                            {
                                Flight = flight,
                                ScheduledFlight = scheduledFlight,
                                OriginAirport = originAirport,
                                DestinationAirport = destinationAirport
                            };
                        },
                        new { FlightIDs = flightIDs },
                        splitOn: "ScheduledFlightID, AirportID, AirportID");

                    return result.ToList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }
        // Gets income from flgith by its ID
        public double GetFlightTotalIncome(int flightID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    // Join FlightID = Bookings.FlightID1 and look at price paid, group by total price 
                    string sql = @"
                            SELECT Sum(PricePaid)
                            FROM Bookings
                            JOIN Flights on Bookings.FlightID1 = Flights.FlightID
                            WHERE Flights.FlightID = @flightID";
                    return connection.ExecuteScalar<double>(sql, new { flightID = flightID });
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return 0;
            }
        }

        //C Changes ammount of seats available on flight when a user books flight
        public void ReserveSeatByFlightID(List<int> flightIDs) 
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = "UPDATE Flights SET EmptySeats = EmptySeats - 1 WHERE FlightID IN @flightIDs";
                    connection.Execute(sql, new { flightIDs = flightIDs });
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }
        // Adds another seat to flight when customer cancels flight
        public void UnreserveSeatByFlightID(List<int> flightIDs)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = "UPDATE Flights SET EmptySeats = EmptySeats + 1 WHERE FlightID IN @flightIDs";
                    connection.Execute(sql, new { flightIDs = flightIDs });
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }
        // Gets a flightWithInfo based on flight ID
        public FlightWithInfo GetAllFlightInfoByID(int flightID)
        {
            return GetAllFlightInfoByID(new List<int> { flightID }).First();
        }
        // Gets multiple FlightWithInfo based on multipel flight IDs
        public List<FlightWithInfo> GetAllFlightInfoByID(List<int> flightIDs)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"
                        SELECT *
                        FROM Flights f
                        INNER JOIN ScheduledFlights sf ON f.ScheduledFlightID = sf.ScheduledFlightID
                        INNER JOIN Aircraft a ON sf.AircraftID = a.AircraftID
                        INNER JOIN Airports origin ON sf.OriginAirportID = origin.AirportID
                        INNER JOIN Airports destination ON sf.DestinationAirportID = destination.AirportID
                        WHERE f.FlightID IN @flightIDs";

                    var query = connection.QueryMultiple(sql, new { flightIDs = flightIDs });
                    List<FlightWithInfo> flightsWithInfo = query.Read<Flight, ScheduledFlight, Aircraft, Airport, Airport, FlightWithInfo>(
                        // Map out the objects from the query
                        (flight, scheduledFlight, aircraft, originAirport, destinationAirport) =>
                        {
                            return new FlightWithInfo
                            {
                                Flight = flight,
                                ScheduledFlight = scheduledFlight,
                                Aircraft = aircraft,
                                OriginAirport = originAirport,
                                DestinationAirport = destinationAirport
                            };
                        },
                        // Split on the IDs to separate the objects
                        splitOn: "ScheduledFlightID,AircraftID,AirportID,AirportID"
                    ).ToList();

                    return flightsWithInfo;
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
