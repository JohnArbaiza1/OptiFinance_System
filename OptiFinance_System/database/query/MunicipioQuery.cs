﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.@interface;
using OptiFinance_System.database.models;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.database.query;

public class MunicipioQuery : IQueryEstandar<Municipio>
{
    private static readonly Lazy<MunicipioQuery> _instance = new Lazy<MunicipioQuery>(() => new MunicipioQuery());
    private readonly SqlConnection _connection;
    private readonly Connection _connectionInstance;

    private MunicipioQuery()
    {
        _connectionInstance = Connection.Instance;
        _connection = _connectionInstance.GetSqlConnection();
    }

    public static MunicipioQuery Instance => _instance.Value;

    public bool Insert(Municipio entity, SqlTransaction? transaction = null)
    {
        string query = "INSERT INTO municipios (nombre, id_departamento) VALUES (@nombre, @id_departamento)";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@nombre", entity.Nombre),
            new SqlParameter("@id_departamento", entity.Departamento.Id)
        };

        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Insert(List<Municipio> entities)
    {
        string query = "INSERT INTO municipios (nombre, id_departamento) VALUES (@nombre, @id_departamento)";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (Municipio entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", entity.Nombre),
                    new SqlParameter("@id_departamento", entity.Departamento.Id)
                };
                bool result = QueryHelper.ExecuteInsert(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    return false;
                }
            }

            return true;
        });
    }

    public bool Update(Municipio entity, SqlTransaction? transaction = null)
    {
        string query = "UPDATE municipios SET nombre = @nombre, id_departamento = @id_departamento WHERE id = @id";

        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@nombre", entity.Nombre),
            new SqlParameter("@id_departamento", entity.Departamento.Id),
            new SqlParameter("@id", entity.Id)
        };

        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteUpdate(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Update(List<Municipio> entities)
    {
        string query = "UPDATE municipios SET nombre = @nombre, id_departamento = @id_departamento WHERE id = @id";
        _connectionInstance.OpenConnection();
        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (Municipio entity in entities)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", entity.Nombre),
                    new SqlParameter("@id_departamento", entity.Departamento.Id),
                    new SqlParameter("@id", entity.Id)
                };
                bool result = QueryHelper.ExecuteUpdate(_connectionInstance, query, parameters, transaction);
                if (!result)
                {
                    return false;
                }
            }

            return true;
        });
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        string query = "DELETE FROM municipios WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };

        _connectionInstance.OpenConnection();
        bool result = QueryHelper.ExecuteDelete(_connectionInstance, query, parameters, transaction);
        _connectionInstance.CloseConnection();
        return result;
    }

    public bool Delete(Municipio entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        string query = "DELETE FROM municipios WHERE id = @id";

        _connectionInstance.OpenConnection();

        return QueryHelper.ExecuteInTransaction(_connectionInstance, transaction =>
        {
            foreach (long id in ids)
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

    public bool Delete(List<Municipio> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Municipio? FindById(long id)
    {
        string query = "SELECT id, nombre, id_departamento FROM municipios WHERE id = @id";
        List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id)
        };

        return QueryHelper.ExecuteFind(_connectionInstance, query, MapEntity, parameters);
    }

    public Municipio? FindByName(string name)
    {
        string query = "SELECT id, nombre, id_departamento FROM municipios WHERE nombre = @nombre";
        List<SqlParameter> parameters = new List<SqlParameter> { new SqlParameter("@nombre", name) };
        return QueryHelper.ExecuteFind(_connectionInstance, query, MapEntity, parameters);
    }

    public List<Municipio> SelectAll()
    {
        string query = "SELECT id, nombre, id_departamento FROM municipios";
        return QueryHelper.ExecuteSelect(_connectionInstance, query, MapEntity);
    }

    public Municipio MapEntity(SqlDataReader reader)
    {
        return new Municipio()
        {
            Id = reader.GetInt64(0),
            Nombre = reader.GetString(1),
            Departamento = DepartamentoQuery.Instance.FindById(reader.GetInt64(2))!
        };
    }
}