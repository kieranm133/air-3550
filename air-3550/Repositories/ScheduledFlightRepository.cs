using air_3550.Database;
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
        // When we add a scheduled flight, trigger a cascade to the Flights table that adds the same scheduled flight at the same time each day for the next 6 months.
        public void Add(ScheduledFlight scheduledFlight)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql =
                       "INSERT INTO ScheduledFlights (OriginAirportID, DestinationAirportID, AircraftID, DepartureTime, ArrivalTime, Distance) " +
                       "VALUES (@OriginAirportID, @DestinationAirportID, @AircraftID, @DepartureTime, @ArrivalTime, @Distance); " +
                       "SELECT last_insert_rowid()";

                    scheduledFlight.ScheduledFlightID = connection.QuerySingle<int>(sql, scheduledFlight);
                    List<Flight> flightsToAdd = generateFlightsForSixMonths(scheduledFlight);
                    DatabaseManager.Instance.Flights.InsertFlights(flightsToAdd);
                }

            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }
        // When we delete a scheduled flight, cascade the changes to the Flights table 
        public void DeleteByID(int scheduledFlightID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql =
                       "DELETE FROM ScheduledFlights WHERE ScheduledFlightID = @scheduledFlightID";
                    connection.Execute(sql, new { scheduledFlightID = scheduledFlightID });
                }
                DatabaseManager.Instance.Flights.DeleteByScheduledFlightID(scheduledFlightID);
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }

        }

        private List<Flight> generateFlightsForSixMonths(ScheduledFlight scheduledFlight)
        {
            return generateFlightsForSixMonths(new List<ScheduledFlight> { scheduledFlight });
        }

        private List<Flight> generateFlightsForSixMonths(List<ScheduledFlight> scheduledFlights)
        {
            List<Flight> flights = new List<Flight>();
            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddMonths(6);

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                foreach (var scheduledFlight in scheduledFlights)
                {
                    DateTime departureDateTime = date.Add(TimeSpan.Parse(scheduledFlight.DepartureTime));
                    DateTime arrivalDateTime = date.Add(TimeSpan.Parse(scheduledFlight.ArrivalTime));

                    Flight flight = new Flight
                    {
                        ScheduledFlightID = scheduledFlight.ScheduledFlightID,
                        DepartureDate = departureDateTime.ToShortDateString(),
                        ArrivalDate = arrivalDateTime.ToShortDateString(),
                        EmptySeats = null
                    };
                    flights.Add(flight);
                }
            }

            return flights;
        }
    }
}
