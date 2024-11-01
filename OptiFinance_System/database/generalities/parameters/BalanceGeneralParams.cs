using System.Text;
using global::OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class BalanceGeneralParams
{
    public string SqlSelectAll => "SELECT * FROM balance_general WHERE id_empresa = @id_empresa";
    public string SqlSelectAllByType => "SELECT * FROM balance_general WHERE id_empresa = @id_empresa AND codigo LIKE @tipo";
    public string SqlSumByType => 
        "SELECT MIN(codigo) AS codigo, MIN(id_empresa) AS id_empresa, MIN(nombre_cuenta) AS nombre_cuenta, " + 
        "SUM(debe) AS debe, SUM(haber) AS haber FROM balance_general WHERE id_empresa = @id_empresa AND codigo LIKE @tipo";

    public List<SqlParameter> ParametersSelectAll()
    {
        return new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
    }
    
    public List<SqlParameter> ParametersSelectAllByType(string codigo)
    {
        return new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0),
            new("@tipo", new StringBuilder().Append(codigo).Append('%').ToString())
        };
    }
    
    public List<SqlParameter> ParametersSumByType(string codigo)
    {
        return new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0),
            new("@tipo", new StringBuilder().Append(codigo).Append('%').ToString())
        };
    }

    public BalanceGeneral Map(SqlDataReader reader)
    {
        return new()
        {
            // Codigo = reader[BalanceGeneralField.Codigo].ToString() ?? string.Empty,
            //Validar que no sea nulo
            Codigo = reader[BalanceGeneralField.Codigo] != DBNull.Value ? reader[BalanceGeneralField.Codigo].ToString() : string.Empty,
            // NombreCuenta = reader[BalanceGeneralField.NombreCuenta].ToString() ?? string.Empty,
            NombreCuenta = reader[BalanceGeneralField.NombreCuenta] != DBNull.Value ? reader[BalanceGeneralField.NombreCuenta].ToString() : string.Empty,
            // Debe = (decimal)reader[BalanceGeneralField.Debe],
            Debe = reader[BalanceGeneralField.Debe] != DBNull.Value ? (decimal)reader[BalanceGeneralField.Debe] : 0,
            // Haber = (decimal)reader[BalanceGeneralField.Haber]
            Haber = reader[BalanceGeneralField.Haber] != DBNull.Value ? (decimal)reader[BalanceGeneralField.Haber] : 0.05m
        };
    }
}