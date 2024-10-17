using Microsoft.Data.SqlClient;

namespace OptiFinance_System.database.interfaces;

public interface IQueryEstandar<T>
{
    bool Insert(T entity, SqlTransaction? transaction = null);
    bool Insert(List<T> entities);
    
    bool Update(T entity, SqlTransaction? transaction = null);
    bool Update(List<T> entities);
    
    bool Delete(long id, SqlTransaction? transaction = null);
    bool Delete(T entity);
    bool Delete(List<long> ids);
    bool Delete(List<T> entities);
    
    T? FindById(long id);
    List<T> SelectAll();
    
    T MapEntity(SqlDataReader reader);
}
 