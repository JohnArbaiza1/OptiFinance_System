﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class EmpresaParams : IQueriesString<Empresa>
{
    public string SqlInsert =>
        "INSERT INTO empresas " +
        "(nombre, nit, giro_economico, representante_legal, direccion, telefono, email, id_usuario, id_distrito) " +
        "VALUES (@nombre, @nit, @giro_economico, @representante_legal, @direccion, @telefono, @email, @id_usuario, @id_distrito)";

    public string SqlUpdate =>
        "UPDATE empresas SET " +
        "nombre = @nombre, nit = @nit, giro_economico = @giro_economico, representante_legal = @representante_legal, " +
        "direccion = @direccion, telefono = @telefono, email = @email, id_usuario = @id_usuario, id_distrito = @id_distrito " +
        "WHERE id = @id";

    public string SqlDelete => "DELETE FROM empresas WHERE id = @id";

    public string SqlFindById =>
        "SELECT id, nombre, nit, giro_economico, representante_legal, direccion, telefono, email, id_usuario, id_distrito FROM empresas WHERE id = @id";

    public string SqlSelectAll =>
        "SELECT id, nombre, nit, giro_economico, representante_legal, direccion, telefono, email, id_usuario, id_distrito FROM empresas";

    public List<SqlParameter> ParametersInsert(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@nit", entity.Nit),
            new("@giro_economico", entity.GiroEconomico),
            new("@representante_legal", entity.RepresentanteLegal),
            new("@direccion", entity.Direccion),
            new("@telefono", entity.Telefono),
            new("@email", entity.Email),
            new("@id_usuario", entity.Usuario?.Id),
            new("@id_distrito", entity.Distrito?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@nit", entity.Nit),
            new("@giro_economico", entity.GiroEconomico),
            new("@representante_legal", entity.RepresentanteLegal),
            new("@direccion", entity.Direccion),
            new("@telefono", entity.Telefono),
            new("@email", entity.Email),
            new("@id_usuario", entity.Usuario?.Id),
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
            new("@id", id)
        };
        return parameters;
    }

    public Empresa Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Nit = reader.IsDBNull(2) ? null : reader.GetString(2),
            GiroEconomico = reader.GetString(3),
            RepresentanteLegal = reader.GetString(4),
            Direccion = reader.IsDBNull(5) ? null : reader.GetString(5),
            Telefono = reader.GetString(6),
            Email = reader.GetString(7),
            Usuario = UsuarioQuery.Instance.FindById(reader.GetInt64(8)),
            Distrito = DistritoQuery.Instance.FindById(reader.GetInt64(9))
        };
    }
}