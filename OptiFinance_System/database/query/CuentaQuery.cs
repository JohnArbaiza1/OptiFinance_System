using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class CuentaQuery : IQueryEstandar<Cuenta>
{
    private static readonly Lazy<CuentaQuery> _instance = new(() => new());

    private readonly Connection _connectionInstance;

    private CuentaQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static CuentaQuery Instance => _instance.Value;

    private static CuentaParams Params => Queries.CuentaParams;

    public bool Insert(Cuenta entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.InsertSql,
            Params.InsertParameters(entity), transaction);
    }

    public bool Insert(List<Cuenta> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.InsertParameters(entity)).Select(parameters =>
                    QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(),
                        Params.InsertSql, parameters, transaction))
                .All(result => result);
        });
    }

    public bool Update(Cuenta entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Params.UpdateSql,
            Params.UpdateParameters(entity), transaction);
    }

    public bool Update(List<Cuenta> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(cuenta => Params.UpdateParameters(cuenta))
                .Select(list => QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(),
                    Params.UpdateSql, list, transaction))
                .All(result => result);
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), Params.DeleteSql,
            Params.DeleteParameters(id), transaction);
    }

    public bool Delete(Cuenta entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return ids.Select(id => Params.DeleteParameters(id))
                .Select(list => QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(),
                    Params.DeleteSql, list, transaction))
                .All(result => result);
        });
    }

    public bool Delete(List<Cuenta> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Cuenta? FindById(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.FindByIdSql, MapEntity,
            Params.FindByIdParameters(id));
    }

    public List<Cuenta> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SelectAllSql, MapEntity);
    }

    public Cuenta MapEntity(SqlDataReader reader)
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