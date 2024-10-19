using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class DistritoParams : IQueriesString<Distrito>
{
    public string SqlInsert { get; } = "INSERT INTO distritos (nombre, id_municipio) VALUES (@nombre, @id_municipio)";

    public string SqlUpdate { get; } =
        "UPDATE distritos SET nombre = @nombre, id_municipio = @id_municipio WHERE id = @id";

    public string SqlDelete { get; } = "DELETE FROM distritos WHERE id = @id";
    public string SqlFindById { get; } = "SELECT id, nombre, id_municipio FROM distritos WHERE id = @id";
    public string SqlSelectAll { get; } = "SELECT id, nombre, id_municipio FROM distritos";

    public List<SqlParameter> ParametersInsert(Distrito entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@id_municipio", entity.Municipio.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Distrito entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@id_municipio", entity.Municipio.Id),
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

    public Distrito Map(SqlDataReader reader)
    {
        Distrito distrito = new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Municipio = MunicipioQuery.Instance.FindById(reader.GetInt64(2))
        };
        return distrito;
    }
}