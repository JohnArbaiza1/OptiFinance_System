﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class PartidaQuery : IQueryEstandar<Partida>
{
    public bool Insert(Partida entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Partida> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Partida entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Partida> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
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

    public Partida FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Partida> SelectAll()
    {
        throw new NotImplementedException();
    }
}