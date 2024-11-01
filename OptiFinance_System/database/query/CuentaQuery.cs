using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class CuentaQuery : IQueryEstandar<Cuenta>, IQueryAccounts<Cuenta>
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
        return QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert,
            Params.ParametersInsert(entity), transaction);
    }

    public bool Insert(List<Cuenta> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.ParametersInsert(entity)).Select(parameters =>
                    QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(),
                        Params.SqlInsert, parameters, transaction))
                .All(result => result);
        });
    }

    public bool Update(Cuenta entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Params.SqlUpdate,
            Params.ParametersUpdate(entity), transaction);
    }

    public bool Update(List<Cuenta> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(cuenta => Params.ParametersUpdate(cuenta))
                .Select(list => QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(),
                    Params.SqlUpdate, list, transaction))
                .All(result => result);
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), Params.SqlDelete,
            Params.ParametersDelete(id), transaction);
    }

    public bool Delete(Cuenta entity)
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

    public bool Delete(List<Cuenta> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Cuenta? FindById(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindById, MapEntity,
            Params.ParametersFindById(id));
    }
    
    public Cuenta? FindByIdWithoutObjects(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindById, Params.MapFindWithoutObjects,
            Params.ParametersFindById(id));
    }

    public List<Cuenta> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByPartida,
            Params.MapSelectAll, Params.ParametersSelectAll());
    }

    /// <summary>
    /// Selecciona todos las cuentas diferentes por empresa
    /// Advertencia: Se debe de haber seleccionado una empresa antes de llamar a este método
    /// </summary>
    /// <returns>
    /// Retorna una <see cref="List{T}"/> de <see cref="Cuenta"/> que contiene todas las cuentas distintas de la empresa seleccionada
    /// </returns>
    public List<Cuenta> SelectAllDistinctsByEmpresa()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllDistinctsByEmpresa,
            Params.MapSearchAll, Params.ParametersSelectAllDistinctsByEmpresa());
    }

    public List<Cuenta> SearchAll(string search)
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSearchAll,
            Params.MapSearchAll,
            Params.ParametersSearchAll(search));
    }

    public Cuenta MapEntity(SqlDataReader reader)
    {
        return Params.Map(reader);
    }

    public List<Cuenta> SelectAllByTypeActivo()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlselectByTypeActivo,
            Params.MapSelectAll, Params.ParametersSelectByTypeActivo());
    }

    public List<Cuenta> SelectAllByTypePasivo()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlselectByTypePasivo,
            Params.MapSelectAll, Params.ParametersSelectByTypePasivo());
    }

    public List<Cuenta> SelectAllByTypeCapital()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlselectByTypeCapital,
            Params.MapSelectAll, Params.ParametersSelectByTypeCapital());
    }

    public List<Cuenta> SelectAllByTypeDeudora()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlselectByTypeDeudora,
            Params.MapSelectAll, Params.ParametersSelectByTypeDeudora());
    }

    public List<Cuenta> SelectAllByTypeAcreedora()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlselectByTypeAcreedora,
            Params.MapSelectAll, Params.ParametersSelectByTypeAcreedora());
    }

    public List<Cuenta> SelectAllByTypePuenteCierre()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlselectByTypePuenteCierre,
            Params.MapSelectAll, Params.ParametersSelectByTypePuenteCierre());
    }
}