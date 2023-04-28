using air_3550.Database;
using air_3550.Logging;
using air_3550.Models;
using Dapper;
using Microsoft.Data.Sqlite;

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

        public List<Booking>? GetPricePaid(int flightID1)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = @"SELECT PricePaid FROM Bookings WHERE FlightID1 = @FlightID1";
                    
                    var parameters = new { FlightID1 = flightID1 };

                    return connection.Query<Booking>(query, parameters).AsList();
              
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

        public List<Booking> GetAllByIDWithoutCancellations(int customerID)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = @"SELECT * FROM Bookings 
                                     WHERE CustomerID = @CustomerID
                                     AND IsCancelled = 0";
                    var parameters = new { CustomerID = customerID };
                    return connection.Query<Booking>(query, parameters).AsList();
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }
        public void Cancel(Booking booking)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = @"
                                    UPDATE Bookings
                                    SET IsCancelled = 1
                                    WHERE BookingID = @bookingID";
                    connection.Execute(query, new { bookingID = booking.BookingID });
                }

                // Cascade the change to the flights table to update seat counts.
                var flightIDs = new List<int> { booking.FlightID1 };
                if (booking.FlightID2 != null) { flightIDs.Add((int)booking.FlightID2); }
                if (booking.FlightID3 != null) { flightIDs.Add((int)booking.FlightID3); }
                DatabaseManager.Instance.Flights.UnreserveSeatByFlightID(flightIDs);
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }
        public void Insert(Booking booking)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql =
                       "INSERT INTO Bookings (CustomerID, FlightID1, FlightID2, FlightID3, TripType, BookingDate, PaymentMethod, PointsUsed, PricePaid, IsCancelled, PointsAwarded) " +
                       "VALUES (@CustomerID, @FlightID1, @FlightID2, @FlightID3, @TripType, @BookingDate, @PaymentMethod, @PointsUsed, @PricePaid, @IsCancelled, @PointsAwarded); " +
                       "SELECT last_insert_rowid()";

                    booking.BookingID = connection.QuerySingle<int>(sql, booking);
                }
                // Cascade the change to the flights table to update seat counts.
                var flightIDs = new List<int> { booking.FlightID1 };
                if (booking.FlightID2 != null) { flightIDs.Add((int)booking.FlightID2); } 
                if (booking.FlightID3 != null) { flightIDs.Add((int)booking.FlightID3); } 
                DatabaseManager.Instance.Flights.ReserveSeatByFlightID(flightIDs);
            }

            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }


    }
}
