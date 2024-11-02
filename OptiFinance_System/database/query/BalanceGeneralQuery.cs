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

    public List<BalanceGeneral> SelectAllBytYpeActivoCorriente(bool selectResultadoAcreedor = false)
    {
        List<BalanceGeneral> byTypeActivocorriente = QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(),
            Params.SqlSelectAllByType, Map, Params.ParametersSelectAllByType(TypesAccount.ActivoCorriente));
        return !selectResultadoAcreedor ? byTypeActivocorriente : SelectAllBytYpeActivoCorrienteAndResultadoDeudor();
    }
    
    public List<BalanceGeneral> SelectAllBytYpeActivoCorrienteAndResultadoDeudor()
    {
        List<BalanceGeneral> byTypeActivoCorriente = SelectAllBytYpeActivoCorriente();
        List<BalanceGeneral> byTypeResultadoDeudor = SelectAllByTypeResultadoDeudor();
        byTypeActivoCorriente.AddRange(byTypeResultadoDeudor);
        return byTypeActivoCorriente;
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

    public List<BalanceGeneral> SelectAllByTypePasivoCorriente(bool selectResultadoAcreedor = false)
    {
        List<BalanceGeneral> byTypePasivoCorriente = QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(),
            Params.SqlSelectAllByType, Map, Params.ParametersSelectAllByType(TypesAccount.PasivoCorriente));
        return !selectResultadoAcreedor ? byTypePasivoCorriente : SelectByTypePasivoCorrienteAndResultadoAcreedor();
    }
    
    private List<BalanceGeneral> SelectByTypePasivoCorrienteAndResultadoAcreedor()
    {
        List<BalanceGeneral> byTypePasivoCorriente = SelectAllByTypePasivoCorriente();
        List<BalanceGeneral> byTypeResultadoAcreedor = SelectAllByTypeResultadoAcreedor();
        byTypePasivoCorriente.AddRange(byTypeResultadoAcreedor);
        return byTypePasivoCorriente;
    }
    
    public List<BalanceGeneral> SelectAllByTypePasivoNoCorriente()
    {
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), Params.SqlSelectAllByType, Map,
            Params.ParametersSelectAllByType(TypesAccount.PasivoNoCorriente));
    }

    public List<BalanceGeneral> SelectAllByTypeCapital(bool selectPuenteCierre = false)
    {
        List<BalanceGeneral> byTypeCapital = QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(),
            Params.SqlSelectAllByType, Map, Params.ParametersSelectAllByType(TypesAccount.Capital));
        return !selectPuenteCierre ? byTypeCapital : SelctAllByTypeCapitalAndPuenteCierre();
    }
    
    public List<BalanceGeneral> SelctAllByTypeCapitalAndPuenteCierre()
    {
        List<BalanceGeneral> byTypeCapital = SelectAllByTypeCapital();
        List<BalanceGeneral> byTypePuenteCierre = SelectAllByTypePuenteCierre();
        byTypeCapital.AddRange(byTypePuenteCierre);
        return byTypeCapital;
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
    
    private BalanceGeneral? SumInBalanceGeneral(BalanceGeneral? balanceGeneral1, BalanceGeneral? balanceGeneral2)
    {
        if (balanceGeneral1 == null || balanceGeneral2 == null) return null;
        balanceGeneral1.Debe += balanceGeneral2.Debe;
        balanceGeneral1.Haber += balanceGeneral2.Haber;
        return balanceGeneral1;
    }

    public BalanceGeneral? SumByTypeActivoCorriente(bool selectResultadoDeudor = false)
    {
        BalanceGeneral? byTypeActivoCorriente = QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(),
            Params.SqlSumByType, Map, Params.ParametersSumByType(TypesAccount.ActivoCorriente));
        return !selectResultadoDeudor ? byTypeActivoCorriente : SumByTypeActivoCorrienteAndResultadoDeudor();
    }

    public BalanceGeneral? SumByTypeActivoCorrienteAndResultadoDeudor()
    {
        return SumInBalanceGeneral(SumByTypeActivoCorriente(), SumByTypeResultadoDeudor());
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
    
    public BalanceGeneral? SumByTypePasivoCorriente(bool selectResultadoAcreedor = false)
    {
        BalanceGeneral? byTypePasivoCorriente = QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(),
            Params.SqlSumByType, Map, Params.ParametersSumByType(TypesAccount.PasivoCorriente));
        
        return !selectResultadoAcreedor ? byTypePasivoCorriente : SumByTypePasivoCorrienteAndResultadoAcreedor();
    }
    
    public BalanceGeneral? SumByTypePasivoCorrienteAndResultadoAcreedor()
    {
        return SumInBalanceGeneral(SumByTypePasivoCorriente(), SumByTypeResultadoAcreedor());
    }
    
    public BalanceGeneral? SumByTypePasivoNoCorriente()
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlSumByType, Map,
            Params.ParametersSumByType(TypesAccount.PasivoNoCorriente));
    }

    public BalanceGeneral? SumByTypeCapital(bool selectPuenteCierre = false)
    {
        BalanceGeneral? byTypeCapital = QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(),
            Params.SqlSumByType, Map, Params.ParametersSumByType(TypesAccount.Capital));
        return !selectPuenteCierre ? byTypeCapital : SumByTypeCapitalAndPuenteCierre();
    }
    
    public BalanceGeneral? SumByTypeCapitalAndPuenteCierre()
    {
        return SumInBalanceGeneral(SumByTypeCapital(), SumByTypePuenteCierre());
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