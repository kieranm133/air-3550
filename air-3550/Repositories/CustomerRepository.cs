using air_3550.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace air_3550.Repositories
{
    public class CustomerRepository
    {
        private readonly string connectionString;

        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddCustomer(Customer customer)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            using var command = new SqliteCommand(
               "INSERT INTO Customers (user_id, first_name, last_name, address, phone, age, points_used, points_available, credit_card) " +
               "VALUES (@UserID, @FirstName, @LastName, @Address, @Phone, @Age, @PointsUsed, @PointsAvailable, @CreditCard)",
               connection
            );
            command.Parameters.AddWithValue("@UserID", customer.UserID);
            command.Parameters.AddWithValue("@FirstName", customer.FirstName);
            command.Parameters.AddWithValue("@LastName", customer.LastName);
            command.Parameters.AddWithValue("@Address", customer.Address);
            command.Parameters.AddWithValue("@Phone", customer.Phone);
            command.Parameters.AddWithValue("@Age", customer.Age);
            command.Parameters.AddWithValue("@PointsUsed", customer.PointsUsed);
            command.Parameters.AddWithValue("@PointsAvailable", customer.PointsAvailable);
            command.Parameters.AddWithValue("@CreditCard", customer.CreditCard);
            command.ExecuteNonQuery();  
        }

        public Customer getCustomerByID(int userID)
        {
            using var connection = new SqliteConnection(connectionString);
            return connection.QuerySingleOrDefault<Customer>("SELECT * FROM Customer WHERE user_id = @userID", new { userID = userID });
        }
    }
}
