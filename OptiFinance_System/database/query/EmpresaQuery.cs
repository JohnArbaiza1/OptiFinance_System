using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class EmpresaQuery : IQueryEstandar<Empresa>
{
    private static readonly Lazy<EmpresaQuery> _instance = new(() => new());
    private readonly Connection _connectionInstance;

    private EmpresaQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static EmpresaQuery Instance => _instance.Value;

    private static EmpresaParams Params => Queries.EmpresaParams;

    public bool Insert(Empresa entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert,
            Params.ParametersInsert(entity), transaction);
    }

    public bool Insert(List<Empresa> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.ParametersInsert(entity)).Select(parameters =>
                QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert, parameters,
                    transaction)).All(result => result);
        });
    }
    
    public Empresa? InsertWithResult(Empresa entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteInsertWithResult(_connectionInstance.GetSqlConnection(), Params.SqlWithResult,
            Params.ParametersInsert(entity), MapEntity, transaction);
    }

    public bool Update(Empresa entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Params.SqlUpdate,
            Params.ParametersUpdate(entity), transaction);
    }

    public bool Update(List<Empresa> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.ParametersUpdate(entity)).Select(parameters =>
                QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Params.SqlUpdate, parameters,
                    transaction)).All(result => result);
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), Params.SqlDelete,
            Params.ParametersDelete(id), transaction);
    }

    public bool Delete(Empresa entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return ids.Select(id => Params.ParametersDelete(id)).Select(parameters =>
                QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), Params.SqlDelete, parameters,
                    transaction)).All(result => result);
        });
    }

    public bool Delete(List<Empresa> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Empresa? FindById(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindById, MapEntity,
            Params.ParametersFindById(id));
    }
    
    public Empresa? FindByIdWithoutUser(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByIdWithoutUser, MapEntity,
            Params.ParametersFindByIdWithoutUser(id));
    }
    
    public Empresa? FindByNit(string nit)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByNit, MapEntity,
            Params.ParametersFindByNit(nit));
    }
    
    public Empresa? FindByEmail(string email)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByEmail, MapEntity,
            Params.ParametersFindByEmail(email));
    }
    
    public Empresa? FindByTelefono(string telefono)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByTelefono, MapEntity,
            Params.ParametersFindByTelefono(telefono));
    }

    public List<Empresa> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByPartida, MapEntity,
            Params.ParametersSelectAll());
    }

    public List<Empresa> SearchAll(string search)
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSearchAll, MapEntity,
            Params.ParametersSearchAll(search));
    }

    public Empresa MapEntity(SqlDataReader reader)
    {
        return Params.Map(reader);
    }
}