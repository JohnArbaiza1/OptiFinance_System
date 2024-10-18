using System.Runtime.InteropServices;

namespace OptiFinance_System.Views;

public partial class Principal : Form
{
    public Principal()
    {
        AutoScaleMode = AutoScaleMode.Dpi;
        InitializeComponent();
        // Establecemos el estilo del borde del formulario a ninguno
        FormBorderStyle = FormBorderStyle.None;
        //Indicamos el tamaño mínimo del formulario
        MinimumSize = new Size(300, 200);

        // Asociamos los eventos del mouse con los métodos manejadores
        MouseDown += panelContenedor_MouseDown;
        MouseMove += panelContenedor_MouseMove;
        MouseUp += panelContenedor_MouseUp;
        MouseDown += panelRedireccion_MouseDown;
        MouseMove += panelRedireccion_MouseMove;
        MouseUp += panelRedireccion_MouseUp;
    }

    #region Parte donde se trabaja la logica del panel contenedor de formularios

    public void abrirF<MiForm>() where MiForm : Form, new()
    {
        Form formulario;
        //Buscara en la coleccion el formulario si el formulario o instancia no existe
        formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();

        if (formulario == null)
        {
            //Creamos una nueva instancia
            formulario = new MiForm();
            //Indicamos que el formulario que se use sera secundario
            formulario.TopLevel = false;
            //Nos permetira que el formulario se acople al panel contenedor
            formulario.Dock = DockStyle.Fill;
            //Agregamos el formulario a la coleccion de controles del panel
            panelContenedor.Controls.Add(formulario);
            //Especificamos la propiedad tag
            panelContenedor.Tag = formulario;
            formulario.Show(); //Se encarga de mostrar
            formulario.FormClosed += Close;
            formulario.Dock = DockStyle.Fill;
        }
        //Si el formulario o instancia existe
        else
        {
            formulario.BringToFront();
        }
    }

    #endregion


    #region Metodo para regresar los buttons del menu a su color original al cerrar el form secundario

    private void Close(object sender, FormClosedEventArgs e)
    {
        if (Application.OpenForms["Usuarios"] == null) btnUsuarios.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["InfoEmpresa"] == null) btnInfo.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["libriDiario"] == null) btnDiario.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["RegistrarPartidas"] == null)
            btnIngresarPartida.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["IngresarCuentas"] == null) btnIngresarCuenta.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["CatalogoCuentas"] == null) btnCatalogo.BackColor = Color.FromArgb(34, 53, 80);
    }

    #endregion


    private void Principal_Load(object sender, EventArgs e)
    {
        btnInicio_Click(null, e);
        //========================================================
        //Para la opcion de cuentas
        btnCuentas.Location = new Point(0, 190);
        btnLibros.Location = new Point(0, 260);
        PanelCuentas.Hide();
        //Para la opcion de libros
        btnEstados.Location = new Point(0, 330);
        panelLibros.Hide();
        //Para la opcion de estados
        btnRLiquidez.Location = new Point(0, 400);
        panelEstados.Hide();
        btnIngresarPartida.Location = new Point(0, 470);
        btnUsuarios.Location = new Point(0, 540);
        btnInfo.Location = new Point(0, 610);
        btnSalir.Location = new Point(0, 830);
    }

    private void btnIngresarPartida_Click(object sender, EventArgs e)
    {
        abrirF<RegistrarPartidas>();
        btnIngresarPartida.BackColor = Color.FromArgb(215, 143, 35);
    }

    private void btnIngresarCuenta_Click(object sender, EventArgs e)
    {
        abrirF<IngresarCuentas>();
        btnIngresarCuenta.BackColor = Color.FromArgb(215, 143, 35);
    }

    private void btnCatalogo_Click(object sender, EventArgs e)
    {
        abrirF<CatalogoCuentas>();
        btnCatalogo.BackColor = Color.FromArgb(215, 143, 35);
    }

    #region Varibles Empleadas

    // Variable para indicar si se está redimensionando el formulario
    private bool resizing;

    // Variable para almacenar la última posición del mouse
    private Point lastMousePos;

    private Form activeForm;

    #endregion

    #region Parte donde se trabaja la barra de titulo

    private void btnBarraTituloCerrar_Click(object sender, EventArgs e)
    {
        //Almacenamos la respuesta del usuario en una variable
        DialogResult respuesta = MessageBox.Show(@"¿Esta seguro que desea salir?", @"Salir del Sistema",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        //Verificamos la respuesta del usuario
        if (respuesta == DialogResult.OK) Application.Exit();
    }

    //Nos permite mover la ventana del formulario a traves de la barra de titulo
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void btnMaximo_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
        btnMaximo.Visible = false;
        btnRestaurar.Visible = true;
    }

    private void btnRestaurar_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Normal;
        btnRestaurar.Visible = false;
        btnMaximo.Visible = true;
    }

    private void btnMenos_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    #endregion

    #region Reposicionamiento

    private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
    {
        // Verifica si el botón presionado es el izquierdo
        if (e.Button == MouseButtons.Left)
        {
            // Inicia el redimensionamiento
            resizing = true;
            // Guarda la posición actual del mouse
            lastMousePos = e.Location;
        }
    }

    private void panelContenedor_MouseMove(object sender, MouseEventArgs e)
    {
        // Verifica si se está redimensionando
        if (resizing)
        {
            // Calcula la diferencia en la posición del mouse
            int dx = e.X - lastMousePos.X;
            int dy = e.Y - lastMousePos.Y;
            // Ajusta el tamaño del formulario según el movimiento del mouse
            Size = new Size(Width + dx, Height + dy);
            // Actualiza la posición del mouse
            lastMousePos = e.Location;
        }
    }

    private void panelContenedor_MouseUp(object sender, MouseEventArgs e)
    {
        // Verifica si el botón soltado es el izquierdo
        if (e.Button == MouseButtons.Left)
            // Termina el redimensionamiento
            resizing = false;
    }


    private void panelRedireccion_MouseDown(object sender, MouseEventArgs e)
    {
        // Verifica si el botón presionado es el izquierdo
        if (e.Button == MouseButtons.Left)
        {
            // Inicia el redimensionamiento
            resizing = true;
            // Guarda la posición actual del mouse
            lastMousePos = e.Location;
        }
    }

    private void panelRedireccion_MouseMove(object sender, MouseEventArgs e)
    {
        // Verifica si se está redimensionando
        if (resizing)
        {
            // Calcula la diferencia en la posición del mouse
            int dx = e.X - lastMousePos.X;
            int dy = e.Y - lastMousePos.Y;
            // Ajusta el tamaño del formulario según el movimiento del mouse
            Size = new Size(Width + dx, Height + dy);
            // Actualiza la posición del mouse
            lastMousePos = e.Location;
        }
    }

    private void panelRedireccion_MouseUp(object sender, MouseEventArgs e)
    {
        // Verifica si el botón soltado es el izquierdo
        if (e.Button == MouseButtons.Left)
            // Termina el redimensionamiento
            resizing = false;
    }

    #endregion

    #region Buttons del menu

    private void btnInicio_Click(object sender, EventArgs e)
    {
        abrirF<Inicio>();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        //Almacenamos la respuesta del usuario en una variable
        DialogResult respuesta = MessageBox.Show(@"¿Esta seguro que desea salir?", @"Salir del Sistema",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        //Verificamos la respuesta del usuario
        if (respuesta == DialogResult.OK) Application.Exit();
    }

    //=================================================================================
    //Opcion de las cuentas
    private void btnCuentas_Click(object sender, EventArgs e)
    {
        if (PanelCuentas.Visible)
        {
            PanelCuentas.Visible = false;
            btnLibros.Location = new Point(0, 257);
            btnEstados.Location = new Point(0, 330);
            btnRLiquidez.Location = new Point(0, 400);
            btnIngresarPartida.Location = new Point(0, 470);
            btnUsuarios.Location = new Point(0, 540);
            btnInfo.Location = new Point(0, 610);
        }
        else
        {
            PanelCuentas.Visible = true;
            btnLibros.Location = new Point(0, 392);
            btnEstados.Location = new Point(0, 465);
            btnRLiquidez.Location = new Point(0, 535);
            btnIngresarPartida.Location = new Point(0, 604);
            btnUsuarios.Location = new Point(0, 674);
            btnInfo.Location = new Point(0, 738);
        }

        btnCuentas.Location = new Point(0, 190);
        PanelCuentas.Location = new Point(0, 263);
    }

    //=================================================================================
    //OPcion de los libros contables
    private void btnLibros_Click(object sender, EventArgs e)
    {
        if (panelLibros.Visible)
        {
            panelLibros.Visible = false;
            btnEstados.Location = new Point(0, 330);
            btnRLiquidez.Location = new Point(0, 400);
            btnIngresarPartida.Location = new Point(0, 470);
            btnUsuarios.Location = new Point(0, 540);
            btnInfo.Location = new Point(0, 610);
        }
        else
        {
            panelLibros.Visible = true;
            btnEstados.Location = new Point(0, 465);
            btnRLiquidez.Location = new Point(0, 530);
            btnIngresarPartida.Location = new Point(0, 600);
            btnUsuarios.Location = new Point(0, 665);
            btnInfo.Location = new Point(0, 735);
        }

        btnLibros.Location = new Point(0, 257);
        panelLibros.Location = new Point(0, 330);
    }

    //=================================================================================
    //Opcion de los Estados Financieros
    private void btnEstados_Click(object sender, EventArgs e)
    {
        if (panelEstados.Visible)
        {
            panelEstados.Visible = false;
            btnRLiquidez.Location = new Point(0, 400);
            btnIngresarPartida.Location = new Point(0, 470);
            btnUsuarios.Location = new Point(0, 540);
            btnInfo.Location = new Point(0, 610);
        }
        else
        {
            panelEstados.Visible = true;
            btnRLiquidez.Location = new Point(0, 545);
            btnIngresarPartida.Location = new Point(0, 610);
            btnUsuarios.Location = new Point(0, 680);
            btnInfo.Location = new Point(0, 750);
            btnSalir.Location = new Point(0, 830);
        }

        btnEstados.Location = new Point(0, 332);
        panelEstados.Location = new Point(0, 400);
    }

    private void btnUsuarios_Click(object sender, EventArgs e)
    {
        abrirF<Usuarios>();
        btnUsuarios.BackColor = Color.FromArgb(215, 143, 35);
    }

    private void btnInfo_Click(object sender, EventArgs e)
    {
        abrirF<InfoEmpresacs>();
        btnInfo.BackColor = Color.FromArgb(215, 143, 35);
    }

    private void btnDiario_Click(object sender, EventArgs e)
    {
        abrirF<libriDiario>();
        btnDiario.BackColor = Color.FromArgb(254, 214, 0);
    }

    #endregion
}