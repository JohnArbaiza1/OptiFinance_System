using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
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
        List<LibroMayor> listaMayor = LibroMayorQuery.Instance.SelectAll();
        // Crea una lista de cuentas únicas basadas en el Id de la cuenta.
        List<Cuenta> cuentasUnicas = CuentaQuery.Instance.SelectAllDistinctsByEmpresa();
        for (int i = 0; i < cuentasUnicas.Count; i++)
        {
            //creamos una nueva instancia de DataGridView
            DataGridView dataGridMayor = new DataGridView();

            //Configuramos las propiedades
            dataGridMayor.Name = "dataLibroMayor";
            dataGridMayor.Size = new Size(590, 300);
            dataGridMayor.Location = new Point(20, 10);

            //Columnas
            dataGridMayor.Columns.Add("Column", "Fecha");
            dataGridMayor.Columns.Add("Column1", cuentasUnicas[i].Codigo);
            dataGridMayor.Columns.Add("Column2", cuentasUnicas[i].Nombre);
            dataGridMayor.Columns.Add("Column3", "Debe");
            dataGridMayor.Columns.Add("Column4", "Haber");
            dataGridMayor.Columns.Add("Column5", "Saldo");
            dataGridMayor.Columns["Column"].Width = 180;
            dataGridMayor.Columns["Column1"].Width = 290;
            dataGridMayor.Columns["Column2"].Width = 100;
            dataGridMayor.Columns["Column3"].Width = 150;
            dataGridMayor.Columns["Column4"].Width = 150;
            dataGridMayor.Columns["Column5"].Width = 150;

            // Filtrar los elementos de listaMayor que coinciden con la cuenta actual
            var itemsFiltrados = listaMayor.Where(libro => libro.Cuenta?.Id == cuentasUnicas[i].Id);
            //var itemsFiltrados = LibroMayorQuery.Instance.SelectAllByAccount(cuentasUnicas[i].Id);
            decimal saldo = 0m;
            // Agregar cada elemento filtrado como una nueva fila en el DataGridView
            foreach (var item in itemsFiltrados)
            {
                // Obtén el saldo (debe - haber) o según el cálculo deseado
                saldo += calcularSaldo(item.Cuenta, item.Debe, item.Haber);
                // Agregar fila
                dataGridMayor.Rows.Add(
                    item.Partida?.Fecha.ToString("d/MM/yyyy"), // Reemplaza con la fecha real si la tienes
                    item.Partida?.Detalles,
                    item.Partida?.Id,
                    item.Debe,
                    item.Haber,
                    saldo
                );
            }

            // Cálculo para colocar dos DataGridView por fila
            int x = 10 + (i % 2) * spacingX; // Alterna entre columna 0 y columna 1
            int y = 10 + (i / 2) * spacingY; // Cada dos DataGridView, se pasa a una nueva fila
            dataGridMayor.Location = new Point(x, y); // Establece la posición dinámica

            //Agregamos los data al panel
            containerDataMayor.Controls.Add(dataGridMayor);
        }
    }
    private decimal calcularSaldo(Cuenta tipoCuenta, decimal debe, decimal haber)
    {
        decimal dato = 0m;
        if (tipoCuenta.Codigo.StartsWith("1"))
        {
            dato = debe - haber;
        }
        else if (tipoCuenta.Codigo.StartsWith("2"))
        {
            dato = haber - debe;
        }
        else if (tipoCuenta.Codigo.StartsWith("3"))
        {
            dato = haber - debe;
        }
        else if (tipoCuenta.Codigo.StartsWith("4"))
        {
            dato = haber - debe;
        }
        else if (tipoCuenta.Codigo.StartsWith("5"))
        {
            dato = haber - debe;
        }
        else if (tipoCuenta.Codigo.StartsWith("6"))
        {
            dato = debe - haber;
        }
        return dato;
    }
    #endregion
}