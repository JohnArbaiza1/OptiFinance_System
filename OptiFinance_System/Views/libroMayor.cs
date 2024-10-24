using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OptiFinance_System.Views;

public partial class libroMayor : Form
{
    public libroMayor()
    {
        InitializeComponent();
        addDataGrid();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void libroMayor_Load(object sender, EventArgs e)
    {

    }

    #region Metodo Libro Mayor
    //Definimos un metodo para crear y añadir los DataGridView al panel
    private void addDataGrid()
    {
        //Definimos las variables para los espacios
        int spacingX = 610;
        int spacingY = 310;

        for(int i = 0; i < 4; i++)
        {
            //creamos una nueva instancia de DataGridView
            DataGridView dataGridMayor = new DataGridView();

            //Configuramos las propiedades
            dataGridMayor.Name = "dataLibroMayor";
            dataGridMayor.Size = new Size(590, 300);
            dataGridMayor.Location = new Point(20, 10);

            //Columnas 
            dataGridMayor.Columns.Add("Column1", "Cuenta");
            dataGridMayor.Columns.Add("Column2", "Codigo");
            dataGridMayor.Columns["Column1"].Width = 290;
            dataGridMayor.Columns["Column2"].Width = 290;

            // Cálculo para colocar dos DataGridView por fila
            int x = 10 + (i % 2) * spacingX; // Alterna entre columna 0 y columna 1
            int y = 10 + (i / 2) * spacingY; // Cada dos DataGridView, se pasa a una nueva fila
            dataGridMayor.Location = new Point(x, y); // Establece la posición dinámica

            //Agregamos los data al panel
            containerDataMayor.Controls.Add(dataGridMayor);
        }
    }
    #endregion
}