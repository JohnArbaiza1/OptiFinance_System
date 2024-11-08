using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class EstadoResultadoQuery
{
    private static readonly Lazy<EstadoResultadoQuery> _instance = new(() => new());
    private readonly Connection _connectionInstance;
    
    private EstadoResultadoQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }
    
    public static EstadoResultadoQuery Instance => _instance.Value;
    private static EstadoResultadoParams Params => Queries.EstadoResultadoParams;
    
    public EstadoResultado? GetAccountByName(string nombreCuenta)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlAccountByName, Map, 
            Params.ParametersAccountByName(nombreCuenta));
    }
    
    public EstadoResultado? GetAccountByCodigo(string codigo)
    {
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), Params.SqlAccountByCodigo, Map, 
            Params.ParametersAccountByCodigo(codigo));
    }
    
    
    private EstadoResultado Map(SqlDataReader reader)
    {
        return Params.Map(reader);
    }
 
}