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

    public bool Insert(Departamento entity)
    {
        try
        {
            _connectionInstance.OpenConnection();

            string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";

            SqlCommand command = new SqlCommand(query, _connection);
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
        bool isInserted = true;
        string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";

        try
        {
            _connectionInstance.OpenConnection();
            using (SqlTransaction transaction = _connection.BeginTransaction())
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        SqlCommand command = new SqlCommand(query, _connection, transaction);
                        command.Parameters.AddWithValue("@nombre", entity.Nombre);
                        command.Parameters.AddWithValue("@codigo", entity.Codigo);

                        if (command.ExecuteNonQuery() <= 0)
                        {
                            isInserted = false;
                            break;
                        }
                    }

                    if (isInserted)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return isInserted;
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