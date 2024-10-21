namespace OptiFinance_System.Views
{
    partial class Miembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miembros));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAddress = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDui = new TextBox();
            txtAlias = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnBuscarMiembros = new Button();
            txtBusqueda = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAtras);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 69);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(391, 9);
            label1.Name = "label1";
            label1.Size = new Size(521, 45);
            label1.TabIndex = 4;
            label1.Text = "Miembros de la Empresa.";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 3;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnBuscarMiembros);
            panel2.Controls.Add(txtBusqueda);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 781);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox1.Location = new Point(750, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 650);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de Miembros:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(44, 161, 232);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(167, 422);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(148, 54);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(234, 130, 6);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(9, 422);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 54);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(31, 58, 93);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(321, 422);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 0, 0, 0);
            btnGuardar.Size = new Size(146, 54);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.1998062F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8001938F));
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 6);
            tableLayoutPanel1.Controls.Add(txtTelefono, 1, 5);
            tableLayoutPanel1.Controls.Add(txtCorreo, 1, 4);
            tableLayoutPanel1.Controls.Add(txtDui, 1, 3);
            tableLayoutPanel1.Controls.Add(txtAlias, 1, 2);
            tableLayoutPanel1.Controls.Add(txtApellido, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Location = new Point(6, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(464, 328);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(245, 245, 242);
            txtAddress.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(175, 279);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(286, 31);
            txtAddress.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(245, 245, 242);
            txtTelefono.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(175, 233);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(286, 31);
            txtTelefono.TabIndex = 11;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(245, 245, 242);
            txtCorreo.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(175, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(286, 31);
            txtCorreo.TabIndex = 10;
            // 
            // txtDui
            // 
            txtDui.BackColor = Color.FromArgb(245, 245, 242);
            txtDui.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDui.Location = new Point(175, 141);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(286, 31);
            txtDui.TabIndex = 9;
            // 
            // txtAlias
            // 
            txtAlias.BackColor = Color.FromArgb(245, 245, 242);
            txtAlias.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlias.Location = new Point(175, 95);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(286, 31);
            txtAlias.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(245, 245, 242);
            txtApellido.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(175, 49);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(286, 31);
            txtApellido.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(245, 245, 242);
            txtNombre.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(175, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(286, 31);
            txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 1;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 92);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 2;
            label4.Text = "Alias:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 138);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 3;
            label5.Text = "Dui:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 184);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 4;
            label6.Text = "Correo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 230);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 5;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 276);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 6;
            label8.Text = "Dirección:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(41, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(685, 589);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(685, 589);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Alias";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dui";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Correo Electronico";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Telefono";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Dirección";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // btnBuscarMiembros
            // 
            btnBuscarMiembros.BackColor = Color.FromArgb(215, 143, 35);
            btnBuscarMiembros.Image = (Image)resources.GetObject("btnBuscarMiembros.Image");
            btnBuscarMiembros.Location = new Point(658, 48);
            btnBuscarMiembros.Name = "btnBuscarMiembros";
            btnBuscarMiembros.Size = new Size(68, 38);
            btnBuscarMiembros.TabIndex = 2;
            btnBuscarMiembros.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(245, 245, 242);
            txtBusqueda.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(41, 52);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(611, 31);
            txtBusqueda.TabIndex = 1;
            // 
            // Miembros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 850);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Miembros";
            Text = "Miembros";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnAtras;
        private Label label1;
        private Panel panel2;
        private TextBox txtBusqueda;
        private TextBox txtNombre;
        private Button btnBuscarMiembros;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAddress;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDui;
        private TextBox txtAlias;
        private TextBox txtApellido;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}