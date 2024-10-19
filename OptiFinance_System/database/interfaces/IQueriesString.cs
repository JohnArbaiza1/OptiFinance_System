using Microsoft.Data.SqlClient;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.interfaces;

public interface IQueriesString<T>
{
    string InsertSql { get; }
    string UpdateSql { get; }
    string DeleteSql { get; }
    string FindByIdSql { get; }
    string SelectAllSql { get; }
    List<SqlParameter> InsertParameters(T entity);
    List<SqlParameter> UpdateParameters(T entity);
    List<SqlParameter> DeleteParameters(long id);
    List<SqlParameter> FindByIdParameters(long id, Usuario? user = null);
    
    T Map(SqlDataReader reader);
}