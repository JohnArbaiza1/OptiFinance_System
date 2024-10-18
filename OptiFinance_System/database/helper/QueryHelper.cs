using Microsoft.Data.SqlClient;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.helper;

public static class QueryHelper
{
    private static bool ExecuteNonQuery(SqlConnection connection, string query, List<SqlParameter> parameters,
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
            Message.MessageViewError(@"Error en la consulta SQL: " + e.Message);
            return false;
        }
    }

    public static bool ExecuteInTransaction(SqlConnection connection, Func<SqlTransaction, bool> operation)
    {
        bool isSuccess = false;
        try
        {
            using (SqlTransaction? transaction = connection.BeginTransaction())
            {
                try
                {
                    // Ejecutar la operación pasada como parámetro
                    isSuccess = operation(transaction);

                    if (isSuccess)
                        transaction.Commit();
                    else
                        transaction.Rollback();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Message.MessageViewError(@"Error en la operación: " + ex.Message);
                }
            }
        }
        catch (Exception ex)
        {
            Message.MessageViewError(@"Error al abrir la conexión: " + ex.Message);
        }

        return isSuccess;
    }

    public static bool ExecuteInsert(SqlConnection connection, string query, List<SqlParameter> parameters,
        SqlTransaction? transaction = null)
    {
        return ExecuteNonQuery(connection, query, parameters, transaction);
    }

    public static bool ExecuteUpdate(SqlConnection connection, string query, List<SqlParameter> parameters,
        SqlTransaction? transaction = null)
    {
        return ExecuteNonQuery(connection, query, parameters, transaction);
    }

    public static bool ExecuteDelete(SqlConnection connection, string query, List<SqlParameter> parameters,
        SqlTransaction? transaction = null)
    {
        return ExecuteNonQuery(connection, query, parameters, transaction);
    }

    public static List<T> ExecuteSelect<T>(SqlConnection connection, string query, Func<SqlDataReader, T> func,
        List<SqlParameter>? parameters = null)
    {
        List<T> resultList = new List<T>();
        try
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null) command.Parameters.AddRange(parameters.ToArray());

                using (SqlDataReader? reader = command.ExecuteReader())
                {
                    while (reader.Read()) resultList.Add(func(reader));
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(@"Error en la consulta SQL: " + e.Message);
        }

        return resultList;
    }


    public static T? ExecuteFind<T>(SqlConnection connection, string query, Func<SqlDataReader, T> func,
        List<SqlParameter> parameters)
    {
        T? entity = default;

        try
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddRange(parameters.ToArray());

                using (SqlDataReader? reader = command.ExecuteReader())
                {
                    if (reader.Read()) entity = func(reader);
                }
            }
        }
        catch (Exception e)
        {
            // Message.MessageViewError(@"Error en la consulta SQL refdgdf: " + e.Message);
            throw new Exception(e.Message);
        }

        return entity;
    }
}