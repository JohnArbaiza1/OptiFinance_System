﻿using System.Data;
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
    
    public string SqlFindByEmpresa =>
        "SELECT u.* FROM usuarios AS u INNER JOIN empresas AS e ON u.id = e.id_usuario WHERE e.id = @id_empresa";

    public string SqlFindByTelefono =>
        "SELECT * FROM usuarios WHERE telefono = @telefono";

    public string SqlFindByEmail =>
        "SELECT * FROM usuarios WHERE email = @email";

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

    public List<SqlParameter> ParametersFindByTelefono(string telefono)
    {
        List<SqlParameter> parameters = new()
        {
            new("@telefono", telefono)
        };
        return parameters;
    }
    
    public List<SqlParameter> ParametersFindByEmail(string email)
    {
        List<SqlParameter> parameters = new()
        {
            new("@email", email)
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
    
    public List<SqlParameter> ParametersFindByEmpresa(long idEmpresa)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_empresa", idEmpresa)
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
    
    public Usuario MapSearch(SqlDataReader reader)
    {
        return new()
        {
            Id = (long)reader["id"],
            /*Apellidos = reader["apellidos"].ToString() ?? string.Empty,
            Nombres = reader["nombres"].ToString() ?? string.Empty,
            Alias = reader["alias"].ToString() ?? string.Empty,
            Email = reader["email"].ToString() ?? string.Empty,
            Password = reader["password"].ToString() ?? string.Empty,
            Telefono = reader["telefono"].ToString() ?? string.Empty,
            Direccion = reader["direccion"].ToString() ?? string.Empty*/
        };
    }
}