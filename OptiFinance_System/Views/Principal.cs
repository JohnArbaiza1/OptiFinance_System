using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OptiFinance_System.Views
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            // Establecemos el estilo del borde del formulario a ninguno
            this.FormBorderStyle = FormBorderStyle.None;
            //Indicamos el tamaño mínimo del formulario
            this.MinimumSize = new Size(300, 200);

            // Asociamos los eventos del mouse con los métodos manejadores
            this.MouseDown += new MouseEventHandler(panelContenedor_MouseDown);
            this.MouseMove += new MouseEventHandler(panelContenedor_MouseMove);
            this.MouseUp += new MouseEventHandler(panelContenedor_MouseUp);
        }

        #region Varibles Empleadas
        // Variable para indicar si se está redimensionando el formulario
        private bool resizing = false;
        // Variable para almacenar la última posición del mouse
        private Point lastMousePos;

        private Form activeForm;
        #endregion

        #region Parte donde se trabaja la barra de titulo
        private void btnBarraTituloCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Nos permite mover la ventana del formulario a traves de la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximo.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximo.Visible = true;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                this.Size = new Size(this.Width + dx, this.Height + dy);
                // Actualiza la posición del mouse
                lastMousePos = e.Location;
            }
        }

        private void panelContenedor_MouseUp(object sender, MouseEventArgs e)
        {
            // Verifica si el botón soltado es el izquierdo
            if (e.Button == MouseButtons.Left)
            {
                // Termina el redimensionamiento
                resizing = false;
            }
        }
        #endregion

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
                formulario.Show();//Se encarga de mostrar
                formulario.FormClosed += new FormClosedEventHandler(Close);

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
            //if (Application.OpenForms["Fomr1"] == null)
            //{
            //    btnInicio.BackColor = Color.FromArgb(39, 52, 69);
            //}
        }
        #endregion

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //abrirF<Form1>();
            //btnInicio.BackColor = Color.FromArgb(215, 143, 35);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
