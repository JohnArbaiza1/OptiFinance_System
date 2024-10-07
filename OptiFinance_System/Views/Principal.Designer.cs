namespace OptiFinance_System.Views
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            barraTitulo = new Panel();
            opcionesBarraTitulo = new Panel();
            btnMaximo = new PictureBox();
            btnRestaurar = new PictureBox();
            btnMenos = new PictureBox();
            btnBarraTituloCerrar = new PictureBox();
            panelMenu = new Panel();
            btnSalir = new Button();
            btnIngresarPartida = new Button();
            btnRLiquidez = new Button();
            btnEResultados = new Button();
            btnBGeneral = new Button();
            btnMayor = new Button();
            btnDiario = new Button();
            btnCuentas = new Button();
            btnInicio = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panelRedireccion = new Panel();
            barraTitulo.SuspendLayout();
            opcionesBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBarraTituloCerrar).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.Goldenrod;
            barraTitulo.Controls.Add(opcionesBarraTitulo);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1650, 50);
            barraTitulo.TabIndex = 0;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // opcionesBarraTitulo
            // 
            opcionesBarraTitulo.Controls.Add(btnMaximo);
            opcionesBarraTitulo.Controls.Add(btnRestaurar);
            opcionesBarraTitulo.Controls.Add(btnMenos);
            opcionesBarraTitulo.Controls.Add(btnBarraTituloCerrar);
            opcionesBarraTitulo.Dock = DockStyle.Right;
            opcionesBarraTitulo.Location = new Point(1409, 0);
            opcionesBarraTitulo.Name = "opcionesBarraTitulo";
            opcionesBarraTitulo.Size = new Size(241, 50);
            opcionesBarraTitulo.TabIndex = 2;
            // 
            // btnMaximo
            // 
            btnMaximo.Image = (Image)resources.GetObject("btnMaximo.Image");
            btnMaximo.Location = new Point(123, 3);
            btnMaximo.Name = "btnMaximo";
            btnMaximo.Size = new Size(48, 42);
            btnMaximo.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximo.TabIndex = 3;
            btnMaximo.TabStop = false;
            btnMaximo.Click += btnMaximo_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(123, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(48, 42);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 5;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMenos
            // 
            btnMenos.Image = (Image)resources.GetObject("btnMenos.Image");
            btnMenos.Location = new Point(50, 5);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(48, 42);
            btnMenos.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenos.TabIndex = 4;
            btnMenos.TabStop = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnBarraTituloCerrar
            // 
            btnBarraTituloCerrar.Image = (Image)resources.GetObject("btnBarraTituloCerrar.Image");
            btnBarraTituloCerrar.Location = new Point(190, 5);
            btnBarraTituloCerrar.Name = "btnBarraTituloCerrar";
            btnBarraTituloCerrar.Size = new Size(48, 42);
            btnBarraTituloCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnBarraTituloCerrar.TabIndex = 2;
            btnBarraTituloCerrar.TabStop = false;
            btnBarraTituloCerrar.Click += btnBarraTituloCerrar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 53, 80);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnIngresarPartida);
            panelMenu.Controls.Add(btnRLiquidez);
            panelMenu.Controls.Add(btnEResultados);
            panelMenu.Controls.Add(btnBGeneral);
            panelMenu.Controls.Add(btnMayor);
            panelMenu.Controls.Add(btnDiario);
            panelMenu.Controls.Add(btnCuentas);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 50);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(363, 850);
            panelMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 659);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(16, 0, 0, 0);
            btnSalir.Size = new Size(363, 67);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "   Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngresarPartida
            // 
            btnIngresarPartida.Dock = DockStyle.Top;
            btnIngresarPartida.FlatAppearance.BorderSize = 0;
            btnIngresarPartida.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnIngresarPartida.FlatStyle = FlatStyle.Flat;
            btnIngresarPartida.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarPartida.ForeColor = Color.White;
            btnIngresarPartida.Image = (Image)resources.GetObject("btnIngresarPartida.Image");
            btnIngresarPartida.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresarPartida.Location = new Point(0, 592);
            btnIngresarPartida.Name = "btnIngresarPartida";
            btnIngresarPartida.Padding = new Padding(16, 0, 0, 0);
            btnIngresarPartida.Size = new Size(363, 67);
            btnIngresarPartida.TabIndex = 9;
            btnIngresarPartida.Text = "   Ingresar Partida";
            btnIngresarPartida.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresarPartida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresarPartida.UseVisualStyleBackColor = true;
            // 
            // btnRLiquidez
            // 
            btnRLiquidez.Dock = DockStyle.Top;
            btnRLiquidez.FlatAppearance.BorderSize = 0;
            btnRLiquidez.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnRLiquidez.FlatStyle = FlatStyle.Flat;
            btnRLiquidez.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRLiquidez.ForeColor = Color.White;
            btnRLiquidez.Image = (Image)resources.GetObject("btnRLiquidez.Image");
            btnRLiquidez.ImageAlign = ContentAlignment.MiddleLeft;
            btnRLiquidez.Location = new Point(0, 525);
            btnRLiquidez.Name = "btnRLiquidez";
            btnRLiquidez.Padding = new Padding(16, 0, 0, 0);
            btnRLiquidez.Size = new Size(363, 67);
            btnRLiquidez.TabIndex = 8;
            btnRLiquidez.Text = "   Razones de LIquidez";
            btnRLiquidez.TextAlign = ContentAlignment.MiddleLeft;
            btnRLiquidez.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRLiquidez.UseVisualStyleBackColor = true;
            // 
            // btnEResultados
            // 
            btnEResultados.Dock = DockStyle.Top;
            btnEResultados.FlatAppearance.BorderSize = 0;
            btnEResultados.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnEResultados.FlatStyle = FlatStyle.Flat;
            btnEResultados.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEResultados.ForeColor = Color.White;
            btnEResultados.Image = (Image)resources.GetObject("btnEResultados.Image");
            btnEResultados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEResultados.Location = new Point(0, 458);
            btnEResultados.Name = "btnEResultados";
            btnEResultados.Padding = new Padding(16, 0, 0, 0);
            btnEResultados.Size = new Size(363, 67);
            btnEResultados.TabIndex = 7;
            btnEResultados.Text = "   Estado de Resultado";
            btnEResultados.TextAlign = ContentAlignment.MiddleLeft;
            btnEResultados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEResultados.UseVisualStyleBackColor = true;
            // 
            // btnBGeneral
            // 
            btnBGeneral.Dock = DockStyle.Top;
            btnBGeneral.FlatAppearance.BorderSize = 0;
            btnBGeneral.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnBGeneral.FlatStyle = FlatStyle.Flat;
            btnBGeneral.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBGeneral.ForeColor = Color.White;
            btnBGeneral.Image = (Image)resources.GetObject("btnBGeneral.Image");
            btnBGeneral.ImageAlign = ContentAlignment.MiddleLeft;
            btnBGeneral.Location = new Point(0, 391);
            btnBGeneral.Name = "btnBGeneral";
            btnBGeneral.Padding = new Padding(16, 0, 0, 0);
            btnBGeneral.Size = new Size(363, 67);
            btnBGeneral.TabIndex = 6;
            btnBGeneral.Text = "   Balance General";
            btnBGeneral.TextAlign = ContentAlignment.MiddleLeft;
            btnBGeneral.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBGeneral.UseVisualStyleBackColor = true;
            // 
            // btnMayor
            // 
            btnMayor.Dock = DockStyle.Top;
            btnMayor.FlatAppearance.BorderSize = 0;
            btnMayor.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnMayor.FlatStyle = FlatStyle.Flat;
            btnMayor.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMayor.ForeColor = Color.White;
            btnMayor.Image = (Image)resources.GetObject("btnMayor.Image");
            btnMayor.ImageAlign = ContentAlignment.MiddleLeft;
            btnMayor.Location = new Point(0, 324);
            btnMayor.Name = "btnMayor";
            btnMayor.Padding = new Padding(16, 0, 0, 0);
            btnMayor.Size = new Size(363, 67);
            btnMayor.TabIndex = 5;
            btnMayor.Text = "   Libro Mayor";
            btnMayor.TextAlign = ContentAlignment.MiddleLeft;
            btnMayor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMayor.UseVisualStyleBackColor = true;
            // 
            // btnDiario
            // 
            btnDiario.Dock = DockStyle.Top;
            btnDiario.FlatAppearance.BorderSize = 0;
            btnDiario.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnDiario.FlatStyle = FlatStyle.Flat;
            btnDiario.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiario.ForeColor = Color.White;
            btnDiario.Image = (Image)resources.GetObject("btnDiario.Image");
            btnDiario.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiario.Location = new Point(0, 257);
            btnDiario.Name = "btnDiario";
            btnDiario.Padding = new Padding(16, 0, 0, 0);
            btnDiario.Size = new Size(363, 67);
            btnDiario.TabIndex = 4;
            btnDiario.Text = "   Libro Diario";
            btnDiario.TextAlign = ContentAlignment.MiddleLeft;
            btnDiario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDiario.UseVisualStyleBackColor = true;
            // 
            // btnCuentas
            // 
            btnCuentas.Dock = DockStyle.Top;
            btnCuentas.FlatAppearance.BorderSize = 0;
            btnCuentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnCuentas.FlatStyle = FlatStyle.Flat;
            btnCuentas.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuentas.ForeColor = Color.White;
            btnCuentas.Image = (Image)resources.GetObject("btnCuentas.Image");
            btnCuentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCuentas.Location = new Point(0, 190);
            btnCuentas.Name = "btnCuentas";
            btnCuentas.Padding = new Padding(16, 0, 0, 0);
            btnCuentas.Size = new Size(363, 67);
            btnCuentas.TabIndex = 3;
            btnCuentas.Text = "   Cuentas";
            btnCuentas.TextAlign = ContentAlignment.MiddleLeft;
            btnCuentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCuentas.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 123);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(16, 0, 0, 0);
            btnInicio.Size = new Size(363, 67);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "   Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(panelRedireccion);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(363, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1287, 850);
            panelContenedor.TabIndex = 2;
            panelContenedor.MouseDown += panelContenedor_MouseDown;
            panelContenedor.MouseMove += panelContenedor_MouseMove;
            panelContenedor.MouseUp += panelContenedor_MouseUp;
            // 
            // panelRedireccion
            // 
            panelRedireccion.Anchor = AnchorStyles.Bottom;
            panelRedireccion.BackColor = Color.White;
            panelRedireccion.Location = new Point(1169, 765);
            panelRedireccion.Name = "panelRedireccion";
            panelRedireccion.Size = new Size(118, 85);
            panelRedireccion.TabIndex = 0;
            panelRedireccion.MouseDown += panelRedireccion_MouseDown;
            panelRedireccion.MouseMove += panelRedireccion_MouseMove;
            panelRedireccion.MouseUp += panelRedireccion_MouseUp;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 900);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            barraTitulo.ResumeLayout(false);
            opcionesBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMaximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBarraTituloCerrar).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel barraTitulo;
        private Panel panelMenu;
        private Panel opcionesBarraTitulo;
        private PictureBox btnBarraTituloCerrar;
        private PictureBox pictureBox1;
        private PictureBox btnMenos;
        private PictureBox btnMaximo;
        private PictureBox btnRestaurar;
        private Button btnInicio;
        private Button btnRLiquidez;
        private Button btnEResultados;
        private Button btnBGeneral;
        private Button btnMayor;
        private Button btnDiario;
        private Button btnCuentas;
        private Button btnIngresarPartida;
        private Button btnSalir;
        private Panel panelContenedor;
        private Panel panelRedireccion;
    }
}