using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class DepartamentoParams : IQueriesString<Departamento>
{
    public string InsertSql { get; } = "INSERT INTO departamentos (nombre, codigo) VALUES (@Nombre, @Codigo)";
    public string UpdateSql { get; } = "UPDATE departamentos SET nombre = @Nombre, codigo = @Codigo WHERE id = @Id";
    public string DeleteSql { get; } = "DELETE FROM departamentos WHERE id = @Id";
    public string FindByIdSql { get; } = "SELECT id, nombre, codigo FROM departamentos WHERE id = @Id";
    public string SelectAllSql { get; } = "SELECT id, nombre, codigo FROM departamentos";

    public List<SqlParameter> InsertParameters(Departamento entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@Nombre", entity.Nombre),
            new("@Codigo", entity.Codigo)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(Departamento entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@Nombre", entity.Nombre),
            new("@Codigo", entity.Codigo),
            new("@Id", entity.Id)
        };
        return parameters;
    }

    public List<SqlParameter> DeleteParameters(long id)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@Id", id)
        };
        return parameters;
    }

    public List<SqlParameter> FindByIdParameters(long id, Usuario? user = null)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@Id", id)
        };
        return parameters;
    }

    public Departamento Map(SqlDataReader reader)
    {
        Departamento departamento = new Departamento
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Codigo = reader.GetString(2)
        };
        return departamento;
    }
}