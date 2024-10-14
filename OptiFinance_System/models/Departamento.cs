namespace OptiFinance_System.models;

public class Departamento
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public DateTime Fecha { get; set; } = DateTime.Now;
    public Empresa Empresa { get; set; } = new Empresa();

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Nombre)}: {Nombre}, {nameof(Codigo)}: {Codigo}, " +
            $"{nameof(Fecha)}: {Fecha}, {nameof(Empresa)}: {Empresa}";
    }
}