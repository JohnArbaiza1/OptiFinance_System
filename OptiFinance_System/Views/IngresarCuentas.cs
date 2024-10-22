namespace OptiFinance_System.Views;

public partial class IngresarCuentas : Form
{
    public IngresarCuentas()
    {
        InitializeComponent();
        comboBoxSubCuenta.Enabled = false;
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
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
}