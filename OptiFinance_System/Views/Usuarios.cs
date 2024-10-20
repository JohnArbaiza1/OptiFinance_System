using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.Views;

public partial class Usuarios : Form
{
    public Usuarios()
    {
        InitializeComponent();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Usuarios_Load(object sender, EventArgs e)
    {
        try
        {
            List<Usuario> userList = UsuarioQuery.Instance.SelectAll();
            //dataGridViewUsuarios.DataSource = userList;

            // Limpiamos las filas actuales del DataGridView
            dataGridViewUsuarios.Rows.Clear();

            // Iteramos sobre cada usuario en la lista y los agregamos al DataGridView
            foreach (Usuario user in userList)
            {
                dataGridViewUsuarios.Rows.Add(user.Nombres, user.Email,user.Alias, user.Email, user.Telefono, user.Direccion); 
            }
        }
        catch (Exception ex)
        {
            //Por si hay algun error :)
            MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
        }
    }
}