﻿namespace OptiFinance_System.database.models;

public class MiembroEmpresa
{
    public long Id { get; set; }
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string Dui { get; set; } = string.Empty;
    public string? Correo { get; set; } = string.Empty;
    public string? Telefono { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public Empresa? Empresa { get; set; } = null;

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Nombres)}: {Nombres}, {nameof(Apellidos)}: {Apellidos}, " +
            $"{nameof(Alias)}: {Alias}, {nameof(Dui)}: {Dui}, {nameof(Correo)}: {Correo}, " +
            $"{nameof(Telefono)}: {Telefono}, {nameof(Direccion)}: {Direccion}, {nameof(Empresa)}: {Empresa}";
    }
}