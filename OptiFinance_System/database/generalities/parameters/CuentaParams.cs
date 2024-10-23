using OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class CuentaParams : IQueriesString<Cuenta>
{
    public string SqlInsert =>
        "INSERT INTO cuentas (codigo, nombre, id_tipo_cuenta, id_empresa) VALUES (@codigo, @nombre, @id_tipo_cuenta, @id_empresa)";

    public string SqlUpdate =>
        "UPDATE cuentas SET codigo = @codigo, nombre = @nombre, id_tipo_cuenta = @id_tipo_cuenta, id_empresa = @id_empresa WHERE id = @id";

    public string SqlDelete => "DELETE FROM cuentas WHERE id = @id";
    public string SqlFindById => "SELECT * FROM cuentas WHERE id = @id";

    public string SqlSelectAll =>
        "SELECT * FROM cuentas WHERE id_empresa = @id_empresa";

    public string SqlSearchAll =>
        "SELECT * FROM cuentas " + 
        "WHERE CONCAT(id, codigo, nombre, id_tipo_cuenta) LIKE @search AND id_empresa = @id_empresa";

    public List<SqlParameter> ParametersInsert(Cuenta entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@codigo", entity.Codigo),
            new("@nombre", entity.Nombre),
            new("@id_tipo_cuenta", entity.TipoCuenta?.Id),
            new("@id_empresa", entity.Empresa?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Cuenta entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@codigo", entity.Codigo),
            new("@nombre", entity.Nombre),
            new("@id_tipo_cuenta", entity.TipoCuenta?.Id),
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
            new("@search", $"%{search}%"),
            new("@id_empresa", Global.SelectedEmpresa!.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersSelectAll()
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_empresa", Global.SelectedEmpresa!.Id)
        };
        return parameters;
    }

    public Cuenta Map(SqlDataReader reader)
    {
        return new()
        {
            Id = (long)reader[CuentasField.Id],
            Codigo = (string)reader[CuentasField.Codigo],
            Nombre = reader.GetString(2),
            TipoCuenta = TipoCuentaQuery.Instance.FindById(reader.GetInt64(3)),
            Empresa = EmpresaQuery.Instance.FindById(reader.GetInt64(4))
        };
    }

    public Cuenta MapSelectAll(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Codigo = reader.GetString(1),
            Nombre = reader.GetString(2)
        };
    }

    public Cuenta MapSearchAll(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Codigo = reader.GetString(1),
            Nombre = reader.GetString(2),
            TipoCuenta = TipoCuentaQuery.Instance.FindById(reader.GetInt64(3))
        };
    }
}