using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

using System.Windows.Forms;

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
        radiobtnDebe.Checked = true;
        radiobtnHaber.Checked = false;
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
                comboFecha.Items.Add(item);
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
                comboFecha.Items.Add(item);
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
        Limpiar();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {

    }

    private void btnRegistrar_Click_1(object sender, EventArgs e)
    {
        if (dataGridView1.Rows.Count <= 1)
        {
            string fecha = dataFecha.Value.ToString("dd/MM/yyyy"); // Formato de la fecha
            Cuenta cuenta = comboFecha.SelectedItem as Cuenta;
            decimal debe = 0m;
            decimal haber = 0m;
            if (string.IsNullOrWhiteSpace(btnValor.Text))
            {
                MessageBox.Show("No se ha agregado un monto perteneciente a la cuenta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radiobtnDebe.Checked)
                {
                    if (decimal.TryParse(btnValor.Text, out decimal montoDecimal))
                    {
                        debe = montoDecimal;
                        haber = 0m;
                    }
                    else
                    {
                        // Mostrar un mensaje si la conversión falló
                        MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                    }
                }
                else if (radiobtnHaber.Checked)
                {
                    if (decimal.TryParse(btnValor.Text, out decimal montoDecimal))
                    {
                        debe = 0m;
                        haber = montoDecimal;
                    }
                    else
                    {
                        // Mostrar un mensaje si la conversión falló
                        MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                    }
                }
                dataGridView1.Rows.Add(fecha, cuenta.Nombre, cuenta.Codigo, debe, haber);
                Limpiar();
            }
        }
        else
        {
            Cuenta cuenta = comboFecha.SelectedItem as Cuenta;
            decimal debe = 0m;
            decimal haber = 0m;
            if (string.IsNullOrWhiteSpace(btnValor.Text))
            {
                MessageBox.Show("No se ha agregado un monto perteneciente a la cuenta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radiobtnDebe.Checked)
                {
                    if (decimal.TryParse(btnValor.Text, out decimal montoDecimal))
                    {
                        debe = montoDecimal;
                        haber = 0m;
                    }
                    else
                    {
                        // Mostrar un mensaje si la conversión falló
                        MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                    }
                }
                else if (radiobtnHaber.Checked)
                {
                    if (decimal.TryParse(btnValor.Text, out decimal montoDecimal))
                    {
                        debe = 0m;
                        haber = montoDecimal;
                    }
                    else
                    {
                        // Mostrar un mensaje si la conversión falló
                        MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                    }
                }
                dataGridView1.Rows.Add("", cuenta.Nombre, cuenta.Codigo, debe, haber);
                Limpiar();
            }
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        int numeroDeFilasConDatos = dataGridView1.Rows.Count - (dataGridView1.AllowUserToAddRows ? 1 : 0);
        if (numeroDeFilasConDatos <= 0)
        {
            MessageBox.Show("No hay información para registrar una Partida");
        }
        else
        {
            decimal sumaDebe = 0m;
            decimal sumaHaber = 0m;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Asegurarse de que la fila no sea una fila nueva (fila vacía)
                if (fila.IsNewRow)
                {
                    continue;
                }

                // Sumar el valor de la columna "Debe"
                if (fila.Cells["Debe"].Value != null && decimal.TryParse(fila.Cells["Debe"].Value.ToString(), out decimal valorDebe))
                {
                    sumaDebe += valorDebe;
                }

                // Sumar el valor de la columna "Haber"
                if (fila.Cells["Haber"].Value != null && decimal.TryParse(fila.Cells["Haber"].Value.ToString(), out decimal valorHaber))
                {
                    sumaHaber += valorHaber;
                }
            }

            // Comparar las sumas de las dos columnas
            if (sumaDebe == sumaHaber)
            {
                if (!textBox1.Enabled)
                {
                    MessageBox.Show("Agregue una descripción y vuelva a presionar el boton de guardar Registro");
                    textBox1.Enabled = true;
                    deshabilitar();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Agregue una Descripción para poder almacenar la partida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        guardarRegistro();
                    }
                }
            }
            else
            {
                MessageBox.Show("Las sumas de las columnas 'Debe' y 'Haber' son diferentes.");
            }
        }


    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        // Muestra un mensaje de confirmación con los botones Sí y No
        DialogResult resultado = MessageBox.Show(
            "¿Está seguro de que desea cerrar la pestaña?\nAl cerrar la pestaña se cerrará el formulario\nSe perderán todos los datos que ha ingresado",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        // Si el usuario elige "Sí", cierra el formulario
        if (resultado == DialogResult.Yes)
        {
            Close();
        }
    }
    private void guardarRegistro()
    {
        //elemento para guardar la partida
        Partida partida = new Partida();
        partida.Fecha = dataFecha.Value.Date;
        partida.Detalles = textBox1.Text;
        Partida resultado = PartidaQuery.Instance.InsertWithResult(partida);

        List<database.models.Registro> list = new List<database.models.Registro>();
        // Recorremos cada fila en el DataGridView
        foreach (DataGridViewRow fila in dataGridView1.Rows)
        {
            OptiFinance_System.database.models.Registro registro = new OptiFinance_System.database.models.Registro();
            // Asegurarse de que la fila no sea una fila de nuevo (si la has habilitado)
            if (!fila.IsNewRow)
            {
                // Obtener el valor de la columna "Cuenta"
                string nombreCuenta = fila.Cells["Cuenta"].Value?.ToString();

                // Verificar que el nombre de la cuenta no sea null o vacío
                if (!string.IsNullOrEmpty(nombreCuenta))
                {
                    // Buscar el objeto Cuenta en la lista utilizando el nombre
                    Cuenta cuentaEncontrada = cuentas.FirstOrDefault(c => c.Nombre.Equals(nombreCuenta, StringComparison.OrdinalIgnoreCase));

                    // Validar si se encontró la cuenta
                    if (cuentaEncontrada != null)
                    {
                        cuentaEncontrada.TipoCuenta = tipocuenta(fila.Cells["Cuenta"].Value?.ToString());

                        string valorDebe = fila.Cells["Debe"].Value?.ToString();
                        string valorHaber = fila.Cells["Haber"].Value?.ToString();
                        decimal valorDecimalDebe;
                        decimal valorDecimalHaber;
                        // Intentar convertir ambos valores a decimal
                        bool esDebeValido = decimal.TryParse(valorDebe, out valorDecimalDebe);
                        bool esHaberValido = decimal.TryParse(valorHaber, out valorDecimalHaber);

                        if (esDebeValido && esHaberValido)
                        {
                            // Ambos valores son válidos, asignar a la instancia registro
                            registro.Debe = valorDecimalDebe;
                            registro.Haber = valorDecimalHaber;
                        }
                        else
                        {
                            // Manejar el caso en que alguno de los valores no es válido
                            MessageBox.Show("Uno o ambos valores en las columnas 'Debe' o 'Haber' no son números válidos.");
                        }
                        registro.Cuenta = cuentaEncontrada;
                        registro.Partida = resultado;
                        list.Add(registro);
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró la cuenta para: {nombreCuenta}");
                    }
                }
            }
        }
        bool respueta = RegistroQuery.Instance.Insert(list);
        if (respueta)
        {
            MessageBox.Show("Partida Registrada");
            Limpiar();
            habilitar();
            dataGridView1.Rows.Clear();
        }
        else
        {
            MessageBox.Show("Ocurren Errores");
        }
    }
    private TipoCuenta tipocuenta(string codigo)
    {
        TipoCuenta tipo = new TipoCuenta();
        if (codigo.StartsWith("1"))
        {
            tipo.Id = 1;
            tipo.Nombre = "activo";
        }
        else if (codigo.StartsWith("2"))
        {
            tipo.Id = 2;
            tipo.Nombre = "pasivo";
        }
        else if (codigo.StartsWith("3"))
        {
            tipo.Id = 3;
            tipo.Nombre = "capital";
        }
        else if (codigo.StartsWith("4"))
        {
            tipo.Id = 4;
            tipo.Nombre = "Cuentas de resultado Deudora";
        }
        else if (codigo.StartsWith("5"))
        {
            tipo.Id = 5;
            tipo.Nombre = "Cuentas de resultado Acreedora";
        }
        else if (codigo.StartsWith("6"))
        {
            tipo.Id = 6;
            tipo.Nombre = "Cuentas de puente de cierre";
        }
        return tipo;
    }
    private void deshabilitar()
    {
        btnEditar.Enabled = false;
        btnRegistrar.Enabled = false;
        dataFecha.Enabled = false;
        comboFecha.Enabled = false;
        txtCodigo.Enabled = false;
        btnValor.Enabled = false;
        radiobtnDebe.Enabled = false;
        radiobtnHaber.Enabled = false;
    }
    private void habilitar()
    {
        btnEditar.Enabled = true;
        btnRegistrar.Enabled = true;
        dataFecha.Enabled = true;
        comboFecha.Enabled = true;
        txtCodigo.Enabled = true;
        btnValor.Enabled = true;
        radiobtnDebe.Enabled = true;
        radiobtnHaber.Enabled = true;
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        // Limpia todas las filas
        dataGridView1.Rows.Clear();
        Limpiar();
        habilitar();
    }

    private void Limpiar()
    {
        txtCodigo.Clear();
        textBox1.Clear();
        btnValor.Clear();
        btnEliminar.Enabled = true;
        btnRegistrar.Enabled=true;
        btnSave.Enabled = true;
        comboFecha.Items.Clear();
        foreach (Cuenta item in cuentas)
        {
            comboFecha.Items.Add(item);
        }
    }

    private void btnValor_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Verificar si la tecla presionada es un número, un punto decimal o una tecla de control
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        {
            e.Handled = true; // Evitar la entrada
            MessageBox.Show("Solo se permite el ingreso de numeros y un punto");
        }

        // Permitir solo un punto decimal
        if (e.KeyChar == '.' && btnValor.Text.Contains("."))
        {
            e.Handled = true; // Evitar la entrada
        }
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Permitir solo dígitos y teclas de control (como retroceso)
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Evitar la entrada
        }
    }

    private void comboFecha_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
        {
            e.Handled = true; // Evitar la entrada
        }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) // asegurandose de que no sea la ultima fila que es vacia y el encabezado
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        // Verifica que haya al menos una fila seleccionada en el DataGridView
        if (dataGridView1.SelectedRows.Count > 0)
        {
            // Obtiene el índice de la fila seleccionada
            int rowIndex = dataGridView1.SelectedRows[0].Index;

            // Asegúrate de que no es la última fila vacía (si está habilitada para agregar nuevas filas)
            if (rowIndex < dataGridView1.Rows.Count - 1)
            {
                // Elimina la fila seleccionada
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("No se puede eliminar la última fila vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            MessageBox.Show("Seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (btnEditar.Text.Equals("    Editar"))
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Asegúrate de que no es la última fila vacía (si está habilitada para agregar nuevas filas)
                if (rowIndex < dataGridView1.Rows.Count - 1)
                {
                    btnEditar.Text = "Actualizar";
                    dataGridView1.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegistrar.Enabled = false;
                    btnSave.Enabled = false;
                    // Verifica que haya al menos una fila seleccionada en el DataGridView

                    string cuenta = dataGridView1.Rows[rowIndex].Cells["Cuenta"].Value.ToString();
                    foreach (var item in comboFecha.Items)
                    {
                        if (((Cuenta)item).Nombre == cuenta)
                        {
                            comboFecha.SelectedItem = item;
                            break;
                        }
                    }

                    // Establece el RadioButton en función de si es Debe o Haber
                    string Debe = dataGridView1.Rows[rowIndex].Cells["Debe"].Value.ToString();
                    string Haber = dataGridView1.Rows[rowIndex].Cells["Haber"].Value.ToString();
                    if (Debe.Equals("0"))
                    {
                        radiobtnDebe.Checked = false;
                        radiobtnHaber.Checked = true;
                        btnValor.Text = Haber;
                    }
                    else
                    {
                        radiobtnDebe.Checked = true;
                        radiobtnHaber.Checked = false;
                        btnValor.Text = Debe;
                    }
                }
                else
                {
                    MessageBox.Show("No se puede Seleccionar la última fila vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para Editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            int rowIndex = dataGridView1.SelectedRows[0].Index;

            // Actualiza solo el valor de la celda "Valor" en el DataGridView
            Cuenta cuenta = new Cuenta();
            cuenta = comboFecha.SelectedItem as Cuenta;
            dataGridView1.Rows[rowIndex].Cells["Cuenta"].Value = cuenta.Nombre;
            dataGridView1.Rows[rowIndex].Cells["Codigo"].Value = cuenta.Codigo;
            if (radiobtnDebe.Checked)
            {
                dataGridView1.Rows[rowIndex].Cells["Debe"].Value = btnValor.Text;
                dataGridView1.Rows[rowIndex].Cells["Haber"].Value = "0";
            }
            else
            {
                dataGridView1.Rows[rowIndex].Cells["Debe"].Value = "0";
                dataGridView1.Rows[rowIndex].Cells["Haber"].Value = btnValor.Text;
            }
            btnEliminar.Enabled = true;
            btnRegistrar.Enabled = true;
            btnSave.Enabled = true;
            btnEditar.Text = "    Editar";
            dataGridView1.Enabled = true;
        }
    }
}