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

    private static UsuarioParams Params => Queries.UsuarioParams;

    public bool Insert(Usuario entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert,
            Params.ParametersInsert(entity), transaction);
    }

    public bool Insert(List<Usuario> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.ParametersInsert(entity)).Select(parameters =>
                    QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(),
                        Params.SqlInsert, parameters, transaction))
                .All(result => result);
        });
    }

    public bool Update(Usuario entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Params.SqlUpdate,
            Params.ParametersUpdate(entity), transaction);
    }

    public bool Update(List<Usuario> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.ParametersUpdate(entity)).Select(parameters =>
                    QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(),
                        Params.SqlUpdate, parameters, transaction))
                .All(result => result);
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), Queries.UsuarioParams.SqlDelete,
            Queries.UsuarioParams.ParametersDelete(id), transaction);
    }

    public bool Delete(Usuario entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return ids.Select(id => Params.ParametersDelete(id))
                .Select(list => QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(),
                    Params.SqlDelete, list, transaction))
                .All(result => result);
        });
    }

    public bool Delete(List<Usuario> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Usuario? FindById(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindById, MapEntity,
            Params.ParametersFindById(id));
    }

    public List<Usuario> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByPartida, MapEntity);
    }

    public List<Usuario> SearchAll(string search)
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSearchAll, MapEntity,
            Params.ParametersSearchAll(search));
    }

    public Usuario MapEntity(SqlDataReader reader)
    {
        return Params.Map(reader);
    }

    public Usuario? FindByUsername(string username)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByUsername, MapEntity,
            Params.ParametersFindByUsername(username));
    }

    public Usuario? FindByEmpresa(long idEmpresa)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByEmpresa, MapEntity,
            Params.ParametersFindByEmpresa(idEmpresa));
    }

    public Usuario? FindByTelefono(string telefono)
    {
        return null;
    }
    
    // public Usuario? FindBy
}