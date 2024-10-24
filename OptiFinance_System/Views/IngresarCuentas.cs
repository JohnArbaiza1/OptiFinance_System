using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using System.Windows.Forms;
using System.Xml;

namespace OptiFinance_System.Views;

public partial class IngresarCuentas : Form
{
    public IngresarCuentas()
    {
        InitializeComponent();
        CargarTipoCuenta();
        comboBoxSubCuenta.Enabled = false;
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void CargarTipoCuenta()
    {
        List<TipoCuenta> tipocuenta = TipoCuentaQuery.Instance.SelectAll();
        comboTipoCuenta.Items.Clear();
        foreach (TipoCuenta item in tipocuenta)
        {
            comboTipoCuenta.Items.Add(item);
        }
        comboTipoCuenta.SelectedIndex = 0;
    }

    private void btnSubir_Click(object sender, EventArgs e)
    {
        //Mostramos el cuadro de dialogo y comprobamos si el usuario ha seleccionado un archivo
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            //Si sea seleccionado un archivo, obtenemos la ruta
            string? direccionFile = openFileDialog1.FileName;

            //llamamos a la función para mostrar el contenido del archivo subido
            mostrarArchivo(direccionFile);
        }
    }

    //Definimos una funcion que nos ayude a mostrar el contenido del archivo JSON
    private void mostrarArchivo(string direccionFile)
    {
        //manejo de exepciones
        try
        {
            //La siguiente variable se encarga de leer el contenido del archivo JSON en forma de cadena
            string jsonContent = File.ReadAllText(direccionFile);

            //Mostramos el contenido
            richTextBoxCuentas.Text = jsonContent;
        }
        catch (Exception e)
        {
            //MOstramos el mensaje siguiente en caso de errores
            MessageBox.Show("Error al leer el archivo: " + e.Message);
        }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        // Limpiar el contenido del RichTextBox
        richTextBoxCuentas.Clear();
    }

    private void checkBoxSubCuenta_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxSubCuenta.Checked)
            comboBoxSubCuenta.Enabled = true;
        else
            comboBoxSubCuenta.Enabled = false;
    }

    private void btnGuardarCuentas_Click(object sender, EventArgs e)
    {
        if (guardar())
        {
            if (!string.IsNullOrEmpty(richTextBoxCuentas.Text))
            {
                MessageBox.Show("El Richt tiene información");
                try
                {
                    // Extraer solo la parte de "Cuentas" del JSON
                    var json = richTextBoxCuentas.Text;

                    // Deserializar el contenido del RichTextBox directamente como una lista de Cuenta
                    var cuentas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cuenta>>(json);

                    if (cuentas != null)
                    {
                        bool insertarListaCuentas = CuentaQuery.Instance.Insert(cuentas);
                        if (insertarListaCuentas)
                        {
                            MessageBox.Show("Catalogo Insertado");
                            richTextBoxCuentas.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido Ingresar el Catalogo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron cuentas.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el JSON: {ex.Message}");
                }
            }
            else
            {
                TipoCuenta tipo = comboTipoCuenta.SelectedItem as TipoCuenta;
                Cuenta cuenta = new Cuenta();
                cuenta.Codigo = txtCodigo.Text;
                cuenta.Nombre = txtNombreCuenta.Text;
                cuenta.TipoCuenta = tipo;
                bool insertarcuenta = CuentaQuery.Instance.Insert(cuenta);
                if (insertarcuenta)
                {
                    MessageBox.Show("Cuenta Registrada con Exito");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un Error al Registrar la cuenta");
                }
            }
            
        }
        else
        {
            MessageBox.Show("No se puede guardar aun");
        }
    }
    private bool guardar()
    {
        bool respuesta = false;
        if ((string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombreCuenta.Text)) && string.IsNullOrEmpty(richTextBoxCuentas.Text))
        {
            MessageBox.Show("No hay suficiente informacion para poder almacenar");
            respuesta = false;
        }
        else
        {
            respuesta = true;
        }
        return respuesta;
    }
    private void limpiar()
    {
        txtCodigo.Clear();
        txtNombreCuenta.Clear();
    }
}