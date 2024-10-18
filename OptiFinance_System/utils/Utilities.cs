namespace OptiFinance_System.utils;

public class Utilities
{
    public static string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}