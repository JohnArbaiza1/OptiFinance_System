using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.utils;

namespace OptiFinance_System.Views;

public partial class Miembros : Form
{
    //Variables
    private List<MiembroEmpresa>? listaMiembroEmpresa;
    private int selectMiembroId;
    private MiembroEmpresa? selectMiembroEmpresa;

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
    private void busquedaMiembrosEmpresa(string? search)
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
    private void limpiarTextBoxMiembro()
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
        try
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataMiembros.Rows[e.RowIndex];

                selectMiembroId = (int)((MiembroEmpresa)row.Cells["Nombre"].Value).Id;
                selectMiembroEmpresa = row.Cells["Nombre"].Value as MiembroEmpresa;
                if (selectMiembroEmpresa == null)
                {
                    MessageBox.Show(@"No se ha seleccionado un Miembro", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtNombre.Text = selectMiembroEmpresa.Nombres;
                txtApellido.Text = selectMiembroEmpresa.Apellidos;
                txtAlias.Text = selectMiembroEmpresa.Alias;
                txtPassword.Text = selectMiembroEmpresa.Password;
                txtDui.Text = selectMiembroEmpresa.Dui;
                txtCorreo.Text = selectMiembroEmpresa.Correo;
                txtTelefono.Text = selectMiembroEmpresa.Telefono;
                txtAddress.Text = selectMiembroEmpresa.Direccion;

            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    private void btnBuscarMiembros_Click(object sender, EventArgs e)
    {
    }

    private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
    {
        string search = txtBusqueda.Text.Trim();
        busquedaMiembrosEmpresa(search);
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
        limpiarTextBoxMiembro();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show(@"¿Esta seguro de eliminar este miembro?", @"Eliminar Miembro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (respuesta == DialogResult.OK)
        {
            bool result = MiembroEmpresaQuery.Instance.Delete(selectMiembroId);
            if (result)
            {
                limpiarTextBoxMiembro();
                MessageBox.Show(@"Miembro Eliminado Correctamente");
            }
            else
            {
                MessageBox.Show(@"Error al eliminar los datos de Miembro", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
        if (Validations.ValidarUsuarioAndMiembroExist(alias))
        {
            SetErrorProvider(errorProvider1, txtAlias, "El alias ya existe", ErrorIconAlignment.MiddleLeft);
        }
        else
        {
            errorProvider1.SetError(txtAlias, "");
        }
    }

    private void SetErrorProvider(ErrorProvider errorProvider, Control control, string message, ErrorIconAlignment iconAlignment)
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
        if (Validations.ExistDui(dui))
        {
            SetErrorProvider(errorProvider1, txtDui, "El dui ya existe", ErrorIconAlignment.MiddleLeft);
        }
        else
        {
            errorProvider1.SetError(txtDui, "");
        }
    }

    private void txtCorreo_KeyUp(object sender, KeyEventArgs e)
    {
        timerCorreo.Stop();
        timerCorreo.Start();
    }

    private void timerCorreo_Tick(object sender, EventArgs e)
    {
        string correo = txtCorreo.Text.Trim();
        if (Validations.ExistEmail(correo))
        {
            SetErrorProvider(errorProvider1, txtCorreo, "El correo ya existe", ErrorIconAlignment.MiddleLeft);
        }
        else
        {
            errorProvider1.SetError(txtCorreo, "");
        }
    }

    private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
    {
        timerTelefono.Stop();
        timerTelefono.Start();
    }

    private void timerTelefono_Tick(object sender, EventArgs e)
    {
        string telefono = txtTelefono.Text.Trim();
        if (Validations.ExistTelefono(telefono))
        {
            SetErrorProvider(errorProvider1, txtTelefono, "El telefono ya existe", ErrorIconAlignment.MiddleLeft);
        }
        else
        {
            errorProvider1.SetError(txtTelefono, "");
        }
    }
}