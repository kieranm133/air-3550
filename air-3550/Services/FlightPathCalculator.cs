using air_3550.Database;
using air_3550.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Services
{
    public class FlightPathCalculator
    {
        private DatabaseManager db;

        public static List<ScheduledFlight> GetDirectRoutes(string originAirportID, string destinationAirportID)
        {
            // Get all scheduled flights.
            List<ScheduledFlight> scheduledFlights = DatabaseManager.Instance.ScheduledFlights.GetAll();

            // Filter direct flights from origin to destination.
            return scheduledFlights.Where(flight => flight.OriginAirportID == originAirportID && flight.DestinationAirportID == destinationAirportID).ToList();
        }

        public static List<List<ScheduledFlight>> GetAllRoutes(string originAirportID, string destinationAirportID)
        {
            List<ScheduledFlight> scheduledFlights = DatabaseManager.Instance.ScheduledFlights.GetAll();
            Queue<List<ScheduledFlight>> queue = new Queue<List<ScheduledFlight>>();
            List<List<ScheduledFlight>> validRoutes = new List<List<ScheduledFlight>>();

            int minLayoverTime = 40; // Minimum layover time in minutes.
            int maxLayoverTime = 240; // Maximum layover time in minutes (4 hours).

            // Enqueue direct flights from origin.
            foreach (ScheduledFlight flight in scheduledFlights.Where(f => f.OriginAirportID == originAirportID && f.AircraftID.HasValue))
            {
                queue.Enqueue(new List<ScheduledFlight> { flight });
            }

            while (queue.Count > 0)
            {
                List<ScheduledFlight> currentRoute = queue.Dequeue();

                // If the last flight in the route has the destination airport, add the route to validRoutes.
                if (currentRoute.Last().DestinationAirportID == destinationAirportID)
                {
                    validRoutes.Add(currentRoute);
                }
                // If the current route has less than 3 legs, continue searching for connecting flights.
                else if (currentRoute.Count < 3)
                {
                    string currentAirport = currentRoute.Last().DestinationAirportID;
                    string currentArrivalTime = currentRoute.Last().ArrivalTime;
                    foreach (ScheduledFlight flight in scheduledFlights.Where(f => f.OriginAirportID == currentAirport && f.AircraftID.HasValue))
                    {
                        // Avoid cycles in the route.
                        if (!currentRoute.Any(r => r.ScheduledFlightID == flight.ScheduledFlightID))
                        {
                            int layoverTime = GetLayoverTime(currentArrivalTime, flight.DepartureTime);

                            // Check if the layover time is within the constraints.
                            if (layoverTime >= minLayoverTime && layoverTime <= maxLayoverTime)
                            {
                                List<ScheduledFlight> newRoute = new List<ScheduledFlight>(currentRoute) { flight };
                                queue.Enqueue(newRoute);
                            }
                        }
                    }
                }
            }
            return validRoutes;
        }
        private static int GetLayoverTime(string arrivalTime, string departureTime)
        {
            TimeSpan arrivalTS = TimeSpan.Parse(arrivalTime);
            TimeSpan departureTS = TimeSpan.Parse(departureTime);
            TimeSpan timeDifference = departureTS - arrivalTS;
            return (int)timeDifference.TotalMinutes;
        }
    }
}
