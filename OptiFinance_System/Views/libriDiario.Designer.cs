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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libriDiario));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dataPartidas = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPartidas).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 850);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(215, 143, 35);
            label4.Location = new Point(1092, 776);
            label4.Name = "label4";
            label4.Size = new Size(61, 26);
            label4.TabIndex = 4;
            label4.Text = "0.00";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(215, 143, 35);
            label3.Location = new Point(874, 776);
            label3.Name = "label3";
            label3.Size = new Size(61, 26);
            label3.TabIndex = 3;
            label3.Text = "0.00";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPartidas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
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
            // Column1
            // 
            Column1.HeaderText = "Fecha";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 204;
            // 
            // Column2
            // 
            Column2.HeaderText = "Detalle";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 314;
            // 
            // Column3
            // 
            Column3.HeaderText = "Codigo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 208;
            // 
            // Column4
            // 
            Column4.HeaderText = "Debe";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 218;
            // 
            // Column5
            // 
            Column5.HeaderText = "Haber";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 218;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}