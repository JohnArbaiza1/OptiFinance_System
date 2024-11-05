using System.Data;
using global::OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class MiembroEmpresaParams : IQueriesString<MiembroEmpresa>
{
    public string SqlInsert =>
        "INSERT INTO miembros_empresa " +
        "(nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa, password) " +
        "VALUES (@nombres, @apellidos, @alias, @dui, @correo_electronico, @telefono, @direccion, @id_empresa, @password)";

    public string SqlUpdate =>
        "UPDATE miembros_empresa SET " +
        "nombres = @nombres, apellidos = @apellidos, alias = @alias, dui = @dui, " +
        "correo_electronico = @correo_electronico, telefono = @telefono, direccion = @direccion, id_empresa = @id_empresa " +
        "WHERE id = @id";

    public string SqlDelete => "DELETE FROM miembros_empresa WHERE id = @id";

    public string SqlFindById =>
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa, password " +
        "FROM miembros_empresa WHERE id = @id and id_empresa = @id_empresa";

    public string SqlFindByIdWithoutEmpresa =>
        "SELECT me.*, e.nombre AS nombre_empresa FROM miembros_empresa AS me " +
        "INNER JOIN empresas AS e ON me.id_empresa = e.id WHERE me.id = @id";

    public string SqlSelectAllByPartida =>
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa, password " +
        "FROM miembros_empresa WHERE id_empresa = @id_empresa";

    public string SqlSearchAll =>
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa, password FROM miembros_empresa " +
        "WHERE CONCAT(id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa) LIKE @search " +
        "AND id_empresa = @id_empresa";

    public string SqlFindByUsername =>
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa, password " +
        "FROM miembros_empresa WHERE alias = @alias AND id_empresa = @id_empresa";
    
    public string SqlFindByUsernameWithoutEmpresa =>
        "SELECT id, nombres, apellidos, alias, dui, correo_electronico, telefono, direccion, id_empresa, password " +
        "FROM miembros_empresa WHERE alias = @alias";

    public string SqlFindIdEmpresa => "SELECT id_empresa FROM miembros_empresa WHERE id = @id";
    
    public List<SqlParameter> ParametersFindIdEmpresa(long id)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return parameters;
    }

    public MiembroEmpresa MapOnlyIdEmpresa(SqlDataReader reader)
    {
        return new()
        {
            Empresa = EmpresaQuery.Instance.FindByIdWithoutUser(reader.GetInt64(0))
        };
    }

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
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0),
            new("@password", entity.Password)
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
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0),
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
            new("@id", id),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }
    
    public List<SqlParameter> ParametersFindByIdWithoutEmpresa(long id)
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
            new("@search", $"%{search}%"),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersSelectAll()
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
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
            Empresa = new() { Id = reader.GetInt64(8) },
            Password = reader.GetString(9)
        };
    }

    public MiembroEmpresa MapSelectAll(SqlDataReader reader)
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
            Password = reader.GetString(9)
        };
    }
    
    public MiembroEmpresa MapWithoutEmpresa(SqlDataReader reader)
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
            Password = reader.GetString(9)
        };
    }
    
    public MiembroEmpresa MapWithoutEmpresaFull(SqlDataReader reader)
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
            Password = reader.GetString(9),
            Empresa = new()
            {
                Id = reader["id_empresa"] != DBNull.Value ? (long)reader["id_empresa"] : 0,
                Nombre = reader["nombre_empresa"] != DBNull.Value ? (string)reader["nombre_empresa"] : string.Empty
            }
        };
    }

    public List<SqlParameter> ParametersFindByUsername(string username)
    {
        List<SqlParameter> parameters = new()
        {
            new("@alias", username),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersFindByUsernameWithoutEmpresa(string username)
    {
        List<SqlParameter> parameters = new()
        {
            new("@alias", username)
        };
        return parameters;
    }
}