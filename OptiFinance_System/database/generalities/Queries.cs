using OptiFinance_System.database.generalities.queries;

namespace OptiFinance_System.database.generalities;

public static class Queries
{
    public static CuentaQueries CuentaQueries { get; } = new();
    public static MiembroEmpresaQueries MiembroEmpresaQueries { get; } = new();
    public static PartidaQueries PartidaQueries { get; } = new();
    public static RegistroQueries RegistroQueries { get; } = new();
    public static TipoCuentaQueries TipoCuentaQueries { get; } = new();
    public static TipoUsuarioQueries TipoUsuarioQueries { get; } = new();
    public static UsuarioQueries UsuarioQueries { get; } = new();
    public static EmpresaQueries EmpresaQueries { get; } = new();
    public static DepartamentoQueries DepartamentoQueries { get; } = new();
    public static MunicipiosQueries MunicipiosQueries { get; } = new();
    public static DistritoQueries DistritoQueries { get; } = new();
}