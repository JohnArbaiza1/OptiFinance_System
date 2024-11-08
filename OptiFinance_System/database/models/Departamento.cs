namespace OptiFinance_System.database.models;

public class Departamento
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Codigo { get; set; } = string.Empty;

    public override string ToString()
    {
        return Nombre;
    }
}