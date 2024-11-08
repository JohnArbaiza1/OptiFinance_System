using OptiFinance_System.database.generalities.parameters;

namespace OptiFinance_System.database.generalities;

public static class Queries
{
    public static CuentaParams CuentaParams { get; } = new();
    public static MiembroEmpresaParams MiembroEmpresaParams { get; } = new();
    public static PartidaParams PartidaParams { get; } = new();
    public static RegistroParams RegistroParams { get; } = new();
    public static TipoCuentaParams TipoCuentaParams { get; } = new();
    public static TipoUsuarioParams TipoUsuarioParams { get; } = new();
    public static UsuarioParams UsuarioParams { get; } = new();
    public static EmpresaParams EmpresaParams { get; } = new();
    public static DepartamentoParams DepartamentoParams { get; } = new();
    public static MunicipiosParams MunicipiosParams { get; } = new();
    public static DistritoParams DistritoParams { get; } = new();
    public static GiroEconomicoParams GiroEconomicoParams { get; } = new();
    public static LibroMayorParams LibroMayorParams { get; } = new();
    public static BalanceGeneralParams BalanceGeneralParams { get; } = new();
    
    public static EstadoResultadoParams EstadoResultadoParams { get; } = new();
}