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
    private BalanceGeneral? _totalActivoCorriente;
    private BalanceGeneral? _totalPasivoCorriente;
    private BalanceGeneral? _totalActivosNoCorrientes;
    private BalanceGeneral? _totalPasivosNoCorrientes;
    private BalanceGeneral? _totalCapital;
    
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
        
        // -> cuentas de activosx
        List<BalanceGeneral> lista_cuenta_activo = BalanceGeneralQuery.Instance.SelectAllByTypeActivo();
        List<BalanceGeneral> listaCuentaActivoCorriente = BalanceGeneralQuery.Instance.SelectAllBytYpeActivoCorriente();
        List<BalanceGeneral> listaCuentaActivoNoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypeActivoNoCorriente();
        
        // --> cuentas de pasivos + capital
        List<BalanceGeneral> lista_cuenta_pasivo = BalanceGeneralQuery.Instance.SelectAllByTypePasivo();
        List<BalanceGeneral> listaCuentaPasivoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoCorriente();
        List<BalanceGeneral> listaCuentaPasivoNoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoNoCorriente();
        List<BalanceGeneral> listaCuentaCapital = BalanceGeneralQuery.Instance.SelectAllByTypeCapital();
        
        // Calcular totales
        calcular_totales();
        
        // --> cuentas resultado deudora (4)
        List<BalanceGeneral> listaCuentaResultadoDeudora = BalanceGeneralQuery.Instance.SelectAllByTypeResultadoDeudor();
        
        // --> cuentas resultado acreedor (5)
        List<BalanceGeneral> listaCuentaResultadoAcreedor = BalanceGeneralQuery.Instance.SelectAllByTypeResultadoAcreedor();
        
        // --> cuentas puentes de cierre (6)
        List<BalanceGeneral> listaCuentaPuenteCierre = BalanceGeneralQuery.Instance.SelectAllByTypePuenteCierre();
        
        // Añadir encabezados principales para activos y pasivos en la misma fila
        dataBalance.Rows.Add("Activos", "", "Pasivos", "");

        // Crear índice para la siguiente fila donde se van a insertar subcategorías de Activos y Pasivos
        int rowIndex = 1;

        // Insertar secciones de Activos y Pasivos en paralelo
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "Activo Corriente", listaCuentaActivoCorriente, "Pasivo Corriente", listaCuentaPasivoCorriente);
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "", listaCuentaResultadoDeudora, "", listaCuentaResultadoAcreedor); // Resultado Deudor y Acreedor
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "Total Activo Corriente", _totalActivoCorriente, "Total Pasivo Corriente", _totalPasivoCorriente); // Resultado Deudor y Acreedor
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "Activo No Corriente", listaCuentaActivoNoCorriente, "Pasivo No Corriente", listaCuentaPasivoNoCorriente);
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "Total Activo No Corriente", _totalActivosNoCorrientes, "Total Pasivo No Corriente", _totalPasivosNoCorrientes);
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "", new List<BalanceGeneral>(), "Capital", listaCuentaCapital);
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "", new List<BalanceGeneral>(), "", listaCuentaPuenteCierre);
        rowIndex = agregar_cuentas_filas(dataBalance, rowIndex, "", new List<BalanceGeneral>(), "Total de Capital", _totalCapital);

        txtTotalActivo.Text = (_totalActivoCorriente.Debe + _totalActivosNoCorrientes.Debe).ToString();
        txtTotalPasyPatri.Text = (_totalPasivoCorriente.Haber + _totalPasivosNoCorrientes.Haber + _totalCapital.Haber).ToString();
    }
    
    private void calcular_totales()
    {
        // Calcular y almacenar los totales
        // total_activo_corriente = BalanceGeneralQuery.Instance.SumByTypeActivoCorrienteAndResultadoDeudor();
        _totalActivoCorriente = BalanceGeneralQuery.Instance.SumByTypeActivoCorriente(true);
        // total_pasivo_corriente = BalanceGeneralQuery.Instance.SumByTypePasivoCorrienteAndResultadoAcreedor();
        _totalPasivoCorriente = BalanceGeneralQuery.Instance.SumByTypePasivoCorriente(true);
        _totalActivosNoCorrientes = BalanceGeneralQuery.Instance.SumByTypeActivoNoCorriente();
        _totalPasivosNoCorrientes = BalanceGeneralQuery.Instance.SumByTypePasivoNoCorriente();
        // total_capital = BalanceGeneralQuery.Instance.SumByTypeCapitalAndPuenteCierre();
        _totalCapital = BalanceGeneralQuery.Instance.SumByTypeCapital(true);
    }

    private int agregar_cuentas_filas(DataGridView dgv, int startIndex, string tituloActivos, object cuentasActivos,
        string tituloPasivos, object cuentasPasivos)
    {
        lblFechaBalance.Text = DateTime.Now.ToString("dd/MM/yyyy");
        lblFechaBalance.AutoSize = false;
        lblFechaBalance.TextAlign = ContentAlignment.MiddleCenter;

        // Agregar el título de la subcategoría de Activos y Pasivos en la misma fila
        dgv.Rows.Insert(startIndex, "   " + tituloActivos, "", "   " + tituloPasivos, "");
        startIndex++;

        // Verificar si cuentasActivos es una lista o un valor único
        if (cuentasActivos is List<BalanceGeneral> activos_list)
        {
            // Insertar cada cuenta en la lista de activos
            foreach (BalanceGeneral cuenta in activos_list)
            {
                DataGridViewRow row = new();
                row.CreateCells(dgv);
                row.Cells[0].Value = "      " + cuenta.NombreCuenta;
                row.Cells[1].Value = cuenta.Debe;
                dgv.Rows.Insert(startIndex, row);
                startIndex++;
            }
        }
        else if (cuentasActivos is BalanceGeneral total_activo)
        {
            // Insertar directamente en las filas específicas para Activo Corriente y Activo No Corriente
            DataGridViewRow row_activo_corriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[0].Value?.ToString().Trim() == "Total Activo Corriente");

            if (row_activo_corriente != null) row_activo_corriente.Cells[1].Value = _totalActivoCorriente.Debe;

            DataGridViewRow row_activo_no_corriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[0].Value?.ToString().Trim() == "Total Activo No Corriente");

            if (row_activo_no_corriente != null)
                row_activo_no_corriente.Cells[1].Value = _totalActivosNoCorrientes.Debe;
        }

        // Repite lo mismo para los Pasivos
        if (cuentasPasivos is List<BalanceGeneral> pasivos_list)
        {
            int pasivoIndex = 2;
            foreach (BalanceGeneral cuenta in pasivos_list)
            {
                // if (dgv.Rows.Count <= pasivoIndex)
                // {
                //     dgv.Rows.Add(new DataGridViewRow());
                // }

                dgv.Rows[pasivoIndex].Cells[2].Value = "      " + cuenta.NombreCuenta;
                dgv.Rows[pasivoIndex].Cells[3].Value = cuenta.Haber;
                pasivoIndex++;
            }
        }
        else if (cuentasPasivos is BalanceGeneral total_pasivo)
        {
            DataGridViewRow rowPasivoCorriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[2].Value?.ToString().Trim() == "Total Pasivo Corriente");

            if (rowPasivoCorriente != null) rowPasivoCorriente.Cells[3].Value = _totalPasivoCorriente.Haber;

            DataGridViewRow rowPasivoNoCorriente = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[2].Value?.ToString().Trim() == "Total Pasivo No Corriente");

            if (rowPasivoNoCorriente != null)
                rowPasivoNoCorriente.Cells[3].Value = _totalPasivosNoCorrientes.Haber;

            DataGridViewRow rowTotalCapital = dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[2].Value?.ToString().Trim() == "Total de Capital");

            if (rowTotalCapital != null) rowTotalCapital.Cells[3].Value = _totalCapital.Haber;
        }

        return startIndex;
    }
}