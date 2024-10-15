using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class UsuarioQuery : IQueryEstandar<Usuario>
{
    public bool Insert(Usuario entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Usuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Usuario entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Usuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Usuario entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Usuario> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Usuario FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Usuario> SelectAll()
    {
        throw new NotImplementedException();
    }
}