﻿using OptiFinance_System.global;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.Views;

public partial class SeleccionEmpresa : Form
{
    private EmpresaQuery _empresaQuery;

    public SeleccionEmpresa()
    {
        InitializeComponent();
        _empresaQuery = EmpresaQuery.Instance;
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SeleccionEmpresa_Load(object sender, EventArgs e)
    {
        List<Empresa> empresas = _empresaQuery.SelectAll();
        empresas.ForEach(entity =>
        {
            dataEmpresas.Rows.Add(
                entity,
                entity.Nit,
                entity.GiroEconomico?.Nombre,
                entity.RepresentanteLegal,
                entity.Direccion,
                entity.Telefono,
                entity.Email
            );
            Console.WriteLine(entity);
        });
    }

    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
        if (dataEmpresas.SelectedRows.Count == 0)
        {
            Message.MessageViewError("Seleccione una empresa");
            return;
        }
        Empresa? empresa = dataEmpresas.SelectedRows[0].Cells[0].Value as Empresa;
        Global.SelectedEmpresa = empresa;
        // Inicio.lblNombreEmpresa.Text = $@"Bienvenidos a {empresa?.Nombre ?? ""}";
        Close();
    }
}