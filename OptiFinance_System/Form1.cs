using System.Runtime.InteropServices;
using OptiFinance_System.Views;
using OptiFinance_System.Config.Helper;
using Microsoft.Data.SqlClient;
using OptiFinance_System.Config.connection;

namespace OptiFinance_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void InsertarUsuarios()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper("");
            string password = BCrypt.Net.BCrypt.HashPassword("admin");
            string query = "INSERT INTO usuarios (nombres, apellidos, alias, email, password, id_tipo_usuario) " + 
                           $@"VALUES ('admin', 'admin', 'admin', 'admin@gmail.com', '{password}', '1')";
            int value = databaseHelper.ExecuteQuery(query);
            MessageBox.Show(value == 1 ? @"Usuario registrado correctamente" : @"Error al registrar el usuario");
        }
        
        private bool validarUsuario(string username, string password)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper("");
            string query = $@"SELECT * FROM usuarios WHERE alias = '{username}'";
            SqlDataReader reader = databaseHelper.ExecuteReader(query, Conexion.Instance.GetConnection());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string? passwordHash = reader["password"].ToString();
                    if (BCrypt.Net.BCrypt.Verify(password, passwordHash))
                    {
                        return true;
                    }
                }
            }
            MessageBox.Show(@"Usuario o contraseña incorrectos");
            return false;
        }

        //Nos permite mover la ventana del formulario a traves de la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // InsertarUsuarios();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text != @"USUARIO") return;
            txtUser.Text = "";
            txtUser.ForeColor = Color.Goldenrod;
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text != "") return;
            txtUser.Text = @"USUARIO";
            txtUser.ForeColor = Color.Goldenrod;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text != @"PASSWORD") return;
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Goldenrod;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text != "") return;
            txtPassword.Text = @"PASSWORD";
            txtPassword.ForeColor = Color.Goldenrod;
        }

        //Variables
        private string _usuario = "";
        private string _pass = "";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            _usuario = txtUser.Text;
            _pass = txtPassword.Text;
            if (!validarUsuario(_usuario, _pass)) return;
            this.Hide();
            Principal menu = new Principal();
            menu.Show();
            //evento que se dispara cuando el formulario Principal se cierra.
            menu.FormClosed += (s, args) => this.Close();
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
