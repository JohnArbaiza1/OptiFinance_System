namespace OptiFinance_System.Views
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            Container = new Panel();
            lblLogin = new Label();
            label8 = new Label();
            btnRegistrar = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtConfirmPass = new TextBox();
            txtPass = new TextBox();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtUsuario = new TextBox();
            label7 = new Label();
            btnSalir = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Container
            // 
            Container.Controls.Add(lblLogin);
            Container.Controls.Add(label8);
            Container.Controls.Add(btnRegistrar);
            Container.Controls.Add(pictureBox3);
            Container.Controls.Add(label1);
            Container.Controls.Add(tableLayoutPanel1);
            Container.Controls.Add(btnSalir);
            Container.Controls.Add(pictureBox2);
            Container.Controls.Add(pictureBox1);
            Container.Dock = DockStyle.Fill;
            Container.Location = new Point(0, 0);
            Container.Name = "Container";
            Container.Size = new Size(1039, 589);
            Container.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.Highlight;
            lblLogin.Location = new Point(888, 549);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(122, 20);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "Inicia Sesión";
            lblLogin.Click += lblLogin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(713, 549);
            label8.Name = "label8";
            label8.Size = new Size(185, 20);
            label8.TabIndex = 18;
            label8.Text = "¿Ya tienes cuenta? ";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(254, 214, 0);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(626, 483);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(358, 49);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(599, 477);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(406, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(697, 126);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 15;
            label1.Text = "Regístrate Ahora ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(txtConfirmPass, 1, 5);
            tableLayoutPanel1.Controls.Add(txtPass, 1, 4);
            tableLayoutPanel1.Controls.Add(txtCorreo, 1, 3);
            tableLayoutPanel1.Controls.Add(txtApellido, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtUsuario, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Location = new Point(593, 167);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(418, 295);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.Location = new Point(139, 248);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.PlaceholderText = "****";
            txtConfirmPass.Size = new Size(276, 34);
            txtConfirmPass.TabIndex = 27;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(139, 199);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "****";
            txtPass.Size = new Size(276, 34);
            txtPass.TabIndex = 26;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(139, 150);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "carlos@gmail.com";
            txtCorreo.Size = new Size(276, 34);
            txtCorreo.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(139, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Martínez";
            txtApellido.Size = new Size(276, 34);
            txtApellido.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(3, 49);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 17;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 16;
            label2.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(3, 98);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 18;
            label4.Text = "Apellido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(3, 245);
            label6.Name = "label6";
            label6.Size = new Size(119, 42);
            label6.TabIndex = 20;
            label6.Text = "Confirmar Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(139, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Carlos";
            txtNombre.Size = new Size(276, 34);
            txtNombre.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(3, 196);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 19;
            label5.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(139, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Carlos026";
            txtUsuario.Size = new Size(276, 34);
            txtUsuario.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(3, 147);
            label7.Name = "label7";
            label7.Size = new Size(85, 24);
            label7.TabIndex = 21;
            label7.Text = "Correo:";
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(972, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(64, 64);
            btnSalir.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSalir.TabIndex = 13;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(743, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 589);
            Controls.Add(Container);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Container;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnSalir;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtConfirmPass;
        private TextBox txtPass;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private PictureBox pictureBox3;
        private Label label8;
        private Label lblLogin;
    }
}