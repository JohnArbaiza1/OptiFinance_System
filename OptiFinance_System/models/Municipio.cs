namespace OptiFinance_System.models;

public class Municipio
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public Departamento Departamento { get; set; } = new Departamento();

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Nombre)}: {Nombre}, {nameof(Departamento)}: {Departamento}";
    }
}