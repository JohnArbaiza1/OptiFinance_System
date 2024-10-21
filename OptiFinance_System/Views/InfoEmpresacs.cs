using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.Views;

public partial class InfoEmpresacs : Form
{
    public InfoEmpresacs()
    {
        InitializeComponent();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        Empresa empresa = new();

        empresa.Nombre = txtNombreEmpresa.Text;
        //empresa.GiroEconomico = txtGiro.Text;
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

        Invoke(() =>
        {
            comboDistrito.DataSource = distritos;
        });

    }

    private void btnBuscarGiro_Click(object sender, EventArgs e)
    {
        busquedaGiro busqueda = new();
        busqueda.Show();
    }

    private async void  InfoEmpresacs_Shown(object sender, EventArgs e)
    {
        await Task.Run(cargarDistritos);
    }
}