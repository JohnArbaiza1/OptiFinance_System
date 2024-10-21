using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class GiroEconomicoParams : IQueriesString<GiroEconomico>
{
    public string SqlInsert { get; } = "INSERT INTO giros_economicos (nombre) VALUES (@nombre)";
    public string SqlUpdate { get; } = "UPDATE giros_economicos SET nombre = @nombre WHERE id = @id";
    public string SqlDelete { get; } = "DELETE FROM giros_economicos WHERE id = @id";
    public string SqlFindById { get; } = "SELECT id, nombre FROM giros_economicos WHERE id = @id";
    public string SqlSelectAll { get; } = "SELECT id, nombre FROM giros_economicos";
    public string SqlSearchAll { get; } = "SELECT id, nombre FROM giros_economicos WHERE CONCAT(id, nombre) LIKE @search";
    public List<SqlParameter> ParametersInsert(GiroEconomico entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(GiroEconomico entity)
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

    public List<SqlParameter> ParametersSearchAll(string search)
    {
        List<SqlParameter> parameters = new()
        {
            new("@search", $"%{search}%")
        };
        return parameters;
    }

    public GiroEconomico Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1)
        };
    }
}