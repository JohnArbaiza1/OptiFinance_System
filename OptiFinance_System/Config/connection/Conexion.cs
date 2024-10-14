using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace OptiFinance_System.Config.connection;

public class Conexion
{
    private static readonly Lazy<Conexion> _instance = new Lazy<Conexion>(() => new Conexion());
    private readonly string? _connectionString;
    private readonly SqlConnection _connection;

    private Conexion()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();
        _connectionString = configuration.GetConnectionString("DefaultConnection")
                            ?? throw new InvalidOperationException("Connection string not found.");

        // Inicializar el objeto SqlConnection
        _connection = new SqlConnection(_connectionString);
    }

    public static Conexion Instance => _instance.Value;

    public SqlConnection GetConnection()
    {
        return _connection;
    }

    public void OpenConnection()
    {
        if (_connection.State == System.Data.ConnectionState.Closed)
        {
            _connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (_connection.State == System.Data.ConnectionState.Open)
        {
            _connection.Close();
        }
    }
}