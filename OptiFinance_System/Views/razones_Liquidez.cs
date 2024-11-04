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

public partial class razones_Liquidez : Form
{
    public razones_Liquidez()
    {
        InitializeComponent();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnRealizarOperacion_Click(object sender, EventArgs e)
    {
        BalanceGeneral totalActivoCirculante = BalanceGeneralQuery.Instance.SumByTypeActivoCorriente(true);
        BalanceGeneral totalPasivoCirculante = BalanceGeneralQuery.Instance.SumByTypePasivoCorriente(true);
        List<BalanceGeneral> cuentasActivoCorriente = BalanceGeneralQuery.Instance.SelectAllBytYpeActivoCorriente();
        BalanceGeneral inventario = cuentasActivoCorriente.FirstOrDefault(activo => activo.NombreCuenta == "Inventario");
        
        // --> razon de circulante
        lblActivoCirculante.Text = totalActivoCirculante.Debe.ToString();
        lblPasivoCirculante.Text = totalPasivoCirculante.Haber.ToString();
        
        // --> prueba de acido
        lblActCirculante.Text = totalActivoCirculante.Debe.ToString();
        lblPasiCiculante.Text = totalPasivoCirculante.Haber.ToString();
        lblInventario.Text = inventario.Debe.ToString();
        
        // --> capital de trabajo
        lblActivCir.Text = totalActivoCirculante.Debe.ToString();
        lblPasCirculante.Text = totalPasivoCirculante.Haber.ToString();
        
        try
        {
            // --> totales
            lblTotalRcirculante.Text = (totalActivoCirculante.Debe / totalPasivoCirculante.Haber).ToString();
            label16.Text = ((totalActivoCirculante.Debe - inventario.Debe) / totalPasivoCirculante.Haber).ToString();
            lblTptalCapTrabajo.Text = (totalActivoCirculante.Debe - totalPasivoCirculante.Haber).ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: No se puede realizar las operaciones debido a una división por cero.");
            lblActivoCirculante.Text = "";
            lblPasivoCirculante.Text = "";
            lblActCirculante.Text = "";
            lblPasiCiculante.Text = "";
            lblInventario.Text = "";
            lblActivCir.Text = "";
            lblPasCirculante.Text = "";
            lblTotalRcirculante.Text = "";
            label16.Text = "";
            lblTptalCapTrabajo.Text = "";
        }
    }
}