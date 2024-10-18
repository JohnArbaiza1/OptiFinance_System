namespace OptiFinance_System.database.models;

public class Empresa
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Nit { get; set; } = string.Empty;
    public string GiroEconomico { get; set; } = string.Empty;
    public string RepresentanteLegal { get; set; } = string.Empty;
    public string? Direccion { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Usuario Usuario { get; set; } = new();
    public Distrito? Distrito { get; set; } = new();

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Nombre)}: {Nombre}, {nameof(Nit)}: {Nit}, " +
            $"{nameof(GiroEconomico)}: {GiroEconomico}, {nameof(RepresentanteLegal)}: {RepresentanteLegal}, " +
            $"{nameof(Direccion)}: {Direccion}, {nameof(Telefono)}: {Telefono}, {nameof(Email)}: {Email}, " +
            $"{nameof(Usuario)}: {Usuario}, {nameof(Distrito)}: {Distrito}";
    }
}