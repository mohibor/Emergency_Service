using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace EmergencyService
{
    sealed class Database
    {
        private static string serverName = @"LAPTOP-21P2UACQ\SQLEXPRESS";
        private static string databaseName = @"es_db";
        private static string connectionString = String.Format(@"Server={0};Database={1};Integrated Security=true;", serverName, databaseName);

        private static SqlConnection connection = new SqlConnection(connectionString);
        public static SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
