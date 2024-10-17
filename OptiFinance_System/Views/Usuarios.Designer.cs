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
            txtEmail = new TextBox();
            txtAlias = new TextBox();
            txtLastName = new TextBox();
            lblNombre = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            panelTabla = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Alias = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panelControlUser.Location = new Point(827, 161);
            panelControlUser.Name = "panelControlUser";
            panelControlUser.Size = new Size(430, 633);
            panelControlUser.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 428);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de Usuarios";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(71, 102, 121);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(13, 299);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(389, 51);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7681923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.2318039F));
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(txtAlias, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9981289F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(399, 229);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(109, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 31);
            txtEmail.TabIndex = 8;
            // 
            // txtAlias
            // 
            txtAlias.Dock = DockStyle.Fill;
            txtAlias.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlias.Location = new Point(109, 117);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(287, 31);
            txtAlias.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Bookman Old Style", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(109, 60);
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
            label5.Location = new Point(18, 171);
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
            label2.Location = new Point(4, 57);
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
            label3.Location = new Point(36, 114);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 2;
            label3.Text = "Alias:";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Bookman Old Style", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(109, 3);
            txtName.Margin = new Padding(3, 3, 3, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 33);
            txtName.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(187, 45, 59);
            btnEliminar.FlatAppearance.BorderColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(252, 378);
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
            btnEditar.BackColor = Color.FromArgb(11, 94, 215);
            btnEditar.FlatAppearance.BorderColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(96, 378);
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
            panelTabla.Controls.Add(dataGridView1);
            panelTabla.Location = new Point(34, 161);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(787, 630);
            panelTabla.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Alias, Email });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(787, 630);
            dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 142;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 145;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 145;
            // 
            // Alias
            // 
            Alias.HeaderText = "Alias";
            Alias.MinimumWidth = 6;
            Alias.Name = "Alias";
            Alias.Width = 140;
            // 
            // Email
            // 
            Email.HeaderText = "Correo Electronico";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 170;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(34, 101);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "  Nombre de Usuario o Id";
            txtBusqueda.Size = new Size(631, 43);
            txtBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(21, 110, 69);
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(671, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(5, 0, 0, 0);
            btnBuscar.Size = new Size(150, 44);
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
            btnAtras.Location = new Point(12, 0);
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
            Container.ResumeLayout(false);
            Container.PerformLayout();
            panelControlUser.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Panel panelControlUser;
        private Label lblNombre;
        private Label label2;
        private Label label5;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Alias;
        private DataGridViewTextBoxColumn Email;
        private TextBox txtEmail;
        private TextBox txtAlias;
        private TextBox txtLastName;
        private Button btnGuardar;
    }
}