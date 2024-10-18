﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.queries;

public class UsuarioQueries : IQueriesString<Usuario>
{
    public string Insert { get; } = "INSERT INTO usuarios " +
                                    "(nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario) " +
                                    "VALUES (@nombres, @apellidos, @alias, @email, @password, @telefono, @direccion, @id_tipo_usuario)";

    public string Update { get; } = "UPDATE usuarios SET " +
                                    "nombres = @nombres, apellidos = @apellidos, alias = @alias, email = @email, " +
                                    "password = @password, telefono = @telefono, direccion = @direccion, id_tipo_usuario = @id_tipo_usuario " +
                                    "WHERE id = @id";

    public string Delete { get; } = "DELETE FROM usuarios WHERE id = @id";
    public string FindById { get; } = "SELECT id, nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario FROM usuarios WHERE id = @id";
    public string SelectAll { get; } = "SELECT id, nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario FROM usuarios";

    public List<SqlParameter> InsertParameters(Usuario entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombres", entity.Nombres),
            new("@apellidos", entity.Apellidos),
            new("@alias", entity.Alias),
            new("@email", entity.Email),
            new("@password", entity.Password),
            new("@telefono", entity.Telefono),
            new("@direccion", entity.Direccion),
            new("@id_tipo_usuario", entity.TipoUsuario.Id)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(Usuario entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombres", entity.Nombres),
            new("@apellidos", entity.Apellidos),
            new("@alias", entity.Alias),
            new("@email", entity.Email),
            new("@password", entity.Password),
            new("@telefono", entity.Telefono),
            new("@direccion", entity.Direccion),
            new("@id_tipo_usuario", entity.TipoUsuario.Id),
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

    public Usuario Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombres = reader.GetString(1),
            Apellidos = reader.GetString(2),
            Alias = reader.GetString(3),
            Email = reader.GetString(4),
            Password = reader.GetString(5),
            Telefono = reader.GetString(6),
            Direccion = reader.GetString(7),
            TipoUsuario = TipoUsuarioQuery.Instance.FindById(reader.GetInt64(8))
        };
    }
}