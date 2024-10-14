using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace OptiFinance_System.Config.connection;

public class Conexion
{
    private static Conexion? _instance;
    private static readonly object _lock = new object();
    private readonly string? _connectionString;
    private readonly SqlConnection? _connection;

    private Conexion()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();
        _connectionString = configuration.GetConnectionString("DefaultConnection");

        // Inicializar el objeto SqlConnection
        _connection = new SqlConnection(_connectionString);
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

    // Método para obtener el objeto SqlConnection
    public SqlConnection GetConnection()
    {
        return _connection ?? throw new InvalidOperationException();
    }

    // Método para abrir la conexión (si aún no está abierta)
    public void AbrirConexion()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Closed)
        {
            _connection.Open();
        }
    }

    // Método para cerrar la conexión (si está abierta)
    public void CerrarConexion()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
        {
            _connection.Close();
        }
    }
}