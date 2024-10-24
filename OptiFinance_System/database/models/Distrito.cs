namespace OptiFinance_System.database.models;

public class Distrito
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public Municipio? Municipio { get; set; } = null;

    public override string ToString()
    {
        return Nombre + " - " + Id;
    }
}