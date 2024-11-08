using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class MunicipiosParams : IQueriesString<Municipio>
{
    public string SqlInsert => "INSERT INTO municipios (nombre, id_departamento) VALUES (@nombre, @id_departamento)";

    public string SqlUpdate =>
        "UPDATE municipios SET nombre = @nombre, id_departamento = @id_departamento WHERE id = @id";

    public string SqlDelete => "DELETE FROM municipios WHERE id = @id";
    public string SqlFindById => "SELECT id, nombre, id_departamento FROM municipios WHERE id = @id";
    public string SqlSelectAllByPartida => "SELECT id, nombre, id_departamento FROM municipios ORDER BY id_departamento";

    public string SqlSearchAll => "SELECT id, nombre, id_departamento FROM municipios " +
                                  "WHERE CONCAT(id, nombre, id_departamento) LIKE @search";

    public string SqlFindByName => "SELECT id, nombre, id_departamento FROM municipios WHERE nombre = @nombre";

    public List<SqlParameter> ParametersInsert(Municipio entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@id_departamento", entity.Departamento?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Municipio entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@id_departamento", entity.Departamento?.Id),
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

    public List<SqlParameter> ParametersSearchAll(string search)
    {
        List<SqlParameter> parameters = new()
        {
            new("@search", $"%{search}%")
        };
        return parameters;
    }

    public Municipio Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(MunicipioField.Id),
            Nombre = reader.GetString(MunicipioField.Nombre),
            Departamento = DepartamentoQuery.Instance.FindById(reader.GetInt64(MunicipioField.IdDepartamento))
        };
    }

    public Municipio MapSelectAll(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Departamento = new(){Id = reader.GetInt64(MunicipioField.IdDepartamento)}
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