namespace OptiFinance_System.database.models;

public class Usuario
{
    public long Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? Telefono { get; set; } = string.Empty;
    public string? Direccion { get; set; } = string.Empty;
    public TipoUsuario TipoUsuario { get; set; } = new TipoUsuario();

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Nombre)}: {Nombre}, {nameof(Apellido)}: {Apellido}, " +
            $"{nameof(Alias)}: {Alias}, {nameof(Email)}: {Email}, {nameof(Password)}: {Password}, " +
            $"{nameof(Telefono)}: {Telefono}, {nameof(Direccion)}: {Direccion}, {nameof(TipoUsuario)}: {TipoUsuario}";
    }
}