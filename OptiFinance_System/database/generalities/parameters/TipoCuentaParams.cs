using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class TipoCuentaParams : IQueriesString<TipoCuenta>
{
    public string SqlInsert => "INSERT INTO tipo_cuenta (nombre) VALUES (@nombre)";
    public string SqlUpdate => "UPDATE tipo_cuenta SET nombre = @nombre WHERE id = @id";
    public string SqlDelete => "DELETE FROM tipo_cuenta WHERE id = @id";
    public string SqlFindById => "SELECT id, nombre FROM tipo_cuenta WHERE id = @id";
    public string SqlSelectAll => "SELECT id, nombre FROM tipo_cuenta";
    public string SqlSearchAll => "SELECT id, nombre FROM tipo_cuenta WHERE CONCAT(id, nombre) LIKE @search";

    public List<SqlParameter> ParametersInsert(TipoCuenta entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(TipoCuenta entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@id", entity.Id)
        };
        return parameters;
    }
    
    public string SqlSelectByName => "SELECT id, nombre FROM tipo_cuenta WHERE nombre = @nombre";
    public List<SqlParameter> ParametersSelectByName(string name)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", name)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersDelete(long id)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersFindById(long id, Usuario? user = null)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersSearchAll(string search)
    {
        List<SqlParameter> parameters = new()
        {
            new("@search", $"%{search}%")
        };
        return parameters;
    }

    public TipoCuenta Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1)
        };
    }
}