namespace OptiFinance_System.Views;

public partial class Inicio : Form
{
    public Inicio()
    {
        InitializeComponent();
    }

    private void horaFecha_Tick(object sender, EventArgs e)
    {
        lblHora.Text = DateTime.Now.ToLongTimeString();
        lblFecha.Text = DateTime.Now.ToLongDateString();
    }
}