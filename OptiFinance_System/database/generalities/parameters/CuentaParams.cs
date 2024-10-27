using OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.global.database;

namespace OptiFinance_System.database.generalities.parameters;

public class CuentaParams : IQueriesString<Cuenta>, IQueriesByTypeAccount<Cuenta>
{
    public string SqlInsert =>
        "INSERT INTO cuentas (codigo, nombre, id_tipo_cuenta, id_empresa) VALUES (@codigo, @nombre, @id_tipo_cuenta, @id_empresa)";

    public string SqlUpdate =>
        "UPDATE cuentas SET codigo = @codigo, nombre = @nombre, id_tipo_cuenta = @id_tipo_cuenta, id_empresa = @id_empresa WHERE id = @id";

    public string SqlDelete => "DELETE FROM cuentas WHERE id = @id";
    public string SqlFindById => "SELECT * FROM cuentas WHERE id = @id and id_empresa = @id_empresa";

    public string SqlSelectAllByPartida =>
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
            new("@id_tipo_cuenta", entity.TipoCuenta?.Id ?? 0),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
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
            new("@id", id),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
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
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public Cuenta Map(SqlDataReader reader)
    {
        return new()
        {
            Id = (long)reader[CuentasField.Id],
            Codigo = (string)reader[CuentasField.Codigo],
            Nombre = reader.GetString(CuentasField.Nombre),
            TipoCuenta = TipoCuentaQuery.Instance.FindById(reader.GetInt64(CuentasField.IdTipoCuenta))
        };
    }

    public Cuenta MapSelectAll(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(CuentasField.Id),
            Codigo = reader.GetString(CuentasField.Codigo),
            Nombre = reader.GetString(CuentasField.Nombre)
        };
    }

    public Cuenta MapSearchAll(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(CuentasField.Id),
            Codigo = reader.GetString(CuentasField.Codigo),
            Nombre = reader.GetString(CuentasField.Nombre),
            TipoCuenta = new(){Id = reader.GetInt64(CuentasField.IdTipoCuenta)}
        };
    }

    public string SqlselectByTypeActivo => "SELECT * FROM cuentas WHERE id_tipo_cuenta = @id_tipo_cuenta AND id_empresa = @id_empresa";

    public List<SqlParameter> ParametersSelectByTypeActivo()
    {
        TipoCuenta? tipoCuenta = TipoCuentaQuery.Instance.FindByName(AccountTypes.Activo);
        List<SqlParameter> parameters = new()
        {
            new("@id_tipo_cuenta", tipoCuenta?.Id ?? 0),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public string SqlselectByTypePasivo => "SELECT * FROM cuentas WHERE id_tipo_cuenta = @id_tipo_cuenta AND id_empresa = @id_empresa";

    public List<SqlParameter> ParametersSelectByTypePasivo()
    {
        TipoCuenta? tipoCuenta = TipoCuentaQuery.Instance.FindByName(AccountTypes.Pasivo);
        List<SqlParameter> parameters = new()
        {
            new("@id_tipo_cuenta", tipoCuenta?.Id ?? 0),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public string SqlselectByTypeCapital => "SELECT * FROM cuentas WHERE id_tipo_cuenta = @id_tipo_cuenta AND id_empresa = @id_empresa";

    public List<SqlParameter> ParametersSelectByTypeCapital()
    {
        TipoCuenta? tipoCuenta = TipoCuentaQuery.Instance.FindByName(AccountTypes.Capital);
        List<SqlParameter> parameters = new()
        {
            new("@id_tipo_cuenta", tipoCuenta?.Id ?? 0),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public string SqlselectByTypeDeudora => "SELECT * FROM cuentas WHERE id_tipo_cuenta = @id_tipo_cuenta AND id_empresa = @id_empresa";

    public List<SqlParameter> ParametersSelectByTypeDeudora()
    {
        TipoCuenta? tipoCuenta = TipoCuentaQuery.Instance.FindByName(AccountTypes.Deudora);
        List<SqlParameter> parameters = new()
        {
            new("@id_tipo_cuenta", tipoCuenta?.Id ?? 0),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public string SqlselectByTypeAcreedora => "SELECT * FROM cuentas WHERE id_tipo_cuenta = @id_tipo_cuenta AND id_empresa = @id_empresa";

    public List<SqlParameter> ParametersSelectByTypeAcreedora()
    {
        TipoCuenta? tipoCuenta = TipoCuentaQuery.Instance.FindByName(AccountTypes.Acreedora);
        List<SqlParameter> parameters = new()
        {
            new("@id_tipo_cuenta", tipoCuenta?.Id ?? 0),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public string SqlselectByTypePuenteCierre => "SELECT * FROM cuentas WHERE id_tipo_cuenta = @id_tipo_cuenta AND id_empresa = @id_empresa";

    public List<SqlParameter> ParametersSelectByTypePuenteCierre()
    {
        TipoCuenta? tipoCuenta = TipoCuentaQuery.Instance.FindByName(AccountTypes.PuenteCierre);
        List<SqlParameter> parameters = new()
        {
            new("@id_tipo_cuenta", tipoCuenta?.Id ?? 0),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
        return parameters;
    }

    public Cuenta MapFindWithoutObjects(SqlDataReader reader)
    {
        return new()
        {
            Codigo = reader.GetString(CuentasField.Codigo),
            Nombre = reader.GetString(CuentasField.Nombre)
        };
    }
}