using Microsoft.Data.SqlClient;

namespace OptiFinance_System.database.interfaces;

public interface IQueriesByTypeAccount <T>
{
    public string SqlselectByTypeActivo { get; }
    public List<SqlParameter> ParametersSelectByTypeActivo();
    public string SqlselectByTypePasivo { get; }
    public List<SqlParameter> ParametersSelectByTypePasivo();
    public string SqlselectByTypeCapital { get; }
    public List<SqlParameter> ParametersSelectByTypeCapital();
    public string SqlselectByTypeDeudora { get; }
    public List<SqlParameter> ParametersSelectByTypeDeudora();
    public string SqlselectByTypeAcreedora { get; }
    public List<SqlParameter> ParametersSelectByTypeAcreedora();
    public string SqlselectByTypePuenteCierre { get; }
    public List<SqlParameter> ParametersSelectByTypePuenteCierre();
}