using System.Data;
using System.Runtime.InteropServices;
using global::OptiFinance_System.global;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.Views;

public partial class busquedaGiro : Form
{
    public static TextBox txtGiroAux;
    private List<GiroEconomico>? giroEconomicos;

    public busquedaGiro()
    {
        InitializeComponent();
    }

    //Nos permite mover la ventana del formulario a traves de la barra de titulo
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void barraTiulo_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void busquedaGiro_Shown(object sender, EventArgs e)
    {
        btnGuardarGiro.Focus();
        CargarGirosEconomicos();
    }

    private void CargarGirosEconomicos()
    {
        if (Global.ListGirosEconomicos == null)
        {
            Console.WriteLine(@"Cargando giros economicos desde la base de datos");
            Global.ListGirosEconomicos = GiroEconomicoQuery.Instance.SelectAll();
        }
        else
        {
            Console.WriteLine(@"Cargando giros economicos desde la lista");
        }
        
        if (Global.ListGirosEconomicos.Count == 0) return;

        DataTable dataTable = new();
        dataTable.Columns.Add("Giros Disponibles", typeof(GiroEconomico));

        Global.ListGirosEconomicos.ForEach(entity => { dataTable.Rows.Add(entity); });
        dataGiros.DataSource = dataTable;
    }

    private void Search(string? search)
    {
        DataTable dataTable = (DataTable)dataGiros.DataSource;
        if (dataTable == null) return;
        if (string.IsNullOrEmpty(search))
        {
            dataTable.DefaultView.RowFilter = string.Empty;
            return;
        }

        dataTable.DefaultView.RowFilter = $"[Giros Disponibles] LIKE '%{search}%'";
    }

    private void txtBusquedaGiro_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void txtBusquedaGiro_KeyUp(object sender, KeyEventArgs e)
    {
        int totalTextCount = txtBusquedaGiro.Text.Length;
        string search = totalTextCount == 0 ? "" : txtBusquedaGiro.Text.Trim();
        Search(search);
    }

    private void btnGuardarGiro_Click(object sender, EventArgs e)
    {
        if (dataGiros.SelectedRows.Count == 0) return;
        InfoEmpresacs.txtGiroAux.Tag = dataGiros.SelectedRows[0].Cells[0].Value;
        GiroEconomico giroEconomico = (GiroEconomico)dataGiros.SelectedRows[0].Cells[0].Value;
        InfoEmpresacs.txtGiroAux.Tag = giroEconomico;
        InfoEmpresacs.txtGiroAux.Text = dataGiros.SelectedRows[0].Cells[0].Value.ToString();
        Close();
    }
}