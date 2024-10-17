using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.@interface;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class TipoCuentaQuery : IQueryEstandar<TipoCuenta>
{
    private static readonly Lazy<TipoCuentaQuery> _instance =
        new Lazy<TipoCuentaQuery>(() => new TipoCuentaQuery());

    private readonly SqlConnection _connection;
    private readonly Connection _connectionInstance;

    private TipoCuentaQuery()
    {
        _connectionInstance = Connection.Instance;
        _connection = _connectionInstance.GetSqlConnection();
    }

    public static TipoCuentaQuery Instance => _instance.Value;

    public bool Insert(TipoCuenta entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<TipoCuenta> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(TipoCuenta entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<TipoCuenta> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(TipoCuenta entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<TipoCuenta> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public TipoCuenta? FindById(long id)
    {
        string query = "SELECT id, nombre FROM tipo_cuenta WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };

        return QueryHelper.ExecuteFindById(_connectionInstance, query, MapEntity, parameters);
    }

    public List<TipoCuenta> SelectAll()
    {
        string query = "SELECT id, nombre FROM tipo_cuenta";
        return QueryHelper.ExecuteSelect(_connectionInstance, query, MapEntity);
    }

    public TipoCuenta MapEntity(SqlDataReader reader)
    {
        return new TipoCuenta()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1)
        };
    }
}