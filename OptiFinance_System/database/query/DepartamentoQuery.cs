using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.query;

public class DepartamentoQuery : IQueryEstandar<Departamento>
{
    private static readonly Lazy<DepartamentoQuery> _instance = new(() => new());

    private readonly Connection _connectionInstance;

    private DepartamentoQuery()
    {
        _connectionInstance = connection.Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static DepartamentoQuery Instance => _instance.Value;

    public SqlConnection Connection { get; set; }

    public bool Insert(Departamento entity, SqlTransaction? transaction = null)
    {
        string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@codigo", entity.Codigo)
        };

        bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Insert(List<Departamento> entities)
    {
        string query = "INSERT INTO departamentos (nombre, codigo) VALUES (@nombre, @codigo)";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (Departamento entity in entities)
            {
                List<SqlParameter> parameters = new()
                {
                    new("@nombre", entity.Nombre),
                    new("@codigo", entity.Codigo)
                };

                bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters,
                    transaction);
                if (!result) return false;
            }

            return true;
        });
    }


    public bool Update(Departamento entity, SqlTransaction? transaction = null)
    {
        string query = "UPDATE departamentos SET nombre = @nombre, codigo = @codigo WHERE id = @id";
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@codigo", entity.Codigo),
            new("@id", entity.Id)
        };

        bool result = QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Update(List<Departamento> entities)
    {
        string query = "UPDATE departamentos SET nombre = @nombre, codigo = @codigo WHERE id = @id";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
            {
                foreach (Departamento entity in entities)
                {
                    List<SqlParameter> parameters = new()
                    {
                        new("@nombre", entity.Nombre),
                        new("@codigo", entity.Codigo),
                        new("@id", entity.Id)
                    };

                    bool result = QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), query, parameters,
                        transaction);
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
        string query = "DELETE FROM departamentos WHERE id = @id";

        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };

        bool result = QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Delete(Departamento entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        string query = "DELETE FROM departamentos WHERE id = @id";

        _connectionInstance.OpenConnection();

        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (long id in ids)
            {
                List<SqlParameter> parameters = new()
                {
                    new("@id", id)
                };

                bool result = QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), query, parameters,
                    transaction);
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
        string query = "SELECT id, nombre, codigo FROM departamentos WHERE id = @id";
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };

        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }

    public List<Departamento> SelectAll()
    {
        string query = "SELECT id, nombre, codigo FROM departamentos";
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), query, MapEntity);
    }

    public Departamento MapEntity(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Codigo = reader.IsDBNull(2) ? null : reader.GetString(2)
        };
    }

    public Departamento? FindByName(string name)
    {
        string query = "SELECT id, nombre, codigo FROM departamentos WHERE nombre = @nombre";

        List<SqlParameter> parameters = new()
        {
            new("@nombre", name)
        };

        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }
}