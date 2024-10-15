using OptiFinance_System.models;

namespace OptiFinance_System.Config.query;

public class TipoUsuarioQuery : IQueryEstandar<TipoUsuario>
{
    public bool Insert(TipoUsuario entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<TipoUsuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(TipoUsuario entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<TipoUsuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(TipoUsuario entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<TipoUsuario> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public TipoUsuario FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<TipoUsuario> SelectAll()
    {
        throw new NotImplementedException();
    }
}