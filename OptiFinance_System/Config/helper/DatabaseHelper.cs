using System.Data;
using Microsoft.Data.SqlClient;
using OptiFinance_System.Config;
using OptiFinance_System.Config.connection;

namespace OptiFinance_System.Config.Helper
{
    public class DatabaseHelper
    {
        private readonly string? _connectionString;

        public DatabaseHelper(string? connectionString)
        {
            _connectionString = connectionString;
        }

        public int ExecuteQuery(string query)
        {
            using (SqlConnection? connection = Connection.Instance.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                return 1;
            }
        }

        public SqlDataReader ExecuteReader(string query, SqlConnection connection)
        {
            SqlConnection connectionLocal = connection;
            SqlCommand command = new SqlCommand(query, connectionLocal);
            connectionLocal.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}