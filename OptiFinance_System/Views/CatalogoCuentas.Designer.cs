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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCuentas));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridActivos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tabPage2 = new TabPage();
            dataGridPasivos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            tabPage3 = new TabPage();
            dataGridCapital = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            label6 = new Label();
            label7 = new Label();
            dataGridDeudora = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridAcreedora = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridCierre = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridActivos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasivos).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCapital).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDeudora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAcreedora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCierre).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 803);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(1252, 737);
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
            tabControl1.Size = new Size(1188, 684);
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
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1180, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ACTIVO    ";
            // 
            // dataGridActivos
            // 
            dataGridActivos.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle7.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridActivos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridActivos.EnableHeadersVisualStyles = false;
            dataGridActivos.Location = new Point(43, 56);
            dataGridActivos.Name = "dataGridActivos";
            dataGridActivos.ReadOnly = true;
            dataGridActivos.RowHeadersWidth = 51;
            dataGridActivos.RowTemplate.Height = 29;
            dataGridActivos.Size = new Size(1082, 564);
            dataGridActivos.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 515;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 515;
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
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1180, 648);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "PASIVO      ";
            // 
            // dataGridPasivos
            // 
            dataGridPasivos.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle8.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridPasivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridPasivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPasivos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridPasivos.EnableHeadersVisualStyles = false;
            dataGridPasivos.Location = new Point(46, 58);
            dataGridPasivos.Name = "dataGridPasivos";
            dataGridPasivos.ReadOnly = true;
            dataGridPasivos.RowHeadersWidth = 51;
            dataGridPasivos.RowTemplate.Height = 29;
            dataGridPasivos.Size = new Size(1082, 564);
            dataGridPasivos.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 515;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 515;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(6, 14);
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
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1180, 648);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CAPITAL   ";
            // 
            // dataGridCapital
            // 
            dataGridCapital.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle9.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridCapital.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCapital.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridCapital.EnableHeadersVisualStyles = false;
            dataGridCapital.Location = new Point(49, 59);
            dataGridCapital.Name = "dataGridCapital";
            dataGridCapital.ReadOnly = true;
            dataGridCapital.RowHeadersWidth = 51;
            dataGridCapital.RowTemplate.Height = 29;
            dataGridCapital.Size = new Size(1082, 564);
            dataGridCapital.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Código";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 515;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 515;
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
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAtras);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 66);
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
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.BorderStyle = BorderStyle.Fixed3D;
            tabPage4.Controls.Add(dataGridDeudora);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1180, 648);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "RESULTADO DEUDORA  ";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridAcreedora);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 32);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1180, 648);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "RESULTADO ACREEDORA";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label8);
            tabPage6.Controls.Add(dataGridCierre);
            tabPage6.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage6.Location = new Point(4, 32);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1180, 648);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "PUENTE DE CIERRE";
            tabPage6.UseVisualStyleBackColor = true;
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
            // dataGridDeudora
            // 
            dataGridDeudora.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle10.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridDeudora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridDeudora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDeudora.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridDeudora.EnableHeadersVisualStyles = false;
            dataGridDeudora.Location = new Point(46, 59);
            dataGridDeudora.Name = "dataGridDeudora";
            dataGridDeudora.ReadOnly = true;
            dataGridDeudora.RowHeadersWidth = 51;
            dataGridDeudora.RowTemplate.Height = 29;
            dataGridDeudora.Size = new Size(1082, 564);
            dataGridDeudora.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Código";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 515;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 515;
            // 
            // dataGridAcreedora
            // 
            dataGridAcreedora.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle11.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridAcreedora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridAcreedora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAcreedora.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridAcreedora.EnableHeadersVisualStyles = false;
            dataGridAcreedora.Location = new Point(58, 65);
            dataGridAcreedora.Name = "dataGridAcreedora";
            dataGridAcreedora.ReadOnly = true;
            dataGridAcreedora.RowHeadersWidth = 51;
            dataGridAcreedora.RowTemplate.Height = 29;
            dataGridAcreedora.Size = new Size(1082, 564);
            dataGridAcreedora.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Código";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 515;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 515;
            // 
            // dataGridCierre
            // 
            dataGridCierre.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle12.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridCierre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridCierre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCierre.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridCierre.EnableHeadersVisualStyles = false;
            dataGridCierre.Location = new Point(46, 59);
            dataGridCierre.Name = "dataGridCierre";
            dataGridCierre.ReadOnly = true;
            dataGridCierre.RowHeadersWidth = 51;
            dataGridCierre.RowTemplate.Height = 29;
            dataGridCierre.Size = new Size(1082, 564);
            dataGridCierre.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Código";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 515;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 515;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(35, 55, 80);
            label8.Location = new Point(36, 15);
            label8.Name = "label8";
            label8.Size = new Size(597, 41);
            label8.TabIndex = 16;
            label8.Text = "CUENTAS DE PUENTE DE CIERRE";
            // 
            // CatalogoCuentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1252, 803);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDeudora).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAcreedora).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCierre).EndInit();
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dataGridPasivos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridCapital;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TabPage tabPage4;
        private Label label5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label6;
        private DataGridView dataGridDeudora;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label7;
        private DataGridView dataGridAcreedora;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridView dataGridCierre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label label8;
    }
}