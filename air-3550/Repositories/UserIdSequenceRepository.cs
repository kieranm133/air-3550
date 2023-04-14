using air_3550.Logging;
using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Repositories
{
    public class UserIdSequenceRepository
    {
        private readonly string connectionString;
        public UserIdSequenceRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int GetNextUserID()
        {
            int nextUserID;
            try
            {
                using(SqliteConnection con = new SqliteConnection(connectionString))
                {
                    con.Execute("INSERT INTO UserIdSequence DEFAULT VALUES");
                    nextUserID = con.QuerySingle<int>("SELECT last_insert_rowid()");
                } 
                return nextUserID;
            }
            catch (Exception sqlEx) 
            {
                Logger.LogException(sqlEx);
                return -1;
            }
        }
    }
}
