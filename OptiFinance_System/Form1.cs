using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text.Json;
using OptiFinance_System.global;
using OptiFinance_System.database.connection;
using OptiFinance_System.database.generalities;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.helper;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.utils;
using OptiFinance_System.Views;
using Message = OptiFinance_System.utils.Message;
using Registro = OptiFinance_System.Views.Registro;

namespace OptiFinance_System;

public partial class Form1 : Form
{
    public static Usuario? currentUser = new();
    private string _pass = "";

    //Variables
    private string _usuario = "";

    public Form1()
    {
        InitializeComponent();
    }

    private static void CargarDatos()
    {
        QueryBuilder<Empresa> queryBuilder = new QueryBuilder<Empresa>()
            .SelectAll()
            .Where("nombre", "nose");

        Connection.Instance.OpenConnection();
        List<Empresa> departamentos =
            queryBuilder.ExecuteQuery(Connection.Instance.GetSqlConnection(), Queries.EmpresaParams.Map);
    }

    private void InsertarUsuarios()
    {
        DatabaseHelper databaseHelper = new("");
        string? password = BCrypt.Net.BCrypt.HashPassword("admin");
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
        string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database", "resources",
            "departamentos.json");

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
        municipios.ForEach(entity =>
            entity.Departamento = DepartamentoQuery.Instance.FindByName(entity.Departamento!.Nombre));
        if (MunicipioQuery.Instance.Insert(municipios)) MessageBox.Show(@"Municipios registrados correctamente");
    }

    [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
    private void InsertarDistritos()
    {
        string distritosJsonPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database", "resources", "distritos.json");

        Console.WriteLine(distritosJsonPath);

        if (!File.Exists(distritosJsonPath))
        {
            MessageBox.Show(@"No se encontró el archivo json");
            return;
        }

        string distritosJson = File.ReadAllText(distritosJsonPath);

        List<Distrito>? distritos = JsonSerializer.Deserialize<List<Distrito>>(distritosJson);
        distritos!.ForEach(distrito =>
            distrito.Municipio = MunicipioQuery.Instance.FindByName(distrito.Municipio!.Nombre));
        if (DistritoQuery.Instance.Insert(distritos)) MessageBox.Show(@"Distritos registrados correctamente");
    }

    private void InsertarGirosEconomicos()
    {
        string girosPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database", "resources", "giros.json");
        Console.WriteLine(girosPath);

        if (!File.Exists(girosPath))
        {
            MessageBox.Show(@"No se encontró el archivo giros.json");
            return;
        }

        string girosJson = File.ReadAllText(girosPath);

        List<GiroEconomico>? giros = JsonSerializer.Deserialize<List<GiroEconomico>>(girosJson);
        if (GiroEconomicoQuery.Instance.Insert(giros!)) MessageBox.Show(@"Giros económicos registrados correctamente");
    }

    private static bool ValidarUsuario(string username, string password)
    {
        People? usuario = (People?)UsuarioQuery.Instance.FindByUsername(username) ??
                          MiembroEmpresaQuery.Instance.FindByUsername(username);
        return Validations.UserExist(usuario);
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
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // InsertarDistritos();
        // InsertarGirosEconomicos();
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

    private bool SigningSucces(string usermame, string password)
    {
        Usuario? usuario = UsuarioQuery.Instance.FindByUsername(usermame);

        if (usuario != null) return Validations.ComparePasswordHash(password, usuario.Password);
        MiembroEmpresa? miembroEmpresa = MiembroEmpresaQuery.Instance.FindByUsername(usermame);
        return miembroEmpresa != null && Validations.ComparePasswordHash(password, miembroEmpresa.Password);
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        Ingresar();
    }

    private void lblRegistro_Click(object sender, EventArgs e)
    {
        Registro registro = new();
        registro.Show();
        Hide();
    }

    private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (int)Keys.Enter) return;
        Ingresar();
    }

    private void Ingresar()
    {
        _usuario = txtUser.Text;
        _pass = txtPassword.Text;

        if (!ValidarUsuario(_usuario, _pass))
        {
            Message.MessageViewError(@"Usuario o contraseña incorrecta");
            return;
        }

        if (!SigningSucces(_usuario, _pass))
        {
            Message.MessageViewError(@"Usuario o contraseña incorrecta");
            return;
        }

        Usuario? curentUser = UsuarioQuery.Instance.FindByUsername(_usuario);
        if (curentUser == null)
        {
            Global.SelectedMiembroEmpresa = MiembroEmpresaQuery.Instance.FindByUsername(_usuario);
            Global.SelectedUser = Global.SelectedMiembroEmpresa!.Empresa!.Usuario;
            Global.SelectedEmpresa = Global.SelectedMiembroEmpresa.Empresa;
        }

        Global.SelectedUser = curentUser;

        // Console.WriteLine(@"Usuario: " + Global.SelectedUser);
        // Console.WriteLine(@"Miembro Empresa: " + Global.SelectedMiembroEmpresa);

        Hide();
        Principal menu = new();
        menu.Show();
        //evento que se dispara cuando el formulario Principal se cierra.
        menu.FormClosed += (s, args) => Close();
    }
}