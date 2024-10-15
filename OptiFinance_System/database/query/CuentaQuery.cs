using Microsoft.Data.SqlClient;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class CuentaQuery : IQueryEstandar<Cuenta>
{
    public bool Insert(Cuenta entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Cuenta> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Cuenta entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Cuenta> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Cuenta entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Cuenta> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Cuenta? FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Cuenta> SelectAll()
    {
        throw new NotImplementedException();
    }

    public Cuenta MapEntity(SqlDataReader reader)
    {
        throw new NotImplementedException();
    }
}