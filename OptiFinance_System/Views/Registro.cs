using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.utils;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.Views;

public partial class Registro : Form
{
    public Registro()
    {
        InitializeComponent();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void lblLogin_Click(object sender, EventArgs e)
    {
        Form1 form = new();
        form.Show();
        Hide();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        string username = txtUsuario.Text.Trim();
        string password = txtPass.Text.Trim();
        string confirmPassword = txtConfirmPass.Text.Trim();
        string nombres = txtNombre.Text.Trim();
        string apellidos = txtApellido.Text.Trim();
        string email = txtCorreo.Text.Trim();

        if (password != confirmPassword)
        {
            Message.MessageViewError(@"Las contraseñas no coinciden");
            return;
        }

        if (Validations.UserExist(UsuarioQuery.Instance.FindByUsername(username)))
        {
            Message.MessageViewError(@"El usuario ya existe");
            txtUsuario.Clear();
            return;
        }

        Usuario user = new()
        {
            Alias = username,
            Password = Utilities.HashPassword(password),
            Nombres = nombres,
            Apellidos = apellidos,
            Email = email,
            TipoUsuario = TipoUsuarioQuery.Instance.FindById(2)
        };

        bool result = UsuarioQuery.Instance.Insert(user);
        if (result)
            Message.MessageViewSuccess(@"Usuario registrado correctamente");
        else
            Message.MessageViewError(@"Error al registrar usuario");
    }
}