using BCrypt.Net;
using Microsoft.IdentityModel.Tokens;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

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
}