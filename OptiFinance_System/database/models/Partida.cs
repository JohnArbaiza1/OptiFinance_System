namespace OptiFinance_System.database.models;

public class Partida
{
    public long Id { get; set; }
    public string Detalles { get; set; } = string.Empty;
    public DateTime Fecha { get; set; } = DateTime.Now;
    public Empresa Empresa { get; set; } = new();

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Detalles)}: {Detalles}";
    }
}