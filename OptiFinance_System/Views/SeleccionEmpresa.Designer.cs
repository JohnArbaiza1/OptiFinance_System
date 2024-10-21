namespace OptiFinance_System.Views
{
    partial class SeleccionEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionEmpresa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnSeleccionar = new Button();
            txtNombreEmpresa = new TextBox();
            btnBuscar = new Button();
            txtSearchEmpresa = new TextBox();
            panelEmpresasSelect = new Panel();
            dataEmpresas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            groupBox1.SuspendLayout();
            panelEmpresasSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEmpresas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAtras);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(402, 9);
            label1.Name = "label1";
            label1.Size = new Size(471, 45);
            label1.TabIndex = 4;
            label1.Text = "Empresas Registradas.";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 3;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(35, 55, 80);
            label2.Location = new Point(143, 75);
            label2.Name = "label2";
            label2.Size = new Size(1010, 26);
            label2.TabIndex = 5;
            label2.Text = "En esta sección podrás observar las empresas registradas y seleccionar la empresa con la";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(539, 111);
            label3.Name = "label3";
            label3.Size = new Size(190, 26);
            label3.TabIndex = 6;
            label3.Text = "deseas trabajar.";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnSeleccionar);
            groupBox1.Controls.Add(txtNombreEmpresa);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtSearchEmpresa);
            groupBox1.Controls.Add(panelEmpresasSelect);
            groupBox1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox1.Location = new Point(51, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1169, 651);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tus Empresas:";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(31, 58, 93);
            btnSeleccionar.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(568, 53);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(285, 42);
            btnSeleccionar.TabIndex = 9;
            btnSeleccionar.Text = "Seleccionar esta empresa";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.BackColor = Color.FromArgb(245, 245, 242);
            txtNombreEmpresa.Location = new Point(859, 59);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.ReadOnly = true;
            txtNombreEmpresa.Size = new Size(286, 34);
            txtNombreEmpresa.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(215, 143, 35);
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(431, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(5, 0, 0, 0);
            btnBuscar.Size = new Size(131, 39);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = " Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtSearchEmpresa
            // 
            txtSearchEmpresa.BackColor = Color.FromArgb(245, 245, 242);
            txtSearchEmpresa.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchEmpresa.Location = new Point(26, 53);
            txtSearchEmpresa.Name = "txtSearchEmpresa";
            txtSearchEmpresa.Size = new Size(399, 39);
            txtSearchEmpresa.TabIndex = 1;
            // 
            // panelEmpresasSelect
            // 
            panelEmpresasSelect.Controls.Add(dataEmpresas);
            panelEmpresasSelect.Location = new Point(26, 121);
            panelEmpresasSelect.Name = "panelEmpresasSelect";
            panelEmpresasSelect.Size = new Size(1120, 501);
            panelEmpresasSelect.TabIndex = 0;
            // 
            // dataEmpresas
            // 
            dataEmpresas.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEmpresas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataEmpresas.Dock = DockStyle.Fill;
            dataEmpresas.EnableHeadersVisualStyles = false;
            dataEmpresas.Location = new Point(0, 0);
            dataEmpresas.Name = "dataEmpresas";
            dataEmpresas.RowHeadersWidth = 51;
            dataEmpresas.RowTemplate.Height = 29;
            dataEmpresas.Size = new Size(1120, 501);
            dataEmpresas.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nit";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giro Economico";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Representante Legal";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Direccion";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Telefono";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // SeleccionEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 851);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeleccionEmpresa";
            Text = "SeleccionEmpresa";
            Load += SeleccionEmpresa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelEmpresasSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataEmpresas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnAtras;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Panel panelEmpresasSelect;
        private DataGridView dataEmpresas;
        private TextBox txtSearchEmpresa;
        private Button btnBuscar;
        private TextBox txtNombreEmpresa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnSeleccionar;
    }
}