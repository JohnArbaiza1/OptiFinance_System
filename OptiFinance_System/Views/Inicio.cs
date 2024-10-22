using global::OptiFinance_System.global;

namespace OptiFinance_System.Views;

public partial class Inicio : Form
{
    public static Label lblNombreEmpresa;
    public Inicio()
    {
        InitializeComponent();
        // label2.Text = $@"Bienvenidos a {Global.SelectedEmpresa?.Nombre ?? ""}";
        lblNombreEmpresa = label2;
    }

    private void horaFecha_Tick(object sender, EventArgs e)
    {
        lblHora.Text = DateTime.Now.ToLongTimeString();
        lblFecha.Text = DateTime.Now.ToLongDateString();
    }
}