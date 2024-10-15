using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class RegistroQuery : IQueryEstandar<Registro>
{
    public bool Insert(Registro entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Registro> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Registro entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Registro> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Registro entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Registro> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Registro FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Registro> SelectAll()
    {
        throw new NotImplementedException();
    }
}