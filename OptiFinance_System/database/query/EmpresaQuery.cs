using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class EmpresaQuery : IQueryEstandar<Empresa>
{
    private static readonly Lazy<EmpresaQuery> _instance = new(() => new EmpresaQuery());

    private readonly Connection _connectionInstance;

    private EmpresaQuery()
    {
        _connectionInstance = Connection.Instance;
        _connectionInstance.OpenConnection();
    }

    public static EmpresaQuery Instance => _instance.Value;

    public bool Insert(Empresa entity, SqlTransaction? transaction = null)
    {
        string query =
            "INSERT INTO empresas (nombre, nit, giro_economico, representante_legal, direccion, telefono, email, id_usuario, id_distrito) " +
            "VALUES (@nombre, @nit, @giro_economico, @representante_legal, @direccion, @telefono, @email, @id_usuario, @id_distrito)";

        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@nombre", entity.Nombre),
            new("@nit", entity.Nit),
            new("@giro_economico", entity.GiroEconomico),
            new("@representante_legal", entity.RepresentanteLegal),
            new("@direccion", entity.Direccion),
            new("@telefono", entity.Telefono),
            new("@email", entity.Email),
            new("@id_usuario", entity.Usuario.Id),
            new("@id_distrito", entity.Distrito.Id)
        };

        bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters, transaction);
        return result;
    }

    public bool Insert(List<Empresa> entities)
    {
        string query =
            "INSERT INTO empresas (nombre, nit, giro_economico, representante_legal, direccion, telefono, email, id_usuario, id_distrito) " +
            "VALUES (@nombre, @nit, @giro_economico, @representante_legal, @direccion, @telefono, @email, @id_usuario, @id_distrito)";

        return QueryHelper.ExecuteInTransaction(_connectionInstance.GetSqlConnection(), transaction =>
        {
            foreach (Empresa entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new("@nombre", entity.Nombre),
                    new("@nit", entity.Nit),
                    new("@giro_economico", entity.GiroEconomico),
                    new("@representante_legal", entity.RepresentanteLegal),
                    new("@direccion", entity.Direccion),
                    new("@telefono", entity.Telefono),
                    new("@email", entity.Email),
                    new("@id_usuario", entity.Usuario.Id),
                    new("@id_distrito", entity.Distrito.Id)
                };

                bool result = QueryHelper.ExecuteInsert(_connectionInstance.GetSqlConnection(), query, parameters,
                    transaction);
                if (!result) return false;
            }

            return true;
        });
    }

    public bool Update(Empresa entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Empresa> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Empresa entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Empresa> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Empresa? FindById(long id)
    {
        string query = "SELECT id, nombre, nit, giro_economico, representante_legal, direccion, " +
                       "telefono, email, id_usuario, id_distrito FROM empresas WHERE id = @id";

        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new("@id", id)
        };

        return QueryHelper.ExecuteFind(_connectionInstance.GetSqlConnection(), query, MapEntity, parameters);
    }

    public List<Empresa> SelectAll()
    {
        string query = "SELECT id, nombre, nit, giro_economico, representante_legal, direccion, " +
                       "telefono, email, id_usuario, id_distrito FROM empresas";

        return QueryHelper.ExecuteSelect(_connectionInstance.GetSqlConnection(), query, MapEntity);
    }

    public Empresa MapEntity(SqlDataReader reader)
    {
        return new Empresa
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Nit = reader.IsDBNull(2) ? null : reader.GetString(2),
            GiroEconomico = reader.GetString(3),
            RepresentanteLegal = reader.GetString(4),
            Direccion = reader.IsDBNull(5) ? null : reader.GetString(5),
            Telefono = reader.GetString(6),
            Email = reader.GetString(7),
            Usuario = UsuarioQuery.Instance.FindById(reader.GetInt64(8))!,
            Distrito = DistritoQuery.Instance.FindById(reader.GetInt64(9))!
        };
    }
}