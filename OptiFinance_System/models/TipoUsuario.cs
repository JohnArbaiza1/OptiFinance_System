namespace OptiFinance_System.models;

public class TipoUsuario
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Nombre)}: {Nombre}";
    }
}