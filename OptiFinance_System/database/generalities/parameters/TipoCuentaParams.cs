using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class TipoCuentaParams : IQueriesString<TipoCuenta>
{
    public string SqlInsert { get; } = "INSERT INTO tipo_cuenta (nombre) VALUES (@nombre)";
    public string SqlUpdate { get; } = "UPDATE tipo_cuenta SET nombre = @nombre WHERE id = @id";
    public string SqlDelete { get; } = "DELETE FROM tipo_cuenta WHERE id = @id";
    public string SqlFindById { get; } = "SELECT id, nombre FROM tipo_cuenta WHERE id = @id";
    public string SqlSelectAll { get; } = "SELECT id, nombre FROM tipo_cuenta";

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

    public TipoCuenta Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1)
        };
    }
}