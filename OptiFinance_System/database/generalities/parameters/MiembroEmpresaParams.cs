using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class MiembroEmpresaParams : IQueriesString<MiembroEmpresa>
{
    public string SqlInsert { get; } = "INSERT INTO miembros_empresa " +
                                       "(nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa) " +
                                       "VALUES (@nombres, @apellidos, @alias, @dui, @correo_electronico, @telefono, @direccion, @id_empresa)";

    public string SqlUpdate { get; } = "UPDATE miembros_empresa SET " +
                                       "nombres = @nombres, apellidos = @apellidos, alias = @alias, dui = @dui, " +
                                       "correo_electronico = @correo_electronico, telefono = @telefono, direccion = @direccion, id_empresa = @id_empresa " +
                                       "WHERE id = @id";

    public string SqlDelete { get; } = "DELETE FROM miembros_empresa WHERE id = @id";

    public string SqlFindById { get; } =
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa FROM miembros_empresa WHERE id = @id";

    public string SqlSelectAll { get; } =
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa FROM miembros_empresa WHERE id_empresa = @id_empresa";

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
            Correo = reader.GetString(5),
            Telefono = reader.GetString(6),
            Direccion = reader.GetString(7),
            Empresa = EmpresaQuery.Instance.FindById(reader.GetInt64(8))
        };
    }
}