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

public partial class balanceGeneral : Form
{
    // Declaración de variables globales
    private BalanceGeneral total_activo_corriente;
    private BalanceGeneral total_pasivo_corriente;
    private BalanceGeneral total_activos_no_corrientes;
    private BalanceGeneral total_pasivos_no_corrientes;
    private BalanceGeneral total_capital;
    
    public balanceGeneral()
    {
        InitializeComponent();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnGenerarBalance_Click(object sender, EventArgs e)
    {
        // Configuración inicial del DataGridView
        dataBalance.Columns.Clear();
        dataBalance.Rows.Clear();
        
        // Configurar columnas y anchos
        dataBalance.Columns.Add("DetalleActivos", "Detalle Activos");
        dataBalance.Columns["DetalleActivos"].Width = 400;
        dataBalance.Columns.Add("MontoActivos", "$");
        dataBalance.Columns["MontoActivos"].Width = 155;
        dataBalance.Columns.Add("DetallePasivos", "Detalle Pasivos");
        dataBalance.Columns["DetallePasivos"].Width = 400;
        dataBalance.Columns.Add("MontoPasivos", "$");
        dataBalance.Columns["MontoPasivos"].Width = 155;
        
        // --> todas las cuentas
        List<BalanceGeneral> lista_cuentas = BalanceGeneralQuery.Instance.SelectAll();
        
        // -> cuentas de activos
        List<BalanceGeneral> lista_cuenta_activo = BalanceGeneralQuery.Instance.SelectAllByTypeActivo();
        List<BalanceGeneral> lista_cuenta_activo_corriente = BalanceGeneralQuery.Instance.SelectAllBytYpeActivoCorriente();
        List<BalanceGeneral> lista_cuenta_activo_no_corriente = BalanceGeneralQuery.Instance.SelectAllByTypeActivoNoCorriente();
        
        // --> cuentas de pasivos + capital
        List<BalanceGeneral> lista_cuenta_pasivo = BalanceGeneralQuery.Instance.SelectAllByTypePasivo();
        List<BalanceGeneral> lista_cuenta_pasivo_corriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoCorriente();
        List<BalanceGeneral> lista_cuenta_pasivo_no_corriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoNoCorriente();
        List<BalanceGeneral> lista_cuenta_capital = BalanceGeneralQuery.Instance.SelectAllByTypeCapital();
        
        // Calcular totales
        calcular_totales();
        
        // --> cuentas resultado deudora (4)
        List<BalanceGeneral> lista_cuenta_resultado_deudora = BalanceGeneralQuery.Instance.SelectAllByTypeResultadoDeudor();
        
        // --> cuentas resultado acreedor (5)
        List<BalanceGeneral> lista_cuenta_resultado_acreedor = BalanceGeneralQuery.Instance.SelectAllByTypeResultadoAcreedor();
        
        // --> cuentas puentes de cierre (6)
        List<BalanceGeneral> lista_cuenta_puente_cierre = BalanceGeneralQuery.Instance.SelectAllByTypePuenteCierre();
        
        // Añadir encabezados principales para activos y pasivos en la misma fila
        dataBalance.Rows.Add("Activos", "", "Pasivos", "");

        // Crear índice para la siguiente fila donde se van a insertar subcategorías de Activos y Pasivos
        int row_index = 1;

        // Insertar secciones de Activos y Pasivos en paralelo
        row_index = agregar_cuentas_filas(dataBalance, row_index, "Activo Corriente", lista_cuenta_activo_corriente, "Pasivo Corriente", lista_cuenta_pasivo_corriente);
        row_index = agregar_cuentas_filas(dataBalance, row_index, "", lista_cuenta_resultado_deudora, "", lista_cuenta_resultado_acreedor); // Resultado Deudor y Acreedor
        row_index = agregar_cuentas_filas(dataBalance, row_index, "Total Activo Corriente", total_activo_corriente, "Total Pasivo Corriente", total_pasivo_corriente); // Resultado Deudor y Acreedor
        row_index = agregar_cuentas_filas(dataBalance, row_index, "Activo No Corriente", lista_cuenta_activo_no_corriente, "Pasivo No Corriente", lista_cuenta_pasivo_no_corriente);
        row_index = agregar_cuentas_filas(dataBalance, row_index, "Total Activo No Corriente", total_activos_no_corrientes, "Total Pasivo No Corriente", total_pasivos_no_corrientes);
        row_index = agregar_cuentas_filas(dataBalance, row_index, "", new List<BalanceGeneral>(), "Capital", lista_cuenta_capital);
        row_index = agregar_cuentas_filas(dataBalance, row_index, "", new List<BalanceGeneral>(), "", lista_cuenta_puente_cierre);
        row_index = agregar_cuentas_filas(dataBalance, row_index, "", new List<BalanceGeneral>(), "Total de Capital", total_capital);

        txtTotalActivo.Text = (total_activo_corriente.Debe + total_activos_no_corrientes.Debe).ToString();
        txtTotalPasyPatri.Text = (total_pasivo_corriente.Haber + total_pasivos_no_corrientes.Haber + total_capital.Haber).ToString();
    }
    
    private void calcular_totales()
    {
        // Calcular y almacenar los totales
        total_activo_corriente = BalanceGeneralQuery.Instance.SumByTypeActivoCorrienteAndResultadoDeudor();
        total_pasivo_corriente = BalanceGeneralQuery.Instance.SumByTypePasivoCorrienteAndResultadoAcreedor();
        total_activos_no_corrientes = BalanceGeneralQuery.Instance.SumByTypeActivoNoCorriente();
        total_pasivos_no_corrientes = BalanceGeneralQuery.Instance.SumByTypePasivoNoCorriente();
        total_capital = BalanceGeneralQuery.Instance.SumByTypeCapitalAndPuenteCierre();
    }

    private int agregar_cuentas_filas(DataGridView dgv, int start_index, string titulo_activos, object cuentas_activos, string titulo_pasivos, object cuentas_pasivos)
    {
        lblFechaBalance.Text = DateTime.Now.ToString("dd/MM/yyyy");
        lblFechaBalance.AutoSize = false;
        lblFechaBalance.TextAlign = ContentAlignment.MiddleCenter;

        // Agregar el título de la subcategoría de Activos y Pasivos en la misma fila
        dgv.Rows.Insert(start_index, "   " + titulo_activos, "", "   " + titulo_pasivos, "");
        start_index++;

        // Verificar si cuentasActivos es una lista o un valor único
        if (cuentas_activos is List<BalanceGeneral> activos_list)
        {
            // Insertar cada cuenta en la lista de activos
            foreach (var cuenta in activos_list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = "      " + cuenta.NombreCuenta;
                row.Cells[1].Value = cuenta.Debe;
                dgv.Rows.Insert(start_index, row);
                start_index++;
            }
        }
        else if (cuentas_activos is BalanceGeneral total_activo)
        {
            // Insertar directamente en las filas específicas para Activo Corriente y Activo No Corriente
            DataGridViewRow row_activo_corriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[0].Value?.ToString().Trim() == "Total Activo Corriente");

            if (row_activo_corriente != null)
            {
                row_activo_corriente.Cells[1].Value = total_activo_corriente.Debe;
            }

            DataGridViewRow row_activo_no_corriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[0].Value?.ToString().Trim() == "Total Activo No Corriente");

            if (row_activo_no_corriente != null)
            {
                row_activo_no_corriente.Cells[1].Value = total_activos_no_corrientes.Debe;
            }
        }

        // Repite lo mismo para los Pasivos
        if (cuentas_pasivos is List<BalanceGeneral> pasivos_list)
        {
            int pasivo_index = 2;
            foreach (var cuenta in pasivos_list)
            {
                // if (dgv.Rows.Count <= pasivoIndex)
                // {
                //     dgv.Rows.Add(new DataGridViewRow());
                // }

                dgv.Rows[pasivo_index].Cells[2].Value = "      " + cuenta.NombreCuenta;
                dgv.Rows[pasivo_index].Cells[3].Value = cuenta.Haber;
                pasivo_index++;
            }
        }
        else if (cuentas_pasivos is BalanceGeneral total_pasivo)
        {
            DataGridViewRow row_pasivo_corriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[2].Value?.ToString().Trim() == "Total Pasivo Corriente");

            if (row_pasivo_corriente != null)
            {
                row_pasivo_corriente.Cells[3].Value = total_pasivo_corriente.Haber;
            }

            DataGridViewRow row_pasivo_no_corriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[2].Value?.ToString().Trim() == "Total Pasivo No Corriente");

            if (row_pasivo_no_corriente != null)
            {
                row_pasivo_no_corriente.Cells[3].Value = total_pasivos_no_corrientes.Haber;
            }

            DataGridViewRow row_total_capital = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[2].Value?.ToString().Trim() == "Total de Capital");

            if (row_total_capital != null)
            {
                row_total_capital.Cells[3].Value = total_capital.Haber;
            }
        }
        
        return start_index;
    }
}