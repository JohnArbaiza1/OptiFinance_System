using System.Data;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.@interface;
using OptiFinance_System.database.models;
using Exception = System.Exception;
using Message = OptiFinance_System.utils.Message;

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

    public bool Insert(Departamento entity, SqlTransaction? transaction = null)
    {
        /*bool isInserted = false;
        try
        {
            _connectionInstance.OpenConnection();

            string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";

            SqlCommand command = new SqlCommand(query, _connection, transaction);
            command.Parameters.AddWithValue("@nombre", entity.Nombre);
            command.Parameters.AddWithValue("@codigo", entity.Codigo);

            isInserted = command.ExecuteNonQuery() > 0;
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al insertar la entidad: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return isInserted;*/

        string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@nombre", entity.Nombre),
            new SqlParameter("@codigo", entity.Codigo)
        };

        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Insert(List<Departamento> entities)
    {
        /*bool isInserted = false;

        try
        {
            _connectionInstance.OpenConnection();
            using (SqlTransaction? transaction = _connection.BeginTransaction())
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        if (!Insert(entity, transaction))
                        {
                            Message.MessageViewError(@"Error al insertar una de las entidades.");
                            transaction.Rollback();
                            return false;
                        }
                    }

                    transaction.Commit();
                    isInserted = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Message.MessageViewError(@"Error al insertar las entidades: " + ex.Message);
                }
            }
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al abrir la conexión: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return isInserted;*/

        string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (var entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", entity.Nombre),
                    new SqlParameter("@codigo", entity.Codigo)
                };
                
                bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    Message.MessageViewError(@"Error al insertar una de las entidades.");
                    return false;
                }
            }
            return true;
        });
    }


    public bool Update(Departamento entity, SqlTransaction? transaction = null)
    {
        /*bool isUpdated = false;
        string query = "UPDATE departamentos SET nombre = @nombre, codigo = @codigo WHERE id = @id";
        try
        {
            _connectionInstance.OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection, transaction);
            command.Parameters.AddWithValue("@nombre", entity.Nombre);
            command.Parameters.AddWithValue("@codigo", entity.Codigo);
            command.Parameters.AddWithValue("@id", entity.Id);

            isUpdated = command.ExecuteNonQuery() > 0;
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al actualizar la entidad: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return isUpdated;*/

        string query = "UPDATE departamentos SET nombre = @nombre, codigo = @codigo WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@nombre", entity.Nombre),
            new SqlParameter("@codigo", entity.Codigo),
            new SqlParameter("@id", entity.Id)
        };

        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteUpdate(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Update(List<Departamento> entities)
    {
        /*bool isUpdated = false;

        try
        {
            _connectionInstance.OpenConnection();
            using (SqlTransaction? transaction = _connection.BeginTransaction())
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        if (!Update(entity, transaction))
                        {
                            Message.MessageViewError(@"Error al actualizar una de las entidades.");
                            transaction.Rollback();
                            return false;
                        }
                    }

                    transaction.Commit();
                    isUpdated = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Message.MessageViewError(@"Error al actualizar las entidades: " + ex.Message);
                }
            }
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al abrir la conexión: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return isUpdated;*/

        string query = "UPDATE departamentos SET nombre = @nombre, codigo = @codigo WHERE id = @id";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
            {
                foreach (var entity in entities)
                {
                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@nombre", entity.Nombre),
                        new SqlParameter("@codigo", entity.Codigo),
                        new SqlParameter("@id", entity.Id)
                    };

                    bool result = QueryHelper.ExecuteUpdate(_connectionInstance, query, parameters, transaction);
                    if (!result)
                    {
                        Message.MessageViewError(@"Error al actualizar una de las entidades.");
                        return false;
                    }
                }

                return true;
            }
        );
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        /*bool isDeleted = false;
        string query = "DELETE FROM departamentos WHERE id = @id";
        try
        {
            _connectionInstance.OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection, transaction);
            command.Parameters.AddWithValue("@id", id);

            isDeleted = command.ExecuteNonQuery() > 0;
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al eliminar la entidad: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return isDeleted;*/
        
        string query = "DELETE FROM departamentos WHERE id = @id";
        
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };
        
        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteDelete(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Delete(Departamento entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        /*bool isDeleted = false;
        try
        {
            _connectionInstance.OpenConnection();
            using (SqlTransaction? transaction = _connection.BeginTransaction())
            {
                try
                {
                    foreach (var id in ids)
                    {
                        if (!Delete(id, transaction))
                        {
                            Message.MessageViewError(@"Error al eliminar una de las entidades.");
                            transaction.Rollback();
                            return false;
                        }
                    }

                    transaction.Commit();
                    isDeleted = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Message.MessageViewError(@"Error al eliminar las entidades: " + ex.Message);
                }
            }
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al abrir la conexión: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return isDeleted;*/

        string query = "DELETE FROM departamentos WHERE id = @id";

        _connectionInstance.OpenConnection();

        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (var id in ids)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@id", id)
                };

                bool result = QueryHelper.ExecuteDelete(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    Message.MessageViewError(@"Error al eliminar una de las entidades.");
                    return false;
                }
            }

            return true;
        });
    }

    public bool Delete(List<Departamento> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Departamento? FindById(long id)
    {
        /*Departamento? departamento = null;
        string query = "SELECT id, nombre, codigo FROM departamentos WHERE id = @id";
        
        try
        {
            _connectionInstance.OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    departamento = new Departamento
                    {
                        Id = reader.GetInt64(0),
                        Nombre = reader.GetString(1),
                        Codigo = reader.GetString(2),
                    };
                }
            }
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al buscar la entidad: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }
        return departamento;*/
        
        string query = "SELECT id, nombre, codigo FROM departamentos WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };

        return QueryHelper.ExecuteFindById(_connectionInstance, query, MapEntity, parameters);
    }

    public List<Departamento> SelectAll()
    {
        /*List<Departamento> departamentos = new List<Departamento>();
        string query = "SELECT id, nombre, codigo FROM departamentos";

        try
        {
            _connectionInstance.OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Departamento departamento = new Departamento
                    {
                        Id = reader.GetInt64(0),
                        Nombre = reader.GetString(1),
                        Codigo = reader.GetString(2),
                    };
                    departamentos.Add(departamento);
                }
            }
        }
        catch (Exception e)
        {
            Message.MessageViewError(@"Error al buscar las entidades: " + e.Message);
        }
        finally
        {
            _connectionInstance.CloseConnection();
        }

        return departamentos;*/

        string query = "SELECT id, nombre, codigo FROM departamentos";
        return QueryHelper.ExecuteSelect(_connectionInstance, query, MapEntity);
    }

    public Departamento MapEntity(SqlDataReader reader)
    {
        return new Departamento
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Codigo = reader.GetString(2),
        };
    }
}