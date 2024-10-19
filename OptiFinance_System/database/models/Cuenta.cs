namespace OptiFinance_System.database.models;

public class Cuenta
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public TipoCuenta? TipoCuenta { get; set; } = null;

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Codigo)}: {Codigo}, {nameof(TipoCuenta)}: {TipoCuenta}";
    }
}