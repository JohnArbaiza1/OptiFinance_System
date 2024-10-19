﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class PartidaParams : IQueriesString<Partida>
{
    public string SqlInsert { get; } =
        "INSERT INTO partidas (detalles, fecha, id_empresa) VALUES (@detalles, @fecha, @id_empresa)";

    public string SqlUpdate { get; } =
        "UPDATE partidas SET detalles = @detalles, fecha = @fecha, id_empresa = @id_empresa WHERE id = @id";

    public string SqlDelete { get; } = "DELETE FROM partidas WHERE id = @id";
    public string SqlFindById { get; } = "SELECT id, detalles, fecha, id_empresa FROM partidas WHERE id = @id";

    public string SqlSelectAll { get; } =
        "SELECT id, detalles, fecha, id_empresa FROM partidas WHERE id_empresa = @id_empresa";

    public List<SqlParameter> ParametersInsert(Partida entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@detalles", entity.Detalles),
            new("@fecha", entity.Fecha),
            new("@id_empresa", entity.Empresa.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Partida entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@detalles", entity.Detalles),
            new("@fecha", entity.Fecha),
            new("@id_empresa", entity.Empresa?.Id),
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

    public Partida Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Detalles = reader.GetString(1),
            Fecha = reader.GetDateTime(2),
            Empresa = EmpresaQuery.Instance.FindById(reader.GetInt64(3))
        };
    }

    public List<SqlParameter> SelectAllParameters(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_empresa", entity.Id)
        };
        return parameters;
    }
}