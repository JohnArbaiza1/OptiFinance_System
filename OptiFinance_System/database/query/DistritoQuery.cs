﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.query;

public class DistritoQuery : IQueryEstandar<Distrito>
{
    private static readonly Lazy<DistritoQuery> _instance = new(() => new());

    private readonly Connection _connectionInstance;

    private DistritoQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static DistritoQuery Instance => _instance.Value;
    private static DistritoParams Params => Queries.DistritoParams;

    public bool Insert(Distrito entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert,
            Params.ParametersInsert(entity), transaction);
    }

    public bool Insert(List<Distrito> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.ParametersInsert(entity)).Select(parameters =>
                QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert, parameters,
                    transaction)).All(result => result);
        });
    }

    public bool Update(Distrito entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Params.SqlUpdate,
            Params.ParametersUpdate(entity), transaction);
    }

    public bool Update(List<Distrito> entities)
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

    public bool Delete(Distrito entity)
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

    public bool Delete(List<Distrito> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Distrito? FindById(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindById, MapEntity,
            Params.ParametersFindById(id));
    }

    public List<Distrito> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByPartida,
            Params.MapSelectAll);
    }

    public List<Distrito> SearchAll(string search)
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSearchAll, MapEntity,
            Params.ParametersSearchAll(search));
    }

    public Distrito MapEntity(SqlDataReader reader)
    {
        return Params.Map(reader);
    }
}