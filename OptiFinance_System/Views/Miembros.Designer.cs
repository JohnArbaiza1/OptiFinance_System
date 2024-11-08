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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miembros));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            txtAlias = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            txtDui = new TextBox();
            txtPassword = new TextBox();
            panel3 = new Panel();
            dataMiembros = new DataGridView();
            btnBuscarMiembros = new Button();
            txtBusqueda = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            errorProvider1 = new ErrorProvider(components);
            timerAlias = new System.Windows.Forms.Timer(components);
            timerDui = new System.Windows.Forms.Timer(components);
            timerCorreo = new System.Windows.Forms.Timer(components);
            timerTelefono = new System.Windows.Forms.Timer(components);
            Nombre = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Alias = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMiembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            btnAtras.Location = new Point(0, 3);
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
            panel2.Size = new Size(1270, 782);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox1.Location = new Point(750, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 651);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de Miembros:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(215, 143, 35);
            btnCancelar.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(318, 521);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 44);
            btnCancelar.TabIndex = 6;
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
            btnLimpiar.Location = new Point(165, 521);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 44);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(44, 161, 232);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(165, 461);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 53);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(234, 130, 6);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(6, 461);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 53);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(31, 58, 93);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(318, 461);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(10, 0, 0, 0);
            btnAgregar.Size = new Size(146, 53);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.19981F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8001938F));
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(txtAlias, 1, 2);
            tableLayoutPanel1.Controls.Add(txtApellido, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtTelefono, 1, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtCorreo, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtDui, 1, 4);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 3);
            tableLayoutPanel1.Location = new Point(6, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995289F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5032816F));
            tableLayoutPanel1.Size = new Size(464, 381);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 141);
            label9.Name = "label9";
            label9.Size = new Size(108, 23);
            label9.TabIndex = 13;
            label9.Text = "Password:";
            // 
            // txtAlias
            // 
            txtAlias.BackColor = Color.FromArgb(245, 245, 242);
            txtAlias.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlias.Location = new Point(175, 97);
            txtAlias.MaxLength = 20;
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(284, 31);
            txtAlias.TabIndex = 8;
            txtAlias.KeyUp += txtAlias_KeyUp;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(245, 245, 242);
            txtApellido.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(175, 50);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(284, 31);
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
            txtNombre.Size = new Size(284, 31);
            txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 1;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 2;
            label4.Text = "Alias:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 329);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 6;
            label8.Text = "Dirección:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(245, 245, 242);
            txtAddress.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(175, 332);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 31);
            txtAddress.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 282);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 5;
            label7.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(245, 245, 242);
            txtTelefono.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(175, 285);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(284, 31);
            txtTelefono.TabIndex = 11;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            txtTelefono.KeyUp += txtTelefono_KeyUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 235);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 4;
            label6.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(245, 245, 242);
            txtCorreo.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(175, 238);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(284, 31);
            txtCorreo.TabIndex = 10;
            txtCorreo.KeyUp += txtCorreo_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 188);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 3;
            label5.Text = "Dui:";
            // 
            // txtDui
            // 
            txtDui.BackColor = Color.FromArgb(245, 245, 242);
            txtDui.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDui.Location = new Point(175, 191);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(284, 31);
            txtDui.TabIndex = 9;
            txtDui.TextChanged += txtDui_TextChanged;
            txtDui.KeyPress += txtDui_KeyPress;
            txtDui.KeyUp += txtDui_KeyUp;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 245, 242);
            txtPassword.Location = new Point(175, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 31);
            txtPassword.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dataMiembros);
            panel3.Location = new Point(41, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(685, 589);
            panel3.TabIndex = 3;
            // 
            // dataMiembros
            // 
            dataMiembros.BackgroundColor = Color.FromArgb(245, 245, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 161, 232);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataMiembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMiembros.Columns.AddRange(new DataGridViewColumn[] { Nombre, Column2, Alias, Column8, Column4, Column5, Column6, Column7 });
            dataMiembros.Dock = DockStyle.Fill;
            dataMiembros.EnableHeadersVisualStyles = false;
            dataMiembros.Location = new Point(0, 0);
            dataMiembros.Name = "dataMiembros";
            dataMiembros.ReadOnly = true;
            dataMiembros.RowHeadersWidth = 51;
            dataMiembros.RowTemplate.Height = 29;
            dataMiembros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMiembros.ShowCellToolTips = false;
            dataMiembros.Size = new Size(685, 589);
            dataMiembros.TabIndex = 0;
            dataMiembros.CellClick += dataMiembros_CellClick;
            dataMiembros.CellContentClick += dataMiembros_CellContentClick;
            // 
            // btnBuscarMiembros
            // 
            btnBuscarMiembros.BackColor = Color.FromArgb(215, 143, 35);
            btnBuscarMiembros.Image = (Image)resources.GetObject("btnBuscarMiembros.Image");
            btnBuscarMiembros.Location = new Point(658, 48);
            btnBuscarMiembros.Name = "btnBuscarMiembros";
            btnBuscarMiembros.Size = new Size(69, 37);
            btnBuscarMiembros.TabIndex = 2;
            btnBuscarMiembros.UseVisualStyleBackColor = false;
            btnBuscarMiembros.Click += btnBuscarMiembros_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(245, 245, 242);
            txtBusqueda.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(41, 52);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(611, 31);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.KeyUp += txtBusqueda_KeyUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timerAlias
            // 
            timerAlias.Interval = 500;
            timerAlias.Tick += timerAlias_Tick;
            // 
            // timerDui
            // 
            timerDui.Interval = 500;
            timerDui.Tick += timerDui_Tick;
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
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Alias
            // 
            Alias.HeaderText = "Alias";
            Alias.MinimumWidth = 6;
            Alias.Name = "Alias";
            Alias.ReadOnly = true;
            Alias.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "Password";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dui";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Correo Electronico";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Telefono";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Dirección";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 200;
            // 
            // Miembros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 851);
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
            ((System.ComponentModel.ISupportInitialize)dataMiembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private DataGridView dataMiembros;
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
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label9;
        private TextBox txtPassword;
        private ContextMenuStrip contextMenuStrip1;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerAlias;
        private System.Windows.Forms.Timer timerDui;
        private System.Windows.Forms.Timer timerCorreo;
        private System.Windows.Forms.Timer timerTelefono;
        private Button btnLimpiar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Alias;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}