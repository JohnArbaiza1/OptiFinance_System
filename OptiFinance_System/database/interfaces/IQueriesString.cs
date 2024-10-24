using Microsoft.Data.SqlClient;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.interfaces;

public interface IQueriesString<T>
{
    string SqlInsert { get; }
    string SqlUpdate { get; }
    string SqlDelete { get; }
    string SqlFindById { get; }
    string SqlSelectAll { get; }
    string SqlSearchAll { get; }
    List<SqlParameter> ParametersInsert(T entity);
    List<SqlParameter> ParametersUpdate(T entity);
    List<SqlParameter> ParametersDelete(long id);
    List<SqlParameter> ParametersFindById(long id, Usuario? user = null);
    List<SqlParameter> ParametersSearchAll(string search);

    T Map(SqlDataReader reader);
}