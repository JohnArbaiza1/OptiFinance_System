using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class MiembroEmpresaQuery : TableQuery, IQueryEstandar<MiembroEmpresa>
{
    public bool Insert(MiembroEmpresa entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<MiembroEmpresa> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(MiembroEmpresa entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<MiembroEmpresa> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(MiembroEmpresa entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<MiembroEmpresa> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public MiembroEmpresa? FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<MiembroEmpresa> SelectAll()
    {
        throw new NotImplementedException();
    }

    public MiembroEmpresa MapEntity(SqlDataReader reader)
    {
        return new MiembroEmpresa
        {
            Id = reader.GetInt64(0),
            Nombres = reader.GetString(1),
            Apellidos = reader.GetString(2),
            Alias = reader.GetString(3),
            Dui = reader.GetString(4),
            Correo = reader.IsDBNull(5) ? null : reader.GetString(5),
            Telefono = reader.IsDBNull(6) ? null : reader.GetString(6),
            Direccion = reader.GetString(7),
            Empresa = EmpresaQuery.Instance.FindById(reader.GetInt64(8))
        };
    }
}