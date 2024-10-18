namespace OptiFinance_System.database.interfaces;

public interface IQueryRegistros<T>
{
    List<T> SelectActivos();
    List<T> SelectActivosCorrientes();
    List<T> SelectActivosNoCorrientes();
    List<T> DelectPasivos();
    List<T> SelectPasivosCorrientes();
    List<T> SelectPasivosNoCorrientes();

    List<T> SelectPatrimonio();

    List<T> SelectIngresos();
    List<T> SelectGastos();
    List<T> SelectCostos();

    decimal SumActivos();
    decimal SumActivosCorrientes();
    decimal SumActivosNoCorrientes();
    decimal SumPasivos();
    decimal SumPasivosCorrientes();
    decimal SumPasivosNoCorrientes();
    decimal SumPatrimonio();
    decimal SumIngresos();
    decimal SumGastos();
    decimal SumCostos();
}