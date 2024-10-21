using System.Data;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class MiembroEmpresaParams : IQueriesString<MiembroEmpresa>
{
    public string SqlInsert =>
        "INSERT INTO miembros_empresa " +
        "(nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa) " +
        "VALUES (@nombres, @apellidos, @alias, @dui, @correo_electronico, @telefono, @direccion, @id_empresa)";

    public string SqlUpdate =>
        "UPDATE miembros_empresa SET " +
        "nombres = @nombres, apellidos = @apellidos, alias = @alias, dui = @dui, " +
        "correo_electronico = @correo_electronico, telefono = @telefono, direccion = @direccion, id_empresa = @id_empresa " +
        "WHERE id = @id";

    public string SqlDelete => "DELETE FROM miembros_empresa WHERE id = @id";

    public string SqlFindById => 
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa " + 
        "FROM miembros_empresa WHERE id = @id";

    public string SqlSelectAll => 
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa " + 
        "FROM miembros_empresa WHERE id_empresa = @id_empresa";

    public string SqlSearchAll =>
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa FROM miembros_empresa " +
        "WHERE CONCAT(id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa) LIKE @search";
    
    public string SqlFindByUsername =>
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa " +
        "FROM miembros_empresa WHERE alias = @alias";

    public List<SqlParameter> ParametersInsert(MiembroEmpresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombres", entity.Nombres),
            new("@apellidos", entity.Apellidos),
            new("@alias", entity.Alias),
            new("@dui", entity.Dui),
            new("@correo_electronico", entity.Correo),
            new("@telefono", entity.Telefono),
            new("@direccion", entity.Direccion),
            new("@id_empresa", entity.Empresa?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(MiembroEmpresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombres", entity.Nombres),
            new("@apellidos", entity.Apellidos),
            new("@alias", entity.Alias),
            new("@dui", entity.Dui),
            new("@correo_electronico", entity.Correo),
            new("@telefono", entity.Telefono),
            new("@direccion", entity.Direccion),
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

    public List<SqlParameter> ParametersSearchAll(string search)
    {
        List<SqlParameter> parameters = new()
        {
            new("@search", $"%{search}%")
        };
        return parameters;
    }

    public List<SqlParameter> SelectAllParameters(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_empresa", entity.Id)
        };
        return parameters;
    }

    public MiembroEmpresa Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombres = reader.GetString(1),
            Apellidos = reader.GetString(2),
            Alias = reader.GetString(3),
            Dui = reader.GetString(4),
            Correo = reader.IsDBNull(5) ? null : reader.GetString(5),
            Telefono = reader.IsDBNull(6) ? null : reader.GetString(6),
            Direccion = reader.GetString(7),
            Empresa = EmpresaQuery.Instance.FindById(reader.GetInt64(8))
        };
    }
    
    public List<SqlParameter> FindByUsernameParameters(string username)
    {
        List<SqlParameter> parameters = new()
        {
            new("@alias", username)
        };
        return parameters;
    }
}