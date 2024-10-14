using OptiFinance_System.models;

namespace OptiFinance_System.Config.query;

public class DepartamentoQuery : IQueryEstandar<Departamento>
{
    public bool Insert(Departamento entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Departamento> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Departamento entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Departamento> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Departamento entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Departamento> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Departamento FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Departamento> SelectAll()
    {
        throw new NotImplementedException();
    }
}