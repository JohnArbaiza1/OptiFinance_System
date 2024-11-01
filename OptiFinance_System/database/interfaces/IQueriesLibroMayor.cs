using OptiFinance_System.database.models;

namespace OptiFinance_System.database.interfaces;

public interface IQueriesLibroMayor
{
     List<LibroMayor> SelectAll();
     List<LibroMayor> SelectAllByAccount(string codigo);
     List<LibroMayor> SelectAllByAccount(Cuenta entity);
     LibroMayor? GetSumByAccount(string id);
     LibroMayor? GetSumByAccount(Cuenta entity);
     int Count { get; }
}