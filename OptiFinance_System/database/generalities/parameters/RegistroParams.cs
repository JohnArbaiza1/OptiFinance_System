﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.interfaces;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.database.generalities.parameters;

public class RegistroParams : IQueriesString<Registro>
{
    public string InsertSql { get; } =
        "INSERT INTO registros (debe, haber, id_cuenta, id_partida) VALUES (@debe, @haber, @id_cuenta, @id_partida)";

    public string UpdateSql { get; } =
        "UPDATE registros SET debe = @debe, haber = @haber, id_cuenta = @id_cuenta, id_partida = @id_partida WHERE id = @id";

    public string DeleteSql { get; } = "DELETE FROM registros WHERE id = @id";
    public string FindByIdSql { get; } = "SELECT id, debe, haber, id_cuenta, id_partida FROM registros WHERE id = @id";

    public string SelectAllSql { get; } =
        "SELECT id, debe, haber, id_cuenta, id_partida FROM registros WHERE id_partida = @id_partida";

    public List<SqlParameter> InsertParameters(Registro entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@debe", entity.Debe),
            new("@haber", entity.Haber),
            new("@id_cuenta", entity.Cuenta?.Id),
            new("@id_partida", entity.Partida?.Id)
        };
        return parameters;
    }

    public List<SqlParameter> UpdateParameters(Registro entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@debe", entity.Debe),
            new("@haber", entity.Haber),
            new("@id_cuenta", entity.Cuenta?.Id),
            new("@id_partida", entity.Partida?.Id),
            new("@id", entity.Id)
        };
        return parameters;
    }

    public List<SqlParameter> DeleteParameters(long id)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return parameters;
    }

    public List<SqlParameter> FindByIdParameters(long id, Usuario? user = null)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id", id)
        };
        return parameters;
    }

    public List<SqlParameter> SelectAllParameters(Partida entity)
    {
        List<SqlParameter> parameters = new()
        {
            new("@id_partida", entity.Id)
        };
        return parameters;
    }

    public Registro Map(SqlDataReader reader)
    {
        return new()
        {
            Id = reader.GetInt64(0),
            Debe = reader.GetDecimal(1),
            Haber = reader.GetDecimal(2),
            Cuenta = CuentaQuery.Instance.FindById(reader.GetInt64(3)),
            Partida = PartidaQuery.Instance.FindById(reader.GetInt64(4))
        };
    }
}