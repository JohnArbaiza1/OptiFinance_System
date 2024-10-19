using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class MunicipiosParams : IQueriesString<Municipio>
{
    public string SqlInsert { get; } =
        "INSERT INTO municipios (nombre, id_departamento) VALUES (@nombre, @id_departamento)";

    public string SqlUpdate { get; } =
        "UPDATE municipios SET nombre = @nombre, id_departamento = @id_departamento WHERE id = @id";

    public string SqlDelete { get; } = "DELETE FROM municipios WHERE id = @id";
    public string SqlFindById { get; } = "SELECT id, nombre, id_departamento FROM municipios WHERE id = @id";
    public string SqlSelectAll { get; } = "SELECT id, nombre, id_departamento FROM municipios";
    
    public string SqlFindByName { get; } = "SELECT id, nombre, id_departamento FROM municipios WHERE nombre = @nombre";

    public List<SqlParameter> ParametersInsert(Municipio entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@id_departamento", entity.Departamento.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Municipio entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@id_departamento", entity.Departamento.Id),
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

    public Municipio Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Departamento = DepartamentoQuery.Instance.FindById(reader.GetInt64(2))
        };
    }
    
    public List<SqlParameter> ParametersFindByName(string name)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", name)
        };
        return parameters;
    }
}