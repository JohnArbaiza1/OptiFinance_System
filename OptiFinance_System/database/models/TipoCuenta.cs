namespace OptiFinance_System.database.models;

public class TipoCuenta
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    public override string ToString()
    {
        return Nombre;
    }
}