using OptiFinance_System.database.models;
using OptiFinance_System.database.query;

namespace OptiFinance_System.Views;

public partial class LibroMayor : Form
{
    public LibroMayor()
    {
        InitializeComponent();
        AddDataGrid();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void libroMayor_Load(object sender, EventArgs e)
    {
    }

    #region Metodo Libro Mayor
    
    /// <summary>
    /// Crea los DataGridView para mostrar el libro mayor
    /// </summary>
    /// <param name="codigo">Parametro que indica el código de la cuenta</param>
    /// <param name="nombre">Parametro que indica el nombre de la cuenta</param>
    /// <returns>
    /// DataGridView configurado
    /// </returns>
    private DataGridView ConfigureDataGridView(string codigo, string nombre)
{
    DataGridView dataGridMayor = new();

    //Configuramos las propiedades
    dataGridMayor.Name = "dataLibroMayor";
    dataGridMayor.Size = new(1150, 300);
    dataGridMayor.Location = new(20, 10);

    //Columnas
    dataGridMayor.Columns.Add("Column", $"Codigo: {codigo}");
    dataGridMayor.Columns.Add("Column1", $"{nombre}");
    dataGridMayor.Columns.Add("Column2", "");
    dataGridMayor.Columns.Add("Column3", "");
    dataGridMayor.Columns.Add("Column4", "");
    dataGridMayor.Columns.Add("Column5", "");
    dataGridMayor.Columns["Column"]!.Width = 180;
    dataGridMayor.Columns["Column1"]!.Width = 390;
    dataGridMayor.Columns["Column2"]!.Width = 100;
    dataGridMayor.Columns["Column3"]!.Width = 150;
    dataGridMayor.Columns["Column4"]!.Width = 150;
    dataGridMayor.Columns["Column5"]!.Width = 150;

    dataGridMayor.Rows.Add("Fecha", "Concepto","Partida", "Debe", "Haber", "Saldo", "");
    return dataGridMayor;
}

    //Definimos un metodo para crear y añadir los DataGridView al panel
    private void AddDataGrid()
    {
        //Definimos las variables para los espacios
        int spacingX = 610;
        int spacingY = 310;
        List<OptiFinance_System.database.models.LibroMayor> listaMayor = LibroMayorQuery.Instance.SelectAll();
        // Crea una lista de cuentas únicas basadas en el Id de la cuenta.
        List<Cuenta> cuentasUnicas = CuentaQuery.Instance.SelectAllDistinctsByEmpresa();
        for (int i = 0; i < cuentasUnicas.Count; i++)
        {
            //creamos una nueva instancia de DataGridView
            DataGridView dataGridMayor = ConfigureDataGridView(cuentasUnicas[i].Codigo, cuentasUnicas[i].Nombre);

            // Filtrar los elementos de listaMayor que coinciden con la cuenta actual
            // var itemsFiltrados = listaMayor.Where(libro => libro.Cuenta?.Id == cuentasUnicas[i].Id);
            List<database.models.LibroMayor> itemsFiltrados = LibroMayorQuery.Instance.SelectAllByAccount(cuentasUnicas[i].Codigo);
            decimal saldo = 0m;
            // Agregar cada elemento filtrado como una nueva fila en el DataGridView
            foreach (database.models.LibroMayor item in itemsFiltrados)
            {
                // Obtén el saldo (debe - haber) o según el cálculo deseado
                saldo += CalcularSaldo(item.Cuenta, item.Debe, item.Haber);
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
            int y = 10 + i * spacingY; // Incrementa el y para cada DataGridView
            dataGridMayor.Location = new Point(10, y); // Establece la posición dinámica

            //Agregamos los data al panel
            containerDataMayor.Controls.Add(dataGridMayor);
        }
    }

    private decimal CalcularSaldo(Cuenta tipoCuenta, decimal debe, decimal haber)
    {
        decimal dato = 0m;
        if (tipoCuenta.Codigo.StartsWith("1"))
            dato = debe - haber;
        else if (tipoCuenta.Codigo.StartsWith("2"))
            dato = haber - debe;
        else if (tipoCuenta.Codigo.StartsWith("3"))
            dato = haber - debe;
        else if (tipoCuenta.Codigo.StartsWith("4"))
            dato = debe - haber;
        else if (tipoCuenta.Codigo.StartsWith("5"))
            dato = haber - debe;
        else if (tipoCuenta.Codigo.StartsWith("6")) dato = haber - debe;
        return dato;
    }

    #endregion
}