using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.global;

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
        button1.Enabled = true;
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

    private void button1_Click(object sender, EventArgs e)
    {
        // Pedir al usuario que seleccione una ubicación para guardar el archivo PDF
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Guardar balance general como PDF";
            saveFileDialog.FileName = $"Balance General {Global.SelectedEmpresa?.Nombre}.pdf"; // Nombre por defecto

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Generar el PDF con los datos del balance
                GenerarBalancePDF(saveFileDialog.FileName);
            }
        }
    }
    private void GenerarBalancePDF(string filePath)
    {
        try
        {
            // Crear un documento PDF
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Abrir el documento para agregar contenido
            document.Open();

            // Título del PDF
            string titulo = $"Balance General de {Global.SelectedEmpresa?.Nombre}";
            iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Paragraph parrafoTitulo = new Paragraph(titulo, tituloFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(parrafoTitulo);
            document.Add(new Chunk("\n"));

            // Fecha del balance
            Paragraph fecha = new Paragraph($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}")
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(fecha);
            document.Add(new Chunk("\n"));

            // Tabla para balance general (activos, pasivos)
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 4f, 2f, 4f, 2f }); // Anchos de columnas

            // Añadir encabezados
            table.AddCell("Detalle Activos");
            table.AddCell("Monto Activos");
            table.AddCell("Detalle Pasivos");
            table.AddCell("Monto Pasivos");

            // Rellenar los datos de la tabla
            foreach (DataGridViewRow row in dataBalance.Rows)
            {
                // Verificar si las celdas contienen valores antes de agregar a la tabla
                string detalleActivo = row.Cells[0].Value?.ToString() ?? ""; // Si es null, usar una cadena vacía
                string montoActivo = row.Cells[1].Value?.ToString() ?? "";   // Lo mismo para monto activo
                string detallePasivo = row.Cells[2].Value?.ToString() ?? "";  // Lo mismo para detalle pasivo
                string montoPasivo = row.Cells[3].Value?.ToString() ?? "";    // Lo mismo para monto pasivo

                // Agregar los valores a la tabla
                table.AddCell(detalleActivo);
                table.AddCell(montoActivo);
                table.AddCell(detallePasivo);
                table.AddCell(montoPasivo);
            }

            // Agregar la tabla al documento
            document.Add(table);
            document.Add(new Chunk("\n"));

            // Verificar si las propiedades tienen valor y asignarles un valor predeterminado si es nulo
            decimal totalActivoCorriente = _totalActivoCorriente?.Debe ?? 0;
            decimal totalActivosNoCorrientes = _totalActivosNoCorrientes?.Debe ?? 0;
            decimal totalPasivoCorriente = _totalPasivoCorriente?.Haber ?? 0;
            decimal totalPasivosNoCorrientes = _totalPasivosNoCorrientes?.Haber ?? 0;
            decimal totalCapital = _totalCapital?.Haber ?? 0;

            // Calcular los totales
            string totalActivo = (totalActivoCorriente + totalActivosNoCorrientes).ToString("N2");
            string totalPasivo = (totalPasivoCorriente + totalPasivosNoCorrientes + totalCapital).ToString("N2");

            // Crear una fila para los totales
            PdfPTable totalTable = new PdfPTable(4);
            totalTable.WidthPercentage = 100;
            totalTable.SetWidths(new float[] { 4f, 2f, 4f, 2f });

            // Añadir los totales
            totalTable.AddCell("Total Activo");
            totalTable.AddCell(totalActivo);
            totalTable.AddCell("Total Pasivo y Capital");
            totalTable.AddCell(totalPasivo);

            // Agregar la tabla de totales al documento
            document.Add(totalTable);
            // Cerrar el documento
            document.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocurrió un error al generar el PDF: {ex.Message}");
        }
    }
}