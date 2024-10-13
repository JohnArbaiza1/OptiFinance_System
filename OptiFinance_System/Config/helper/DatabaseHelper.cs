using System.Data;
using Microsoft.Data.SqlClient;
using OptiFinance_System.Config;
using OptiFinance_System.Config.connection;

namespace OptiFinance_System.Config.Helper
{
    public class DatabaseHelper
    {
        private readonly string? _connectionString;

        public DatabaseHelper()
        {
            _connectionString = Conexion.Instance.GetConnectionString();
        }

        public int ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                return 1;
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}