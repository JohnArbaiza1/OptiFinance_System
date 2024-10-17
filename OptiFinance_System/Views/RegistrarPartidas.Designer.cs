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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPartidas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            btnNew = new Button();
            radiobtnHaber = new RadioButton();
            radiobtnDebe = new RadioButton();
            btnValor = new TextBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
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
            panel1.Size = new Size(1270, 850);
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
            groupBox1.Location = new Point(25, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1221, 745);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Datos";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(btnNew);
            groupBox2.Controls.Add(radiobtnHaber);
            groupBox2.Controls.Add(radiobtnDebe);
            groupBox2.Controls.Add(btnValor);
            groupBox2.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(989, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 407);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresa el valor";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(71, 102, 121);
            btnSave.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(6, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 59);
            btnSave.TabIndex = 15;
            btnSave.Text = "   Guardar     Registros";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(187, 45, 59);
            btnCancelar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(6, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(214, 47);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "   Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(11, 94, 215);
            btnRegistrar.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.Location = new Point(6, 133);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(214, 47);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "   Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(49, 210, 242);
            btnNew.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.Location = new Point(6, 186);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(214, 47);
            btnNew.TabIndex = 14;
            btnNew.Text = "   Nuevo asiento";
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = false;
            // 
            // radiobtnHaber
            // 
            radiobtnHaber.AutoSize = true;
            radiobtnHaber.Location = new Point(118, 82);
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
            radiobtnDebe.Location = new Point(17, 82);
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
            btnValor.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor.Location = new Point(6, 36);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(214, 31);
            btnValor.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(187, 45, 59);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(917, 67);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 47);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(21, 110, 69);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(845, 67);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 47);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(0, 138);
            panel4.Name = "panel4";
            panel4.Size = new Size(983, 577);
            panel4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Column2, Column3, Column4, Column1 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
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
            Fecha.Width = 160;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cuenta";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 224;
            // 
            // Column3
            // 
            Column3.HeaderText = "Codigo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 137;
            // 
            // Column4
            // 
            Column4.HeaderText = "Debe";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 205;
            // 
            // Column1
            // 
            Column1.HeaderText = "Haber";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 205;
            // 
            // comboFecha
            // 
            comboFecha.FormattingEnabled = true;
            comboFecha.Location = new Point(261, 74);
            comboFecha.Name = "comboFecha";
            comboFecha.Size = new Size(325, 34);
            comboFecha.TabIndex = 9;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(603, 74);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(236, 34);
            txtCodigo.TabIndex = 5;
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
            label5.Location = new Point(1082, 138);
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
            label4.Text = "Codigo:";
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
            dataFecha.Format = DateTimePickerFormat.Short;
            dataFecha.Location = new Point(6, 74);
            dataFecha.Name = "dataFecha";
            dataFecha.Size = new Size(232, 34);
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
            label1.Location = new Point(412, 9);
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
            // 
            // RegistrarPartidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 850);
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
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
    }
}