﻿using Microsoft.Data.SqlClient;
using OptiFinance_System.database.models;

namespace OptiFinance_System.database.query;

public class DistritoQuery : IQueryEstandar<Distrito>
{
    public bool Insert(Distrito entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<Distrito> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(Distrito entity, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<Distrito> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id, SqlTransaction? transaction = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Distrito entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<Distrito> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public Distrito? FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Distrito> SelectAll()
    {
        throw new NotImplementedException();
    }
}