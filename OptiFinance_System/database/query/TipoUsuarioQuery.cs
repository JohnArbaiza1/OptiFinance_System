using Microsoft.Data.SqlClient;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class TipoUsuarioQuery : IQueryEstandar<TipoUsuario>
{
    public bool Insert(TipoUsuario entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<TipoUsuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(TipoUsuario entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<TipoUsuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
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

    public TipoUsuario? FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<TipoUsuario> SelectAll()
    {
        throw new NotImplementedException();
    }

    public TipoUsuario MapEntity(SqlDataReader reader)
    {
        return new TipoUsuario()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1)
        };
    }
}