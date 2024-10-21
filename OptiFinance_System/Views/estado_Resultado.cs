using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptiFinance_System.Views
{
    public partial class estado_Resultado : Form
    {
        public estado_Resultado()
        {
            InitializeComponent();

            // Configuración básica del ListView
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            // Agregar columnas para descripción y montos
            listView1.Columns.Add("Descripción", 400);
            listView1.Columns.Add("Monto", 300);

            //Definimos loas grupos que van dentro del estado de resultados
            ListViewGroup ingresosGroup = new ListViewGroup("Ingresos Operacionales");
            listView1.Groups.Add(ingresosGroup);

            ListViewGroup gastosGroup = new ListViewGroup("Gastos Operativos");
            listView1.Groups.Add(gastosGroup);

            ListViewGroup utilidadOperativa = new ListViewGroup("Utilidad Operativa");
            listView1.Groups.Add(utilidadOperativa);

            ListViewGroup otros = new ListViewGroup("Otros Ingresos/Egresos");
            listView1.Groups.Add(otros);

            ListViewGroup impuesto = new ListViewGroup("Impuesto a la renta");
            listView1.Groups.Add(impuesto);

            ListViewGroup utilidadGroup = new ListViewGroup("Utilidad Neta");
            listView1.Groups.Add(utilidadGroup);

            //Agregamos ítems vacíos solo para que se muestren los encabezados de los grupos esto es solo para probar
            listView1.Items.Add(new ListViewItem(new string[] { "N/A", "N/A" }, ingresosGroup));
            listView1.Items.Add(new ListViewItem(new string[] { "N/A", "N/A" }, gastosGroup));
            listView1.Items.Add(new ListViewItem(new string[] { "N/A", "N/A" }, utilidadOperativa));
            listView1.Items.Add(new ListViewItem(new string[] { "N/A", "N/A" }, otros));
            listView1.Items.Add(new ListViewItem(new string[] { "N/A", "N/A" }, impuesto));
            listView1.Items.Add(new ListViewItem(new string[] { "N/A", "N/A" }, utilidadGroup));

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
