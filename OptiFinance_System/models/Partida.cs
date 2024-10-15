namespace OptiFinance_System.models;

public class Partida
{
    public long Id { get; set; }
    public string Detalles { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Detalles)}: {Detalles}";
    }
}