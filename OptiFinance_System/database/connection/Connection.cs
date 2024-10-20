﻿using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace OptiFinance_System.database.connection;

public class Connection
{
    private static readonly Lazy<Connection> _instance = new(() => new());
    private readonly string? _connectionString;
    private readonly SqlConnection _sql_connection;

    private Connection()
    {
        IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true);

        IConfigurationRoot configuration = builder.Build();
        _connectionString = configuration.GetConnectionString("DefaultConnection")
                            ?? throw new InvalidOperationException("Connection string not found.");

        // Inicializar el objeto SqlConnection
        _sql_connection = new(_connectionString);
    }

    public static Connection Instance => _instance.Value;

    public SqlConnection GetSqlConnection()
    {
        return _sql_connection;
    }

    public void OpenConnection()
    {
        try
        {
            if (_sql_connection.State == ConnectionState.Closed) _sql_connection.Open();
        }
        catch (SqlException ex)
        {
            throw new("Error al abrir la conexión", ex);
        }
    }

    public void CloseConnection()
    {
        try
        {
            if (_sql_connection.State == ConnectionState.Open) _sql_connection.Close();
        }
        catch (SqlException ex)
        {
            throw new("Error al cerrar la conexión", ex);
        }
    }
}