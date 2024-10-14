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
            btnInfo = new Button();
            btnUsuarios = new Button();
            btnSalir = new Button();
            btnEstados = new Button();
            btnIngresarPartida = new Button();
            btnRLiquidez = new Button();
            btnLibros = new Button();
            btnCuentas = new Button();
            panelEstados = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            btnBGeneral = new Button();
            btnEResultados = new Button();
            btnInicio = new Button();
            pictureBox1 = new PictureBox();
            PanelCuentas = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panelLibros = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            btnDiario = new Button();
            btnMayor = new Button();
            panelContenedor = new Panel();
            panelRedireccion = new Panel();
            barraTitulo.SuspendLayout();
            opcionesBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBarraTituloCerrar).BeginInit();
            panelMenu.SuspendLayout();
            panelEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelCuentas.SuspendLayout();
            panelLibros.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.Goldenrod;
            barraTitulo.Controls.Add(opcionesBarraTitulo);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(380, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1270, 50);
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
            opcionesBarraTitulo.Location = new Point(1029, 0);
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
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(34, 53, 80);
            panelMenu.Controls.Add(btnInfo);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnEstados);
            panelMenu.Controls.Add(btnIngresarPartida);
            panelMenu.Controls.Add(btnRLiquidez);
            panelMenu.Controls.Add(btnLibros);
            panelMenu.Controls.Add(btnCuentas);
            panelMenu.Controls.Add(panelEstados);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(PanelCuentas);
            panelMenu.Controls.Add(panelLibros);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(380, 900);
            panelMenu.TabIndex = 1;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.White;
            btnInfo.Image = (Image)resources.GetObject("btnInfo.Image");
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(3, 1036);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(16, 0, 0, 0);
            btnInfo.Size = new Size(380, 67);
            btnInfo.TabIndex = 16;
            btnInfo.Text = "   Información de la empresa";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 963);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(16, 0, 0, 0);
            btnUsuarios.Size = new Size(380, 67);
            btnUsuarios.TabIndex = 13;
            btnUsuarios.Text = "   Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 1114);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(16, 0, 0, 0);
            btnSalir.Size = new Size(380, 67);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "   Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEstados
            // 
            btnEstados.FlatAppearance.BorderSize = 0;
            btnEstados.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnEstados.FlatStyle = FlatStyle.Flat;
            btnEstados.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstados.ForeColor = Color.White;
            btnEstados.Image = (Image)resources.GetObject("btnEstados.Image");
            btnEstados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstados.Location = new Point(0, 607);
            btnEstados.Name = "btnEstados";
            btnEstados.Padding = new Padding(16, 0, 0, 0);
            btnEstados.Size = new Size(380, 67);
            btnEstados.TabIndex = 12;
            btnEstados.Text = "   Estados Financieros";
            btnEstados.TextAlign = ContentAlignment.MiddleLeft;
            btnEstados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstados.UseVisualStyleBackColor = true;
            btnEstados.Click += btnEstados_Click;
            // 
            // btnIngresarPartida
            // 
            btnIngresarPartida.FlatAppearance.BorderSize = 0;
            btnIngresarPartida.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnIngresarPartida.FlatStyle = FlatStyle.Flat;
            btnIngresarPartida.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarPartida.ForeColor = Color.White;
            btnIngresarPartida.Image = (Image)resources.GetObject("btnIngresarPartida.Image");
            btnIngresarPartida.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresarPartida.Location = new Point(0, 890);
            btnIngresarPartida.Name = "btnIngresarPartida";
            btnIngresarPartida.Padding = new Padding(16, 0, 0, 0);
            btnIngresarPartida.Size = new Size(380, 67);
            btnIngresarPartida.TabIndex = 9;
            btnIngresarPartida.Text = "   Ingresar Partida";
            btnIngresarPartida.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresarPartida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresarPartida.UseVisualStyleBackColor = true;
            // 
            // btnRLiquidez
            // 
            btnRLiquidez.FlatAppearance.BorderSize = 0;
            btnRLiquidez.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnRLiquidez.FlatStyle = FlatStyle.Flat;
            btnRLiquidez.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRLiquidez.ForeColor = Color.White;
            btnRLiquidez.Image = (Image)resources.GetObject("btnRLiquidez.Image");
            btnRLiquidez.ImageAlign = ContentAlignment.MiddleLeft;
            btnRLiquidez.Location = new Point(0, 817);
            btnRLiquidez.Name = "btnRLiquidez";
            btnRLiquidez.Padding = new Padding(16, 0, 0, 0);
            btnRLiquidez.Size = new Size(380, 67);
            btnRLiquidez.TabIndex = 8;
            btnRLiquidez.Text = "   Razones de Liquidez";
            btnRLiquidez.TextAlign = ContentAlignment.MiddleLeft;
            btnRLiquidez.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRLiquidez.UseVisualStyleBackColor = true;
            // 
            // btnLibros
            // 
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibros.ForeColor = Color.White;
            btnLibros.Image = (Image)resources.GetObject("btnLibros.Image");
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(0, 394);
            btnLibros.Name = "btnLibros";
            btnLibros.Padding = new Padding(16, 0, 0, 0);
            btnLibros.Size = new Size(380, 67);
            btnLibros.TabIndex = 11;
            btnLibros.Text = "   Libros Contables";
            btnLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
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
            btnCuentas.Size = new Size(383, 67);
            btnCuentas.TabIndex = 3;
            btnCuentas.Text = "   Cuentas";
            btnCuentas.TextAlign = ContentAlignment.MiddleLeft;
            btnCuentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCuentas.UseVisualStyleBackColor = true;
            btnCuentas.Click += btnCuentas_Click;
            // 
            // panelEstados
            // 
            panelEstados.BackColor = Color.FromArgb(35, 55, 80);
            panelEstados.Controls.Add(panel7);
            panelEstados.Controls.Add(panel8);
            panelEstados.Controls.Add(btnBGeneral);
            panelEstados.Controls.Add(btnEResultados);
            panelEstados.Location = new Point(0, 680);
            panelEstados.Name = "panelEstados";
            panelEstados.Size = new Size(380, 143);
            panelEstados.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(254, 214, 0);
            panel7.Location = new Point(3, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 64);
            panel7.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(254, 214, 0);
            panel8.Location = new Point(3, 76);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 64);
            panel8.TabIndex = 14;
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
            btnBGeneral.Location = new Point(0, 0);
            btnBGeneral.Name = "btnBGeneral";
            btnBGeneral.Padding = new Padding(16, 0, 0, 0);
            btnBGeneral.Size = new Size(380, 67);
            btnBGeneral.TabIndex = 6;
            btnBGeneral.Text = "   Balance General";
            btnBGeneral.TextAlign = ContentAlignment.MiddleLeft;
            btnBGeneral.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBGeneral.UseVisualStyleBackColor = true;
            // 
            // btnEResultados
            // 
            btnEResultados.FlatAppearance.BorderSize = 0;
            btnEResultados.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnEResultados.FlatStyle = FlatStyle.Flat;
            btnEResultados.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEResultados.ForeColor = Color.White;
            btnEResultados.Image = (Image)resources.GetObject("btnEResultados.Image");
            btnEResultados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEResultados.Location = new Point(3, 73);
            btnEResultados.Name = "btnEResultados";
            btnEResultados.Padding = new Padding(16, 0, 0, 0);
            btnEResultados.Size = new Size(377, 67);
            btnEResultados.TabIndex = 7;
            btnEResultados.Text = "   Estado de Resultado";
            btnEResultados.TextAlign = ContentAlignment.MiddleLeft;
            btnEResultados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEResultados.UseVisualStyleBackColor = true;
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
            btnInicio.Size = new Size(383, 67);
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
            pictureBox1.Size = new Size(383, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelCuentas
            // 
            PanelCuentas.BackColor = Color.FromArgb(35, 55, 80);
            PanelCuentas.Controls.Add(panel3);
            PanelCuentas.Controls.Add(panel4);
            PanelCuentas.Controls.Add(panel2);
            PanelCuentas.Controls.Add(panel1);
            PanelCuentas.Controls.Add(button2);
            PanelCuentas.Controls.Add(button1);
            PanelCuentas.Location = new Point(0, 257);
            PanelCuentas.Name = "PanelCuentas";
            PanelCuentas.Size = new Size(377, 139);
            PanelCuentas.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(254, 214, 0);
            panel3.Location = new Point(3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 64);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(254, 214, 0);
            panel4.Location = new Point(3, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 64);
            panel4.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(254, 214, 0);
            panel2.Location = new Point(3, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 214, 0);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(9, 67);
            button2.Name = "button2";
            button2.Padding = new Padding(16, 0, 0, 0);
            button2.Size = new Size(377, 67);
            button2.TabIndex = 6;
            button2.Text = "   Catalogo de cuentas";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(16, 0, 0, 0);
            button1.Size = new Size(377, 67);
            button1.TabIndex = 5;
            button1.Text = "   Ingresar Cuenta";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // panelLibros
            // 
            panelLibros.BackColor = Color.FromArgb(35, 55, 80);
            panelLibros.Controls.Add(panel6);
            panelLibros.Controls.Add(panel5);
            panelLibros.Controls.Add(btnDiario);
            panelLibros.Controls.Add(btnMayor);
            panelLibros.Location = new Point(0, 467);
            panelLibros.Name = "panelLibros";
            panelLibros.Size = new Size(380, 134);
            panelLibros.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(254, 214, 0);
            panel6.Location = new Point(3, 70);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 64);
            panel6.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(254, 214, 0);
            panel5.Location = new Point(3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 64);
            panel5.TabIndex = 12;
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
            btnDiario.Location = new Point(0, 0);
            btnDiario.Name = "btnDiario";
            btnDiario.Padding = new Padding(16, 0, 0, 0);
            btnDiario.Size = new Size(380, 67);
            btnDiario.TabIndex = 4;
            btnDiario.Text = "   Libro Diario";
            btnDiario.TextAlign = ContentAlignment.MiddleLeft;
            btnDiario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDiario.UseVisualStyleBackColor = true;
            // 
            // btnMayor
            // 
            btnMayor.FlatAppearance.BorderSize = 0;
            btnMayor.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 143, 35);
            btnMayor.FlatStyle = FlatStyle.Flat;
            btnMayor.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMayor.ForeColor = Color.White;
            btnMayor.Image = (Image)resources.GetObject("btnMayor.Image");
            btnMayor.ImageAlign = ContentAlignment.MiddleLeft;
            btnMayor.Location = new Point(3, 67);
            btnMayor.Name = "btnMayor";
            btnMayor.Padding = new Padding(16, 0, 0, 0);
            btnMayor.Size = new Size(348, 67);
            btnMayor.TabIndex = 5;
            btnMayor.Text = "   Libro Mayor";
            btnMayor.TextAlign = ContentAlignment.MiddleLeft;
            btnMayor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMayor.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(panelRedireccion);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(380, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1270, 850);
            panelContenedor.TabIndex = 2;
            panelContenedor.MouseDown += panelContenedor_MouseDown;
            panelContenedor.MouseMove += panelContenedor_MouseMove;
            panelContenedor.MouseUp += panelContenedor_MouseUp;
            // 
            // panelRedireccion
            // 
            panelRedireccion.Anchor = AnchorStyles.None;
            panelRedireccion.BackColor = Color.White;
            panelRedireccion.Location = new Point(1161, 765);
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
            Controls.Add(barraTitulo);
            Controls.Add(panelMenu);
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
            panelEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelCuentas.ResumeLayout(false);
            panelLibros.ResumeLayout(false);
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
        private Panel PanelCuentas;
        private Button button2;
        private Button button1;
        private Button btnLibros;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panelLibros;
        private Button btnEstados;
        private Panel panel6;
        private Panel panel5;
        private Panel panel8;
        private Panel panel7;
        private Panel panelEstados;
        private Button btnUsuarios;
        private Button btnInfo;
    }
}