using global::OptiFinance_System.global;
using Microsoft.IdentityModel.Tokens;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.utils;

namespace OptiFinance_System.Views;

public partial class Miembros : Form
{
    //Variables
    private int _selectMiembroId;
    private MiembroEmpresa? _selectMiembroEmpresa;

    public Miembros()
    {
        InitializeComponent();
        CargarMiembrosEmpresa();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    #region Metodos Miembros
    //====================| Metodo para Cargar los Miembros |====================
    private void CargarMiembrosEmpresa()
    {
        List<MiembroEmpresa> miembroEmpresas = MiembroEmpresaQuery.Instance.SelectAll();

        if (miembroEmpresas.Count == 0)
        {
            Console.WriteLine(@"No hay miembros empresa");
        }
        else
        {
            miembroEmpresas.ForEach(entity =>
            {
                dataMiembros.Rows.Add(
                    entity,
                    entity.Apellidos,
                    entity.Alias,
                    entity.Password,
                    entity.Dui,
                    entity.Correo,
                    entity.Telefono,
                    entity.Direccion
                );
            });
        }
    }

    //====================| Metodo para buscar los Miembros |====================
    private void BusquedaMiembrosEmpresa(string? search)
    {
        if (string.IsNullOrEmpty(search))
        {
            foreach (DataGridViewRow row in dataMiembros.Rows)
            {
                if (row.IsNewRow) continue;
                row.Visible = true;
            }
        }
        else
        {
            string sanitizedSearch = search.Trim().ToLower();
            foreach (DataGridViewRow row in dataMiembros.Rows)
            {
                if (row.IsNewRow) continue;
                // Obtenemos el valor de la columna "Alias" y comparamos con el texto de búsqueda
                string alias = row.Cells["Alias"].Value?.ToString()?.ToLower() ?? "";
                row.Visible = alias.Contains(sanitizedSearch);
            }
        }
    }

    //====================| Metodo para limpiar textbox |====================
    private void LimpiarTextBoxMiembro()
    {
        txtNombre.Clear();
        txtApellido.Clear();
        txtAlias.Clear();
        txtPassword.Clear();
        txtDui.Clear();
        txtCorreo.Clear();
        txtTelefono.Clear();
        txtAddress.Clear();
        dataMiembros.Rows.Clear();
        CargarMiembrosEmpresa();
    }

    #endregion

    private void dataMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void btnBuscarMiembros_Click(object sender, EventArgs e)
    {
    }

    private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
    {
        string search = txtBusqueda.Text.Trim();
        BusquedaMiembrosEmpresa(search);
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();
        string apellido = txtApellido.Text.Trim();
        string alias = txtAlias.Text.Trim();
        string pass = txtPassword.Text.Trim();
        string dui = txtDui.Text.Trim();
        string mail = txtCorreo.Text.Trim();
        string phone = txtTelefono.Text.Trim();
        string address = txtAddress.Text.Trim();



        //Validamos que no se ingresen password vacias
        if (string.IsNullOrWhiteSpace(pass))
        {
            MessageBox.Show(@"Debe Ingresar la contraseña", @"¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (Validations.ValidarUsuarioAndMiembroExist(alias))
        {
            MessageBox.Show(@"El miembro ya existe", @"!Advertencia¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNombre.Clear();
            return;
        }

        MiembroEmpresa miembroEm = new MiembroEmpresa();
        {
            miembroEm.Nombres = nombre;
            miembroEm.Apellidos = apellido;
            miembroEm.Alias = alias;
            miembroEm.Password = Utilities.HashPassword(pass);
            miembroEm.Dui = dui;
            miembroEm.Correo = mail;
            miembroEm.Telefono = phone;
            miembroEm.Direccion = address;
        }
        bool result = MiembroEmpresaQuery.Instance.Insert(miembroEm);
        if (result)
            MessageBox.Show(@"Miembro registrado correctamente");
        else
            MessageBox.Show(@"Error al registrar miembro");
        LimpiarTextBoxMiembro();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show(@"¿Esta seguro de eliminar este miembro?", @"Eliminar Miembro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (respuesta != DialogResult.OK) return;
        bool result = MiembroEmpresaQuery.Instance.Delete(_selectMiembroId);
        if (result)
        {
            LimpiarTextBoxMiembro();
            MessageBox.Show(@"Miembro Eliminado Correctamente");
        }
        else
        {
            MessageBox.Show(@"Error al eliminar los datos de Miembro", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        _selectMiembroEmpresa = null;
        LimpiarCamposTexto();
        btnEditar.Visible = false;
        btnEliminar.Visible = false;
        btnAgregar.Visible = true;
        btnCancelar.Visible = false;
    }

    private void txtDui_TextChanged(object sender, EventArgs e)
    {
        Formats.FormatDui(sender, e);
    }

    private void txtTelefono_TextChanged(object sender, EventArgs e)
    {
        Formats.FormatTelefono(sender, e);
    }

    private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
    {
        Formats.OnlyNumbers(sender, e);
    }

    private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
    {
        Formats.OnlyNumbers(sender, e);
    }

    private void txtAlias_KeyUp(object sender, KeyEventArgs e)
    {
        timerAlias.Stop();
        timerAlias.Start();
    }

    private void timerAlias_Tick(object sender, EventArgs e)
    {
        string alias = txtAlias.Text.Trim();
        if (_selectMiembroEmpresa != null && _selectMiembroEmpresa.Alias.Equals(alias))
        {
            SetErrorProvider(errorProvider1, txtAlias, "");
            timerAlias.Stop();
            return;
        }
        if (Validations.ValidarUsuarioAndMiembroExist(alias))
        {
            SetErrorProvider(errorProvider1, txtAlias, "El alias ya existe");
        }
        else
        {
            errorProvider1.SetError(txtAlias, "");
        }
        timerAlias.Stop();
    }

    private void SetErrorProvider(ErrorProvider errorProvider, Control control, string message, ErrorIconAlignment iconAlignment = ErrorIconAlignment.MiddleLeft)
    {
        errorProvider.SetIconAlignment(control, iconAlignment);
        errorProvider.SetError(control, message);
    }

    private void txtDui_KeyUp(object sender, KeyEventArgs e)
    {
        timerDui.Stop();
        timerDui.Start();
    }

    private void timerDui_Tick(object sender, EventArgs e)
    {
        string dui = txtDui.Text.Trim();
        if (_selectMiembroEmpresa != null && _selectMiembroEmpresa.Dui.Equals(dui))
        {
            SetErrorProvider(errorProvider1, txtDui, "");
            timerDui.Stop();
            return;
        }
        if (Validations.ExistDui(dui))
        {
            SetErrorProvider(errorProvider1, txtDui, "El dui ya existe");
        }
        else
        {
            errorProvider1.SetError(txtDui, "");
        }
        timerDui.Stop();
    }

    private void txtCorreo_KeyUp(object sender, KeyEventArgs e)
    {
        timerCorreo.Stop();
        timerCorreo.Start();
    }

    private void timerCorreo_Tick(object sender, EventArgs e)
    {
        string correo = txtCorreo.Text.Trim();
        if (_selectMiembroEmpresa != null && _selectMiembroEmpresa.Correo != null && _selectMiembroEmpresa.Correo.Equals(correo))
        {
            SetErrorProvider(errorProvider1, txtCorreo, "");
            timerCorreo.Stop();
            return;
        }
        if (Validations.ExistEmail(correo))
        {
            SetErrorProvider(errorProvider1, txtCorreo, "El correo ya existe");
        }
        else
        {
            errorProvider1.SetError(txtCorreo, "");
        }
        timerCorreo.Stop();
    }

    private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
    {
        timerTelefono.Stop();
        timerTelefono.Start();
    }

    private void timerTelefono_Tick(object sender, EventArgs e)
    {
        string telefono = txtTelefono.Text.Trim();
        if (_selectMiembroEmpresa != null && _selectMiembroEmpresa.Telefono != null && _selectMiembroEmpresa.Telefono.Equals(telefono))
        {
            SetErrorProvider(errorProvider1, txtTelefono, "");
            timerTelefono.Stop();
            return;
        }
        if (Validations.ExistTelefono(telefono))
        {
            SetErrorProvider(errorProvider1, txtTelefono, "El telefono ya existe");
        }
        else
        {
            errorProvider1.SetError(txtTelefono, "");
        }
        timerTelefono.Stop();
    }


    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (_selectMiembroEmpresa == null)
        {
            MessageBox.Show(@"No se ha seleccionado un Miembro", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        bool txtNombreEmpty =
            Validations.FieldNullOrEmpty(errorProvider1, txtNombre, "El campo nombre no puede estar vacio");

        bool txtApellidoEmpty =
            Validations.FieldNullOrEmpty(errorProvider1, txtApellido, "El campo apellido no puede estar vacio");

        bool txtAliasEmpty =
            Validations.FieldNullOrEmpty(errorProvider1, txtAlias, "El campo alias no puede estar vacio");

        bool txtDuiEmpty = Validations.FieldNullOrEmpty(errorProvider1, txtDui, "El campo dui no puede estar vacio");

        bool txtCorreoEmpty =
            Validations.FieldNullOrEmpty(errorProvider1, txtCorreo, "El campo correo no puede estar vacio");

        bool txtTelefonoEmpty =
            Validations.FieldNullOrEmpty(errorProvider1, txtTelefono, "El campo telefono no puede estar vacio");

        bool txtAddressEmpty =
            Validations.FieldNullOrEmpty(errorProvider1, txtAddress, "El campo direccion no puede estar vacio");

        bool aliasExist = !_selectMiembroEmpresa.Alias.Equals(txtAlias.Text.Trim()) &&
                          Validations.ValidarUsuarioAndMiembroExist(txtAlias.Text.Trim());
        bool duiExist = !_selectMiembroEmpresa.Dui.Equals(txtDui.Text.Trim()) &&
                        Validations.ExistDui(txtDui.Text.Trim());
        bool emailExist = _selectMiembroEmpresa.Correo != null &&
                          !_selectMiembroEmpresa.Correo.Equals(txtCorreo.Text.Trim()) &&
                          Validations.ExistEmail(txtCorreo.Text.Trim());
        bool phoneExist = _selectMiembroEmpresa.Telefono != null &&
                          !_selectMiembroEmpresa.Telefono.Equals(txtTelefono.Text.Trim()) &&
                          Validations.ExistTelefono(txtTelefono.Text.Trim());

        bool result = txtNombreEmpty || txtApellidoEmpty || txtAliasEmpty || txtDuiEmpty || txtCorreoEmpty ||
                      txtTelefonoEmpty || txtAddressEmpty || aliasExist || duiExist || emailExist ||
                      phoneExist;

        if (result) return;


        MiembroEmpresa updateMember = new()
        {
            Id = _selectMiembroEmpresa.Id,
            Apellidos = txtApellido.Text.Trim(),
            Direccion = txtAddress.Text.Trim(),
            Alias = txtAlias.Text.Trim(),
            Correo = txtCorreo.Text.Trim(),
            Dui = txtDui.Text.Trim(),
            Nombres = txtNombre.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            Password = txtPassword.Text.IsNullOrEmpty() || txtPassword.Text.Trim().Equals(_selectMiembroEmpresa.Password)
                ? _selectMiembroEmpresa.Password
                : Utilities.HashPassword(txtPassword.Text.Trim())
        };

        bool update = MiembroEmpresaQuery.Instance.Update(updateMember);
        if (update)
        {
            MessageBox.Show(@"Miembro actualizado correctamente");
            _selectMiembroEmpresa = null;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = true;
            btnCancelar.Visible = false;
            LimpiarTextBoxMiembro();
        }
        else
        {
            MessageBox.Show(@"Error al actualizar miembro");
        }

    }

    private void dataMiembros_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataMiembros.Rows[e.RowIndex];

            _selectMiembroId = (int)((MiembroEmpresa)row.Cells["Nombre"].Value).Id;
            _selectMiembroEmpresa = row.Cells["Nombre"].Value as MiembroEmpresa;
            if (_selectMiembroEmpresa == null)
            {
                MessageBox.Show(@"No se ha seleccionado un Miembro", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtNombre.Text = _selectMiembroEmpresa.Nombres;
            txtApellido.Text = _selectMiembroEmpresa.Apellidos;
            txtAlias.Text = _selectMiembroEmpresa.Alias;
            txtPassword.Text = _selectMiembroEmpresa.Password;
            txtDui.Text = _selectMiembroEmpresa.Dui;
            txtCorreo.Text = _selectMiembroEmpresa.Correo;
            txtTelefono.Text = _selectMiembroEmpresa.Telefono;
            txtAddress.Text = _selectMiembroEmpresa.Direccion;
            btnEditar.Visible = true;
            btnAgregar.Visible = false;
            btnEliminar.Visible = true;
            btnCancelar.Visible = true;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarCamposTexto();
    }

    private void LimpiarCamposTexto()
    {
        if (_selectMiembroEmpresa != null) return;
        txtNombre.Clear();
        txtApellido.Clear();
        txtAlias.Clear();
        txtPassword.Clear();
        txtDui.Clear();
        txtCorreo.Clear();
        txtTelefono.Clear();
        txtAddress.Clear();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        _selectMiembroEmpresa = null;
        LimpiarCamposTexto();
        btnEditar.Visible = false;
        btnEliminar.Visible = false;
        btnAgregar.Visible = true;
    }
}