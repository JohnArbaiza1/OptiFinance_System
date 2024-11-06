using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
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
}