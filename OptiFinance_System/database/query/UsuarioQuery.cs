using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.query;

public class UsuarioQuery : IQueryEstandar<Usuario>
{
    private static readonly Lazy<UsuarioQuery> _instance = new(() => new());
    private readonly Connection _connectionInstance;

    private UsuarioQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static UsuarioQuery Instance => _instance.Value;

    private static UsuarioParams Parameters => Queries.UsuarioParams;

    public bool Insert(Usuario entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Parameters.InsertSql,
            Parameters.InsertParameters(entity), transaction);
    }

    public bool Insert(List<Usuario> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(),
            transaction =>
            {
                return entities.Select(entity => Parameters.InsertParameters(entity)).Select(parameters =>
                        QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(),
                            Parameters.InsertSql, parameters, transaction))
                    .All(result => result);
            });
    }

    public bool Update(Usuario entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Parameters.UpdateSql,
            Parameters.UpdateParameters(entity), transaction);
    }

    public bool Update(List<Usuario> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(usuario => Queries.UsuarioParams.UpdateParameters(usuario))
                .Select(list => QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(),
                    Queries.UsuarioParams.UpdateSql, list, transaction))
                .All(result => result);
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), Queries.UsuarioParams.DeleteSql,
            Queries.UsuarioParams.DeleteParameters(id), transaction);
    }

    public bool Delete(Usuario entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return ids.Select(id => Parameters.DeleteParameters(id))
                .Select(list => QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(),
                    Parameters.InsertSql, list, transaction))
                .All(result => result);
        });
    }

    public bool Delete(List<Usuario> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Usuario? FindById(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Parameters.FindByIdSql, MapEntity,
            Parameters.FindByIdParameters(id));
    }

    public List<Usuario> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Parameters.SelectAllSql, MapEntity);
    }

    public Usuario MapEntity(SqlDataReader reader)
    {
        return Parameters.Map(reader);
    }

    public Usuario? FindByUsername(string username)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Parameters.FindByUsernameSql, MapEntity,
            Parameters.FindByUsernameParameters(username));
    }
}