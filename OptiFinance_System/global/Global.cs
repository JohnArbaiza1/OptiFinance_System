using OptiFinance_System.database.models;

namespace OptiFinance_System.global;

public class Global
{
    /// <summary>
    /// Devuelve el usuario seleccionado, si no hay usuario seleccionado devuelve null
    /// </summary>
    public static Usuario? SelectedUser { get; set; } = null;
    
    /// <summary>
    /// Valida si hay un usuario seleccionado
    /// true si hay un usuario seleccionado
    /// false en caso contarario
    /// </summary>
    public static bool IsSelectedUser { get; set; } = false;
    
    /// <summary>
    /// Valida el miembro de empresa seleccionado, si no hay miembro de empresa seleccionado devuelve null
    /// </summary>
    public static MiembroEmpresa? SelectedMiembroEmpresa { get; set; } = null;
    
    /// <summary>
    /// Valida si hay un miembro de empresa seleccionado
    /// true si hay un miembro de empresa seleccionado
    /// false en caso contarario
    /// </summary>
    public static bool IsSelectedMiembroEmpresa { get; set; } = false;
    
    /// <summary>
    /// Valida la empresa seleccionada, si no hay empresa seleccionada devuelve null
    /// </summary>
    public static Empresa? SelectedEmpresa { get; set; } = null;
    
    /// <summary>
    /// Valida si hay una empresa seleccionada
    /// </summary>
    public static bool IsSelectedEmpresa { get; set; } = false;
    
    /// <summary>
    /// Contiene todos los giros económicos en caché,con la finalidad de no hacer consultas innecesarias a la base de datos
    /// </summary>
    public static List<GiroEconomico>? ListGirosEconomicos { get; set; } = null;
    public static List<Usuario>? listUsuarios { get; set; } = null;
}