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
        List<Cuenta> cuentasActivo = CuentaQuery.Instance.SelectAllByTypeActivo();

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridActivos.DataSource = cuentasActivo
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridActivos.Columns["Codigo"].Width = 382;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridActivos.Columns["Nombre"].Width = 690;  // Ancho de 594 píxeles para la columna 'Nombre'

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        List<Cuenta> cuentasPasivo = CuentaQuery.Instance.SelectAllByTypePasivo();
        dataGridPasivos.DataSource = cuentasPasivo
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridPasivos.Columns["Codigo"].Width = 382;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridPasivos.Columns["Nombre"].Width = 690;  // Ancho de 594 píxeles para la columna 'Nombre'

        List<Cuenta> cuentasCapital = CuentaQuery.Instance.SelectAllByTypeCapital();

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridCapital.DataSource = cuentasCapital
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridCapital.Columns["Codigo"].Width = 382;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridCapital.Columns["Nombre"].Width = 690;  // Ancho de 594 píxeles para la columna 'Nombre'

        List<Cuenta> cuentasDeudora = CuentaQuery.Instance.SelectAllByTypeDeudora();

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridDeudora.DataSource = cuentasDeudora
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridDeudora.Columns["Codigo"].Width = 382;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridDeudora.Columns["Nombre"].Width = 690;  // Ancho de 594 píxeles para la columna 'Nombre'

        List<Cuenta> cuentaAcreedora = CuentaQuery.Instance.SelectAllByTypeAcreedora();

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridAcreedora.DataSource = cuentaAcreedora
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridAcreedora.Columns["Codigo"].Width = 382;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridAcreedora.Columns["Nombre"].Width = 690;  // Ancho de 594 píxeles para la columna 'Nombre'

        List<Cuenta> cuentaCierre = CuentaQuery.Instance.SelectAllByTypePuenteCierre();

        // Asignas las cuentas al DataGridView, mostrando solo Codigo y Nombre
        dataGridCierre.DataSource = cuentaCierre
            .Select(c => new { Codigo = c.Codigo, Nombre = c.Nombre })
            .ToList();
        dataGridCierre.Columns["Codigo"].Width = 382;  // Ancho de 282 píxeles para la columna 'Codigo'
        dataGridCierre.Columns["Nombre"].Width = 690;  // Ancho de 594 píxeles para la columna 'Nombre'
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }
}