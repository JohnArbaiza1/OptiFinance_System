using System.Runtime.InteropServices;
using OptiFinance_System.global;
using OptiFinance_System.global.database;

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
        MinimumSize = new(300, 200);

        // Asociamos los eventos del mouse con los métodos manejadores
        MouseDown += panelContenedor_MouseDown;
        MouseMove += panelContenedor_MouseMove;
        MouseUp += panelContenedor_MouseUp;
        MouseDown += panelRedireccion_MouseDown;
        MouseMove += panelRedireccion_MouseMove;
        MouseUp += panelRedireccion_MouseUp;
    }

    #region Parte donde se trabaja la logica del panel contenedor de formularios

    public void abrirF<TMiForm>() where TMiForm : Form, new()
    {
        Form? formulario;
        //Buscara en la coleccion el formulario si el formulario o instancia no existe
        formulario = panelContenedor.Controls.OfType<TMiForm>().FirstOrDefault();

        if (formulario == null)
        {
            //Creamos una nueva instancia
            formulario = new TMiForm();
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
        if (Application.OpenForms["libroMayor"] == null) btnMayor.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["balanceGeneral"] == null) btnBGeneral.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["SeleccionEmpresa"] == null)
            btnSeleccionarEmpresa.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["estado_Resultado"] == null) btnEResultados.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["razones_Liquidez"] == null) btnRLiquidez.BackColor = Color.FromArgb(34, 53, 80);
        if (Application.OpenForms["Miembros"] == null) btnMiembros.BackColor = Color.FromArgb(34, 53, 80);
    }

    #endregion


    private void Principal_Load(object sender, EventArgs e)
    {
        btnInicio_Click(null, e);

        //Validamos las opciones que se mostraran segun el id del tipo de usuario
        if (Global.SelectedUser == null) return;
        if (Global.SelectedUser.TipoUsuario!.Id == UserTypes.Admin)
        {
            //Hacemos invisibles las demas opciones para el admin
            btnCuentas.Visible = false;
            btnLibros.Visible = false;
            btnEstados.Visible = false;
            btnRLiquidez.Visible = false;
            btnIngresarPartida.Visible = false;
            btnEmpresas.Visible = false;
            PanelCuentas.Visible = false;
            panelLibros.Visible = false;
            panelEstados.Visible = false;
            panelEmpresa.Visible = false;
            //Reposicionamos los buttons de las opciones que el admin manejara
            btnUsuarios.Location = new(0, 190);
            btnCuentas.Location = new(0, 540);
            btnSalir.Location = new(0, 830);
            //Llamamos a los metodos
            reajustesMenu();
            notificaciones();
            
            btnLibros.Location = new(0, 700);
        }
        else if(Global.SelectedMiembroEmpresa == null)
        {
            buttonsPosition();
            //Ajustes de la validacion
            btnUsuarios.Location = new(0, 610);
            btnEmpresas.Location = new(0, 540);
            btnUsuarios.Visible = false;
        }
        else
        {
            //Llamamos a los metodos
            buttonsPosition();
            reajustesMenu();
            btnUsuarios.Visible = false;
            btnEmpresas.Visible = false;
            panelEmpresa.Visible = false;

        }
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
            Size = new(Width + dx, Height + dy);
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
            Size = new(Width + dx, Height + dy);
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

    #region Metodos
    private void buttonsPosition()
    {
        btnCuentas.Location = new(0, 190);
        btnLibros.Location = new(0, 260);
        PanelCuentas.Hide();
        //Para la opcion de libros
        btnEstados.Location = new(0, 330);
        panelLibros.Hide();
        //Para la opcion de estados
        btnRLiquidez.Location = new(0, 400);
        panelEstados.Hide();
        btnIngresarPartida.Location = new(0, 470);
        btnSalir.Location = new(0, 830);
        panelEmpresa.Hide();
    }

    private void reajustesMenu()
    {
        //Ajustes necesarios
        panelMenu.AutoSize = false; //Desactivamos el ajuste automatico
        panelMenu.Size = new(381, 900); //Fijamos un tamaño especifico
        panelMenu.AutoScroll = false; // Desactivamos el scroll automático
    }

    //Metodo para crear el button de notificaciones
    private Button notificaciones()
    {
        //Creamos el button de notificacion
        Button btnNotificacion = new();

        // Configuramos las propiedades del botón
        btnNotificacion.Name = "btnNotificacion";
        btnNotificacion.Text = "Notificaciónes";
        btnNotificacion.Size = new(380, 67);
        btnNotificacion.BackColor = Color.FromArgb(34, 53, 80);
        btnNotificacion.ForeColor = Color.White;
        btnNotificacion.FlatStyle = FlatStyle.Flat;
        btnNotificacion.FlatAppearance.BorderSize = 0;
        btnNotificacion.Font = new("Bookman Old Style", 12, FontStyle.Bold);
        btnNotificacion.TextAlign = ContentAlignment.MiddleLeft;
        btnNotificacion.Padding = new Padding(16, 0, 0, 0);
        // Evento para cambiar color cuando el ratón pasa sobre el botón
        btnNotificacion.MouseEnter += (sender, e) =>
        {
            btnNotificacion.BackColor = Color.FromArgb(215, 143, 35); // Restaurar el color original
        };

        // Evento para restaurar el color cuando el ratón sale del botón
        btnNotificacion.MouseLeave += (sender, e) =>
        {
            btnNotificacion.BackColor = Color.FromArgb(34, 53, 80); // Restaurar el color original
        };

        // Esto es una prueba
        btnNotificacion.Click += (sender, e) => { MessageBox.Show("Has hecho clic en Notificación"); };
        //Agregamos el botón al panel
        panelMenu.Controls.Add(btnNotificacion);
        //Reposicionamos por si acaso XD
        btnNotificacion.Location = new(0, 260);

        return btnNotificacion;
    }
    #endregion

    #region Buttons del menu

    //=================================| Inicio |===================================
    private void btnInicio_Click(object sender, EventArgs e)
    {
        abrirF<Inicio>();
    }

    //=================================| Salir |===================================
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
            btnLibros.Location = new(0, 257);
            btnEstados.Location = new(0, 330);
            btnRLiquidez.Location = new(0, 400);
            btnIngresarPartida.Location = new(0, 470);
            btnEmpresas.Location = new(0, 540);
        }
        else
        {
            PanelCuentas.Visible = true;
            btnLibros.Location = new(0, 392);
            btnEstados.Location = new(0, 465);
            btnRLiquidez.Location = new(0, 535);
            btnIngresarPartida.Location = new(0, 604);
            btnEmpresas.Location = new(0, 674);
        }

        btnCuentas.Location = new(0, 190);
        PanelCuentas.Location = new(0, 263);
    }

    //=================================================================================
    //OPcion de los libros contables
    private void btnLibros_Click(object sender, EventArgs e)
    {
        if (panelLibros.Visible)
        {
            panelLibros.Visible = false;
            btnEstados.Location = new(0, 330);
            btnRLiquidez.Location = new(0, 400);
            btnIngresarPartida.Location = new(0, 470);
            btnEmpresas.Location = new(0, 540);
        }
        else
        {
            panelLibros.Visible = true;
            btnEstados.Location = new(0, 465);
            btnRLiquidez.Location = new(0, 530);
            btnIngresarPartida.Location = new(0, 600);
            btnEmpresas.Location = new(0, 665);
        }

        btnLibros.Location = new(0, 257);
        panelLibros.Location = new(0, 330);
    }

    //=================================================================================
    //Opcion de los Estados Financieros
    private void btnEstados_Click(object sender, EventArgs e)
    {
        if (panelEstados.Visible)
        {
            panelEstados.Visible = false;
            btnRLiquidez.Location = new(0, 400);
            btnIngresarPartida.Location = new(0, 470);
            btnEmpresas.Location = new(0, 540);
        }
        else
        {
            panelEstados.Visible = true;
            btnRLiquidez.Location = new(0, 545);
            btnIngresarPartida.Location = new(0, 610);
            btnEmpresas.Location = new(0, 680);
        }

        btnEstados.Location = new(0, 332);
        panelEstados.Location = new(0, 400);
    }

    //=================================| Empresas |===================================
    private void btnEmpresas_Click(object sender, EventArgs e)
    {
        if (panelEmpresa.Visible)
        {
            panelEmpresa.Visible = false;
        }
        else
        {
            panelEmpresa.Visible = true;
            btnSalir.Location = new(0, 830);
        }

        btnEmpresas.Location = new(0, 540);
        panelEmpresa.Location = new(0, 610);
    }

    //=================================| Partidas |===================================
    private void btnIngresarPartida_Click(object sender, EventArgs e)
    {
        abrirF<RegistrarPartidas>();
        btnIngresarPartida.BackColor = Color.FromArgb(215, 143, 35);
    }

    //=================================| Cuentas |===================================
    private void btnIngresarCuenta_Click(object sender, EventArgs e)
    {
        abrirF<IngresarCuentas>();
        btnIngresarCuenta.BackColor = Color.FromArgb(215, 143, 35);
    }

    //=================================| Catalogo |===================================
    private void btnCatalogo_Click(object sender, EventArgs e)
    {
        abrirF<CatalogoCuentas>();
        btnCatalogo.BackColor = Color.FromArgb(215, 143, 35);
    }

    //=================================| Usuarios |===================================

    private void btnUsuarios_Click(object sender, EventArgs e)
    {
        abrirF<Usuarios>();
        btnUsuarios.BackColor = Color.FromArgb(215, 143, 35);
    }

    //=================================| Info Empresa |================================
    private void btnInfo_Click(object sender, EventArgs e)
    {
        abrirF<InfoEmpresacs>();
        btnInfo.BackColor = Color.FromArgb(254, 214, 0);
    }

    //==============================| Libro Diario |===================================
    private void btnDiario_Click(object sender, EventArgs e)
    {
        abrirF<libriDiario>();
        btnDiario.BackColor = Color.FromArgb(254, 214, 0);
    }

    //===============================| Libro Mayor |===================================
    private void btnMayor_Click(object sender, EventArgs e)
    {
        abrirF<libroMayor>();
        btnMayor.BackColor = Color.FromArgb(254, 214, 0);
    }

    //==============================| Balance General |================================
    private void btnBGeneral_Click(object sender, EventArgs e)
    {
        abrirF<balanceGeneral>();
        btnBGeneral.BackColor = Color.FromArgb(254, 214, 0);
    }

    //=============================| Seleccionar Empresa |==============================
    private void btnSeleccionarEmpresa_Click(object sender, EventArgs e)
    {
        abrirF<SeleccionEmpresa>();
        btnSeleccionarEmpresa.BackColor = Color.FromArgb(254, 214, 0);
    }

    //=============================| Estado de Resultados |==============================
    private void btnEResultados_Click(object sender, EventArgs e)
    {
        abrirF<estado_Resultado>();
        btnEResultados.BackColor = Color.FromArgb(254, 214, 0);
    }

    //=============================| Razones de Liquidez |==============================
    private void btnRLiquidez_Click(object sender, EventArgs e)
    {
        abrirF<razones_Liquidez>();
        btnRLiquidez.BackColor = Color.FromArgb(215, 143, 35);
    }

    //=============================| Miembros |==============================
    private void btnMiembros_Click(object sender, EventArgs e)
    {
        abrirF<Miembros>();
        btnMiembros.BackColor = Color.FromArgb(254, 214, 0);
    }

    #endregion
}