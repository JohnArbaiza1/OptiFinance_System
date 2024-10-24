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
            pictureBox1 = new PictureBox();
            panelControlUser = new Panel();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            txtEmail = new TextBox();
            txtAlias = new TextBox();
            txtLastName = new TextBox();
            lblNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtTelefonos = new TextBox();
            label5 = new Label();
            txtPassUser = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            panelTabla = new Panel();
            dataGridViewUsuarios = new DataGridView();
            txtBusqueda = new TextBox();
            panelHeader = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            Container.Controls.Add(pictureBox1);
            Container.Controls.Add(panelControlUser);
            Container.Controls.Add(panelTabla);
            Container.Controls.Add(txtBusqueda);
            Container.Controls.Add(panelHeader);
            Container.Dock = DockStyle.Fill;
            Container.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Container.ForeColor = Color.FromArgb(35, 55, 80);
            Container.Location = new Point(0, 0);
            Container.Margin = new Padding(3, 2, 3, 2);
            Container.Name = "Container";
            Container.Size = new Size(1110, 602);
            Container.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(215, 143, 35);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(674, 82);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panelControlUser
            // 
            panelControlUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelControlUser.Controls.Add(groupBox1);
            panelControlUser.Location = new Point(724, 82);
            panelControlUser.Margin = new Padding(3, 2, 3, 2);
            panelControlUser.Name = "panelControlUser";
            panelControlUser.Size = new Size(376, 513);
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
            groupBox1.Location = new Point(12, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(361, 474);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de Usuarios";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(31, 58, 93);
            btnGuardar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(7, 380);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(344, 38);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7681923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.2318039F));
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(txtAlias, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(txtTelefonos, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPassUser, 1, 4);
            tableLayoutPanel1.Location = new Point(5, 38);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2842369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2856646F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2856646F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853031F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853079F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881622F));
            tableLayoutPanel1.Size = new Size(349, 268);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(35, 55, 80);
            label7.Location = new Point(9, 152);
            label7.Name = "label7";
            label7.Size = new Size(81, 18);
            label7.TabIndex = 13;
            label7.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 245, 242);
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(96, 116);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 26);
            txtEmail.TabIndex = 8;
            // 
            // txtAlias
            // 
            txtAlias.BackColor = Color.FromArgb(245, 245, 242);
            txtAlias.Dock = DockStyle.Fill;
            txtAlias.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlias.Location = new Point(96, 78);
            txtAlias.Margin = new Padding(3, 2, 3, 2);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(250, 26);
            txtAlias.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(245, 245, 242);
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(96, 40);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 26);
            txtLastName.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(35, 55, 80);
            lblNombre.Location = new Point(12, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(35, 55, 80);
            label2.Location = new Point(9, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(36, 76);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 2;
            label3.Text = "Alias:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(245, 245, 242);
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(96, 2);
            txtName.Margin = new Padding(3, 2, 3, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 26);
            txtName.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(35, 55, 80);
            label6.Location = new Point(9, 228);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 10;
            label6.Text = "Dirección:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(245, 245, 242);
            txtAddress.Location = new Point(96, 230);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(249, 26);
            txtAddress.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(35, 55, 80);
            label4.Location = new Point(9, 190);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 9;
            label4.Text = "Telefono:";
            // 
            // txtTelefonos
            // 
            txtTelefonos.BackColor = Color.FromArgb(245, 245, 242);
            txtTelefonos.Location = new Point(96, 192);
            txtTelefonos.Margin = new Padding(3, 2, 3, 2);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(249, 26);
            txtTelefonos.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(35, 55, 80);
            label5.Location = new Point(21, 114);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 4;
            label5.Text = "Correo:";
            // 
            // txtPassUser
            // 
            txtPassUser.BackColor = Color.FromArgb(245, 245, 242);
            txtPassUser.Location = new Point(96, 154);
            txtPassUser.Margin = new Padding(3, 2, 3, 2);
            txtPassUser.Name = "txtPassUser";
            txtPassUser.Size = new Size(250, 26);
            txtPassUser.TabIndex = 14;
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
            btnEliminar.Location = new Point(220, 430);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(4, 0, 0, 0);
            btnEliminar.Size = new Size(130, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnEditar.Location = new Point(101, 430);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(4, 0, 0, 0);
            btnEditar.Size = new Size(115, 39);
            btnEditar.TabIndex = 2;
            btnEditar.Text = " Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // panelTabla
            // 
            panelTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelTabla.Controls.Add(dataGridViewUsuarios);
            panelTabla.Location = new Point(30, 121);
            panelTabla.Margin = new Padding(3, 2, 3, 2);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(689, 472);
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
            dataGridViewUsuarios.Dock = DockStyle.Fill;
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewUsuarios.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewUsuarios.Location = new Point(0, 0);
            dataGridViewUsuarios.Margin = new Padding(3, 2, 3, 2);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.RowTemplate.Height = 29;
            dataGridViewUsuarios.Size = new Size(689, 472);
            dataGridViewUsuarios.TabIndex = 4;
            dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
            dataGridViewUsuarios.MouseClick += dataGridViewUsuarios_MouseClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(245, 245, 242);
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(30, 82);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "  Nombre de Usuario o Id";
            txtBusqueda.Size = new Size(639, 29);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.KeyUp += txtBusqueda_KeyUp;
            // 
            // panelHeader
            // 
            panelHeader.AutoSize = true;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnAtras);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1110, 66);
            panelHeader.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(411, 7);
            label1.Name = "label1";
            label1.Size = new Size(360, 39);
            label1.TabIndex = 1;
            label1.Text = "Usuarios del Sistema.";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 2;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 602);
            Controls.Add(Container);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label7;
        private TextBox txtPassUser;
        private PictureBox pictureBox1;
    }
}