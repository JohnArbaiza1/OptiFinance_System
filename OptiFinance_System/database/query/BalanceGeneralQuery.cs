using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.generalities.types;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class BalanceGeneralQuery
{
    private static readonly Lazy<BalanceGeneralQuery> _instance = new(() => new());
    private readonly Connection _connectionInstance;
    
    private BalanceGeneralQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }
    
    public static BalanceGeneralQuery Instance => _instance.Value;
    private static BalanceGeneralParams Params => Queries.BalanceGeneralParams;
    
    
    public List<BalanceGeneral> SelectAll()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAll,
            Map, Params.ParametersSelectAll());
    }
    
    public List<BalanceGeneral> SelectAllByTypeActivo()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.Activo));
    }
    
    public List<BalanceGeneral> SelectAllBytYpeActivoCorriente()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.ActivoCorriente));
    }
    
    public List<BalanceGeneral> SelectAllByTypeActivoNoCorriente()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.ActivoNoCorriente));
    }
    
    public List<BalanceGeneral> SelectAllByTypePasivo()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.Pasivo));
    }
    
    public List<BalanceGeneral> SelectAllByTypePasivoCorriente()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.PasivoCorriente));
    }
    
    public List<BalanceGeneral> SelectAllByTypePasivoNoCorriente()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.PasivoNoCorriente));
    }
    
    public List<BalanceGeneral> SelectAllByTypeCapital()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.Capital));
    }
    
    public List<BalanceGeneral> SelectAllByTypeResultadoDeudor()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.CuentasDeResultadoDeudora));
    }
    
    public List<BalanceGeneral> SelectAllByTypeResultadoAcreedor()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.CuentasDeResultadoAcreedora));
    }
    
    public List<BalanceGeneral> SelectAllByTypePuenteCierre()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.CuentasDePuenteDeCierre));
    }
    
    public BalanceGeneral? SumByTypeActivo()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.Activo));
    }
    
    public BalanceGeneral? SumByTypeActivoCorriente()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.ActivoCorriente));
    }
    
    public BalanceGeneral? SumByTypeActivoNoCorriente()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.ActivoNoCorriente));
    }
    
    public BalanceGeneral? SumByTypePasivo()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.Pasivo));
    }
    
    public BalanceGeneral? SumByTypePasivoCorriente()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.PasivoCorriente));
    }
    
    public BalanceGeneral? SumByTypePasivoNoCorriente()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.PasivoNoCorriente));
    }
    
    public BalanceGeneral? SumByTypeCapital()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.Capital));
    }
    
    public BalanceGeneral? SumByTypeResultadoDeudor()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.CuentasDeResultadoDeudora));
    }
    
    public BalanceGeneral? SumByTypeResultadoAcreedor()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.CuentasDeResultadoAcreedora));
    }
    
    public BalanceGeneral? SumByTypePuenteCierre()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.CuentasDePuenteDeCierre));
    }
    
    public BalanceGeneral Map(SqlDataReader reader)
    {
        return Params.Map(reader);
    }
}