using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class EmpresaQuery : IQueryEstandar<Empresa>
{
    public bool Insert(Empresa entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Empresa> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Empresa entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Empresa> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Empresa entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Empresa> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Empresa FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Empresa> SelectAll()
    {
        throw new NotImplementedException();
    }
}