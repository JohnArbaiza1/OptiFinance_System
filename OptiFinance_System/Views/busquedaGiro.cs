using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptiFinance_System.database.generalities.parameters;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.Views
{
    public partial class busquedaGiro : Form
    {
        public busquedaGiro()
        {
            InitializeComponent();
        }

        //Nos permite mover la ventana del formulario a traves de la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void barraTiulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void busquedaGiro_Shown(object sender, EventArgs e)
        {
            CargarGirosEconomicos();
        }

        private void CargarGirosEconomicos()
        {
            List<GiroEconomico> giroEconomicos = GiroEconomicoQuery.Instance.SelectAll();
            
            giroEconomicos.ForEach(entity =>
            {
                dataGiros.Rows.Add(
                    entity.Nombre
                    );
            });
        }
    }
}
