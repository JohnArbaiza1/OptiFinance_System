using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class CuentaQuery : IQueryEstandar<Cuenta>
{
    private static readonly Lazy<CuentaQuery> _instance = new(() => new CuentaQuery());

    private readonly Connection _connectionInstance;

    private CuentaQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static CuentaQuery Instance => _instance.Value;

    public bool Insert(Cuenta entity, SqlTransaction? transaction = null)
    {
        string query =
            "INSERT INTO cuentas (codigo, nombre, id_tipo_cuenta) VALUES (@codigo, @nombre, @id_tipo_cuenta)";

        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@codigo", entity.Codigo),
            new("@nombre", entity.Nombre),
            new("@id_tipo_cuenta", entity.TipoCuenta.Id)
        };

        bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Insert(List<Cuenta> entities)
    {
        string query =
            "INSERT INTO cuentas (codigo, nombre, id_tipo_cuenta) VALUES (@codigo, @nombre, @id_tipo_cuenta)";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (Cuenta entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new("@codigo", entity.Codigo),
                    new("@nombre", entity.Nombre),
                    new("@id_tipo_cuenta", entity.TipoCuenta.Id)
                };

                bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters,
                    transaction);
                if (!result) return false;
            }

            return true;
        });
    }

    public bool Update(Cuenta entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Cuenta> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Cuenta entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Cuenta> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Cuenta? FindById(long id)
    {
        string query = "SELECT id, codigo, nombre, id_tipo_cuenta FROM cuentas WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@id", id)
        };

        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }

    public List<Cuenta> SelectAll()
    {
        string query = "SELECT id, codigo, nombre, id_tipo_cuenta FROM cuentas";
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), query, MapEntity);
    }

    public Cuenta MapEntity(SqlDataReader reader)
    {
        return new Cuenta
        {
            Id = reader.GetInt64(0),
            Codigo = reader.GetString(1),
            Nombre = reader.GetString(2),
            TipoCuenta = TipoCuentaQuery.Instance.FindById(reader.GetInt64(3))!
        };
    }
}