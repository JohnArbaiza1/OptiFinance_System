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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Container = new Panel();
            pictureBox1 = new PictureBox();
            panelControlUser = new Panel();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnLimpiar = new Button();
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
            timerAlias = new System.Windows.Forms.Timer(components);
            timerCorreo = new System.Windows.Forms.Timer(components);
            timerTelefono = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelControlUser.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            Container.Name = "Container";
            Container.Size = new Size(1269, 803);
            Container.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(215, 143, 35);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(770, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panelControlUser
            // 
            panelControlUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelControlUser.Controls.Add(groupBox1);
            panelControlUser.Location = new Point(827, 109);
            panelControlUser.Name = "panelControlUser";
            panelControlUser.Size = new Size(430, 684);
            panelControlUser.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 632);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de Usuarios";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(215, 143, 35);
            btnCancelar.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(6, 573);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 52);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(234, 130, 6);
            btnLimpiar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(0, 519);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(405, 41);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.BackColor = Color.FromArgb(31, 58, 93);
            btnGuardar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(0, 461);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(402, 51);
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
            tableLayoutPanel1.Location = new Point(6, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2842369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2856646F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2856646F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853031F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853079F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881622F));
            tableLayoutPanel1.Size = new Size(399, 357);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(35, 55, 80);
            label7.Location = new Point(7, 200);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 13;
            label7.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 245, 242);
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(109, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 31);
            txtEmail.TabIndex = 8;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // txtAlias
            // 
            txtAlias.BackColor = Color.FromArgb(245, 245, 242);
            txtAlias.Dock = DockStyle.Fill;
            txtAlias.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlias.Location = new Point(109, 103);
            txtAlias.MaxLength = 20;
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(287, 31);
            txtAlias.TabIndex = 7;
            txtAlias.KeyUp += txtAlias_KeyUp;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(245, 245, 242);
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(109, 53);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(287, 31);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(35, 55, 80);
            label2.Location = new Point(4, 50);
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
            label3.Location = new Point(36, 100);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 2;
            label3.Text = "Alias:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(245, 245, 242);
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(109, 3);
            txtName.Margin = new Padding(3, 3, 3, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 31);
            txtName.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(35, 55, 80);
            label6.Location = new Point(4, 300);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 10;
            label6.Text = "Dirección:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(245, 245, 242);
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(109, 303);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(287, 31);
            txtAddress.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(35, 55, 80);
            label4.Location = new Point(7, 250);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 9;
            label4.Text = "Telefono:";
            // 
            // txtTelefonos
            // 
            txtTelefonos.BackColor = Color.FromArgb(245, 245, 242);
            txtTelefonos.Dock = DockStyle.Fill;
            txtTelefonos.Location = new Point(109, 253);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(287, 31);
            txtTelefonos.TabIndex = 11;
            txtTelefonos.TextChanged += txtTelefonos_TextChanged;
            txtTelefonos.KeyPress += txtTelefonos_KeyPress;
            txtTelefonos.KeyUp += txtTelefonos_KeyUp;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(35, 55, 80);
            label5.Location = new Point(18, 150);
            label5.Name = "label5";
            label5.Size = new Size(85, 24);
            label5.TabIndex = 4;
            label5.Text = "Correo:";
            // 
            // txtPassUser
            // 
            txtPassUser.BackColor = Color.FromArgb(245, 245, 242);
            txtPassUser.Dock = DockStyle.Fill;
            txtPassUser.Location = new Point(109, 203);
            txtPassUser.MaxLength = 30;
            txtPassUser.Name = "txtPassUser";
            txtPassUser.Size = new Size(287, 31);
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
            btnEliminar.Location = new Point(252, 573);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(5, 0, 0, 0);
            btnEliminar.Size = new Size(148, 53);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
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
            btnEditar.Location = new Point(115, 573);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5, 0, 0, 0);
            btnEditar.Size = new Size(131, 52);
            btnEditar.TabIndex = 2;
            btnEditar.Text = " Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
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
            dataGridViewUsuarios.AllowUserToAddRows = false;
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
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.RowTemplate.Height = 29;
            dataGridViewUsuarios.Size = new Size(787, 629);
            dataGridViewUsuarios.TabIndex = 4;
            dataGridViewUsuarios.CellClick += dataGridViewUsuarios_CellClick;
            dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(245, 245, 242);
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(34, 109);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "  Nombre de Usuario o Id";
            txtBusqueda.Size = new Size(730, 34);
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
            // timerAlias
            // 
            timerAlias.Interval = 500;
            timerAlias.Tick += timerAlias_Tick;
            // 
            // timerCorreo
            // 
            timerCorreo.Interval = 500;
            timerCorreo.Tick += timerCorreo_Tick;
            // 
            // timerTelefono
            // 
            timerTelefono.Interval = 500;
            timerTelefono.Tick += timerTelefono_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Button btnLimpiar;
        private Button btnCancelar;
        private System.Windows.Forms.Timer timerAlias;
        private System.Windows.Forms.Timer timerCorreo;
        private System.Windows.Forms.Timer timerTelefono;
        private ErrorProvider errorProvider1;
    }
}