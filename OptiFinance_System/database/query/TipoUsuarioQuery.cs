using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class TipoUsuarioQuery : IQueryEstandar<TipoUsuario>
{
    private static readonly Lazy<TipoUsuarioQuery> _instance = new(() => new());

    private readonly Connection _connectionInstance;

    private TipoUsuarioQuery()
    {
        _connectionInstance = Connection.Instance;
    }

    public static TipoUsuarioQuery Instance => _instance.Value;

    public bool Insert(TipoUsuario entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<TipoUsuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(TipoUsuario entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<TipoUsuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(TipoUsuario entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<TipoUsuario> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public TipoUsuario? FindById(long id)
    {
        string query = "SELECT id, nombre FROM tipo_usuario WHERE id = @id";
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }

    public List<TipoUsuario> SelectAll()
    {
        string query = "SELECT id, nombre FROM tipo_usuario";
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), query, MapEntity);
    }

    public TipoUsuario MapEntity(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1)
        };
    }
}