using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class TipoCuentaParams : IQueriesString<TipoCuenta>
{
    public string InsertSql { get; } = "INSERT INTO tipo_cuenta (nombre) VALUES (@nombre)";
    public string UpdateSql { get; } = "UPDATE tipo_cuenta SET nombre = @nombre WHERE id = @id";   
    public string DeleteSql { get; } = "DELETE FROM tipo_cuenta WHERE id = @id";
    public string FindByIdSql { get; } = "SELECT id, nombre FROM tipo_cuenta WHERE id = @id";
    public string SelectAllSql { get; } = "SELECT id, nombre FROM tipo_cuenta";
    public List<SqlParameter> InsertParameters(TipoCuenta entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(TipoCuenta entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@id", entity.Id)
        };
        return parameters;
    }

    public List<SqlParameter> DeleteParameters(long id)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@id", id)
        };
        return parameters;
    }

    public List<SqlParameter> FindByIdParameters(long id, Usuario? user = null)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
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