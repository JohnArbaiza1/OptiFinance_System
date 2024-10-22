using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using Formats = OptiFinance_System.utils.Formats;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.Views;

public partial class InfoEmpresacs : Form
{
    public static TextBox txtGiroAux;

    public InfoEmpresacs()
    {
        InitializeComponent();
        txtGiroAux = textBox4;
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        Empresa empresa = new();

        empresa.Nombre = txtNombreEmpresa.Text;
        empresa.GiroEconomico = textBox4.Tag as GiroEconomico;
        empresa.Nit = txtNit.Text;
        empresa.RepresentanteLegal = txtRepresentante.Text;
        empresa.Telefono = textBox1.Text;
        empresa.Email = textBox2.Text;
        empresa.Direccion = textBox3.Text;
        empresa.Distrito = comboDistrito.SelectedItem as Distrito;
        empresa.Usuario = Form1.currentUser;

        if (!EmpresaQuery.Instance.Insert(empresa)) return;
        Message.MessageViewSuccess(@"Empresa registrada correctamente");
        Close();
    }

    private void InfoEmpresacs_Load(object sender, EventArgs e)
    {
        // await Task.Run(cargarDistritos);
    }

    private void cargarDistritos()
    {
        List<Distrito> distritos = DistritoQuery.Instance.SelectAll();
        if (distritos.Count == 0) return;

        Invoke(() => { comboDistrito.DataSource = distritos; });
    }

    private void btnBuscarGiro_Click(object sender, EventArgs e)
    {
        busquedaGiro busqueda = new();
        busqueda.Show();
    }

    private async void InfoEmpresacs_Shown(object sender, EventArgs e)
    {
        await Task.Run(cargarDistritos);
    }

    private void txtNit_TextChanged(object sender, EventArgs e)
    {
        Formats.FormatNit(sender, e);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        Formats.FormatTelefono(sender, e);
    }

    private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
    {
        Formats.OnlyNumbers(sender, e);
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        Formats.OnlyNumbers(sender, e);
    }
}