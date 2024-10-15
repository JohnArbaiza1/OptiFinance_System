using Microsoft.Data.SqlClient;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.helper;

public class QueryHelper
{
    public static bool ExecuteNonQuery(SqlConnection connection, string query, List<SqlParameter> parameters,
        SqlTransaction? transaction = null)
    {
        try
        {
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddRange(parameters.ToArray());
                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al ejecutar la consulta SQL: " + e.Message);
            return false;
        }
    }
}