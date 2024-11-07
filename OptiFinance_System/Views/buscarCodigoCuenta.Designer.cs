namespace OptiFinance_System.Views
{
    partial class buscarCodigoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarCodigoCuenta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSuperior = new Panel();
            btnClose = new PictureBox();
            panelContenedor = new Panel();
            txtCapturarCode = new TextBox();
            txtCodigo = new TextBox();
            btnGuardar = new Button();
            panel1 = new Panel();
            dataGridCodigos = new DataGridView();
            nombres = new DataGridViewTextBoxColumn();
            codigos = new DataGridViewTextBoxColumn();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelContenedor.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCodigos).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Goldenrod;
            panelSuperior.Controls.Add(btnClose);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(814, 54);
            panelSuperior.TabIndex = 0;
            panelSuperior.MouseDown += panelSuperior_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(752, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(62, 51);
            btnClose.SizeMode = PictureBoxSizeMode.CenterImage;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(txtCapturarCode);
            panelContenedor.Controls.Add(txtCodigo);
            panelContenedor.Controls.Add(btnGuardar);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 54);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(814, 530);
            panelContenedor.TabIndex = 1;
            // 
            // txtCapturarCode
            // 
            txtCapturarCode.BackColor = Color.FromArgb(245, 245, 242);
            txtCapturarCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapturarCode.Location = new Point(514, 27);
            txtCapturarCode.Name = "txtCapturarCode";
            txtCapturarCode.ReadOnly = true;
            txtCapturarCode.Size = new Size(251, 34);
            txtCapturarCode.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(245, 245, 242);
            txtCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(43, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Ingrese el nombre de la cuenta y de click en la tabla";
            txtCodigo.Size = new Size(456, 34);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyUp += txtCodigo_KeyUp;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(31, 58, 93);
            btnGuardar.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(596, 478);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Agregar Codigo";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridCodigos);
            panel1.Location = new Point(43, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 400);
            panel1.TabIndex = 0;
            // 
            // dataGridCodigos
            // 
            dataGridCodigos.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCodigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCodigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCodigos.Columns.AddRange(new DataGridViewColumn[] { nombres, codigos });
            dataGridCodigos.Dock = DockStyle.Fill;
            dataGridCodigos.EnableHeadersVisualStyles = false;
            dataGridCodigos.Location = new Point(0, 0);
            dataGridCodigos.Name = "dataGridCodigos";
            dataGridCodigos.ReadOnly = true;
            dataGridCodigos.RowHeadersWidth = 51;
            dataGridCodigos.RowTemplate.Height = 29;
            dataGridCodigos.Size = new Size(722, 400);
            dataGridCodigos.TabIndex = 0;
            dataGridCodigos.CellClick += dataGridCodigos_CellClick;
            // 
            // nombres
            // 
            nombres.HeaderText = "Cuentas";
            nombres.MinimumWidth = 6;
            nombres.Name = "nombres";
            nombres.ReadOnly = true;
            nombres.Width = 400;
            // 
            // codigos
            // 
            codigos.HeaderText = "Códigos ";
            codigos.MinimumWidth = 6;
            codigos.Name = "codigos";
            codigos.ReadOnly = true;
            codigos.Width = 270;
            // 
            // buscarCodigoCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 584);
            Controls.Add(panelContenedor);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "buscarCodigoCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "buscarCodigoCuenta";
            Load += buscarCodigoCuenta_Load;
            panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCodigos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private PictureBox btnClose;
        private Panel panelContenedor;
        private Panel panel1;
        private DataGridView dataGridCodigos;
        private Button btnGuardar;
        private TextBox txtCodigo;
        private DataGridViewTextBoxColumn nombres;
        private DataGridViewTextBoxColumn codigos;
        private TextBox txtCapturarCode;
    }
}