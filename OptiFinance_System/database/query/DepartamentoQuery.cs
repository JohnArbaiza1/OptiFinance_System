using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.models;
using Exception = System.Exception;

namespace OptiFinance_System.database.query;

public class DepartamentoQuery : IQueryEstandar<Departamento>
{
    private static readonly Lazy<DepartamentoQuery> _instance =
        new Lazy<DepartamentoQuery>(() => new DepartamentoQuery());

    private readonly SqlConnection _connection;
    private readonly Connection _connectionInstance;

    private DepartamentoQuery()
    {
        _connectionInstance = database.connection.Connection.Instance;
        _connection = _connectionInstance.GetSqlConnection();
    }

    public static DepartamentoQuery Instance => _instance.Value;

    public SqlConnection Connection { get; set; }

    public bool Insert(Departamento entity, SqlTransaction? transaction)
    {
        try
        {
            _connectionInstance.OpenConnection();

            string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";

            SqlCommand command = new SqlCommand(query, _connection, transaction);
            command.Parameters.AddWithValue("@nombre", entity.Nombre);
            command.Parameters.AddWithValue("@codigo", entity.Codigo);

            return command.ExecuteNonQuery() > 0;
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar el departamento", e);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }
    }

    public bool Insert(List<Departamento> entities)
    {
        bool isInserted = false;

        try
        {
            _connectionInstance.OpenConnection(); // Abrimos la conexión
            using (SqlTransaction? transaction = _connection.BeginTransaction()) // Iniciamos la transacción
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        // Llamamos al método Insert para cada Departamento, pasando la transacción
                        if (!Insert(entity, transaction))
                        {
                            throw new Exception("Error al insertar uno de los departamentos.");
                        }
                    }

                    // Si todas las inserciones son exitosas, confirmamos la transacción
                    transaction.Commit();
                    isInserted = true;
                }
                catch (Exception ex)
                {
                    // Si algo falla, deshacemos todas las inserciones
                    transaction.Rollback();
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al insertar la lista de departamentos: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection(); // Cerramos la conexión
        }

        return isInserted; // Retorna true si todas las inserciones son exitosas
    }




    public bool Update(Departamento entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Departamento> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Departamento entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Departamento> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Departamento FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Departamento> SelectAll()
    {
        throw new NotImplementedException();
    }
}