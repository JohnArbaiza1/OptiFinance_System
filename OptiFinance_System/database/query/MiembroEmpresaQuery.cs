using Microsoft.Data.SqlClient;
using OptiFinance_System.database.@interface;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class MiembroEmpresaQuery : IQueryEstandar<MiembroEmpresa>
{
    public bool Insert(MiembroEmpresa entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<MiembroEmpresa> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(MiembroEmpresa entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<MiembroEmpresa> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(MiembroEmpresa entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<MiembroEmpresa> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public MiembroEmpresa? FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<MiembroEmpresa> SelectAll()
    {
        throw new NotImplementedException();
    }

    public MiembroEmpresa MapEntity(SqlDataReader reader)
    {
        throw new NotImplementedException();
    }
}