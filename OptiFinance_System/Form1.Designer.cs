namespace OptiFinance_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnIngresar = new Button();
            btnSalir = new PictureBox();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            lblRegistro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.sin_fondo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(629, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(744, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(666, 145);
            label1.Name = "label1";
            label1.Size = new Size(317, 24);
            label1.TabIndex = 2;
            label1.Text = "Inicie Sesión a Continuación ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(654, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(346, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(654, 323);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(346, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.MenuBar;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(666, 335);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.MenuBar;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(666, 217);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(229, 234, 238);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.CausesValidation = false;
            txtUser.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.ImeMode = ImeMode.NoControl;
            txtUser.Location = new Point(719, 228);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(264, 29);
            txtUser.TabIndex = 7;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(229, 234, 238);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(719, 344);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(264, 22);
            txtPassword.TabIndex = 8;
            txtPassword.Text = "PASSWORD";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.KeyPress += txtPassword_KeyPress;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(654, 181);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(654, 299);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Gold;
            btnIngresar.BackgroundImageLayout = ImageLayout.None;
            btnIngresar.FlatAppearance.BorderColor = Color.Gold;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(686, 441);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(281, 55);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(971, -3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(64, 64);
            btnSalir.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSalir.TabIndex = 12;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(656, 437);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(346, 63);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(728, 396);
            label4.Name = "label4";
            label4.Size = new Size(272, 20);
            label4.TabIndex = 14;
            label4.Text = "¿Has olvidado tu contraseña?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(719, 519);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 15;
            label5.Text = "¿Eres nuevo? ";
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistro.ForeColor = SystemColors.Highlight;
            lblRegistro.Location = new Point(847, 519);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(101, 20);
            lblRegistro.TabIndex = 16;
            lblRegistro.Text = "Regístrate";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1039, 589);
            Controls.Add(lblRegistro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox7);
            Controls.Add(btnSalir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private PictureBox btnSalir;
        private PictureBox pictureBox7;
        private Label label4;
        private Label label5;
        private Label lblRegistro;
    }
}
