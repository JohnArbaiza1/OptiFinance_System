using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.@interface;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class RegistroQuery : IQueryEstandar<Registro>
{
    private static readonly Lazy<RegistroQuery> _instance =
        new Lazy<RegistroQuery>(() => new RegistroQuery());

    private readonly SqlConnection _connection;
    private readonly Connection _connectionInstance;
    
    private RegistroQuery()
    {
        _connectionInstance = Connection.Instance;
        _connection = _connectionInstance.GetSqlConnection();
        _connectionInstance.OpenConnection();
    }
    
    public static RegistroQuery Instance => _instance.Value;
    public bool Insert(Registro entity, SqlTransaction? transaction = null)
    {
        string query = "INSERT INTO registros (debe, haber, id_cuenta, id_partida) VALUES (@debe, @haber, @id_cuenta, @id_partida)";
        
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@debe", entity.Debe),
            new SqlParameter("@haber", entity.Haber),
            new SqlParameter("@id_cuenta", entity.Cuenta.Id),
            new SqlParameter("@id_partida", entity.Partida.Id)
        };
        
        bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
        return result;
    }

    public bool Insert(List<Registro> entities)
    {
        string query = "INSERT INTO registros (debe, haber, id_cuenta, id_partida) VALUES (@debe, @haber, @id_cuenta, @id_partida)";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (var entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@debe", entity.Debe),
                    new SqlParameter("@haber", entity.Haber),
                    new SqlParameter("@id_cuenta", entity.Cuenta.Id),
                    new SqlParameter("@id_partida", entity.Partida.Id)
                };
                
                bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    return false;
                }
            }
            return true;
        });
    }

    public bool Update(Registro entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Registro> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Registro entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Registro> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Registro? FindById(long id)
    {
        string query = "SELECT id, debe, haber, id_cuenta, id_partida FROM registros WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };
        
        return QueryHelper.ExecuteFind(_connectionInstance, query, MapEntity, parameters);
    }

    public List<Registro> SelectAll()
    {
        string query = "SELECT id, debe, haber, id_cuenta, id_partida FROM registros";
        return QueryHelper.ExecuteSelect(_connectionInstance, query, MapEntity);
    }

    public Registro MapEntity(SqlDataReader reader)
    {
        return new Registro()
        {
            Id = reader.GetInt64(0),
            Debe = reader.GetDecimal(1),
            Haber = reader.GetDecimal(2),
            Cuenta = CuentaQuery.Instance.FindById(reader.GetInt64(3))!,
            Partida = PartidaQuery.Instance.FindById(reader.GetInt64(4))!
        };
    }
}