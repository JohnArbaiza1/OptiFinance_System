﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class MiembroEmpresaQuery : IQueryEstandar<MiembroEmpresa>
{
    private static readonly Lazy<MiembroEmpresaQuery> _instance = new(() => new());
    private readonly Connection _connectionInstance;

    private MiembroEmpresaQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static MiembroEmpresaQuery Instance => _instance.Value;
    private static MiembroEmpresaParams Params => Queries.MiembroEmpresaParams;

    public bool Insert(MiembroEmpresa entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert,
            Params.ParametersInsert(entity), transaction);
    }

    public bool Insert(List<MiembroEmpresa> entities)
    {
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            return entities.Select(entity => Params.ParametersInsert(entity)).Select(parameters =>
                QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), Params.SqlInsert, parameters,
                    transaction)).All(result => result);
        });
    }

    public bool Update(MiembroEmpresa entity, SqlTransaction? transaction = null)
    {
        return QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), Params.SqlUpdate,
            Params.ParametersUpdate(entity), transaction);
    }

    public bool Update(List<MiembroEmpresa> entities)
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

    public bool Delete(MiembroEmpresa entity)
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

    public bool Delete(List<MiembroEmpresa> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }
    

    public MiembroEmpresa? FindById(long id)
    {
        MiembroEmpresa? miembroEmpresa = QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(),
            Params.SqlFindById, MapEntity,
            Params.ParametersFindById(id));

        if (miembroEmpresa == null) return null;
        if (miembroEmpresa.Empresa != null) return miembroEmpresa;
        Console.WriteLine(@"Empresa es nullable");
        MiembroEmpresa? aux = QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindIdEmpresa,
            Params.MapOnlyIdEmpresa, Params.ParametersFindIdEmpresa(id));
        miembroEmpresa.Empresa = aux?.Empresa;
        return miembroEmpresa;
    }
    
    public MiembroEmpresa? FindByIdWithoutEmpresa(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByIdWithoutEmpresa, 
            Params.MapWithoutEmpresaFull, Params.ParametersFindByIdWithoutEmpresa(id));
    }

    private MiembroEmpresa? GetEmpresa(long id)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindIdEmpresa, MapEntity,
            Params.ParametersFindIdEmpresa(id));
    }

    public List<MiembroEmpresa> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByPartida,
            Params.MapSelectAll, Params.ParametersSelectAll());
    }

    public List<MiembroEmpresa> SearchAll(string search)
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSearchAll, MapEntity,
            Params.ParametersSearchAll(search));
    }

    public MiembroEmpresa MapEntity(SqlDataReader reader)
    {
        return Params.Map(reader);
    }

    /// <summary>
    /// Busca a un Miembro de Empresa por su nombre de usuario
    /// </summary>
    /// <param name="username"> Nombre de usuario a buscar </param>
    /// <param name="withoutEmpresa"> Valida si se desea buscar a un usuario sin importar que  haya empresa seleccionada
    /// <para><c>true</c>: Busca a un usuario sin importar que haya empresa seleccionada</para>
    /// <c>false</c>: Busca a un usuario que pertenezca a la empresa seleccionada </param>
    /// <returns>
    /// Un objeto de tipo <see cref="MiembroEmpresa"/> si se encuentra, de lo contrario <c>null</c>
    /// </returns>
    public MiembroEmpresa? FindByUsername(string username, bool withoutEmpresa = false)
    {
        MiembroEmpresa? miembroEmpresa = QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByUsername, MapEntity,
            Params.ParametersFindByUsername(username));
        return !withoutEmpresa ? miembroEmpresa : FindByUsernameWithoutEmpresa(username);
    }

    private MiembroEmpresa? FindByUsernameWithoutEmpresa(string username)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByUsernameWithoutEmpresa,
            Params.MapWithoutEmpresa, Params.ParametersFindByUsername(username));
    }
    
    public MiembroEmpresa? FindByTelefono(string telefono)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByTelefono, MapEntity,
            Params.ParametersFindByTelefono(telefono));
    }
    
    public MiembroEmpresa? FindByEmail(string email)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByEmail, Params.MapSearch,
            Params.ParametersFindByEmail(email));
    }
    
    public MiembroEmpresa? FindByDui(string dui)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlFindByDui, Params.MapSearch,
            Params.ParametersFindByDui(dui));
    }
}