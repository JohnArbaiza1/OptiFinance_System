﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.queries;

public class MunicipiosQueries : IQueriesString<Municipio>
{
    public string Insert { get; } =
        "INSERT INTO municipios (nombre, id_departamento) VALUES (@nombre, @id_departamento)";

    public string Update { get; } =
        "UPDATE municipios SET nombre = @nombre, id_departamento = @id_departamento WHERE id = @id";

    public string Delete { get; } = "DELETE FROM municipios WHERE id = @id";
    public string FindById { get; } = "SELECT id, nombre, id_departamento FROM municipios WHERE id = @id";
    public string SelectAll { get; } = "SELECT id, nombre, id_departamento FROM municipios";

    public List<SqlParameter> InsertParameters(Municipio entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@id_departamento", entity.Departamento.Id)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(Municipio entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@id_departamento", entity.Departamento.Id),
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

    public Municipio Map(SqlDataReader reader)
    {
        return new Municipio
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Departamento = DepartamentoQuery.Instance.FindById(reader.GetInt64(2))
        };
    }
}