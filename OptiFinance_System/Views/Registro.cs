namespace OptiFinance_System.Views;

public partial class Registro : Form
{
    public Registro()
    {
        InitializeComponent();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void lblLogin_Click(object sender, EventArgs e)
    {
        Form1 form = new Form1();
        form.Show();
        Hide();
    }
}