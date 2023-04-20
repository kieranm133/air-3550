﻿using air_3550.Logging;
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
    public class UserRepository
    {
        private readonly string connectionString;

        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(User user)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string sql =
                       "INSERT INTO Users (UserID, UserType, PasswordHash)" +
                       "VALUES (@UserID, @UserType, @PasswordHash)";
                    connection.Execute(sql, user);
                }
            }
            catch (SqliteException sqlEx)
            {
                Logger.LogException(sqlEx);
            }
        }

        public User GetUserById(int userID) {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    User user = connection.QuerySingleOrDefault<User>("SELECT * FROM Users WHERE UserID = @userID", new { userID = userID });
                    return user;
                }
            }
            catch(SqliteException sqlEx) 
            {
                Logger.LogException(sqlEx);
                return null;
            }
        }
    }
}
