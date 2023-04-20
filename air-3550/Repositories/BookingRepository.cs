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

        public List<Booking> Search(string originAirportId, string destinationAirportId, bool roundTrip)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = @"SELECT * FROM Bookings WHERE BookingID = @BookingID AND CustomerID = @CustomerID";

                    if (roundTrip)
                    {
                        query += " AND BookingDate IS NOT NULL";
                    }

                    var parameters = new { OriginAirportID = originAirportId, DestinationAirportID = destinationAirportId };
                    return connection.Query<Booking>(query, parameters).AsList();
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
