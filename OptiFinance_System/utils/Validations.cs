using Microsoft.IdentityModel.Tokens;
using OptiFinance_System.database.models;

namespace OptiFinance_System.utils;

public class Validations
{
    public static bool ComparePasswordHash(string password, string passwordHash)
    {
        return BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }

    public static bool UserExist(People? people)
    {
        if (people == null) return false;
        if (people is MiembroEmpresa)
        {
            MiembroEmpresa miembroEmpresa = (MiembroEmpresa)people;
            return !miembroEmpresa.Alias.IsNullOrEmpty() && !miembroEmpresa.Password.IsNullOrEmpty();
        }

        Usuario usuario = (Usuario)people;
        return !usuario.Alias.IsNullOrEmpty() && !usuario.Password.IsNullOrEmpty();
    }

    public static bool FieldNullOrEmpty(string field)
    {
        return field.IsNullOrEmpty();
    }
}