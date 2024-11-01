namespace OptiFinance_System.Views
{
    partial class CatalogoCuentas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCuentas));
            panel1 = new Panel();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridActivos = new DataGridView();
            label2 = new Label();
            tabPage2 = new TabPage();
            dataGridPasivos = new DataGridView();
            label3 = new Label();
            tabPage3 = new TabPage();
            dataGridCapital = new DataGridView();
            label4 = new Label();
            tabPage4 = new TabPage();
            dataGridDeudora = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            tabPage5 = new TabPage();
            dataGridAcreedora = new DataGridView();
            label7 = new Label();
            tabPage6 = new TabPage();
            label8 = new Label();
            dataGridCierre = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridActivos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasivos).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCapital).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDeudora).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAcreedora).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCierre).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 736);
            panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(33, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1189, 684);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(dataGridActivos);
            tabPage1.Controls.Add(label2);
            tabPage1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1181, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ACTIVO    ";
            // 
            // dataGridActivos
            // 
            dataGridActivos.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridActivos.EnableHeadersVisualStyles = false;
            dataGridActivos.Location = new Point(43, 56);
            dataGridActivos.Name = "dataGridActivos";
            dataGridActivos.ReadOnly = true;
            dataGridActivos.RowHeadersWidth = 51;
            dataGridActivos.RowTemplate.Height = 29;
            dataGridActivos.Size = new Size(1082, 564);
            dataGridActivos.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(35, 55, 80);
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(408, 41);
            label2.TabIndex = 9;
            label2.Text = "CUENTAS DE ACTIVOS";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(dataGridPasivos);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1181, 648);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "PASIVO      ";
            // 
            // dataGridPasivos
            // 
            dataGridPasivos.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPasivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPasivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPasivos.EnableHeadersVisualStyles = false;
            dataGridPasivos.Location = new Point(46, 59);
            dataGridPasivos.Name = "dataGridPasivos";
            dataGridPasivos.ReadOnly = true;
            dataGridPasivos.RowHeadersWidth = 51;
            dataGridPasivos.RowTemplate.Height = 29;
            dataGridPasivos.Size = new Size(1082, 564);
            dataGridPasivos.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(6, 13);
            label3.Name = "label3";
            label3.Size = new Size(406, 41);
            label3.TabIndex = 10;
            label3.Text = "CUENTAS DE PASIVOS";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.Controls.Add(dataGridCapital);
            tabPage3.Controls.Add(label4);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 3, 3, 3);
            tabPage3.Size = new Size(1181, 648);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CAPITAL   ";
            // 
            // dataGridCapital
            // 
            dataGridCapital.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCapital.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCapital.EnableHeadersVisualStyles = false;
            dataGridCapital.Location = new Point(49, 59);
            dataGridCapital.Name = "dataGridCapital";
            dataGridCapital.ReadOnly = true;
            dataGridCapital.RowHeadersWidth = 51;
            dataGridCapital.RowTemplate.Height = 29;
            dataGridCapital.Size = new Size(1082, 564);
            dataGridCapital.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(35, 55, 80);
            label4.Location = new Point(6, 15);
            label4.Name = "label4";
            label4.Size = new Size(399, 41);
            label4.TabIndex = 11;
            label4.Text = "CUENTAS DE CAPITAL";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.BorderStyle = BorderStyle.Fixed3D;
            tabPage4.Controls.Add(dataGridDeudora);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 3, 3, 3);
            tabPage4.Size = new Size(1181, 648);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "RESULTADO DEUDORA  ";
            // 
            // dataGridDeudora
            // 
            dataGridDeudora.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridDeudora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridDeudora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDeudora.EnableHeadersVisualStyles = false;
            dataGridDeudora.Location = new Point(46, 59);
            dataGridDeudora.Name = "dataGridDeudora";
            dataGridDeudora.ReadOnly = true;
            dataGridDeudora.RowHeadersWidth = 51;
            dataGridDeudora.RowTemplate.Height = 29;
            dataGridDeudora.Size = new Size(1082, 564);
            dataGridDeudora.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(35, 55, 80);
            label6.Location = new Point(34, 15);
            label6.Name = "label6";
            label6.Size = new Size(679, 41);
            label6.TabIndex = 14;
            label6.Text = "CUENTAS DE RESULTADO DEUDORA  ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(35, 55, 80);
            label5.Location = new Point(6, 15);
            label5.Name = "label5";
            label5.Size = new Size(0, 41);
            label5.TabIndex = 12;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridAcreedora);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 32);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 3, 3, 3);
            tabPage5.Size = new Size(1181, 648);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "RESULTADO ACREEDORA";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridAcreedora
            // 
            dataGridAcreedora.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridAcreedora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridAcreedora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAcreedora.EnableHeadersVisualStyles = false;
            dataGridAcreedora.Location = new Point(58, 65);
            dataGridAcreedora.Name = "dataGridAcreedora";
            dataGridAcreedora.ReadOnly = true;
            dataGridAcreedora.RowHeadersWidth = 51;
            dataGridAcreedora.RowTemplate.Height = 29;
            dataGridAcreedora.Size = new Size(1082, 564);
            dataGridAcreedora.TabIndex = 16;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(35, 55, 80);
            label7.Location = new Point(45, 21);
            label7.Name = "label7";
            label7.Size = new Size(698, 41);
            label7.TabIndex = 15;
            label7.Text = "CUENTAS DE RESULTADO ACREEDORA";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label8);
            tabPage6.Controls.Add(dataGridCierre);
            tabPage6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage6.Location = new Point(4, 32);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 3, 3, 3);
            tabPage6.Size = new Size(1181, 648);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "PUENTE DE CIERRE";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(35, 55, 80);
            label8.Location = new Point(37, 15);
            label8.Name = "label8";
            label8.Size = new Size(597, 41);
            label8.TabIndex = 16;
            label8.Text = "CUENTAS DE PUENTE DE CIERRE";
            // 
            // dataGridCierre
            // 
            dataGridCierre.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle6.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridCierre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridCierre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCierre.EnableHeadersVisualStyles = false;
            dataGridCierre.Location = new Point(46, 59);
            dataGridCierre.Name = "dataGridCierre";
            dataGridCierre.ReadOnly = true;
            dataGridCierre.RowHeadersWidth = 51;
            dataGridCierre.RowTemplate.Height = 29;
            dataGridCierre.Size = new Size(1082, 564);
            dataGridCierre.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAtras);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            label1.Location = new Point(393, 9);
            label1.Name = "label1";
            label1.Size = new Size(530, 45);
            label1.TabIndex = 8;
            label1.Text = "CATALOGO DE CUENTAS";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 7;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 515;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Código";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 515;
            // 
            // CatalogoCuentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1253, 803);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CatalogoCuentas";
            Text = "CatalogoCuentas";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridActivos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasivos).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCapital).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDeudora).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAcreedora).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCierre).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridActivos;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridPasivos;
        private DataGridView dataGridCapital;
        private TabPage tabPage4;
        private Label label5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label6;
        private DataGridView dataGridDeudora;
        private Label label7;
        private DataGridView dataGridAcreedora;
        private DataGridView dataGridCierre;
        private Label label8;
    }
}