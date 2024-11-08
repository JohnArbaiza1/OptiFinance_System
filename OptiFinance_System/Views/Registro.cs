using Microsoft.IdentityModel.Tokens;
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
        errorProvider1.SetIconAlignment(txtUsuario, ErrorIconAlignment.MiddleLeft);
        errorProvider1.SetIconAlignment(txtCorreo, ErrorIconAlignment.MiddleLeft);
        
        if (username.IsNullOrEmpty() || password.IsNullOrEmpty() || nombres.IsNullOrEmpty() || apellidos.IsNullOrEmpty() || email.IsNullOrEmpty())
        {
            Message.MessageViewError(@"Debe llenar todos los campos");
            return;
        }

        if (Validations.UserExist(UsuarioQuery.Instance.FindByUsername(username)))
        {
            errorProvider1.SetError(txtUsuario, @"El usuario ya existe");
            txtUsuario.Clear();
            return;
        }
        if (Validations.ExistEmail(email))
        {
            errorProvider1.SetError(txtCorreo, @"El correo ya existe");
            return;
        }
        errorProvider1.Clear();

        Usuario user = new()
        {
            Alias = username,
            Password = Utilities.HashPassword(password),
            Nombres = nombres,
            Apellidos = apellidos,
            Email = email,
            TipoUsuario = TipoUsuarioQuery.Instance.FindById(2)
        };

        MiembroEmpresa miembroEmpresa = new()
        {
            Alias = username,
            Apellidos = apellidos,
            Nombres = nombres,
            Direccion = "Prueba",
            Password = Utilities.HashPassword(password),
            Empresa = new()
            {
                Id = 12
            },
            Telefono = "70108769",
            Correo = email,
            Dui = "07347846-1"
        };

        bool result = UsuarioQuery.Instance.Insert(user);
        if (result)
            Message.MessageViewSuccess(@"Usuario registrado correctamente");
        else
            Message.MessageViewError(@"Error al registrar usuario");
    }
}