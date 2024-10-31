using OptiFinance_System.database.models;

namespace OptiFinance_System.database.interfaces;

public interface IQueriesLibroMayor
{
     List<LibroMayor> SelectAll();
     List<LibroMayor> SelectAllByAccount(long id);
     List<LibroMayor> SelectAllByAccount(Cuenta entity);
     LibroMayor? GetSumByAccount(long id);
     LibroMayor? GetSumByAccount(Cuenta entity);
     int Count { get; }
}