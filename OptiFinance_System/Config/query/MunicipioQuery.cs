using OptiFinance_System.models;

namespace OptiFinance_System.Config.query;

public class MunicipioQuery : IQueryEstandar<Municipio>
{
    public bool Insert(Municipio entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Municipio> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Municipio entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Municipio> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Municipio entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Municipio> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Municipio FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Municipio> SelectAll()
    {
        throw new NotImplementedException();
    }
}