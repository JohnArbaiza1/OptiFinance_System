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
        rowIndex = AddCuentaRows(dataBalance, rowIndex, "Activo Corriente", listaCuentaActivoCorriente, "Pasivo Corriente", listaCuentaPasivoCorriente);
        rowIndex = AddCuentaRows(dataBalance, rowIndex, "", listaCuentaResultadoDeudora, "", listaCuentaResultadoAcreedor); // Resultado Deudor y Acreedor
        rowIndex = AddCuentaRows(dataBalance, rowIndex, "Activo No Corriente", listaCuentaActivoNoCorriente, "Pasivo No Corriente", listaCuentaPasivoNoCorriente);
        rowIndex = AddCuentaRows(dataBalance, rowIndex, "", listaCuentaCapital, "Capital", listaCuentaPuenteCierre);
    }
    
    private int AddCuentaRows(DataGridView dgv, int startIndex, string tituloActivos, List<BalanceGeneral> cuentasActivos, string tituloPasivos, List<BalanceGeneral> cuentasPasivos)
    {
        // Agregar el título de la subcategoría de Activos y Pasivos en la misma fila
        dgv.Rows.Insert(startIndex, "   " + tituloActivos, "", "   " + tituloPasivos, "");
        startIndex++;

        // Obtener el número máximo de cuentas entre activos y pasivos
        int maxLength = Math.Max(cuentasActivos.Count, cuentasPasivos.Count);

        // Iterar sobre el rango máximo de cuentas
        for (int i = 0; i < maxLength; i++)
        {
            // Crear una nueva fila
            var row = new DataGridViewRow();
            row.CreateCells(dgv); // Crear celdas vacías

            // Colocar la cuenta de Activo si existe
            if (i < cuentasActivos.Count)
            {
                row.Cells[0].Value = "      " + cuentasActivos[i].NombreCuenta; // Detalle Activo
                row.Cells[1].Value = cuentasActivos[i].Debe; // Monto Activo
            }
            // Dejar celdas vacías si no hay más cuentas de activos
            else
            {
                row.Cells[0].Value = ""; // Detalle Activo
                row.Cells[1].Value = ""; // Monto Activo
            }

            // Colocar la cuenta de Pasivo si existe
            if (i < cuentasPasivos.Count)
            {
                row.Cells[2].Value = "      " + cuentasPasivos[i].NombreCuenta; // Detalle Pasivo
                row.Cells[3].Value = cuentasPasivos[i].Haber; // Monto Pasivo
            }
            // Dejar celdas vacías si no hay más cuentas de pasivos
            else
            {
                row.Cells[2].Value = ""; // Detalle Pasivo
                row.Cells[3].Value = ""; // Monto Pasivo
            }

            // Insertar la fila en el DataGridView
            dgv.Rows.Insert(startIndex, row);
            
            startIndex++; // Incrementar el índice para la siguiente fila
        }

        return startIndex; // Devolver el índice de fila actual
    }
}