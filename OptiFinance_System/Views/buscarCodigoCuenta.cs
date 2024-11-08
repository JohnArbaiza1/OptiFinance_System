using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.Views
{
    public partial class buscarCodigoCuenta : Form
    {
        private int _selectedIdCodigoCuenta;
        private Cuenta? _selectCodigoCuenta;
        public buscarCodigoCuenta()
        {
            InitializeComponent();
            cargarCodigos();
        }

        private void buscarCodigoCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Mover a traves de la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Metodos
        //Metodo para cargar los códigos
        private void cargarCodigos()
        {
            List<Cuenta> listCuenta = CuentaQuery.Instance.SelectAll();
            if (listCuenta.Count == 0)
            {
                Console.WriteLine(@"No hay datos");
            }
            listCuenta.ForEach(entity =>
            {
                dataGridCodigos.Rows.Add(
                    entity,
                    entity.Codigo
                );
            });
        }

        //Metodo para buscar
        private void buscarCodigo(string? search)
        {
            if (string.IsNullOrEmpty(search))
            {
                foreach (DataGridViewRow row in dataGridCodigos.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Visible = true;
                }
            }
            else
            {
                string sanitizedSearch = search.Trim().ToLower();
                foreach (DataGridViewRow row in dataGridCodigos.Rows)
                {
                    if (row.IsNewRow) continue;
                    // Obtenemos el valor de la columna 
                    string codigos = row.Cells["nombres"].Value?.ToString()?.ToLower() ?? "";
                    row.Visible = codigos.Contains(sanitizedSearch);
                }
            }
        }


        #endregion

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtCodigo.Text.Trim();
            buscarCodigo(search);
        }

        private void dataGridCodigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dataGridCodigos.Rows[e.RowIndex];
                _selectedIdCodigoCuenta = (int)((Cuenta)row.Cells["nombres"].Value).Id;
                _selectCodigoCuenta = row.Cells["nombres"].Value as Cuenta;
                if (_selectCodigoCuenta == null)
                {
                    MessageBox.Show(@"No se ha seleccionado un código", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCapturarCode.Text = _selectCodigoCuenta.Codigo;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RegistrarPartidas.codeCuentas!.Text = txtCapturarCode.Text ?? "No hay codigo seleccionado";
            Close();
        }
    }
}
