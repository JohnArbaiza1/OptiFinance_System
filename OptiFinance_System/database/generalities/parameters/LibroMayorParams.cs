using OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.fields;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.generalities.parameters;

public class LibroMayorParams
{
    public string SqlInsert { get; }
    public string SqlUpdate { get; }
    public string SqlDelete { get; }
    public string SqlFindById { get; }
    public string SqlSelectAllByPartida { get; }
    public string SqlSearchAll { get; }

    public string SqlSelectAll =>
        "SELECT r.id, r.debe, r.haber, c.id AS id_cuenta, c.codigo AS codigo, c.nombre AS nombre FROM registros AS r " +
        "INNER JOIN cuentas AS c ON r.id_cuenta = c.id " +
        "INNER JOIN empresas ON c.id_empresa = empresas.id " +
        "WHERE empresas.id = @id_empresa";

    public string SelectAllByCodigo =>
        "SELECT r.id, r.debe, r.haber, c.id AS id_cuenta, c.codigo AS codigo, c.nombre AS nombre FROM registros AS r " +
        "INNER JOIN cuentas AS c ON r.id_cuenta = c.id " +
        "INNER JOIN empresas ON c.id_empresa = empresas.id " +
        "WHERE c.codigo = @codigo AND empresas.id = @id_empresa";

    public string TotalByAccount =>
        "SELECT MIN(r.id) AS id, SUM(r.debe) AS debe, SUM(r.haber) AS haber, MIN(c.id) AS id_cuenta, " + 
        "MIN(c.codigo) AS codigo, MIN(c.nombre) AS nombre FROM registros AS r " +
        "INNER JOIN cuentas AS c ON r.id_cuenta = c.id " + 
        "INNER JOIN empresas ON c.id_empresa = empresas.id " +
        "WHERE empresas.id = @id_empresa and c.codigo = @codigo";
    
    public string SqlCount  => 
        "SELECT COUNT(DISTINCT cuentas.id) AS count FROM registros " + 
        "INNER JOIN cuentas ON registros.id_cuenta = cuentas.id " + 
        "INNER JOIN empresas ON cuentas.id_empresa = empresas.id " +
        "WHERE empresas.id = @id_empresa";

    public List<SqlParameter> ParametersInsert(LibroMayor entity)
    {
        throw new NotImplementedException();
    }

    public List<SqlParameter> ParametersUpdate(LibroMayor entity)
    {
        throw new NotImplementedException();
    }

    public List<SqlParameter> ParametersDelete(long id)
    {
        throw new NotImplementedException();
    }

    public List<SqlParameter> ParametersFindById(long id, Usuario? user = null)
    {
        throw new NotImplementedException();
    }

    public List<SqlParameter> ParametersSearchAll(string search)
    {
        throw new NotImplementedException();
    }

    public List<SqlParameter> ParametersSelectAll()
    {
        return new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
    }

    public List<SqlParameter> ParametersSelectAllByAccount(long id)
    {
        return new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0),
            new("@id_cuenta", id)
        };
    }
    
    public List<SqlParameter> ParametersCount()
    {
        return new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0)
        };
    }

    public List<SqlParameter> ParametersTotalByAccount(long id)
    {
        return new()
        {
            new("@id_empresa", Global.SelectedEmpresa?.Id ?? 0),
            new("@codigo", id)
        };
    }

    public LibroMayor Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(LibroMayorField.Id),
            Debe = reader.GetDecimal(LibroMayorField.Debe),
            Haber = reader.GetDecimal(LibroMayorField.Haber),
            Cuenta = new()
            {
                Id = reader.GetInt64(LibroMayorField.IdCuenta),
                Codigo = reader.GetString(LibroMayorField.Codigo),
                Nombre = reader.GetString(LibroMayorField.Nombre)
            }
        };
    }
    
    public int MapCount(SqlDataReader reader)
    {
        return reader.GetInt32(0);
    }
}