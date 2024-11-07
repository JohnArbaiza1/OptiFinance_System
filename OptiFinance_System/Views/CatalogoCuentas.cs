using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.global;
using System.Windows.Forms;

namespace OptiFinance_System.Views;

public partial class CatalogoCuentas : Form
{
    public CatalogoCuentas()
    {
        InitializeComponent();
        this.Load += CatalogoCuentas_Load;
    }

    private void CatalogoCuentas_Load(object sender, EventArgs e)
    {
        // Cargar cuentas y asignarlas a los DataGridViews
        CargarCuentasEnDataGridView(CuentaQuery.Instance.SelectAllByTypeActivo(), dataGridActivos);
        CargarCuentasEnDataGridView(CuentaQuery.Instance.SelectAllByTypePasivo(), dataGridPasivos);
        CargarCuentasEnDataGridView(CuentaQuery.Instance.SelectAllByTypeCapital(), dataGridCapital);
        CargarCuentasEnDataGridView(CuentaQuery.Instance.SelectAllByTypeDeudora(), dataGridDeudora);
        CargarCuentasEnDataGridView(CuentaQuery.Instance.SelectAllByTypeAcreedora(), dataGridAcreedora);
        CargarCuentasEnDataGridView(CuentaQuery.Instance.SelectAllByTypePuenteCierre(), dataGridCierre);
    }
    private void CargarCuentasEnDataGridView(List<Cuenta> cuentas, DataGridView dataGrid)
    {
        // Asignar datos y configurar anchos de columna
        dataGrid.DataSource = cuentas
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGrid.Columns["Codigo"].Width = 382;
        dataGrid.Columns["Nombre"].Width = 690;

        // Suscribirse al evento CellFormatting
        dataGrid.CellFormatting += DataGrid_CellFormatting;
    }

    private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridView dataGrid = sender as DataGridView;

        // Verificar que estamos en las columnas correctas
        if (dataGrid.Columns[e.ColumnIndex].Name == "Codigo" || dataGrid.Columns[e.ColumnIndex].Name == "Nombre")
        {
            var codigo = dataGrid.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString();

            if (!string.IsNullOrEmpty(codigo))
            {
                // Aplicar formato según la longitud del código
                if (codigo.Length <= 4)
                {
                    // Negrita fuerte
                    e.CellStyle.Font = new Font(dataGrid.Font, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.DarkKhaki; // Cambiar el color del texto
                }
                else if (codigo.Length == 6)
                {
                    // Negrita ligera con 4 espacios al inicio
                    e.CellStyle.Font = new Font(dataGrid.Font.FontFamily, dataGrid.Font.Size, FontStyle.Bold);
                    e.Value = "    " + e.Value;
                }
                else // Más de 6 dígitos
                {
                    // Texto normal con 8 espacios al inicio
                    e.CellStyle.Font = new Font(dataGrid.Font, FontStyle.Regular);
                    e.Value = "        " + e.Value;
                }
            }
        }
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Verificar si hay una empresa seleccionada
        string empresaNombre = Global.SelectedEmpresa?.Nombre ?? "Empresa No Seleccionada";

        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            // Establecer el nombre del archivo por defecto con el nombre de la empresa
            saveFileDialog.FileName = $"Catalogo {empresaNombre}.pdf";
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Guardar catálogo de cuentas como PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                GenerarPDF(filePath);
            }
        }
    }
    private void GenerarPDF(string filePath)
    {
        // Crear documento y escribir en él
        using (var document = new iTextSharp.text.Document())
        {
            iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Verificar si hay una empresa seleccionada
            string empresaNombre = Global.SelectedEmpresa?.Nombre ?? "Empresa No Seleccionada";

            // Crear un párrafo con el título en negrita y centrado
            var titulo = new iTextSharp.text.Paragraph($"Catálogo de Cuentas de {empresaNombre}")
            {
                Alignment = iTextSharp.text.Element.ALIGN_CENTER, // Centrado
                Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD) // Negrita
            };

            // Agregar el título al documento
            document.Add(titulo);

            // Espacio antes de las tablas
            document.Add(new iTextSharp.text.Paragraph(" "));

            // Generar tablas para cada DataGridView
            AgregarTablaAlPDF(dataGridActivos, "1   Activos", document);
            AgregarTablaAlPDF(dataGridPasivos, "2   Pasivos", document);
            AgregarTablaAlPDF(dataGridCapital, "3   Capital", document);
            AgregarTablaAlPDF(dataGridDeudora, "4   Cuentas Deudoras", document);
            AgregarTablaAlPDF(dataGridAcreedora, "5   Cuentas Acreedoras", document);
            AgregarTablaAlPDF(dataGridCierre, "6    Cuentas de Cierre", document);

            // Cerrar el documento
            document.Close();
        }
    }

    private void AgregarTablaAlPDF(DataGridView dataGrid, string titulo, iTextSharp.text.Document document)
    {
        // Agregar título de la sección
        document.Add(new iTextSharp.text.Paragraph(titulo));
        document.Add(new iTextSharp.text.Paragraph(" ")); // Espacio

        // Crear una tabla con el número de columnas del DataGridView
        var pdfTable = new iTextSharp.text.pdf.PdfPTable(dataGrid.Columns.Count);

        // Agregar encabezados de columna
        foreach (DataGridViewColumn column in dataGrid.Columns)
        {
            pdfTable.AddCell(new iTextSharp.text.Phrase(column.HeaderText));
        }

        // Agregar filas
        foreach (DataGridViewRow row in dataGrid.Rows)
        {
            if (!row.IsNewRow)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                }
            }
        }

        // Agregar la tabla al documento
        document.Add(pdfTable);
        document.Add(new iTextSharp.text.Paragraph(" ")); // Espacio entre tablas
    }
}