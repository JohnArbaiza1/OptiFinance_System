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
        List<Cuenta> cuentas = CuentaQuery.Instance.SelectAll();

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridActivos.DataSource = cuentas
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridActivos.Columns["Codigo"].Width = 282;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridActivos.Columns["Nombre"].Width = 594;  // Ancho de 594 píxeles para la columna 'Nombre'

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridPasivos.DataSource = cuentas
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridPasivos.Columns["Codigo"].Width = 282;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridPasivos.Columns["Nombre"].Width = 594;  // Ancho de 594 píxeles para la columna 'Nombre'

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridCapital.DataSource = cuentas
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridCapital.Columns["Codigo"].Width = 282;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridCapital.Columns["Nombre"].Width = 594;  // Ancho de 594 píxeles para la columna 'Nombre'

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridDeudora.DataSource = cuentas
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridDeudora.Columns["Codigo"].Width = 282;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridDeudora.Columns["Nombre"].Width = 594;  // Ancho de 594 píxeles para la columna 'Nombre'

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridAcreedora.DataSource = cuentas
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridAcreedora.Columns["Codigo"].Width = 282;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridAcreedora.Columns["Nombre"].Width = 594;  // Ancho de 594 píxeles para la columna 'Nombre'

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridCierre.DataSource = cuentas
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridCierre.Columns["Codigo"].Width = 282;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridCierre.Columns["Nombre"].Width = 594;  // Ancho de 594 píxeles para la columna 'Nombre'
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }
}