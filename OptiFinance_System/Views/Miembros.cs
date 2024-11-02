using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.Views;

public partial class Miembros : Form
{
    public Miembros()
    {
        InitializeComponent();
        CargarMiembrosEmpresa();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }
    
    private void CargarMiembrosEmpresa()
    {
        List<MiembroEmpresa> miembroEmpresas = MiembroEmpresaQuery.Instance.SelectAll();

        if (miembroEmpresas.Count == 0)
        {
            Console.WriteLine(@"No hay miembros empresa");
        }
        else
        {
            miembroEmpresas.ForEach(Console.WriteLine);
        }
    }
}