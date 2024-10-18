using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.queries;

public class DistritoQueries : IQueriesString<Distrito>
{
    public string Insert { get; } = "INSERT INTO distritos (nombre, id_municipio) VALUES (@nombre, @id_municipio)";

    public string Update { get; } =
        "UPDATE distritos SET nombre = @nombre, id_municipio = @id_municipio WHERE id = @id";

    public string Delete { get; } = "DELETE FROM distritos WHERE id = @id";
    public string FindById { get; } = "SELECT id, nombre, id_municipio FROM distritos WHERE id = @id";
    public string SelectAll { get; } = "SELECT id, nombre, id_municipio FROM distritos";

    public List<SqlParameter> InsertParameters(Distrito entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@id_municipio", entity.Municipio.Id)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(Distrito entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@id_municipio", entity.Municipio.Id),
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

    public Distrito Map(SqlDataReader reader)
    {
        Distrito distrito = new Distrito
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Municipio = MunicipioQuery.Instance.FindById(reader.GetInt64(2))
        };
        return distrito;
    }
}