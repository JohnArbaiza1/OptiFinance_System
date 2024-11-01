namespace OptiFinance_System.Views
{
    partial class balanceGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balanceGeneral));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            panel2 = new Panel();
            txtTotalPasyPatri = new TextBox();
            label3 = new Label();
            txtTotalActivo = new TextBox();
            label2 = new Label();
            btnGenerarBalance = new Button();
            ContenedorBalance = new Panel();
            dataBalance = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblFechaBalance = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            panel2.SuspendLayout();
            ContenedorBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBalance).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAtras);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(430, 9);
            label1.Name = "label1";
            label1.Size = new Size(427, 45);
            label1.TabIndex = 7;
            label1.Text = "BALANCE GENERAL";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 4;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTotalPasyPatri);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTotalActivo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnGenerarBalance);
            panel2.Controls.Add(ContenedorBalance);
            panel2.Controls.Add(lblFechaBalance);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 737);
            panel2.TabIndex = 1;
            // 
            // txtTotalPasyPatri
            // 
            txtTotalPasyPatri.BackColor = Color.FromArgb(245, 245, 242);
            txtTotalPasyPatri.Location = new Point(971, 624);
            txtTotalPasyPatri.Name = "txtTotalPasyPatri";
            txtTotalPasyPatri.ReadOnly = true;
            txtTotalPasyPatri.Size = new Size(227, 27);
            txtTotalPasyPatri.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(702, 628);
            label3.Name = "label3";
            label3.Size = new Size(263, 23);
            label3.TabIndex = 13;
            label3.Text = "Total Pasivo + Patrimonio:";
            // 
            // txtTotalActivo
            // 
            txtTotalActivo.BackColor = Color.FromArgb(245, 245, 242);
            txtTotalActivo.Location = new Point(458, 624);
            txtTotalActivo.Name = "txtTotalActivo";
            txtTotalActivo.ReadOnly = true;
            txtTotalActivo.Size = new Size(223, 27);
            txtTotalActivo.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(35, 55, 80);
            label2.Location = new Point(311, 628);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 11;
            label2.Text = "Total Activo:";
            // 
            // btnGenerarBalance
            // 
            btnGenerarBalance.BackColor = Color.FromArgb(31, 58, 93);
            btnGenerarBalance.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarBalance.ForeColor = Color.White;
            btnGenerarBalance.Location = new Point(54, 615);
            btnGenerarBalance.Name = "btnGenerarBalance";
            btnGenerarBalance.Size = new Size(195, 48);
            btnGenerarBalance.TabIndex = 10;
            btnGenerarBalance.Text = "Generar Balance";
            btnGenerarBalance.UseVisualStyleBackColor = false;
            btnGenerarBalance.Click += btnGenerarBalance_Click;
            // 
            // ContenedorBalance
            // 
            ContenedorBalance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ContenedorBalance.Controls.Add(dataBalance);
            ContenedorBalance.Location = new Point(54, 73);
            ContenedorBalance.Name = "ContenedorBalance";
            ContenedorBalance.Size = new Size(1144, 524);
            ContenedorBalance.TabIndex = 9;
            // 
            // dataBalance
            // 
            dataBalance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataBalance.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBalance.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataBalance.EnableHeadersVisualStyles = false;
            dataBalance.Location = new Point(0, 0);
            dataBalance.Name = "dataBalance";
            dataBalance.ReadOnly = true;
            dataBalance.RowHeadersWidth = 51;
            dataBalance.RowTemplate.Height = 29;
            dataBalance.Size = new Size(1144, 524);
            dataBalance.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Detalle";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 324;
            // 
            // Column2
            // 
            Column2.HeaderText = "$";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 222;
            // 
            // Column3
            // 
            Column3.HeaderText = "Detalle";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 324;
            // 
            // Column4
            // 
            Column4.HeaderText = "$";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 222;
            // 
            // lblFechaBalance
            // 
            lblFechaBalance.Anchor = AnchorStyles.Top;
            lblFechaBalance.AutoSize = true;
            lblFechaBalance.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaBalance.ForeColor = Color.FromArgb(35, 55, 80);
            lblFechaBalance.Location = new Point(365, 3);
            lblFechaBalance.Name = "lblFechaBalance";
            lblFechaBalance.Size = new Size(570, 41);
            lblFechaBalance.TabIndex = 8;
            lblFechaBalance.Text = "FECHA DEL BALANCE GENERAL";
            // 
            // balanceGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1252, 803);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "balanceGeneral";
            Text = "balanceGeneral";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ContenedorBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataBalance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblFechaBalance;
        private Panel ContenedorBalance;
        private DataGridView dataBalance;
        private Button btnGenerarBalance;
        private Label label3;
        private TextBox txtTotalActivo;
        private Label label2;
        private TextBox txtTotalPasyPatri;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox btnAtras;
    }
}