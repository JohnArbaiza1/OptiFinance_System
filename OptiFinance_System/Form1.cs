using System.Runtime.InteropServices;
using System.Text.Json;
using OptiFinance_System.Views;
using Microsoft.Data.SqlClient;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.utils;
using Message = OptiFinance_System.utils.Message;
using Registro = OptiFinance_System.Views.Registro;

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
        
        private List<T>? DeserializeJson<T>(string jsonPath, bool validateFileExiste = false)
        {
            if (validateFileExiste && !File.Exists(jsonPath)) return null;
            string json = File.ReadAllText(jsonPath);
            return JsonSerializer.Deserialize<List<T>>(json);
        }

        private void InsertarDepartamentos()
        {
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"database", "resources", "departamentos.json");

            if (!File.Exists(jsonPath)) return;
            string departamentosJson = File.ReadAllText(jsonPath);
            List<Departamento>? departamentos = DeserializeJson<Departamento>(departamentosJson);

            if (departamentos == null) return;
            DepartamentoQuery departamentoQuery = DepartamentoQuery.Instance;
            if (!departamentoQuery.Insert(departamentos)) return;
            MessageBox.Show(@"Departamentos registrados correctamente");
        }
        
        private void InsertarMunicipios()
        {
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database", "resources",
                "municipios.json");

            if (!File.Exists(jsonPath))
            {
                MessageBox.Show(@"No se encontró el archivo distritos.json");
                return;
            }
            string municipiosJson = File.ReadAllText(jsonPath);
            List<Municipio>? municipios = DeserializeJson<Municipio>(municipiosJson);
            if (municipios == null) return;
            municipios.ForEach(municipio => municipio.Departamento = DepartamentoQuery.Instance.FindByName(municipio.Departamento.Nombre)!);
            if (MunicipioQuery.Instance.Insert(municipios))
            {
                MessageBox.Show(@"Municipios registrados correctamente");
            }
        }

        private void InsertarDistritos()
        {
            string distritosJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database", "resources",
                "distritos.json");

            if (!File.Exists(distritosJsonPath))
            {
                MessageBox.Show(@"No se encontró el archivo distritos.json");
                return;
            }

            string distritosJson = File.ReadAllText(distritosJsonPath);
            
            List<Distrito>? distritos = JsonSerializer.Deserialize<List<Distrito>>(distritosJson);
            if (distritos == null) return;
            distritos.ForEach(distrito => distrito.Municipio = MunicipioQuery.Instance.FindByName(distrito.Municipio.Nombre)!);
            if (DistritoQuery.Instance.Insert(distritos))
            {
                MessageBox.Show(@"Distritos registrados correctamente");
            }
        }
        
        private static bool ValidarUsuario(string username, string password)
        {
            Usuario? usuario = UsuarioQuery.Instance.FindByUsername(username);
            if (!Validations.UserExist(usuario)) return false;
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
            // InsertarDepartamentos();
            // InsertarMunicipios();
            // InsertarDistritos();
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
        
        private bool SigningSucces(Usuario? user, string password)
        {
            if (!Validations.UserExist(user)) return false;
            return Validations.ComparePasswordHash(password, user!.Password);
        }

        //Variables
        private string _usuario = "";
        private string _pass = "";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            _usuario = txtUser.Text;
            _pass = txtPassword.Text;
            Usuario? usuario = UsuarioQuery.Instance.FindByUsername(_usuario);
            Console.WriteLine(usuario);
            if (!SigningSucces(usuario, _pass))
            {
                MessageBox.Show(@"Usuario o contraseña incorrectos");
                return;
            }
            // if (!ValidarUsuario(_usuario, _pass)) return;
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
