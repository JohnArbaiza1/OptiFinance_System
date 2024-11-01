using System.Data;
using OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class UsuarioParams : IQueriesString<Usuario>
{
    private string _idTipoUsuarioAdmin = "1";

    public string SqlInsert =>
        "INSERT INTO usuarios " +
        "(nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario) " +
        "VALUES (@nombres, @apellidos, @alias, @email, @password, @telefono, @direccion, @id_tipo_usuario)";

    public string SqlUpdate =>
        "UPDATE usuarios SET " +
        "nombres = @nombres, apellidos = @apellidos, alias = @alias, email = @email, " +
        "password = @password, telefono = @telefono, direccion = @direccion, id_tipo_usuario = @id_tipo_usuario " +
        "WHERE id = @id";

    public string SqlDelete => "DELETE FROM usuarios WHERE id = @id";

    public string SqlFindById =>
        $"SELECT id, nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario FROM usuarios " +
        $"WHERE id = @id";

    public string SqlSelectAllByPartida =>
        $"SELECT id, nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario FROM usuarios " +
        $"WHERE id_tipo_usuario <> {_idTipoUsuarioAdmin}";


    public string SqlSearchAll =>
        $"SELECT id, nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario FROM usuarios " +
        $"WHERE CONCAT(id, nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario) LIKE @search " +
        $"AND id_tipo_usuario <> {_idTipoUsuarioAdmin}";

    public string SqlFindByUsername =>
        "SELECT * FROM usuarios WHERE alias = @alias";

    public List<SqlParameter> ParametersInsert(Usuario entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombres", entity.Nombres),
            new("@apellidos", entity.Apellidos),
            new("@alias", entity.Alias),
            new("@email", entity.Email),
            new("@password", entity.Password),
            new("@telefono", entity.Telefono),
            new("@direccion", entity.Direccion),
            new("@id_tipo_usuario", entity.TipoUsuario?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Usuario entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombres", entity.Nombres),
            new("@apellidos", entity.Apellidos),
            new("@alias", entity.Alias),
            new("@email", entity.Email),
            new("@password", entity.Password),
            new("@telefono", entity.Telefono),
            new("@direccion", entity.Direccion),
            new("@id_tipo_usuario", entity.TipoUsuario?.Id ?? 0),
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

    public List<SqlParameter> ParametersFindByUsername(string username)
    {
        List<SqlParameter> parameters = new()
        {
            new("@alias", username)
        };
        return parameters;
    }

    public Usuario Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(UsuarioField.Id),
            Nombres = reader.GetString(UsuarioField.Nombres),
            Apellidos = reader.GetString(UsuarioField.Apellidos),
            Alias = reader.GetString(UsuarioField.Alias),
            Email = reader.IsDBNull(UsuarioField.Email) ? null : reader.GetString(UsuarioField.Email),
            Password = reader.GetString(UsuarioField.Password),
            Telefono = reader.IsDBNull(6) ? null : reader.GetString(UsuarioField.Telefono),
            Direccion = reader.IsDBNull(7) ? null : reader.GetString(UsuarioField.Direccion),
            TipoUsuario = TipoUsuarioQuery.Instance.FindById(reader.GetInt64(UsuarioField.IdTipoUsuario))
        };
    }
}