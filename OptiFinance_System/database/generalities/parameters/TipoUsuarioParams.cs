using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class TipoUsuarioParams : IQueriesString<TipoUsuario>
{
    public string SqlInsert => "INSERT INTO tipo_usuario (nombre) VALUES (@nombre)";
    public string SqlUpdate => "UPDATE tipo_usuario SET nombre = @nombre WHERE id = @id";
    public string SqlDelete => "DELETE FROM tipo_usuario WHERE id = @id";
    public string SqlFindById => "SELECT id, nombre FROM tipo_usuario WHERE id = @id";
    public string SqlSelectAllByPartida => "SELECT id, nombre FROM tipo_usuario";
    public string SqlSearchAll => "SELECT id, nombre FROM tipo_usuario WHERE CONCAT(id, nombre) LIKE @search";

    public List<SqlParameter> ParametersInsert(TipoUsuario entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(TipoUsuario entity)
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

    public TipoUsuario Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(TipoUsuarioField.Id),
            Nombre = reader.GetString(TipoUsuarioField.Nombre)
        };
    }
}