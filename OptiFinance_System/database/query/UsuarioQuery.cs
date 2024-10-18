using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class UsuarioQuery : IQueryEstandar<Usuario>
{
    private static readonly Lazy<UsuarioQuery> _instance = new(() => new UsuarioQuery());
    private readonly Connection _connectionInstance;

    private UsuarioQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static UsuarioQuery Instance => _instance.Value;

    public bool Insert(Usuario entity, SqlTransaction? transaction = null)
    {
        string query = Queries.UsuarioQueries.Insert;

        List<SqlParameter> parameters = Queries.UsuarioQueries.InsertParameters(entity);

        bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Insert(List<Usuario> entities)
    {
        string query = Queries.UsuarioQueries.Insert;

        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (Usuario entity in entities)
            {
                List<SqlParameter> parameters = Queries.UsuarioQueries.InsertParameters(entity);
                bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters,
                    transaction);
                if (!result) return false;
            }

            return true;
        });
    }

    public bool Update(Usuario entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Usuario> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Usuario entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Usuario> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Usuario? FindById(long id)
    {
        string query = Queries.UsuarioQueries.FindById;
        List<SqlParameter> parameters = Queries.UsuarioQueries.FindByIdParameters(id);
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }

    public List<Usuario> SelectAll()
    {
        string query = Queries.UsuarioQueries.SelectAll;
        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), query, MapEntity);
    }

    public Usuario MapEntity(SqlDataReader reader)
    {
        return new Usuario
        {
            Id = reader.GetInt64(0),
            Nombres = reader.GetString(1),
            Apellidos = reader.GetString(2),
            Alias = reader.GetString(3),
            Email = reader.IsDBNull(4) ? null : reader.GetString(4),
            Password = reader.GetString(5),
            Telefono = reader.IsDBNull(6) ? null : reader.GetString(6),
            Direccion = reader.IsDBNull(7) ? null : reader.GetString(7),
            TipoUsuario = TipoUsuarioQuery.Instance.FindById(reader.GetInt64(8))!
        };
    }

    public Usuario? FindByUsername(string username)
    {
        string query =
            "SELECT id, nombres, apellidos, alias, email, password, telefono, direccion, id_tipo_usuario FROM usuarios WHERE alias = @alias";
        List<SqlParameter> parameters = new List<SqlParameter> { new("@alias", username) };
        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }
}