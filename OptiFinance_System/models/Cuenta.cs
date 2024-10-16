﻿namespace OptiFinance_System.models;

public class Cuenta
{
    public long Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public TipoCuenta TipoCuenta { get; set; } = new TipoCuenta();

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Codigo)}: {Codigo}, {nameof(TipoCuenta)}: {TipoCuenta}";
    }
}