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
    public balanceGeneral()
    {
        InitializeComponent();
        // mostrarCuentas();
    }

    public void mostrarCuentas()
    {
        // --> todas las cuentas
        List<BalanceGeneral> listaCuentas = BalanceGeneralQuery.Instance.SelectAll();
        
        // -> cuentas de activos
        List<BalanceGeneral> listaCuentaActivo = BalanceGeneralQuery.Instance.SelectAllByTypeActivo();
        List<BalanceGeneral> listaCuentaActivoCorriente = BalanceGeneralQuery.Instance.SelectAllBytYpeActivoCorriente();
        List<BalanceGeneral> listaCuentaActivoNoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypeActivoNoCorriente();
        
        // --> cuentas de pasivos + capital
        List<BalanceGeneral> listaCuentaPasivo = BalanceGeneralQuery.Instance.SelectAllByTypePasivo();
        List<BalanceGeneral> listaCuentaPasivoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoCorriente();
        List<BalanceGeneral> listaCuentaPasivoNoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoNoCorriente();
        List<BalanceGeneral> listaCuentaCapital = BalanceGeneralQuery.Instance.SelectAllByTypeCapital();
        
        // --> cuentas resultado deudora (4)
        List<BalanceGeneral> listaCuentaResultadoDeudora = BalanceGeneralQuery.Instance.SelectAllByTypeResultadoDeudor();
        
        // --> cuentas resultado acreedor (5)
        List<BalanceGeneral> listaCuentaResultadoAcreedor = BalanceGeneralQuery.Instance.SelectAllByTypeResultadoAcreedor();
        
        // --> cuentas puentes de cierre (6)
        List<BalanceGeneral> listaCuentaPuenteCierre = BalanceGeneralQuery.Instance.SelectAllByTypePuenteCierre();
        
        // --> cuentas 
        // BalanceGeneral? objeto = BalanceGeneralQuery.Instance.SumByTypeActivo();

        // Console.WriteLine("Resultado del debe: " + objeto.Debe);
        // Console.WriteLine("Resultado del haber: " + objeto.Haber);

        // listaCuentas.ForEach(general =>
        // {
        //     Console.WriteLine(general.NombreCuenta);
        //     Console.WriteLine(general.Haber);
        //     Console.WriteLine(general.Debe);
        // });
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
        List<BalanceGeneral> listaCuentas = BalanceGeneralQuery.Instance.SelectAll();
        
        // -> cuentas de activos
        List<BalanceGeneral> listaCuentaActivo = BalanceGeneralQuery.Instance.SelectAllByTypeActivo();
        List<BalanceGeneral> listaCuentaActivoCorriente = BalanceGeneralQuery.Instance.SelectAllBytYpeActivoCorriente();
        List<BalanceGeneral> listaCuentaActivoNoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypeActivoNoCorriente();
        
        // --> cuentas de pasivos + capital
        List<BalanceGeneral> listaCuentaPasivo = BalanceGeneralQuery.Instance.SelectAllByTypePasivo();
        List<BalanceGeneral> listaCuentaPasivoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoCorriente();
        List<BalanceGeneral> listaCuentaPasivoNoCorriente = BalanceGeneralQuery.Instance.SelectAllByTypePasivoNoCorriente();
        List<BalanceGeneral> listaCuentaCapital = BalanceGeneralQuery.Instance.SelectAllByTypeCapital();
        
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
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "Activo Corriente", listaCuentaActivoCorriente, "Pasivo Corriente", listaCuentaPasivoCorriente);
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "", listaCuentaResultadoDeudora, "", listaCuentaResultadoAcreedor); // Resultado Deudor y Acreedor
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "Total Activo Corriente", new List<BalanceGeneral>(), "Total Pasivo Corriente", new List<BalanceGeneral>()); // Resultado Deudor y Acreedor
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "Activo No Corriente", listaCuentaActivoNoCorriente, "Pasivo No Corriente", listaCuentaPasivoNoCorriente);
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "Total Activo No Corriente", new List<BalanceGeneral>(), "Total Pasivo No Corriente", new List<BalanceGeneral>());
        // rowIndex = AddCuentaRows(dataBalance, rowIndex, "", listaCuentaCapital, "Capital", listaCuentaPuenteCierre);
        // Llamada para agregar solo en el lado de pasivos
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "", new List<BalanceGeneral>(), "Capital", listaCuentaCapital);
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "", new List<BalanceGeneral>(), "", listaCuentaPuenteCierre);
        rowIndex = agregarCuentasFilas(dataBalance, rowIndex, "", new List<BalanceGeneral>(), "Total de Capital", new List<BalanceGeneral>());
    }

    private int agregarCuentasFilas(DataGridView dgv, int startIndex, string tituloActivos, List<BalanceGeneral> cuentasActivos, string tituloPasivos, List<BalanceGeneral> cuentasPasivos)
    {
        lblFechaBalance.Text = DateTime.Now.ToString("dd/MM/yyyy");
        lblFechaBalance.AutoSize = false;
        lblFechaBalance.TextAlign = ContentAlignment.MiddleCenter;
        
        // Agregar el título de la subcategoría de Activos y Pasivos en la misma fila
        dgv.Rows.Insert(startIndex, "   " + tituloActivos, "", "   " + tituloPasivos, "");
        startIndex++;
    
        // Insertar las cuentas de Activos
        foreach (var cuenta in cuentasActivos)
        {
            // crear una nueva fila (row) con celdas vacías basadas en el número de columnas
            var row = new DataGridViewRow();
            row.CreateCells(dgv);
    
            row.Cells[0].Value = "      " + cuenta.NombreCuenta; // Detalle Activo
            row.Cells[1].Value = cuenta.Debe; // Monto Activo
    
            // Insertar la fila en el DataGridView
            dgv.Rows.Insert(startIndex, row);
            startIndex++;
        }
    
        // Insertar las cuentas de Pasivos, comenzando en la siguiente fila disponible
        // int pasivoIndex = startIndex - cuentasActivos.Count - 1; // Ajustar el índice para comenzar junto al título de pasivos
        
        int pasivoIndex = 2; // Ajustar el índice para comenzar junto al título de pasivos
        foreach (var cuenta in cuentasPasivos)
        {
            // Si no hay suficientes filas, crea una nueva
            // if (dgv.Rows.Count <= pasivoIndex)
            // {
            //     dgv.Rows.Add(new DataGridViewRow());
            // }
    
            // Agregar los detalles del pasivo en la columna correspondiente
            dgv.Rows[pasivoIndex].Cells[2].Value = "      " + cuenta.NombreCuenta; // Detalle Pasivo
            dgv.Rows[pasivoIndex].Cells[3].Value = cuenta.Haber; // Monto Pasivo
            pasivoIndex++;
        }
    
        return startIndex; // Devolver el índice de fila actual
    }
}