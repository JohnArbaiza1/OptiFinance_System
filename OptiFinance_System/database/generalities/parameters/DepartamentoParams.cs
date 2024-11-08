using System.Data;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class DepartamentoParams : IQueriesString<Departamento>
{
    public string SqlInsert => "INSERT INTO departamentos (nombre, codigo) VALUES (@Nombre, @Codigo)";
    public string SqlUpdate => "UPDATE departamentos SET nombre = @Nombre, codigo = @Codigo WHERE id = @Id";
    public string SqlDelete => "DELETE FROM departamentos WHERE id = @Id";
    public string SqlFindById => "SELECT id, nombre, codigo FROM departamentos WHERE id = @Id";
    public string SqlFindName => "SELECT id, nombre, codigo FROM departamentos WHERE nombre = @Nombre";
    public string SqlSelectAllByPartida => "SELECT id, nombre, codigo FROM departamentos ORDER BY id";
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
            Id = reader.GetInt64(DepartamentoField.Id),
            Nombre = reader.GetString(DepartamentoField.Nombre),
            Codigo = reader.IsDBNull(DepartamentoField.Codigo) ? null : reader.GetString(DepartamentoField.Codigo)
        };
        return departamento;
    }
}