using Microsoft.Data.SqlClient;
using OptiFinance_System.Config.connection;

namespace OptiFinance_System.Config.query;

public interface IQueryEstandar<T>
{
    
    bool Insert(T entity);
    bool Insert(List<T> entities);
    
    bool Update(T entity);
    bool Update(List<T> entities);
    
    bool Delete(long id);
    bool Delete(T entity);
    bool Delete(List<long> ids);
    bool Delete(List<T> entities);
    
    T FindById(long id);
    List<T> SelectAll();
}
 