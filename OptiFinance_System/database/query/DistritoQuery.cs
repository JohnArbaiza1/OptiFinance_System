using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.query;

public class DistritoQuery : IQueryEstandar<Distrito>
{
    private static readonly Lazy<DistritoQuery> _instance = new(() => new DistritoQuery());

    private readonly Connection _connectionInstance;

    private DistritoQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static DistritoQuery Instance => _instance.Value;

    public bool Insert(Distrito entity, SqlTransaction? transaction = null)
    {
        string query = "INSERT INTO distritos (nombre, id_municipio) VALUES (@nombre, @id_municipio)";

        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@id_municipio", entity.Municipio.Id)
        };

        bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Insert(List<Distrito> entities)
    {
        string query = "INSERT INTO distritos (nombre, id_municipio) VALUES (@nombre, @id_municipio)";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (Distrito entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new("@nombre", entity.Nombre),
                    new("@id_municipio", entity.Municipio.Id)
                };

                bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters,
                    transaction);
                if (!result)
                {
                    Message.MessageViewError(@"Error al insertar una de las entidades.");
                    return false;
                }
            }

            return true;
        });
    }

    public bool Update(Distrito entity, SqlTransaction? transaction = null)
    {
        string query = "UPDATE distritos SET nombre = @nombre, id_municipio = @id_municipio WHERE id = @id";

        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@id_municipio", entity.Municipio.Id),
            new("@id", entity.Id)
        };

        bool result = QueryHelper.ExecuteUpdate(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Update(List<Distrito> entities)
    {
        string query = "UPDATE distritos SET nombre = @nombre, id_municipio = @id_municipio WHERE id = @id";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (Distrito entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new("@nombre", entity.Nombre),
                    new("@id_municipio", entity.Municipio.Id),
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
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        string query = "DELETE FROM distritos WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@id", id)
        };

        bool result = QueryHelper.ExecuteDelete(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Delete(Distrito entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        string query = "DELETE FROM distritos WHERE id = @id";
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (long id in ids)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
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

    public bool Delete(List<Distrito> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Distrito? FindById(long id)
    {
        string query = "SELECT id, nombre, id_municipio FROM distritos WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@id", id)
        };

        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }

    public List<Distrito> SelectAll()
    {
        string query = "SELECT id, nombre, id_municipio FROM distritos";
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), query, MapEntity);
    }

    public Distrito MapEntity(SqlDataReader reader)
    {
        return new Distrito
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Municipio = MunicipioQuery.Instance.FindById(reader.GetInt64(2))!
        };
    }
}