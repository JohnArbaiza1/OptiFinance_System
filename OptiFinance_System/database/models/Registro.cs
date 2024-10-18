﻿namespace OptiFinance_System.database.models;

public class Registro
{
    public long Id { get; set; }
    public decimal Debe { get; set; }
    public decimal Haber { get; set; }
    public Cuenta Cuenta { get; set; } = new();
    public Partida Partida { get; set; } = new();

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Debe)}: {Debe}, {nameof(Haber)}: {Haber}, " +
            $"{nameof(Cuenta)}: {Cuenta}, {nameof(Partida)}: {Partida}";
    }
}