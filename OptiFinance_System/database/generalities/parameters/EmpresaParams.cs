﻿using OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class EmpresaParams : IQueriesString<Empresa>
{
    public string SqlInsert =>
        "INSERT INTO empresas " +
        "(nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico) " +
        "VALUES (@nombre, @nit, @representante_legal, @direccion, @telefono, @email, @id_usuario, @id_distrito, @id_giro_economico)";
    
    public string SqlWithResult =>
        "INSERT INTO empresas " +
        "(nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico) " +
        "OUTPUT INSERTED.id, INSERTED.nombre, INSERTED.nit, INSERTED.representante_legal, INSERTED.direccion, " +
        "INSERTED.telefono, INSERTED.email, INSERTED.id_usuario, INSERTED.id_distrito, INSERTED.id_giro_economico " +
        "VALUES (@nombre, @nit, @representante_legal, @direccion, @telefono, @email, @id_usuario, @id_distrito, @id_giro_economico)";

    public string SqlUpdate =>
        "UPDATE empresas SET " +
        "nombre = @nombre, nit = @nit, representante_legal = @representante_legal, direccion = @direccion, telefono = @telefono, " +
        "email = @email, id_usuario = @id_usuario, id_distrito = @id_distrito, id_giro_economico = @id_giro_economico " +
        "WHERE id = @id";

    public string SqlDelete => "DELETE FROM empresas WHERE id = @id";

    public string SqlFindById =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico " +
        "FROM empresas WHERE id = @id and id_usuario = @id_usuario";
    
    public string SqlFindByIdWithoutUser =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico " +
        "FROM empresas WHERE id = @id";
    
    public string SqlFindByNit =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico " +
        "FROM empresas WHERE nit = @nit";
    
    public string SqlFindByEmail =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico " +
        "FROM empresas WHERE email = @email";
    
    public string SqlFindByTelefono =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico " +
        "FROM empresas WHERE telefono = @telefono";

    public string SqlSelectAllByPartida =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico " +
        "FROM empresas WHERE id_usuario = @id_usuario";

    public string SqlSearchAll =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico FROM empresas " +
        "WHERE CONCAT(id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico) LIKE @search";

    public List<SqlParameter> ParametersInsert(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@nit", entity.Nit),
            new("@representante_legal", entity.RepresentanteLegal),
            new("@direccion", entity.Direccion),
            new("@telefono", entity.Telefono),
            new("@email", entity.Email),
            new("@id_usuario", Global.SelectedUser?.Id ?? 0),
            new("@id_distrito", entity.Distrito?.Id),
            new("@id_giro_economico", entity.GiroEconomico?.Id)
        };
        return parameters;
    }
    
    public List<SqlParameter> ParametersInsertWithResult(Empresa entity)
    {
        return ParametersInsert(entity);
    }

    public List<SqlParameter> ParametersUpdate(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@nit", entity.Nit),
            new("@representante_legal", entity.RepresentanteLegal),
            new("@direccion", entity.Direccion),
            new("@telefono", entity.Telefono),
            new("@email", entity.Email),
            new("@id_usuario", Global.SelectedUser?.Id ?? 0),
            new("@id_distrito", entity.Distrito?.Id),
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
            new("@id", id),
            new("@id_usuario", Global.SelectedUser?.Id ?? 0)
        };
        return parameters;
    }
    
    public List<SqlParameter> ParametersFindByNit(string nit)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nit", nit)
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

    public List<SqlParameter> ParametersSelectAll()
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_usuario", Global.SelectedUser?.Id ?? 0)
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
    
    public List<SqlParameter> ParametersFindByIdWithoutUser(long id)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return parameters;
    }

    public Empresa Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(EmpresaField.Id),
            Nombre = reader.GetString(EmpresaField.Nombre),
            Nit = reader.IsDBNull(EmpresaField.Nit) ? null : reader.GetString(EmpresaField.Nit),
            RepresentanteLegal = reader.GetString(EmpresaField.RepresentanteLegal),
            Direccion = reader.IsDBNull(EmpresaField.Direccion) ? null : reader.GetString(EmpresaField.Direccion),
            Telefono = reader.GetString(EmpresaField.Telefono),
            Email = reader.GetString(EmpresaField.Email),
            Usuario = new() { Id = reader.GetInt64(EmpresaField.IdUsuario) },
            Distrito = new() { Id = reader.GetInt64(EmpresaField.IdDistrito) },
            GiroEconomico = GiroEconomicoQuery.Instance.FindById(reader.GetInt64(EmpresaField.IdGiroEconomico))
        };
    }
}