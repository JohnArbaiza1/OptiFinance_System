using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class PartidaQuery : TableQuery, IQueryEstandar<Partida>
{
    private static readonly Lazy<PartidaQuery> _instance = new(() => new PartidaQuery());

    private readonly Connection _connectionInstance;

    private PartidaQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static PartidaQuery Instance => _instance.Value;

    public bool Insert(Partida entity, SqlTransaction? transaction = null)
    {
        string query = "INSERT INTO partidas (detalles, fecha, id_empresa) VALUES (@detalles, @fecha, @id_empresa)";

        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@detalles", entity.Detalles),
            new("@fecha", entity.Fecha),
            new("@id_empresa", entity.Empresa.Id)
        };

        bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Insert(List<Partida> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Partida entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Partida> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Partida entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Partida> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Partida? FindById(long id)
    {
        string query = "SELECT id, detalles, fecha, id_empresa FROM partidas WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@id", id)
        };

        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }

    public List<Partida> SelectAll()
    {
        string query = "SELECT id, detalles, fecha, id_empresa FROM partidas";
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), query, MapEntity);
    }

    public Partida MapEntity(SqlDataReader reader)
    {
        return new Partida
        {
            Id = reader.GetInt64(0),
            Detalles = reader.GetString(1),
            Fecha = reader.GetDateTime(2),
            Empresa = EmpresaQuery.Instance.FindById(reader.GetInt64(3))!
        };
    }
}