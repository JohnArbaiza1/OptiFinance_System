using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.@interface;
using OptiFinance_System.database.models;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.query;

public class DistritoQuery : IQueryEstandar<Distrito>
{
    
    private static readonly Lazy<DistritoQuery> _instance =
        new Lazy<DistritoQuery>(() => new DistritoQuery());

    private readonly SqlConnection _connection;
    private readonly Connection _connectionInstance;
    
    private DistritoQuery()
    {
        _connectionInstance = Connection.Instance;
        _connection = _connectionInstance.GetSqlConnection();
    }
    
    public static DistritoQuery Instance => _instance.Value;
    public bool Insert(Distrito entity, SqlTransaction? transaction = null)
    {
        string query = "INSERT INTO distritos (nombre, id_municipio) VALUES (@nombre, @id_municipio)";
        
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@nombre", entity.Nombre),
            new SqlParameter("@id_municipio", entity.Municipio.Id)
        };
        
        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Insert(List<Distrito> entities)
    {
        string query = "INSERT INTO distritos (nombre, id_municipio) VALUES (@nombre, @id_municipio)";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (var entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", entity.Nombre),
                    new SqlParameter("@id_municipio", entity.Municipio.Id)
                };
                
                bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    Message.MessageViewError(@"Error al insertar una de las entidades.");
                    return false;
                }
            }
            return true;
        });
    }

    public bool Update(Distrito entity, SqlTransaction? transaction = null)
    {
        string query = "UPDATE distritos SET nombre = @nombre, id_municipio = @id_municipio WHERE id = @id";
        
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@nombre", entity.Nombre),
            new SqlParameter("@id_municipio", entity.Municipio.Id),
            new SqlParameter("@id", entity.Id)
        };
        
        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteUpdate(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Update(List<Distrito> entities)
    {
        string query = "UPDATE distritos SET nombre = @nombre, id_municipio = @id_municipio WHERE id = @id";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (var entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", entity.Nombre),
                    new SqlParameter("@id_municipio", entity.Municipio.Id),
                    new SqlParameter("@id", entity.Id)
                };
                
                bool result = QueryHelper.ExecuteUpdate(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    Message.MessageViewError(@"Error al actualizar una de las entidades.");
                    return false;
                }
            }
            return true;
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        string query = "DELETE FROM distritos WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };
        
        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteDelete(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Delete(Distrito entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        string query = "DELETE FROM distritos WHERE id = @id";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (var id in ids)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@id", id)
                };
                
                bool result = QueryHelper.ExecuteDelete(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    Message.MessageViewError(@"Error al eliminar una de las entidades.");
                    return false;
                }
            }
            return true;
        });
    }

    public bool Delete(List<Distrito> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Distrito? FindById(long id)
    {
        string query = "SELECT id, nombre, id_municipio FROM distritos WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };

        return QueryHelper.ExecuteFindById(_connectionInstance, query, MapEntity, parameters);
    }

    public List<Distrito> SelectAll()
    {
        string query = "SELECT id, nombre, id_municipio FROM distritos";
        return QueryHelper.ExecuteSelect(_connectionInstance, query, MapEntity);
    }

    public Distrito MapEntity(SqlDataReader reader)
    {
        return new Distrito()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Municipio = MunicipioQuery.Instance.FindById(reader.GetInt64(2))!
        };
    }
}