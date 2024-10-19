using Microsoft.IdentityModel.Tokens;
using OptiFinance_System.database.models;

namespace OptiFinance_System.utils;

public class Validations
{
    public static bool ComparePasswordHash(string password, string passwordHash)
    {
        return BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }

    public static bool UserExist(Usuario? user)
    {
        return user != null && !user.Alias.IsNullOrEmpty() && !user.Password.IsNullOrEmpty();
    }

    public static bool FieldNullOrEmpty(string field)
    {
        return field.IsNullOrEmpty();
    }
}