﻿using OptiFinance_System.models;

namespace OptiFinance_System.Config.query;

public class TipoCuentaQuery : IQueryEstandar<TipoCuenta>
{
    public bool Insert(TipoCuenta entity)
    {
        throw new NotImplementedException();
    }

    public bool Insert(List<TipoCuenta> entities)
    {
        throw new NotImplementedException();
    }

    public bool Update(TipoCuenta entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(List<TipoCuenta> entities)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(TipoCuenta entity)
    {
        return Delete(entity.Id);
    }

    public bool Delete(List<long> ids)
    {
        throw new NotImplementedException();
    }

    public bool Delete(List<TipoCuenta> entities)
    {
        return Delete(entities.Select(e => e.Id).ToList());
    }

    public TipoCuenta FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<TipoCuenta> SelectAll()
    {
        throw new NotImplementedException();
    }
}