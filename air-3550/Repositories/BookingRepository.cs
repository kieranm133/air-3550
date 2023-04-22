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
    public class BookingRepository
    {
        private readonly string connectionString;

        public BookingRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Booking>? GetAll()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.Query<Booking>("SELECT * FROM Bookings").AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }

        public List<Booking>? GetAll(Customer customerRecord)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    return connection.Query<Booking>("SELECT * FROM Bookings WHERE CustomerID = @CustomerID").AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }


        public List<Booking> Search(int customerID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = @"SELECT * FROM Bookings WHERE CustomerID = @CustomerID";

                    var parameters = new { CustomerID = customerID};
                    return connection.Query<Booking>(query, parameters).AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }
        public void Add(Booking bookings)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql =
                       "INSERT INTO Bookings (CustomerID, FlightID1, FlightID2, FlightID3, TripType, BookingDate, PaymentMethod, PointsUsed, PricePaid, IsCancelled) " +
                       "VALUES (@CustomerID, @FlightID1, @FlightID2, @FlightID3, @TripType, @BookingDate, @PaymentMethod, @PointsUsed, @PricePaid, @IsCancelled); " +
                       "SELECT last_insert_rowid()";

                    bookings.BookingID = connection.QuerySingle<int>(sql, bookings);
                }

            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }


    }
}
