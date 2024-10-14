namespace OptiFinance_System.models;

public class Distrito
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public Municipio Municipio { get; set; } = new Municipio();

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Nombre)}: {Nombre}, {nameof(Municipio)}: {Municipio}";
    }
}