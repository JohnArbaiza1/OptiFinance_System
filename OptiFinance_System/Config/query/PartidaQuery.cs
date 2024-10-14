using OptiFinance_System.models;

namespace OptiFinance_System.Config.query;

public class PartidaQuery : IQueryEstandar<Partida>
{
    public bool Insert(Partida entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Partida> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Partida entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Partida> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Partida entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Partida> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Partida FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Partida> SelectAll()
    {
        throw new NotImplementedException();
    }
}