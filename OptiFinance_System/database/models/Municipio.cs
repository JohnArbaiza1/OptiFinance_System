namespace OptiFinance_System.database.models;

public class Municipio
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public Departamento? Departamento { get; set; } = null;

    public override string ToString()
    {
        return Nombre;
    }
}