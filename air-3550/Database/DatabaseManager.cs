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
        public CustomerRepository Customers { get; }
        public UserRepository Users { get; }
        public UserIdSequenceRepository UserIdSequences { get; }    

        private DatabaseManager() {

            string databaseFileLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "air3550.db");
            this.connectionString = $"Data Source={databaseFileLocation};";
            this.Customers = new CustomerRepository(connectionString);
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
