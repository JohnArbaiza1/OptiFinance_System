namespace OptiFinance_System.Views
{
    partial class IngresarCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarCuentas));
            panel1 = new Panel();
            panel3 = new Panel();
            btnLimpiar = new Button();
            groupBox2 = new GroupBox();
            richTextBoxCuentas = new RichTextBox();
            groupBox1 = new GroupBox();
            btnCamcelar = new Button();
            btnGuardarCuentas = new Button();
            comboTipoCuenta = new ComboBox();
            txtNombreCuenta = new TextBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            btnSubir = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            comboBoxSubCuenta = new ComboBox();
            checkBoxSubCuenta = new CheckBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 803);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 736);
            panel3.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(234, 130, 6);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(1160, 677);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 47);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxCuentas);
            groupBox2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(681, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 655);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Archivo Subido";
            // 
            // richTextBoxCuentas
            // 
            richTextBoxCuentas.BackColor = Color.White;
            richTextBoxCuentas.Location = new Point(6, 33);
            richTextBoxCuentas.Name = "richTextBoxCuentas";
            richTextBoxCuentas.ReadOnly = true;
            richTextBoxCuentas.Size = new Size(533, 616);
            richTextBoxCuentas.TabIndex = 0;
            richTextBoxCuentas.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(comboBoxSubCuenta);
            groupBox1.Controls.Add(checkBoxSubCuenta);
            groupBox1.Controls.Add(btnCamcelar);
            groupBox1.Controls.Add(btnGuardarCuentas);
            groupBox1.Controls.Add(comboTipoCuenta);
            groupBox1.Controls.Add(txtNombreCuenta);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnSubir);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 655);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Datos";
            // 
            // btnCamcelar
            // 
            btnCamcelar.BackColor = Color.FromArgb(234, 130, 6);
            btnCamcelar.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCamcelar.ForeColor = Color.White;
            btnCamcelar.Image = (Image)resources.GetObject("btnCamcelar.Image");
            btnCamcelar.Location = new Point(79, 510);
            btnCamcelar.Name = "btnCamcelar";
            btnCamcelar.Padding = new Padding(90, 0, 0, 0);
            btnCamcelar.Size = new Size(488, 51);
            btnCamcelar.TabIndex = 17;
            btnCamcelar.Text = "   Cancelar";
            btnCamcelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCamcelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCuentas
            // 
            btnGuardarCuentas.BackColor = Color.FromArgb(31, 58, 93);
            btnGuardarCuentas.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCuentas.ForeColor = Color.White;
            btnGuardarCuentas.Image = (Image)resources.GetObject("btnGuardarCuentas.Image");
            btnGuardarCuentas.Location = new Point(79, 441);
            btnGuardarCuentas.Name = "btnGuardarCuentas";
            btnGuardarCuentas.Padding = new Padding(64, 0, 0, 0);
            btnGuardarCuentas.Size = new Size(488, 51);
            btnGuardarCuentas.TabIndex = 16;
            btnGuardarCuentas.Text = "   Guardar Cuentas";
            btnGuardarCuentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarCuentas.UseVisualStyleBackColor = false;
            btnGuardarCuentas.Click += btnGuardarCuentas_Click;
            // 
            // comboTipoCuenta
            // 
            comboTipoCuenta.BackColor = Color.FromArgb(245, 245, 242);
            comboTipoCuenta.FormattingEnabled = true;
            comboTipoCuenta.Location = new Point(272, 172);
            comboTipoCuenta.Name = "comboTipoCuenta";
            comboTipoCuenta.Size = new Size(331, 34);
            comboTipoCuenta.TabIndex = 15;
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.BackColor = Color.FromArgb(245, 245, 242);
            txtNombreCuenta.Location = new Point(272, 105);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(331, 34);
            txtNombreCuenta.TabIndex = 14;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(245, 245, 242);
            txtCodigo.Location = new Point(272, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(331, 34);
            txtCodigo.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(144, 320);
            label5.Name = "label5";
            label5.Size = new Size(358, 23);
            label5.TabIndex = 12;
            label5.Text = "Agregar Archivo JSON con Cuentas";
            // 
            // btnSubir
            // 
            btnSubir.BackColor = Color.FromArgb(44, 161, 232);
            btnSubir.Image = (Image)resources.GetObject("btnSubir.Image");
            btnSubir.Location = new Point(79, 375);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(488, 51);
            btnSubir.TabIndex = 11;
            btnSubir.UseVisualStyleBackColor = false;
            btnSubir.Click += btnSubir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 179);
            label3.Name = "label3";
            label3.Size = new Size(165, 23);
            label3.TabIndex = 10;
            label3.Text = "Tipo de Cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 111);
            label2.Name = "label2";
            label2.Size = new Size(224, 23);
            label2.TabIndex = 9;
            label2.Text = "Nombre de la Cuenta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 53);
            label4.Name = "label4";
            label4.Size = new Size(190, 23);
            label4.TabIndex = 8;
            label4.Text = "Código de Cuenta:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAtras);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1253, 67);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(444, 45);
            label1.TabIndex = 7;
            label1.Text = "INGRESAR CUENTAS";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 6;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos JSON|*.json";
            openFileDialog1.Title = "Seleccione un archivo JSON con las cuentas";
            // 
            // comboBoxSubCuenta
            // 
            comboBoxSubCuenta.BackColor = Color.FromArgb(245, 245, 242);
            comboBoxSubCuenta.FormattingEnabled = true;
            comboBoxSubCuenta.Location = new Point(272, 232);
            comboBoxSubCuenta.Name = "comboBoxSubCuenta";
            comboBoxSubCuenta.Size = new Size(331, 34);
            comboBoxSubCuenta.TabIndex = 20;
            // 
            // checkBoxSubCuenta
            // 
            checkBoxSubCuenta.AutoSize = true;
            checkBoxSubCuenta.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSubCuenta.Location = new Point(18, 237);
            checkBoxSubCuenta.Name = "checkBoxSubCuenta";
            checkBoxSubCuenta.Size = new Size(145, 27);
            checkBoxSubCuenta.TabIndex = 19;
            checkBoxSubCuenta.Text = "Subcuenta:";
            checkBoxSubCuenta.UseVisualStyleBackColor = true;
            checkBoxSubCuenta.CheckedChanged += checkBoxSubCuenta_CheckedChanged;
            // 
            // IngresarCuentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 803);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngresarCuentas";
            Text = "IngresarCuentas";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btnAtras;
        private Label label1;
        private Panel panel3;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnSubir;
        private TextBox txtCodigo;
        private TextBox txtNombreCuenta;
        private ComboBox comboTipoCuenta;
        private Button btnGuardarCuentas;
        private Button btnCamcelar;
        private GroupBox groupBox2;
        private RichTextBox richTextBoxCuentas;
        private OpenFileDialog openFileDialog1;
        private Button btnLimpiar;
        private ComboBox comboBoxSubCuenta;
        private CheckBox checkBoxSubCuenta;
    }
}