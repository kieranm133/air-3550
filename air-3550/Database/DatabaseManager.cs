using air_3550.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Database
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;
        private readonly string connectionString;
        
        //TODO: Add more repositories
        public AircraftRepository Aircraft { get; }
        public AirportRepository Airports { get; }
        public BookingRepository Bookings { get; }
        public ConnectionRepository Connections { get; }
        public CustomerRepository Customers { get; }
        public FlightRepository Flights { get; }
        public ScheduledFlightRepository ScheduledFlights { get; }
        public UserIdSequenceRepository UserIdSequences { get; }
        public UserRepository Users { get; }


        private DatabaseManager() { 
            string databaseFileLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "air3550.db");
            this.connectionString = $"Data Source={databaseFileLocation};";
            this.Aircraft = new AircraftRepository(connectionString);
            this.Airports = new AirportRepository(connectionString);
            this.Bookings = new BookingRepository(connectionString);
            this.Connections = new ConnectionRepository(connectionString);
            this.Customers = new CustomerRepository(connectionString);
            this.Flights = new FlightRepository(connectionString);
            this.ScheduledFlights = new ScheduledFlightRepository(connectionString);
            this.Users = new UserRepository(connectionString);
            this.UserIdSequences = new UserIdSequenceRepository(connectionString);
        }
        public static DatabaseManager Instance { 
            get { 
                if (instance == null)
                    instance = new DatabaseManager(); 
                return instance; 
            }
        }
    }
}
