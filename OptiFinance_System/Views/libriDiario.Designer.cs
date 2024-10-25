namespace OptiFinance_System.Views
{
    partial class libriDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libriDiario));
            panel1 = new Panel();
            lblTotalHaber = new Label();
            lblTotalDebe = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dataPartidas = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPartidas).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalHaber);
            panel1.Controls.Add(lblTotalDebe);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 850);
            panel1.TabIndex = 0;
            // 
            // lblTotalHaber
            // 
            lblTotalHaber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalHaber.AutoSize = true;
            lblTotalHaber.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalHaber.ForeColor = Color.FromArgb(215, 143, 35);
            lblTotalHaber.Location = new Point(1092, 776);
            lblTotalHaber.Name = "lblTotalHaber";
            lblTotalHaber.Size = new Size(61, 26);
            lblTotalHaber.TabIndex = 4;
            lblTotalHaber.Text = "0.00";
            // 
            // lblTotalDebe
            // 
            lblTotalDebe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalDebe.AutoSize = true;
            lblTotalDebe.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDebe.ForeColor = Color.FromArgb(215, 143, 35);
            lblTotalDebe.Location = new Point(874, 776);
            lblTotalDebe.Name = "lblTotalDebe";
            lblTotalDebe.Size = new Size(61, 26);
            lblTotalDebe.TabIndex = 3;
            lblTotalDebe.Text = "0.00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(34, 53, 80);
            label2.Location = new Point(718, 776);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 2;
            label2.Text = "Total:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataPartidas);
            groupBox1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(34, 53, 80);
            groupBox1.Location = new Point(24, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1221, 671);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Partidas ";
            // 
            // dataPartidas
            // 
            dataPartidas.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPartidas.Dock = DockStyle.Fill;
            dataPartidas.EnableHeadersVisualStyles = false;
            dataPartidas.Location = new Point(3, 30);
            dataPartidas.Name = "dataPartidas";
            dataPartidas.ReadOnly = true;
            dataPartidas.RowHeadersWidth = 51;
            dataPartidas.RowTemplate.Height = 29;
            dataPartidas.Size = new Size(1215, 638);
            dataPartidas.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAtras);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 66);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(481, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 45);
            label1.TabIndex = 5;
            label1.Text = "LIBRO DIARIO";
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
            // libriDiario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "libriDiario";
            Text = "libriDiario";
            Load += libriDiario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataPartidas).EndInit();
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
        private GroupBox groupBox1;
        private DataGridView dataPartidas;
        private Label lblTotalHaber;
        private Label lblTotalDebe;
        private Label label2;
    }
}