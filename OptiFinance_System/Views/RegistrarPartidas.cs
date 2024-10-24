using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.Views;

public partial class RegistrarPartidas : Form
{
    List<Cuenta> cuentas;
    public RegistrarPartidas()
    {
        InitializeComponent();
        this.Load += RegistrarPartidas_Load;
    }

    private void RegistrarPartidas_Load(object? sender, EventArgs e)
    {
        cuentas = CuentaQuery.Instance.SelectAll();
        comboFecha.Items.Clear();
        foreach (Cuenta item in cuentas)
        {
            comboFecha.Items.Add(item);
        }

        // Asociar el evento TextChanged para filtrar elementos
        comboFecha.TextChanged += comboFecha_TextChanged;
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void comboFecha_TextChanged(object sender, EventArgs e)
    {
        // Desconectar temporalmente el evento para evitar que se dispare recursivamente
        comboFecha.TextChanged -= comboFecha_TextChanged;

        // Capturar el texto que el usuario ha escrito
        string filtro = comboFecha.Text.ToLower();

        // Limpiar los elementos actuales del ComboBox
        comboFecha.Items.Clear();

        // Filtrar las cuentas según el texto escrito
        foreach (Cuenta item in cuentas)
        {
            if (item.Nombre.ToLower().Contains(filtro)) // Si coincide con el filtro, agregar
            {
                comboFecha.Items.Add(item.Nombre);
            }
        }

        // Restaurar el texto que el usuario ha escrito
        comboFecha.Text = filtro;

        // Mover el cursor al final del texto escrito
        comboFecha.SelectionStart = filtro.Length;
        comboFecha.SelectionLength = 0;

        // Reconectar el evento TextChanged
        comboFecha.TextChanged += comboFecha_TextChanged;
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        // Limpiar el ComboBox antes de la búsqueda
        comboFecha.Items.Clear();

        // Capturar el texto que el usuario ha escrito en el TextBox
        string codigoBusqueda = txtCodigo.Text.ToLower();

        // Filtrar las cuentas según el código
        foreach (Cuenta item in cuentas)
        {
            // Comparar el código de la cuenta con el texto ingresado
            if (item.Codigo.ToLower().StartsWith(codigoBusqueda) || item.Codigo.ToLower() == codigoBusqueda)
            {
                // Agregar el nombre de la cuenta al ComboBox
                comboFecha.Items.Add(item.Nombre);
            }
        }


        // Seleccionar el primer elemento si se encontraron coincidencias
        if (comboFecha.Items.Count > 0)
        {

        }
        else
        {
            MessageBox.Show("No se encontraron cuentas que coincidan con el código."); // Mensaje si no se encuentran coincidencias
        }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtCodigo.Clear();
        comboFecha.Items.Clear();
        foreach (Cuenta item in cuentas)
        {
            comboFecha.Items.Add(item);
        }
    }
}