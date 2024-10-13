using Microsoft.Extensions.Configuration;

namespace OptiFinance_System.Config.connection;

public class Conexion
{
    private static Conexion? _instance;
    private static readonly object _lock = new object();
    private readonly string? _connectionString;

    private Conexion()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public static Conexion Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Conexion();
                }

                return _instance;
            }
        }
    }

    public string? GetConnectionString()
    {
        return _connectionString;
    }
}