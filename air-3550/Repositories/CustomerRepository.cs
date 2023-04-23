using air_3550.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using air_3550.Logging;
using Microsoft.VisualBasic.ApplicationServices;

namespace air_3550.Repositories
{
    public class CustomerRepository
    {
        private readonly string connectionString;

        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(Customer customer)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString)) 
                { 
                    string sql = 
                       "INSERT INTO Customers (UserID, FirstName, LastName, Address, Phone, Age, PointsUsed, PointsAvailable, CreditCard) " +
                       "VALUES (@UserID, @FirstName, @LastName, @Address, @Phone, @Age, @PointsUsed, @PointsAvailable, @CreditCard)";
                    connection.Execute(sql, customer);
                }
            }
            catch (SqliteException sqlEx) {
                Logger.LogException(sqlEx);
            }
        }
        public Customer GetByID(int userID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.QuerySingleOrDefault<Customer>("SELECT * FROM Customers WHERE UserID = @userID", new { userID = userID });
                }
            }
            catch(SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }

        public List<Customer> getCustomersByFlightID(int flightID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = @"
                        SELECT c.*
                        FROM Customers c
                        JOIN Bookings b ON c.UserID = b.CustomerID
                        JOIN Flights f ON b.FlightID1 = f.FlightID
                        WHERE f.FlightID = @flightID";
                    return connection.Query<Customer>(sql, new { flightID = flightID }).ToList();
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
