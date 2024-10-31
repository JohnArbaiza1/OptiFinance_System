using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class LibroMayorQuery: IQueriesLibroMayor
{
    public List<LibroMayor> SelectAll()
    {
        throw new NotImplementedException();
    }

    public List<LibroMayor> SelectAllByAccount(long id)
    {
        throw new NotImplementedException();
    }

    public List<LibroMayor> SelectAllByAccount(Cuenta entity)
    {
        throw new NotImplementedException();
    }

    public long GetSumByAccount(long id)
    {
        throw new NotImplementedException();
    }

    public long GetSumByAccount(Cuenta entity)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
}