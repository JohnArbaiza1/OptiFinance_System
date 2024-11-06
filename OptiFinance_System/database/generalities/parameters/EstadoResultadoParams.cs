using global::OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class EstadoResultadoParams
{
    public string SqlAccountByName => 
        "SELECT nombre_cuenta AS nombre, CASE WHEN debe <> 0 THEN debe WHEN haber <> 0 THEN haber ELSE 0 END AS valor " +
        "FROM balance_general WHERE nombre_cuenta = @nombre_cuenta AND id_empresa = @id_empresa";
    
    public string SqlAccountByCodigo => 
        "SELECT nombre_cuenta AS nombre, CASE WHEN debe <> 0 THEN debe WHEN haber <> 0 THEN haber ELSE 0 END AS valor " +
        "FROM balance_general WHERE codigo = @codigo AND id_empresa = @id_empresa";
    
    
    public List<SqlParameter> ParametersAccountByName(string nombreCuenta)
    {
        return new()
        {
            new("@nombre_cuenta", nombreCuenta),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
    }
    
    public List<SqlParameter> ParametersAccountByCodigo(string codigo)
    {
        return new()
        {
            new("@codigo", codigo),
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
    }
    
    
    public EstadoResultado Map(SqlDataReader reader)
    {
        return new()
        {
            Nombre = reader[EstadoResultadoField.Nombre] != DBNull.Value ? (string)reader[EstadoResultadoField.Nombre] : string.Empty,
            Valor = reader[EstadoResultadoField.Valor] != DBNull.Value ? Math.Abs((decimal)reader[EstadoResultadoField.Valor]) : 0
        };
    }
}