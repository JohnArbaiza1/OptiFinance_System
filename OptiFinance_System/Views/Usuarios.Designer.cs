namespace OptiFinance_System.Views
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Container = new Panel();
            panelControlUser = new Panel();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            txtEmail = new TextBox();
            txtAlias = new TextBox();
            txtLastName = new TextBox();
            lblNombre = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtTelefonos = new TextBox();
            txtAddress = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            panelTabla = new Panel();
            dataGridViewUsuarios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            panelHeader = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            Container.SuspendLayout();
            panelControlUser.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // Container
            // 
            Container.BackColor = Color.White;
            Container.Controls.Add(panelControlUser);
            Container.Controls.Add(panelTabla);
            Container.Controls.Add(txtBusqueda);
            Container.Controls.Add(btnBuscar);
            Container.Controls.Add(panelHeader);
            Container.Dock = DockStyle.Fill;
            Container.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Container.ForeColor = Color.FromArgb(35, 55, 80);
            Container.Location = new Point(0, 0);
            Container.Name = "Container";
            Container.Size = new Size(1269, 803);
            Container.TabIndex = 0;
            // 
            // panelControlUser
            // 
            panelControlUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelControlUser.Controls.Add(groupBox1);
            panelControlUser.Location = new Point(827, 110);
            panelControlUser.Name = "panelControlUser";
            panelControlUser.Size = new Size(430, 684);
            panelControlUser.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 577);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de Usuarios";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(31, 58, 93);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(10, 455);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(389, 51);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7681923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.2318039F));
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(txtAlias, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtTelefonos, 1, 4);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 5);
            tableLayoutPanel1.Location = new Point(6, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6654167F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66708F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6670856F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6670856F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(399, 357);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(35, 55, 80);
            label4.Location = new Point(7, 236);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 9;
            label4.Text = "Telefono:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 245, 242);
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(109, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 31);
            txtEmail.TabIndex = 8;
            // 
            // txtAlias
            // 
            txtAlias.BackColor = Color.FromArgb(245, 245, 242);
            txtAlias.Dock = DockStyle.Fill;
            txtAlias.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlias.Location = new Point(109, 121);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(287, 31);
            txtAlias.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(245, 245, 242);
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Bookman Old Style", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(109, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(287, 33);
            txtLastName.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(35, 55, 80);
            lblNombre.Location = new Point(7, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(96, 24);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(35, 55, 80);
            label5.Location = new Point(18, 177);
            label5.Name = "label5";
            label5.Size = new Size(85, 24);
            label5.TabIndex = 4;
            label5.Text = "Correo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(35, 55, 80);
            label2.Location = new Point(4, 59);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(36, 118);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 2;
            label3.Text = "Alias:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(245, 245, 242);
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Bookman Old Style", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(109, 3);
            txtName.Margin = new Padding(3, 3, 3, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 33);
            txtName.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(35, 55, 80);
            label6.Location = new Point(4, 295);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 10;
            label6.Text = "Dirección:";
            // 
            // txtTelefonos
            // 
            txtTelefonos.BackColor = Color.FromArgb(245, 245, 242);
            txtTelefonos.Location = new Point(109, 239);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(284, 31);
            txtTelefonos.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(245, 245, 242);
            txtAddress.Location = new Point(109, 298);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 31);
            txtAddress.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(234, 130, 6);
            btnEliminar.FlatAppearance.BorderColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(251, 528);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(5, 0, 0, 0);
            btnEliminar.Size = new Size(150, 44);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(44, 161, 232);
            btnEditar.FlatAppearance.BorderColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(96, 528);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5, 0, 0, 0);
            btnEditar.Size = new Size(150, 44);
            btnEditar.TabIndex = 2;
            btnEditar.Text = " Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // panelTabla
            // 
            panelTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelTabla.Controls.Add(dataGridViewUsuarios);
            panelTabla.Location = new Point(34, 161);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(787, 629);
            panelTabla.TabIndex = 5;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewUsuarios.Dock = DockStyle.Fill;
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewUsuarios.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewUsuarios.Location = new Point(0, 0);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.RowTemplate.Height = 29;
            dataGridViewUsuarios.Size = new Size(787, 629);
            dataGridViewUsuarios.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Alias";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Dirección";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(245, 245, 242);
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(34, 110);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "  Nombre de Usuario o Id";
            txtBusqueda.Size = new Size(631, 34);
            txtBusqueda.TabIndex = 0;
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
            btnBuscar.Location = new Point(671, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(5, 0, 0, 0);
            btnBuscar.Size = new Size(150, 34);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = " Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.AutoSize = true;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnAtras);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1269, 67);
            panelHeader.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(470, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 45);
            label1.TabIndex = 1;
            label1.Text = "Usuarios del Sistema.";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 2;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 803);
            Controls.Add(Container);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            Container.ResumeLayout(false);
            Container.PerformLayout();
            panelControlUser.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Container;
        private Label label1;
        private PictureBox btnAtras;
        private Panel panelHeader;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private Panel panelTabla;
        private DataGridView dataGridViewUsuarios;
        private GroupBox groupBox1;
        private Panel panelControlUser;
        private Label lblNombre;
        private Label label2;
        private Label label5;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtAlias;
        private TextBox txtLastName;
        private Button btnGuardar;
        private Label label4;
        private Label label6;
        private TextBox txtTelefonos;
        private TextBox txtAddress;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}