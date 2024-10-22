using OptiFinance_System.global;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class EmpresaParams : IQueriesString<Empresa>
{
    public string SqlInsert =>
        "INSERT INTO empresas " +
        "(nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico) " +
        "VALUES (@nombre, @nit, @representante_legal, @direccion, @telefono, @email, @id_usuario, @id_distrito, @id_giro_economico)";

    public string SqlUpdate =>
        "UPDATE empresas SET " +
        "nombre = @nombre, nit = @nit, representante_legal = @representante_legal, direccion = @direccion, telefono = @telefono, " +
        "email = @email, id_usuario = @id_usuario, id_distrito = @id_distrito, id_giro_economico = @id_giro_economico " +
        "WHERE id = @id";

    public string SqlDelete => "DELETE FROM empresas WHERE id = @id";

    public string SqlFindById =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico" +
        "FROM empresas WHERE id = @id and id_usuario = @id_usuario";

    public string SqlSelectAll =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico " +
        "FROM empresas WHERE id_usuario = @id_usuario";

    public string SqlSearchAll =>
        "SELECT id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico FROM empresas " +
        "WHERE CONCAT(id, nombre, nit, representante_legal, direccion, telefono, email, id_usuario, id_distrito, id_giro_economico) LIKE @search";

    public List<SqlParameter> ParametersInsert(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@nit", entity.Nit),
            new("@representante_legal", entity.RepresentanteLegal),
            new("@direccion", entity.Direccion),
            new("@telefono", entity.Telefono),
            new("@email", entity.Email),
            new("@id_usuario", entity.Usuario?.Id),
            new("@id_distrito", entity.Distrito?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersUpdate(Empresa entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@nombre", entity.Nombre),
            new("@nit", entity.Nit),
            new("@representante_legal", entity.RepresentanteLegal),
            new("@direccion", entity.Direccion),
            new("@telefono", entity.Telefono),
            new("@email", entity.Email),
            new("@id_usuario", entity.Usuario?.Id),
            new("@id_distrito", entity.Distrito?.Id),
            new("@id", entity.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersDelete(long id)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersFindById(long id, Usuario? user = null)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id),
            new("@id_usuario", Global.SelectedUser!.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersSelectAll()
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_usuario", Global.SelectedUser!.Id)
        };
        return parameters;
    }

    public List<SqlParameter> ParametersSearchAll(string search)
    {
        List<SqlParameter> parameters = new()
        {
            new("@search", $"%{search}%")
        };
        return parameters;
    }

    public Empresa Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Nit = reader.IsDBNull(2) ? null : reader.GetString(2),
            RepresentanteLegal = reader.GetString(4),
            Direccion = reader.IsDBNull(5) ? null : reader.GetString(5),
            Telefono = reader.GetString(6),
            Email = reader.GetString(7),
            Usuario = UsuarioQuery.Instance.FindById(reader.GetInt64(8)),
            Distrito = DistritoQuery.Instance.FindById(reader.GetInt64(9)),
            GiroEconomico = GiroEconomicoQuery.Instance.FindById(reader.GetInt64(10))
        };
    }
}