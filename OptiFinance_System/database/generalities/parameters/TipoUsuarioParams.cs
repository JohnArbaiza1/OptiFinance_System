using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class TipoUsuarioParams : IQueriesString<TipoUsuario>
{
    public string InsertSql { get; } = "INSERT INTO tipo_usuario (nombre) VALUES (@nombre)";
    public string UpdateSql { get; } = "UPDATE tipo_usuario SET nombre = @nombre WHERE id = @id";
    public string DeleteSql { get; } = "DELETE FROM tipo_usuario WHERE id = @id";
    public string FindByIdSql { get; } = "SELECT id, nombre FROM tipo_usuario WHERE id = @id";
    public string SelectAllSql { get; } = "SELECT id, nombre FROM tipo_usuario";

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