using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OptiFinance_System.database.generalities.types;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.global;

namespace OptiFinance_System.Views;

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
        ListViewGroup ingresosGroup = new("Ingresos Operacionales");
        listView1.Groups.Add(ingresosGroup);

        ListViewGroup gastosGroup = new("Gastos Operativos");
        listView1.Groups.Add(gastosGroup);

        ListViewGroup utilidadOperativa = new("Utilidad Operativa");
        listView1.Groups.Add(utilidadOperativa);

        ListViewGroup otros = new("Otros Ingresos/Egresos");
        listView1.Groups.Add(otros);

        ListViewGroup impuesto = new("Impuesto a la renta");
        listView1.Groups.Add(impuesto);

        ListViewGroup utilidadGroup = new("Utilidad Neta");
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
        Close();
    }

    #region Variables

    private decimal resIngresos = 0;
    private decimal utilidadBruta = 0;
    private decimal totalGastosVenta = 0;
    private decimal totalGastosAdministrativos = 0;
    private decimal utilidadOperativa = 0;
    private decimal utilidadAntesImpuesto = 0;
    private decimal impuesto = 0.13m;
    private decimal utilidadNetas = 0;


    #endregion

    #region Metodos estados resultados
    //Metodo para Ingresos Operacionales
    private void ingresosOperacion()
    {
        EstadoResultado inOperaciones = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.VentasBrutas);
        ListViewGroup ingresosGroup = new("Ingresos Operacionales");
        listView1.Groups.Add(ingresosGroup);
        listView1.Items.Add(new ListViewItem(new string[] { inOperaciones?.Nombre ?? "No hay dato disponible", inOperaciones?.Valor.ToString() ?? "0.0" }, ingresosGroup));
        //--------------------------------------------
        EstadoResultado inOperaciones2 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.RebajasDevolucionesSobreVentas);
        listView1.Items.Add(new ListViewItem(new string[] { inOperaciones2?.Nombre ?? "No hay dato disponible", inOperaciones2?.Valor.ToString() ?? "0.0" }, ingresosGroup));
        //---------------------------------------------
        ListViewGroup ingresosNeto = new("Total Ingresos Operacionales");
        listView1.Groups.Add(ingresosNeto);
        decimal ventaBruta = inOperaciones != null ? inOperaciones.Valor : 0;
        decimal rebajas = inOperaciones2 != null ? inOperaciones2.Valor : 0;
        resIngresos = ventaBruta + rebajas;
        listView1.Items.Add(new ListViewItem(new string[] { " ", resIngresos.ToString("F2") }, ingresosNeto));
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, ingresosNeto));
    }

    //Metodo para costos Operacionales
    private void costos()
    {
        EstadoResultado cosOperaciones = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.CostoVentas);
        ListViewGroup costosGroup = new("Costos de Ventas");
        listView1.Groups.Add(costosGroup);
        listView1.Items.Add(new ListViewItem(new string[] { cosOperaciones?.Nombre ?? "No hay dato disponible", cosOperaciones?.Valor.ToString() ?? "0.0" }, costosGroup));
        //---------------------------------------------
        ListViewGroup utilidadB = new("Utilidad Bruta");
        listView1.Groups.Add(utilidadB);
        decimal costosVentas = cosOperaciones != null ? cosOperaciones.Valor : 0;
        utilidadBruta = resIngresos - costosVentas;
        listView1.Items.Add(new ListViewItem(new string[] { " ", utilidadBruta.ToString("F2") }, utilidadB));
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, utilidadB));
    }

    //Metodo para los gastos
    private void gastosOperativos()
    {
        EstadoResultado gastosO1 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Aguinaldos);
        EstadoResultado gastosO2 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Gratificaciones);
        EstadoResultado gastosO3 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.SeguroSocial);
        EstadoResultado gastosO4 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Viaticos);
        EstadoResultado gastosO5 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.MaterialEmpaque);
        EstadoResultado gastosO6 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.FletesAcarreos);
        EstadoResultado gastosO7 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Comunicaciones);
        EstadoResultado gastosO8 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.AtencionesPersonal);
        EstadoResultado gastosO9 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.MantenimientoEquipoTransporte);
        EstadoResultado gastosO10 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Depreciaciones);
        EstadoResultado gastosO11 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.CombustibleLubricantes);
        EstadoResultado gastosO12 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.CuentasIncobrables);
        EstadoResultado gastosO13 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Indemnizaciones);
        EstadoResultado gastosO14 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.AFP);

        ListViewGroup gastosGroup = new("Gastos Operativos");
        listView1.Groups.Add(gastosGroup);
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, gastosGroup));
        listView1.Items.Add(new ListViewItem(new string[] { "Gastos de Ventas:", " " }, gastosGroup));

        //Agregando datos a listView
        foreach (var item in new[] {
                     gastosO1, gastosO2, gastosO3, gastosO4, gastosO5,
                     gastosO6, gastosO7, gastosO8, gastosO9, gastosO10,
                     gastosO11, gastosO12, gastosO13, gastosO14
                 })
        {
            if (item != null)
                listView1.Items.Add(new ListViewItem(new string[] { item.Nombre, item.Valor.ToString() }, gastosGroup));
        }

        //Calculo del total 
        foreach (var item in new[] {
                     gastosO1, gastosO2, gastosO3, gastosO4, gastosO5,
                     gastosO6, gastosO7, gastosO8, gastosO9, gastosO10,
                     gastosO11, gastosO12, gastosO13, gastosO14
                 })
        {
            if (item != null)
                totalGastosVenta += item.Valor;
        }
        Console.WriteLine($"El total de gastos de ventas: {totalGastosVenta}");
        //-----------------------------------------------------
        EstadoResultado gastosA1 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Sueldos);
        EstadoResultado gastosA2 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.Vacaciones);
        EstadoResultado gastosA3 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.HonorariosProfesionales);
        EstadoResultado gastosA4 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.PublicidadGeneral);
        EstadoResultado gastosA5 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.MatriculaComercio);
        EstadoResultado gastosA6 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.EspeciesPostales);
        EstadoResultado gastosA7 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.EnergiaElectrica);
        EstadoResultado gastosA8 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.MantenimientoVehiculos);
        EstadoResultado gastosA9 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.InscripcionesRegistroComercio);
        EstadoResultado gastosA10 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.PapeleriaUtilesOficina);
        EstadoResultado gastosA11 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.NoDeducibles);
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, gastosGroup));
        listView1.Items.Add(new ListViewItem(new string[] { "Gastos de Administración:", " " }, gastosGroup));
        //Agregando datos a listView
        foreach (var item2 in new[]
                 {
                     gastosA1, gastosA2, gastosA3, gastosA4,
                     gastosA5, gastosA6, gastosA7, gastosA8,
                     gastosA9, gastosA10, gastosA11
                 })
        {
            if (item2 != null)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item2.Nombre, item2.Valor.ToString() }, gastosGroup));
            }
        }

        //Calculo del total 
        foreach (var item in new[] {
                     gastosA1, gastosA2, gastosA3, gastosA4, gastosA5,
                     gastosA6, gastosA7, gastosA8, gastosA9, gastosA10,
                     gastosA11
                 })
        {
            if (item != null)
                totalGastosAdministrativos += item.Valor;
        }
        Console.WriteLine($"El total de gatos administrativos: {totalGastosAdministrativos}");

        //---------------------------------------------
        ListViewGroup utilidadOpera = new("Utilidad Operativa");
        listView1.Groups.Add(utilidadOpera);
        utilidadOperativa = utilidadBruta - totalGastosVenta - totalGastosAdministrativos;
        listView1.Items.Add(new ListViewItem(new string[] { " ", utilidadOperativa.ToString() }, utilidadOpera));
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, utilidadOpera));

    }

    private void otrosIE()
    {
        EstadoResultado otros1 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.IngresosFinancieros);
        EstadoResultado otros2 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.IngresosPorServicios);
        EstadoResultado otros3 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.IngresoPorServiciosOperativos);
        EstadoResultado otros4 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.OtrosIngresos);
        ListViewGroup otros = new("Otros Ingresos/Egresos");
        listView1.Groups.Add(otros);
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, otros));
        listView1.Items.Add(new ListViewItem(new string[] { "Ingresos:", " " }, otros));
        foreach (var item in new[]
                 {
                     otros1, otros2, otros3, otros4
                 })
        {
            if (item != null)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item.Nombre, item.Valor.ToString() }, otros));
            }
        }

        decimal totalOtrosI = 0;
        foreach (var item in new[]
                 {
                     otros1, otros2, otros3, otros4
                 })
        {
            if (item != null)
                totalOtrosI += item.Valor;
        }
        Console.WriteLine($"Total de otros ingresos: {totalOtrosI}");

        EstadoResultado otrosG1 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.InteresesBancarios);
        EstadoResultado otrosG2 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.ComisionesBancarias);
        EstadoResultado otrosG3 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.DiferenciasCambio);
        EstadoResultado otrosG4 = EstadoResultadoQuery.Instance.GetAccountByName(TypeEstadoResultado.InteresesDiversos);
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, otros));
        listView1.Items.Add(new ListViewItem(new string[] { "Egresos:", " " }, otros));
        foreach (var item in new[]
                 {
                     otrosG1, otrosG2, otrosG3, otrosG4
                 })
        {
            if (item != null)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item.Nombre, item.Valor.ToString() }, otros));
            }
        }

        decimal totalOtrosE = 0;
        foreach (var item in new[]
                 {
                     otrosG1, otrosG2, otrosG3, otrosG4
                 })
        {
            if (item != null)
                totalOtrosE += item.Valor;
        }
        Console.WriteLine($"Total de otros Egresos: {totalOtrosE}");
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, otros));

        //-----------------------------------------------
        ListViewGroup utilidaAntes = new("Utilidad Antes de Impuestos");
        listView1.Groups.Add(utilidaAntes);
        utilidadAntesImpuesto = utilidadOperativa + (totalOtrosI - totalOtrosE);
        listView1.Items.Add(new ListViewItem(new string[] { " ", utilidadAntesImpuesto.ToString("F2") }, utilidaAntes));
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, utilidaAntes));
    }

    private void utilidadNeta()
    {
        ListViewGroup utilidadImGroup = new("Impuesto a la Utilidad");
        listView1.Groups.Add(utilidadImGroup);
        listView1.Items.Add(new ListViewItem(new string[] { "", "13%" }, utilidadImGroup));
        listView1.Items.Add(new ListViewItem(new string[] { " ", " " }, utilidadImGroup));

        decimal utilidadImpuesto = utilidadAntesImpuesto * impuesto;
        utilidadNetas = utilidadAntesImpuesto - utilidadImpuesto;

        ListViewGroup utilidadGroup = new("Utilidad Neta");
        listView1.Groups.Add(utilidadGroup);
        listView1.Items.Add(new ListViewItem(new string[] { " ", utilidadNetas.ToString("F2") }, utilidadGroup));
    }

    #endregion

    private void btnResultados_Click(object sender, EventArgs e)
    {
        lblFechaEResultados.Text = $"Estado de resultados del {DateTime.Now.ToString("dd/MM/yyyy")}";
        //Limpiamos el listView
        listView1.Items.Clear();
        //Llamamos a los metodos con los items
        ingresosOperacion();
        costos();
        gastosOperativos();
        otrosIE();
        utilidadNeta();
        button1.Enabled = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Pedir al usuario que seleccione una ubicación para guardar el archivo PDF
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Guardar Estado de Resultados como PDF";
            saveFileDialog.FileName = $"Estado de Resultados {Global.SelectedEmpresa?.Nombre}.pdf"; // Nombre por defecto

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Generar el PDF con los datos del estado de resultados
                GenerarEstadoResultadosPDF(saveFileDialog.FileName);
            }
        }
    }
    private void GenerarEstadoResultadosPDF(string filePath)
    {
        try
        {
            // Crear un documento PDF
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Abrir el documento para agregar contenido
            document.Open();

            // Título del PDF
            string titulo = $"Estado de Resultados de {Global.SelectedEmpresa?.Nombre}";
            iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Paragraph parrafoTitulo = new Paragraph(titulo, tituloFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(parrafoTitulo);
            document.Add(new Chunk("\n"));

            // Fecha del estado de resultados
            Paragraph fecha = new Paragraph($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}")
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(fecha);
            document.Add(new Chunk("\n"));

            // Crear tabla para el estado de resultados
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 4f, 2f }); // Ajuste del ancho de las columnas

            // Encabezados de la tabla
            table.AddCell("Detalle");
            table.AddCell("Monto");

            decimal totalIngresos = 0;
            decimal totalEgresos = 0;

            // Rellenar datos desde el ListView y calcular totales
            foreach (ListViewGroup group in listView1.Groups)
            {
                // Agregar el nombre del grupo como un título en negrita
                PdfPCell cellGroup = new PdfPCell(new Phrase(group.Header, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
                {
                    Colspan = 2,
                    BackgroundColor = new BaseColor(220, 220, 220), // Color de fondo para resaltar el grupo
                    HorizontalAlignment = Element.ALIGN_LEFT
                };
                table.AddCell(cellGroup);

                // Agregar los elementos del grupo y sumar montos según el grupo
                foreach (ListViewItem item in group.Items)
                {
                    table.AddCell(item.Text); // Detalle
                    table.AddCell(item.SubItems[1].Text); // Monto

                    // Parsear el monto a decimal y sumar a ingresos o egresos según el grupo
                    decimal monto;
                    if (decimal.TryParse(item.SubItems[1].Text, out monto))
                    {
                        if (group.Header.Equals("Ingresos", StringComparison.OrdinalIgnoreCase))
                        {
                            totalIngresos += monto;
                        }
                        else if (group.Header.Equals("Egresos", StringComparison.OrdinalIgnoreCase))
                        {
                            totalEgresos += monto;
                        }
                    }
                }
            }

            // Agregar la tabla al documento
            document.Add(table);
            document.Add(new Chunk("\n"));

            // Calcular la utilidad neta
            decimal utilidad = totalIngresos - totalEgresos;

           
            // Cerrar el documento
            document.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocurrió un error al generar el PDF: {ex.Message}");
        }
    }
}