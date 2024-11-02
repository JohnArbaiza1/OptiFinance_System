namespace OptiFinance_System.database.models;

public class MiembroEmpresa : People
{
    public long Id { get; set; }
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string Dui { get; set; } = string.Empty;
    public string? Correo { get; set; } = string.Empty;
    public string? Telefono { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
    public Empresa? Empresa { get; set; } = null;

    public override string ToString()
    {
        return Nombres;
    }
}