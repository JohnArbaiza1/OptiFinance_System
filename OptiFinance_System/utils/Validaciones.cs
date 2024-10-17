using BCrypt.Net;

namespace OptiFinance_System.utils;

public class Validaciones
{
    public static bool ComparePasswordHash(string password, string passwordHash)
    {
        return BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }
}