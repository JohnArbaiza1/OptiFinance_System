namespace OptiFinance_System.database.models;

public class BalanceGeneral
{
    public string? Codigo;
    public string? NombreCuenta;
    public decimal? Debe;
    public decimal? Haber;

    public BalanceGeneral()
    {
    }

    public BalanceGeneral(decimal? debe, decimal? haber)
    {
        Debe = debe;
        Haber = haber;
    }
}