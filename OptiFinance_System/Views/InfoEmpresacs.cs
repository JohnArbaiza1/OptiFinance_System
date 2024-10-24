using global::OptiFinance_System.global;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.utils;
using Formats = OptiFinance_System.utils.Formats;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.Views;

public partial class InfoEmpresacs : Form
{
    public static TextBox txtGiroAux;
    private List<string> errores;

    public InfoEmpresacs()
    {
        InitializeComponent();
        txtGiroAux = textBox4;
        Console.WriteLine(Global.SelectedUser!.Id);
        errores = new()
        {
            "El campo nombre de la empresa es obligatorio",
            "El campo giro económico de la empresa es obligatorio",
            "El campo NIT de la empresa es obligatorio",
            "El campo representante legal de la empresa es obligatorio",
            "El campo teléfono de la empresa es obligatorio",
            "El campo email de la empresa es obligatorio",
            "El campo dirección de la empresa es obligatorio",
            "El campo distrito de la empresa es obligatorio"
        };
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        bool validateNombre = Validations.TextBoxNullOrEmpty(errorProvider, txtNombreEmpresa, errores[0]);
        bool validateGiro = Validations.TextBoxNullOrEmpty(errorProvider, textBox4, errores[1]);
        bool validateNit = Validations.TextBoxNullOrEmpty(errorProvider, txtNit, errores[2]);
        bool validateRepresentante = Validations.TextBoxNullOrEmpty(errorProvider, txtRepresentante, errores[3]);
        bool validateTelefono = Validations.TextBoxNullOrEmpty(errorProvider, textBox1, errores[4]);
        bool validateEmail = Validations.TextBoxNullOrEmpty(errorProvider, textBox2, errores[5]);
        bool validateDireccion = Validations.TextBoxNullOrEmpty(errorProvider, textBox3, errores[6]);
        bool validateDistrito = Validations.ComboBoxNullOrEmpty(errorProvider, comboDistrito, errores[7]);
        if (validateNombre || validateGiro || validateNit || validateRepresentante || validateTelefono ||
            validateEmail || validateDireccion || validateDistrito) return;
        Empresa empresa = new();

        Console.WriteLine();
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