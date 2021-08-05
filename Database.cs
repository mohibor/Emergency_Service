using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace EmergencyService
{
    class Database
    {
        private static string serverName = @"LAPTOP-21P2UACQ\SQLEXPRESS";

        private static string databaseName = @"Emergency Service Database";
        private static string connectionString = String.Format(@"Server={0};Database={1};Integrated Security=true;", serverName, databaseName);
        private static Database instance = null;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
