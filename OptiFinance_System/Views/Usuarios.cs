﻿using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.global;
using OptiFinance_System.utils;
using System.Data;

namespace OptiFinance_System.Views;

public partial class Usuarios : Form
{
    private List<Usuario>? usuariosSistema;
    //Definimos una variable para almacenar el id del usuario seleccionado
    private int selectedUserId;
    public Usuarios()
    {
        InitializeComponent();
    }

    #region Metodo user
    private void cargarUsers()
    {
        if (Global.listUsuarios == null)
        {
            Console.WriteLine(@"Cargando Usuarios desde la base de datos");
            Global.listUsuarios = UsuarioQuery.Instance.SelectAll();
        }
        else
        {
            Console.WriteLine(@"Cargando usuarios desde la lista");
        }

        if (Global.listUsuarios.Count == 0)
        {
            Console.WriteLine("No se encontraron usuarios.");
            return;
        }

        // Verificamos cuántos usuarios se han cargado
        Console.WriteLine($"Total de usuarios cargados: {Global.listUsuarios.Count}");

        DataTable dataTable = new();
        dataTable.Columns.Add("Nombre", typeof(Usuario));  // Columna para el objeto Usuario
        dataTable.Columns.Add("Apellido", typeof(string));
        dataTable.Columns.Add("Alias", typeof(string));
        dataTable.Columns.Add("Password", typeof(string));
        dataTable.Columns.Add("Email", typeof(string));
        dataTable.Columns.Add("Telefono", typeof(string));
        dataTable.Columns.Add("Direccion", typeof(string));
        Global.listUsuarios.ForEach(entity =>
        {
            dataTable.Rows.Add(entity, entity.Apellidos, entity.Alias, entity.Password, entity.Email, entity.Telefono, entity.Direccion);
        });
        dataGridViewUsuarios.DataSource = dataTable;
        dataGridViewUsuarios.Columns["Nombre"]!.Width = 200;
        dataGridViewUsuarios.Columns["Apellido"]!.Width = 150;
        dataGridViewUsuarios.Columns["Alias"]!.Width = 150;
        dataGridViewUsuarios.Columns["Password"]!.Width = 150;
        dataGridViewUsuarios.Columns["Email"]!.Width = 200;
        dataGridViewUsuarios.Columns["Telefono"]!.Width = 150;
        dataGridViewUsuarios.Columns["Direccion"]!.Width = 150;
    }

    private void limpiar_ActualizarCampos()
    {
        txtName.Clear();
        txtLastName.Clear();
        txtAlias.Clear();
        txtEmail.Clear();
        txtPassUser.Clear();
        txtTelefonos.Clear();
        txtAddress.Clear();

        Global.listUsuarios = null;
        cargarUsers();
    }

    private void busquedaUsuarios(string? search)
    {
        DataTable dataTable = (DataTable)dataGridViewUsuarios.DataSource;
        if (dataTable == null) return;
        if (string.IsNullOrEmpty(search))
        {
            dataTable.DefaultView.RowFilter = string.Empty;
            return;
        }

        string sanitizedSearch = search.Replace("'", "''"); // Escapar comillas simples
        dataTable.DefaultView.RowFilter = $"[Alias] LIKE '%{sanitizedSearch}%'";
    }

    #endregion


    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Usuarios_Load(object sender, EventArgs e)
    {
        try
        {
            cargarUsers();

        }
        catch (Exception ex)
        {
            //Por si hay algun error :)
            MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
        }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {

        string username = txtName.Text.Trim();
        string apellidos = txtLastName.Text.Trim();
        string alias = txtAlias.Text.Trim();
        string email = txtEmail.Text.Trim();
        string password = txtPassUser.Text.Trim();
        string telefono = txtTelefonos.Text.Trim();
        string direccion = txtAddress.Text.Trim();

        //Validamos que no se pueda ingresar contraeñas vacias
        if (string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Debe Ingresar la contraseña", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (Validations.UserExist(UsuarioQuery.Instance.FindByUsername(alias)))
        {
            MessageBox.Show(@"El usuario ya existe", "!Advertencia¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Clear();
            return;
        }

        Usuario user = new Usuario();
        {
            user.Alias = alias;
            user.Password = Utilities.HashPassword(password);
            user.Nombres = username;
            user.Apellidos = apellidos;
            user.Email = email;
            user.Telefono = telefono;
            user.Direccion = direccion;
            user.TipoUsuario = TipoUsuarioQuery.Instance.FindById(2);
        }

        bool result = UsuarioQuery.Instance.Insert(user);
        if (result)
            MessageBox.Show(@"Usuario registrado correctamente");
        else
            MessageBox.Show(@"Error al registrar usuario");

        limpiar_ActualizarCampos();
    }

    private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsuarios.Rows[e.RowIndex];

                selectedUserId = (int)((Usuario)row.Cells["Nombre"].Value).Id;

                txtName.Text = row.Cells["Nombre"].Value.ToString();
                txtLastName.Text = row.Cells["Apellido"].Value.ToString();
                txtAlias.Text = row.Cells["Alias"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassUser.Text = row.Cells["Password"].Value.ToString();
                txtTelefonos.Text = row.Cells["Telefono"].Value.ToString();
                txtAddress.Text = row.Cells["Direccion"].Value.ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Parece que ha ocurrido un error\n" + ex);
        }
    }


    private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
    {
        int totalTextCount = txtBusqueda.Text.Length;
        string search = totalTextCount == 0 ? "" : txtBusqueda.Text.Trim();
        busquedaUsuarios(search);
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        string username = txtName.Text.Trim();
        string apellidos = txtLastName.Text.Trim();
        string alias = txtAlias.Text.Trim();
        string email = txtEmail.Text.Trim();
        string password = txtPassUser.Text.Trim();
        string telefono = txtTelefonos.Text.Trim();
        string direccion = txtAddress.Text.Trim();

        //Validamos que no se pueda ingresar contraeñas vacias
        if (string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Debe Ingresar la contraseña", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Usuario user = new Usuario();
        {
            user.Id = selectedUserId;
            user.Alias = alias;
            user.Password = Utilities.HashPassword(password);
            user.Nombres = username;
            user.Apellidos = apellidos;
            user.Email = email;
            user.Telefono = telefono;
            user.Direccion = direccion;
            user.TipoUsuario = TipoUsuarioQuery.Instance.FindById(2);
        }

        bool result = UsuarioQuery.Instance.Update(user);

        if (result)
        {
            limpiar_ActualizarCampos();
            MessageBox.Show("Datos de Usuario actualizados correctamente");
        }
        else
        {
            MessageBox.Show("Error al actualizar los datos de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show(@"¿Esta seguro de eliminar este usuario?", @"Eliminar Usuario",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        //Verificamos la respuesta del usuario
        if (respuesta == DialogResult.OK)
        {
            bool result = UsuarioQuery.Instance.Delete(selectedUserId);
            if (result)
            {
                limpiar_ActualizarCampos();
                MessageBox.Show("Usuario Eliminado Correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        };

    }
}