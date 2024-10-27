namespace OptiFinance_System.Views;

using database.models;
using database.query;
using global;
using System.Data;

public partial class libriDiario : Form
{
    //Variables a emplear
    private decimal debe = 0;
    private decimal haber = 0;
    private decimal totalDebe = 0;
    private decimal totalHaber = 0;

    public libriDiario()
    {
        InitializeComponent();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    #region Metodos para el libro diario

    //Metodo para cargar los datos del libro diario
    private void cargarDatosLIbroD()
    {
        try
        {
            DataTable dataTable = new();
            dataTable.Columns.Add("Fecha");
            dataTable.Columns.Add("Partida", typeof(string));
            dataTable.Columns.Add("Detalle", typeof(string));
            dataTable.Columns.Add("Codigo", typeof(string));
            dataTable.Columns.Add("Debe", typeof(string));
            dataTable.Columns.Add("Haber", typeof(string));

            List<Partida> listPartida = PartidaQuery.Instance.SelectAll();
            listPartida.ForEach(entity =>
            {
                List<OptiFinance_System.database.models.Registro> registro = RegistroQuery.Instance.SelectAllByPartida(entity);

                //Definimos una bandera  para la primera fila de cada partida
                bool primeraFila = true;

                registro.ForEach(r =>
                {
                    //Definimos un conjunto de variables para solo mostrar la fecha, partida y detalle en la primera fila de la partida
                    string fecha = primeraFila ? r.Partida?.Fecha.ToString() : "";
                    string? partida = primeraFila ? r.Partida?.Id.ToString() : "";
                    string detalle = primeraFila
                        ? $"{r.Cuenta?.Nombre}"
                        : $"{r.Cuenta?.Nombre}{Environment.NewLine}{r.Partida?.Detalles}";
                    dataTable.Rows.Add(fecha, partida, detalle, r.Cuenta?.Codigo.ToString(), r.Debe, r.Haber);
                    //Hacemos la respectiva suma para calcular el resultado

                    //Convertimos el valor de "Debe" a un número decimal.
                    if (decimal.TryParse(r.Debe.ToString(),
                            out debe)) totalDebe += debe; // Sumamos solo si la conversión es exitosa
                    //Convertimos el valor de "haber" a un número decimal.
                    if (decimal.TryParse(r.Haber.ToString(),
                            out haber)) totalHaber += haber; // Sumamos solo si la conversión es exitosa
                    //Indicamos que despues de la primera fila, desactivamos la bandera
                    primeraFila = false;
                });
            });
            dataPartidas.DataSource = dataTable;
            dataPartidas.Columns["Fecha"]!.Width = 160;
            dataPartidas.Columns["Partida"]!.Width = 100;
            dataPartidas.Columns["Detalle"]!.Width = 470;
            dataPartidas.Columns["Codigo"]!.Width = 150;
            dataPartidas.Columns["Debe"]!.Width = 150;
            dataPartidas.Columns["Haber"]!.Width = 200;

            // Configuración de la columna "Detalle" para el ajuste de texto
            dataPartidas.Columns["Detalle"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataPartidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //Mostramos el resultado de la suma para los totales
            lblTotalDebe.Text = totalDebe.ToString("N2");
            lblTotalHaber.Text = totalHaber.ToString("N2");
        }
        catch (Exception ex)
        {
            Console.WriteLine(@"Error al cargar las partidas" + ex);
        }
    }

    #endregion

    private void libriDiario_Load(object sender, EventArgs e)
    {
        //Llamamos a la funcion
        cargarDatosLIbroD();
    }
}