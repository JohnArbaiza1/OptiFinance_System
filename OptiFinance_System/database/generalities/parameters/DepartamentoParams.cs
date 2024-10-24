using System.Data;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class DepartamentoParams : IQueriesString<Departamento>
{
    public string SqlInsert { get; } = "INSERT INTO departamentos (nombre, codigo) VALUES (@Nombre, @Codigo)";
    public string SqlUpdate { get; } = "UPDATE departamentos SET nombre = @Nombre, codigo = @Codigo WHERE id = @Id";
    public string SqlDelete { get; } = "DELETE FROM departamentos WHERE id = @Id";
    public string SqlFindById { get; } = "SELECT id, nombre, codigo FROM departamentos WHERE id = @Id";
    public string SqlFindName { get; } = "SELECT id, nombre, codigo FROM departamentos WHERE nombre = @Nombre";
    public string SqlSelectAll { get; } = "SELECT id, nombre, codigo FROM departamentos";
    public string SqlSearchAll { get; }

    public List<SqlParameter> ParametersInsert(Departamento entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@Nombre", entity.Nombre),
            new("@Codigo", entity.Codigo)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Departamento entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@Nombre", entity.Nombre),
            new("@Codigo", entity.Codigo),
            new("@Id", entity.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersDelete(long id)
    {
        List<SqlParameter> parameters = new()
        {
            new("@Id", id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersFindById(long id, Usuario? user = null)
    {
        List<SqlParameter> parameters = new()
        {
            new("@Id", id)
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

    public List<SqlParameter> ParametersFindByName(string name)
    {
        List<SqlParameter> parameters = new()
        {
            new("@Nombre", name)
        };
        return parameters;
    }

    public Departamento Map(SqlDataReader reader)
    {
        Departamento departamento = new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Codigo = reader.IsDBNull(2) ? null : reader.GetString(2)
        };
        return departamento;
    }
}