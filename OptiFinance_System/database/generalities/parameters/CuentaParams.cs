using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class CuentaParams : IQueriesString<Cuenta>
{
    public string InsertSql { get; } = "INSERT INTO cuentas (codigo, nombre, id_tipo_cuenta) VALUES (@codigo, @nombre, @id_tipo_cuenta)";
    public string UpdateSql { get; } = "UPDATE cuentas SET codigo = @codigo, nombre = @nombre, id_tipo_cuenta = @id_tipo_cuenta WHERE id = @id";
    public string DeleteSql { get; } = "DELETE FROM cuentas WHERE id = @id";
    public string FindByIdSql { get; } = "SELECT id, codigo, nombre, id_tipo_cuenta FROM cuentas WHERE id = @id";
    public string SelectAllSql { get; } = "SELECT id, codigo, nombre, id_tipo_cuenta FROM cuentas";
    public List<SqlParameter> InsertParameters(Cuenta entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@codigo", entity.Codigo),
            new("@nombre", entity.Nombre),
            new("@id_tipo_cuenta", entity.TipoCuenta?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(Cuenta entity)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@codigo", entity.Codigo),
            new("@nombre", entity.Nombre),
            new("@id_tipo_cuenta", entity.TipoCuenta?.Id),
            new("@id", entity.Id)
        };
        return parameters;
    }

    public List<SqlParameter> DeleteParameters(long id)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@id", id)
        };
        return parameters;
    }

    public List<SqlParameter> FindByIdParameters(long id, Usuario? user = null)
    {
        List<SqlParameter> parameters = new List<SqlParameter>
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