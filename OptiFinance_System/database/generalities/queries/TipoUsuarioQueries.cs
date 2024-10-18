using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.queries;

public class TipoUsuarioQueries : IQueriesString<TipoUsuario>
{
    public string Insert { get; } = "INSERT INTO tipo_usuario (nombre) VALUES (@nombre)";
    public string Update { get; } = "UPDATE tipo_usuario SET nombre = @nombre WHERE id = @id";
    public string Delete { get; } = "DELETE FROM tipo_usuario WHERE id = @id";
    public string FindById { get; } = "SELECT id, nombre FROM tipo_usuario WHERE id = @id";
    public string SelectAll { get; } = "SELECT id, nombre FROM tipo_usuario";

    public List<SqlParameter> InsertParameters(TipoUsuario entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(TipoUsuario entity)
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

    public TipoUsuario Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1)
        };
    }
}