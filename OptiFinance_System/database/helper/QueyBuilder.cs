namespace OptiFinance_System.database.helper;

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

public class QueryBuilder<T>
{
    private StringBuilder _query;
    private List<SqlParameter> _parameters;

    public QueryBuilder()
    {
        _query = new StringBuilder();
        _parameters = new List<SqlParameter>();
    }

    public QueryBuilder<T> SelectAll()
    {
        _query.Append($"SELECT * FROM {typeof(T).Name.ToLower()}s");
        return this;
    }

    public QueryBuilder<T> Where(string column, object value, string condition = "=")
    {
        if (_query.ToString().Contains("WHERE"))
        {
            _query.Append($" AND {column} {condition} @{column}");
        }
        else
        {
            _query.Append($" WHERE {column} {condition} @{column}");
        }
        
        _parameters.Add(new SqlParameter($"@{column}", value));
        return this;
    }

    public QueryBuilder<T> WhereLike(string column, string value)
    {
        return Where(column, $"%{value}%", "LIKE");
    }

    public QueryBuilder<T> WhereBetween(string column, object value1, object value2)
    {
        _query.Append($" WHERE {column} BETWEEN @{column}Start AND @{column}End");
        _parameters.Add(new SqlParameter($"@{column}Start", value1));
        _parameters.Add(new SqlParameter($"@{column}End", value2));
        return this;
    }

    public string BuildQuery()
    {
        return _query.ToString();
    }

    public List<SqlParameter> BuildParameters()
    {
        return _parameters;
    }

    // Método que integra el QueryBuilder con el ExecuteSelect de QueryHelper
    public List<T> ExecuteQuery(SqlConnection connection, Func<SqlDataReader, T> mapFunc)
    {
        string query = BuildQuery();
        List<SqlParameter> parameters = BuildParameters();
        return QueryHelper.ExecuteSelect(connection, query, mapFunc, parameters);
    }
}
