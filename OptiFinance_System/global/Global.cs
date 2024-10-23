using OptiFinance_System.database.models;

namespace OptiFinance_System.global;

public class Global
{
    public static Usuario? SelectedUser { get; set; } = null;
    public static bool IsSelectedUser { get; set; } = false;
    public static MiembroEmpresa? SelectedMiembroEmpresa { get; set; } = null;
    public static bool IsSelectedMiembroEmpresa { get; set; } = false;
    public static Empresa? SelectedEmpresa { get; set; } = null;
    public static bool IsSelectedEmpresa { get; set; } = false;
    public static List<GiroEconomico>? ListGirosEconomicos { get; set; } = null;
}