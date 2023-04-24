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
        public void Update(Customer customer)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql = @"
                        UPDATE Customers SET 
                        FirstName = @FirstName,
                        LastName = @LastName,
                        Address = @Address, 
                        Phone = @Phone, 
                        Age = @Age, 
                        PointsUsed = @PointsUsed, 
                        PointsAvailable = @PointsAvailable, 
                        CreditCard = @CreditCard
                        WHERE UserID = @UserID";
                    connection.Execute(sql, customer);
                }
            }
            catch (SqliteException sqlEx)
            {
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

        public List<Customer> GetCustomersByFlightID(int flightID)
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
                        WHERE f.FlightID = @flightID
                        AND b.IsCancelled = 0";
                    return connection.Query<Customer>(sql, new { flightID = flightID }).ToList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }

        // Updates the amount of customer points based on date. If the current date has passed, 
        public void UpdateCustomerPoints()
        {
            try
            {
                // First, update PointsUsed 
                string getCurrentDate = DateTime.Now.ToString("yyyy-MM-dd");
                // Set the new value of PointsAvailable = to 
                string updatePointsAvailable = $@"
                        UPDATE Customers 
                        SET PointsAvailable = PointsAvailable + (
                            SELECT IFNULL(SUM(CAST((Bookings.PricePaid * 10) AS INTEGER)), 0)
                            FROM Bookings
                            INNER JOIN Flights ON Bookings.FlightID1 = Flights.FlightID
                            WHERE julianday(Flights.DepartureDate) < julianday('{getCurrentDate}')
                            AND Bookings.PointsAwarded = 0
                            AND Bookings.PricePaid != 0
                            AND Bookings.CustomerID = Customers.UserID
                        );";
                // Set PointsAwarded to true for all of the Bookings we just looked at.
                string updatePointsAwarded = $@"
                        UPDATE Bookings
                        SET PointsAwarded = 1
                        WHERE EXISTS (
                            SELECT 1
                            FROM Flights
                            WHERE Bookings.FlightID1 = Flights.FlightID
                            AND julianday(Flights.DepartureDate) < julianday('{getCurrentDate}')
                        )
                        AND Bookings.PointsAwarded = 0
                        AND Bookings.PricePaid != 0;";

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    using (SqliteCommand command = new SqliteCommand(updatePointsAvailable, connection))
                    {
                        command.ExecuteNonQuery();
                    }




                    using (SqliteCommand command = new SqliteCommand(updatePointsAwarded, connection))
                    {
                        command.ExecuteNonQuery();
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
