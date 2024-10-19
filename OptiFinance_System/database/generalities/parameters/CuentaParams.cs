using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class CuentaParams : IQueriesString<Cuenta>
{
    public string SqlInsert { get; } =
        "INSERT INTO cuentas (codigo, nombre, id_tipo_cuenta) VALUES (@codigo, @nombre, @id_tipo_cuenta)";

    public string SqlUpdate { get; } =
        "UPDATE cuentas SET codigo = @codigo, nombre = @nombre, id_tipo_cuenta = @id_tipo_cuenta WHERE id = @id";

    public string SqlDelete { get; } = "DELETE FROM cuentas WHERE id = @id";
    public string SqlFindById { get; } = "SELECT id, codigo, nombre, id_tipo_cuenta FROM cuentas WHERE id = @id";
    public string SqlSelectAll { get; } = "SELECT id, codigo, nombre, id_tipo_cuenta FROM cuentas";

    public List<SqlParameter> ParametersInsert(Cuenta entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@codigo", entity.Codigo),
            new("@nombre", entity.Nombre),
            new("@id_tipo_cuenta", entity.TipoCuenta?.Id)
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

    public Cuenta Map(SqlDataReader reader)
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