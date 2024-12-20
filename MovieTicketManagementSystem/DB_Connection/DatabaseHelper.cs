using System;
using System.Data.SqlClient;

namespace MovieTicketManagementSystem.Helpers
{
    public class DatabaseHelper
    {
        private readonly string _connectionString = @"Data Source=THAOMAI\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
