namespace OptiFinance_System.Views
{
    partial class RegistrarPartidas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPartidas));
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            btnSave = new Button();
            btnNew = new Button();
            radiobtnHaber = new RadioButton();
            radiobtnDebe = new RadioButton();
            btnValor = new TextBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Cuenta = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Debe = new DataGridViewTextBoxColumn();
            Haber = new DataGridViewTextBoxColumn();
            comboFecha = new ComboBox();
            txtCodigo = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dataFecha = new DateTimePicker();
            panel2 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(1270, 851);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(1270, 773);
            panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(comboFecha);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataFecha);
            groupBox1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(34, 53, 80);
            groupBox1.Location = new Point(25, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1221, 745);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Datos";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(245, 245, 242);
            textBox1.Enabled = false;
            textBox1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(995, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 117);
            textBox1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(997, 48);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 14;
            label6.Text = "Detalle:";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnNew);
            groupBox2.Controls.Add(radiobtnHaber);
            groupBox2.Controls.Add(radiobtnDebe);
            groupBox2.Controls.Add(btnValor);
            groupBox2.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(989, 211);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(232, 522);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresa el valor";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(44, 161, 232);
            btnEditar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(8, 181);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(10, 0, 0, 0);
            btnEditar.Size = new Size(214, 61);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "   Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(234, 130, 6);
            btnCancelar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(6, 307);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(214, 52);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "   Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(31, 58, 93);
            btnRegistrar.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.Location = new Point(6, 365);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(214, 61);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "   Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(31, 58, 93);
            btnSave.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(6, 437);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 59);
            btnSave.TabIndex = 15;
            btnSave.Text = "   Guardar     Registros";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(44, 161, 232);
            btnNew.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.Location = new Point(8, 114);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(214, 61);
            btnNew.TabIndex = 14;
            btnNew.Text = "   Nuevo asiento";
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // radiobtnHaber
            // 
            radiobtnHaber.AutoSize = true;
            radiobtnHaber.Location = new Point(120, 74);
            radiobtnHaber.Name = "radiobtnHaber";
            radiobtnHaber.Size = new Size(83, 25);
            radiobtnHaber.TabIndex = 2;
            radiobtnHaber.TabStop = true;
            radiobtnHaber.Text = "Haber";
            radiobtnHaber.UseVisualStyleBackColor = true;
            // 
            // radiobtnDebe
            // 
            radiobtnDebe.Anchor = AnchorStyles.Top;
            radiobtnDebe.AutoSize = true;
            radiobtnDebe.Location = new Point(23, 74);
            radiobtnDebe.Name = "radiobtnDebe";
            radiobtnDebe.Size = new Size(76, 25);
            radiobtnDebe.TabIndex = 1;
            radiobtnDebe.TabStop = true;
            radiobtnDebe.Text = "Debe";
            radiobtnDebe.UseVisualStyleBackColor = true;
            // 
            // btnValor
            // 
            btnValor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnValor.BackColor = Color.FromArgb(245, 245, 242);
            btnValor.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor.Location = new Point(6, 37);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(220, 31);
            btnValor.TabIndex = 0;
            btnValor.KeyPress += btnValor_KeyPress;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(234, 130, 6);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(917, 67);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 47);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(215, 143, 35);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(845, 67);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 47);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(0, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(983, 577);
            panel4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Cuenta, Codigo, Debe, Haber });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(983, 577);
            dataGridView1.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 160;
            // 
            // Cuenta
            // 
            Cuenta.HeaderText = "Cuenta";
            Cuenta.MinimumWidth = 6;
            Cuenta.Name = "Cuenta";
            Cuenta.ReadOnly = true;
            Cuenta.Width = 400;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Debe
            // 
            Debe.HeaderText = "Debe";
            Debe.MinimumWidth = 6;
            Debe.Name = "Debe";
            Debe.ReadOnly = true;
            Debe.Width = 200;
            // 
            // Haber
            // 
            Haber.HeaderText = "Haber";
            Haber.MinimumWidth = 6;
            Haber.Name = "Haber";
            Haber.ReadOnly = true;
            Haber.Width = 200;
            // 
            // comboFecha
            // 
            comboFecha.BackColor = Color.FromArgb(245, 245, 242);
            comboFecha.FormattingEnabled = true;
            comboFecha.Location = new Point(261, 75);
            comboFecha.Name = "comboFecha";
            comboFecha.Size = new Size(325, 34);
            comboFecha.TabIndex = 9;
            comboFecha.TextChanged += comboFecha_TextChanged;
            comboFecha.KeyPress += comboFecha_KeyPress;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(245, 245, 242);
            txtCodigo.Location = new Point(603, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(236, 34);
            txtCodigo.TabIndex = 5;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 4;
            label3.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1082, 139);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(598, 48);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 7;
            label4.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(261, 48);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 6;
            label2.Text = "Cuenta:";
            // 
            // dataFecha
            // 
            dataFecha.CalendarMonthBackground = Color.FromArgb(245, 245, 242);
            dataFecha.Format = DateTimePickerFormat.Short;
            dataFecha.Location = new Point(6, 75);
            dataFecha.Name = "dataFecha";
            dataFecha.Size = new Size(233, 34);
            dataFecha.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAtras);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 65);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(411, 9);
            label1.Name = "label1";
            label1.Size = new Size(452, 45);
            label1.TabIndex = 6;
            label1.Text = "INGRESAR PARTIDAS";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 5;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(234, 130, 6);
            btnEliminar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(8, 248);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(16, 0, 0, 0);
            btnEliminar.Size = new Size(212, 53);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // RegistrarPartidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 851);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarPartidas";
            Text = "RegistrarPartidas";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label3;
        private TextBox txtCodigo;
        private Label label2;
        private Label label4;
        private Label label5;
        private DateTimePicker dataFecha;
        private ComboBox comboFecha;
        private Button btnBuscar;
        private Panel panel4;
        private Button btnLimpiar;
        private GroupBox groupBox2;
        private RadioButton radiobtnHaber;
        private RadioButton radiobtnDebe;
        private TextBox btnValor;
        private DataGridView dataGridView1;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Button btnNew;
        private Button btnSave;
        private TextBox textBox1;
        private Label label6;
        private Button btnEditar;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cuenta;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Debe;
        private DataGridViewTextBoxColumn Haber;
        private Button btnEliminar;
    }
}