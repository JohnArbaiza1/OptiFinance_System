using OptiFinance_System.database.models;

namespace OptiFinance_System.global;

public class Global
{
    public static Usuario? SelectedUser { get; set; } = null;
    public static MiembroEmpresa? SelectedMiembroEmpresa { get; set; } = null;
    public static Empresa? SelectedEmpresa { get; set; } = null;
    public static List<GiroEconomico>? ListGirosEconomicos { get; set; } = null;
}