namespace OptiFinance_System.Views
{
    partial class InfoEmpresacs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmpresacs));
            containerInfoEmpresa = new Panel();
            contenidoInfo = new Panel();
            groupBoxDoc = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblMunicipio = new TextBox();
            label20 = new Label();
            lblEmail = new TextBox();
            lblPhone = new TextBox();
            lblRepre = new TextBox();
            lblNit = new TextBox();
            lblComercio = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            lblEmpresa = new TextBox();
            label16 = new Label();
            lblAddres = new TextBox();
            label17 = new Label();
            lblDistrito = new TextBox();
            label21 = new Label();
            lblDepartamento = new TextBox();
            groupBoxFormulario = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRegistrar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label18 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            txtNombreEmpresa = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtNit = new TextBox();
            label3 = new Label();
            txtRepresentante = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btnBuscarGiro = new Button();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            comboDistrito = new ComboBox();
            label19 = new Label();
            comboDepartamento = new ComboBox();
            comMunucipio = new ComboBox();
            pabelNav = new Panel();
            btnAtras = new PictureBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            errorProvider = new ErrorProvider(components);
            timerNit = new System.Windows.Forms.Timer(components);
            timerTelefono = new System.Windows.Forms.Timer(components);
            timerCorreo = new System.Windows.Forms.Timer(components);
            containerInfoEmpresa.SuspendLayout();
            contenidoInfo.SuspendLayout();
            groupBoxDoc.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxFormulario.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            pabelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // containerInfoEmpresa
            // 
            containerInfoEmpresa.BackColor = Color.White;
            containerInfoEmpresa.Controls.Add(contenidoInfo);
            containerInfoEmpresa.Controls.Add(pabelNav);
            containerInfoEmpresa.Dock = DockStyle.Fill;
            containerInfoEmpresa.Location = new Point(0, 0);
            containerInfoEmpresa.Margin = new Padding(3, 2, 3, 2);
            containerInfoEmpresa.Name = "containerInfoEmpresa";
            containerInfoEmpresa.Size = new Size(1111, 638);
            containerInfoEmpresa.TabIndex = 0;
            // 
            // contenidoInfo
            // 
            contenidoInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contenidoInfo.Controls.Add(groupBoxDoc);
            contenidoInfo.Controls.Add(groupBoxFormulario);
            contenidoInfo.Location = new Point(0, 50);
            contenidoInfo.Margin = new Padding(3, 2, 3, 2);
            contenidoInfo.Name = "contenidoInfo";
            contenidoInfo.Size = new Size(1111, 587);
            contenidoInfo.TabIndex = 1;
            // 
            // groupBoxDoc
            // 
            groupBoxDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDoc.Controls.Add(tableLayoutPanel2);
            groupBoxDoc.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDoc.Location = new Point(535, 16);
            groupBoxDoc.Margin = new Padding(3, 2, 3, 2);
            groupBoxDoc.Name = "groupBoxDoc";
            groupBoxDoc.Padding = new Padding(3, 2, 3, 2);
            groupBoxDoc.Size = new Size(555, 554);
            groupBoxDoc.TabIndex = 0;
            groupBoxDoc.TabStop = false;
            groupBoxDoc.Text = "Datos de la Empresa";
            groupBoxDoc.Enter += groupBoxDoc_Enter_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.76912F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.2308769F));
            tableLayoutPanel2.Controls.Add(lblMunicipio, 1, 7);
            tableLayoutPanel2.Controls.Add(label20, 0, 6);
            tableLayoutPanel2.Controls.Add(lblEmail, 1, 5);
            tableLayoutPanel2.Controls.Add(lblPhone, 1, 4);
            tableLayoutPanel2.Controls.Add(lblRepre, 1, 3);
            tableLayoutPanel2.Controls.Add(lblNit, 1, 2);
            tableLayoutPanel2.Controls.Add(lblComercio, 1, 1);
            tableLayoutPanel2.Controls.Add(label10, 0, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 1);
            tableLayoutPanel2.Controls.Add(label12, 0, 2);
            tableLayoutPanel2.Controls.Add(label13, 0, 3);
            tableLayoutPanel2.Controls.Add(label14, 0, 4);
            tableLayoutPanel2.Controls.Add(label15, 0, 5);
            tableLayoutPanel2.Controls.Add(lblEmpresa, 1, 0);
            tableLayoutPanel2.Controls.Add(label16, 0, 9);
            tableLayoutPanel2.Controls.Add(lblAddres, 1, 9);
            tableLayoutPanel2.Controls.Add(label17, 0, 8);
            tableLayoutPanel2.Controls.Add(lblDistrito, 1, 8);
            tableLayoutPanel2.Controls.Add(label21, 0, 7);
            tableLayoutPanel2.Controls.Add(lblDepartamento, 1, 6);
            tableLayoutPanel2.Location = new Point(16, 37);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(522, 458);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblMunicipio
            // 
            lblMunicipio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMunicipio.BackColor = Color.White;
            lblMunicipio.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMunicipio.Location = new Point(241, 317);
            lblMunicipio.Margin = new Padding(3, 2, 3, 2);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.PlaceholderText = "San Miguel";
            lblMunicipio.ReadOnly = true;
            lblMunicipio.Size = new Size(278, 26);
            lblMunicipio.TabIndex = 26;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(3, 270);
            label20.Name = "label20";
            label20.Size = new Size(127, 20);
            label20.TabIndex = 23;
            label20.Text = "Departamento:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.BackColor = Color.White;
            lblEmail.BorderStyle = BorderStyle.None;
            lblEmail.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(241, 227);
            lblEmail.Margin = new Padding(3, 2, 3, 2);
            lblEmail.Name = "lblEmail";
            lblEmail.PlaceholderText = "optiFinance@gmail.com";
            lblEmail.ReadOnly = true;
            lblEmail.Size = new Size(278, 19);
            lblEmail.TabIndex = 20;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.BackColor = Color.White;
            lblPhone.BorderStyle = BorderStyle.None;
            lblPhone.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(241, 182);
            lblPhone.Margin = new Padding(3, 2, 3, 2);
            lblPhone.Name = "lblPhone";
            lblPhone.PlaceholderText = "00000000";
            lblPhone.ReadOnly = true;
            lblPhone.Size = new Size(278, 19);
            lblPhone.TabIndex = 19;
            // 
            // lblRepre
            // 
            lblRepre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRepre.BackColor = Color.White;
            lblRepre.BorderStyle = BorderStyle.None;
            lblRepre.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRepre.Location = new Point(241, 137);
            lblRepre.Margin = new Padding(3, 2, 3, 2);
            lblRepre.Name = "lblRepre";
            lblRepre.PlaceholderText = "Pedro ";
            lblRepre.ReadOnly = true;
            lblRepre.Size = new Size(278, 19);
            lblRepre.TabIndex = 18;
            // 
            // lblNit
            // 
            lblNit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNit.BackColor = Color.White;
            lblNit.BorderStyle = BorderStyle.None;
            lblNit.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNit.Location = new Point(241, 92);
            lblNit.Margin = new Padding(3, 2, 3, 2);
            lblNit.Name = "lblNit";
            lblNit.PlaceholderText = "0000000";
            lblNit.ReadOnly = true;
            lblNit.Size = new Size(278, 19);
            lblNit.TabIndex = 17;
            // 
            // lblComercio
            // 
            lblComercio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblComercio.BackColor = Color.White;
            lblComercio.BorderStyle = BorderStyle.None;
            lblComercio.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblComercio.Location = new Point(241, 47);
            lblComercio.Margin = new Padding(3, 2, 3, 2);
            lblComercio.Name = "lblComercio";
            lblComercio.PlaceholderText = "Comercio";
            lblComercio.ReadOnly = true;
            lblComercio.Size = new Size(278, 19);
            lblComercio.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 1;
            label10.Text = "Empresa:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 45);
            label11.Name = "label11";
            label11.Size = new Size(138, 20);
            label11.TabIndex = 3;
            label11.Text = "Giro Economico:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 90);
            label12.Name = "label12";
            label12.Size = new Size(212, 40);
            label12.TabIndex = 4;
            label12.Text = "Número de Identificación Tributaria (NIT):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 135);
            label13.Name = "label13";
            label13.Size = new Size(177, 20);
            label13.TabIndex = 5;
            label13.Text = "Representante Legal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(3, 180);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 11;
            label14.Text = "Telefono:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(3, 225);
            label15.Name = "label15";
            label15.Size = new Size(67, 20);
            label15.TabIndex = 12;
            label15.Text = "Correo:";
            // 
            // lblEmpresa
            // 
            lblEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmpresa.BackColor = Color.White;
            lblEmpresa.BorderStyle = BorderStyle.None;
            lblEmpresa.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpresa.Location = new Point(241, 2);
            lblEmpresa.Margin = new Padding(3, 2, 3, 2);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.PlaceholderText = "OptiFinance";
            lblEmpresa.ReadOnly = true;
            lblEmpresa.Size = new Size(278, 19);
            lblEmpresa.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(3, 405);
            label16.Name = "label16";
            label16.Size = new Size(89, 20);
            label16.TabIndex = 13;
            label16.Text = "Dirección:";
            // 
            // lblAddres
            // 
            lblAddres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddres.BackColor = Color.White;
            lblAddres.BorderStyle = BorderStyle.None;
            lblAddres.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddres.Location = new Point(241, 407);
            lblAddres.Margin = new Padding(3, 2, 3, 2);
            lblAddres.Multiline = true;
            lblAddres.Name = "lblAddres";
            lblAddres.PlaceholderText = "San Miguel, El Salvador";
            lblAddres.ReadOnly = true;
            lblAddres.Size = new Size(278, 20);
            lblAddres.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(3, 360);
            label17.Name = "label17";
            label17.Size = new Size(73, 20);
            label17.TabIndex = 14;
            label17.Text = "Distrito:";
            // 
            // lblDistrito
            // 
            lblDistrito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDistrito.BackColor = Color.White;
            lblDistrito.BorderStyle = BorderStyle.None;
            lblDistrito.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDistrito.Location = new Point(241, 362);
            lblDistrito.Margin = new Padding(3, 2, 3, 2);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.PlaceholderText = "San Miguel Centro";
            lblDistrito.ReadOnly = true;
            lblDistrito.Size = new Size(278, 19);
            lblDistrito.TabIndex = 22;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(3, 315);
            label21.Name = "label21";
            label21.Size = new Size(93, 20);
            label21.TabIndex = 24;
            label21.Text = "Municipio:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDepartamento.BackColor = Color.White;
            lblDepartamento.BorderStyle = BorderStyle.None;
            lblDepartamento.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartamento.Location = new Point(241, 272);
            lblDepartamento.Margin = new Padding(3, 2, 3, 2);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.PlaceholderText = "San Miguel";
            lblDepartamento.ReadOnly = true;
            lblDepartamento.Size = new Size(278, 19);
            lblDepartamento.TabIndex = 25;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Controls.Add(btnDelete);
            groupBoxFormulario.Controls.Add(btnEdit);
            groupBoxFormulario.Controls.Add(btnRegistrar);
            groupBoxFormulario.Controls.Add(tableLayoutPanel1);
            groupBoxFormulario.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxFormulario.Location = new Point(29, 16);
            groupBoxFormulario.Margin = new Padding(3, 2, 3, 2);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Padding = new Padding(3, 2, 3, 2);
            groupBoxFormulario.Size = new Size(485, 554);
            groupBoxFormulario.TabIndex = 0;
            groupBoxFormulario.TabStop = false;
            groupBoxFormulario.Text = "Ingrese los datos de la empresa :";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(234, 130, 6);
            btnDelete.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(342, 509);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 39);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "  Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(44, 161, 232);
            btnEdit.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(220, 509);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 39);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "  Editar";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.BackColor = Color.FromArgb(35, 58, 89);
            btnRegistrar.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(5, 509);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(209, 40);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar Información";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.50233F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.49767F));
            tableLayoutPanel1.Controls.Add(label18, 0, 6);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNombreEmpresa, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(txtNit, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(txtRepresentante, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 9);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 9);
            tableLayoutPanel1.Controls.Add(label6, 0, 8);
            tableLayoutPanel1.Controls.Add(comboDistrito, 1, 8);
            tableLayoutPanel1.Controls.Add(label19, 0, 7);
            tableLayoutPanel1.Controls.Add(comboDepartamento, 1, 6);
            tableLayoutPanel1.Controls.Add(comMunucipio, 1, 7);
            tableLayoutPanel1.Location = new Point(5, 37);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999F));
            tableLayoutPanel1.Size = new Size(474, 460);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(3, 276);
            label18.Name = "label18";
            label18.Size = new Size(127, 20);
            label18.TabIndex = 17;
            label18.Text = "Departamento:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(245, 245, 242);
            textBox2.Location = new Point(157, 232);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 14;
            textBox2.KeyUp += textBox2_KeyUp;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 184);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 10;
            label7.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreEmpresa.BackColor = Color.FromArgb(245, 245, 242);
            txtNombreEmpresa.Location = new Point(157, 2);
            txtNombreEmpresa.Margin = new Padding(3, 2, 3, 2);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(314, 23);
            txtNombreEmpresa.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 46);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 2;
            label4.Text = "Giro Economico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 92);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 3;
            label5.Text = "Nit:";
            // 
            // txtNit
            // 
            txtNit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNit.BackColor = Color.FromArgb(245, 245, 242);
            txtNit.Location = new Point(157, 94);
            txtNit.Margin = new Padding(3, 2, 3, 2);
            txtNit.MaxLength = 17;
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(314, 23);
            txtNit.TabIndex = 7;
            txtNit.TextChanged += txtNit_TextChanged;
            txtNit.KeyPress += txtNit_KeyPress;
            txtNit.KeyUp += txtNit_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 138);
            label3.Name = "label3";
            label3.Size = new Size(130, 40);
            label3.TabIndex = 1;
            label3.Text = "Representante Legal:";
            // 
            // txtRepresentante
            // 
            txtRepresentante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRepresentante.BackColor = Color.FromArgb(245, 245, 242);
            txtRepresentante.Location = new Point(157, 140);
            txtRepresentante.Margin = new Padding(3, 2, 3, 2);
            txtRepresentante.Name = "txtRepresentante";
            txtRepresentante.Size = new Size(314, 23);
            txtRepresentante.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 230);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 11;
            label8.Text = "Correo:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(245, 245, 242);
            textBox1.Location = new Point(157, 186);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscarGiro);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(157, 48);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 41);
            panel1.TabIndex = 16;
            // 
            // btnBuscarGiro
            // 
            btnBuscarGiro.BackColor = Color.FromArgb(215, 143, 35);
            btnBuscarGiro.Image = (Image)resources.GetObject("btnBuscarGiro.Image");
            btnBuscarGiro.Location = new Point(262, 4);
            btnBuscarGiro.Margin = new Padding(3, 2, 3, 2);
            btnBuscarGiro.Name = "btnBuscarGiro";
            btnBuscarGiro.Size = new Size(46, 30);
            btnBuscarGiro.TabIndex = 1;
            btnBuscarGiro.UseVisualStyleBackColor = false;
            btnBuscarGiro.Click += btnBuscarGiro_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(245, 245, 242);
            textBox4.Enabled = false;
            textBox4.Location = new Point(3, 10);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.MaxLength = 300;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(255, 23);
            textBox4.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 414);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 12;
            label9.Text = "Dirección:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(245, 245, 242);
            textBox3.Location = new Point(157, 416);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 23);
            textBox3.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 368);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 8;
            label6.Text = "Distrito:";
            // 
            // comboDistrito
            // 
            comboDistrito.BackColor = Color.FromArgb(245, 245, 242);
            comboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDistrito.FormattingEnabled = true;
            comboDistrito.Location = new Point(157, 370);
            comboDistrito.Margin = new Padding(3, 2, 3, 2);
            comboDistrito.Name = "comboDistrito";
            comboDistrito.Size = new Size(312, 27);
            comboDistrito.TabIndex = 9;
            comboDistrito.SelectedIndexChanged += comboDistrito_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(3, 322);
            label19.Name = "label19";
            label19.Size = new Size(93, 20);
            label19.TabIndex = 18;
            label19.Text = "Municipio:";
            // 
            // comboDepartamento
            // 
            comboDepartamento.BackColor = Color.FromArgb(245, 245, 242);
            comboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepartamento.FormattingEnabled = true;
            comboDepartamento.Location = new Point(157, 278);
            comboDepartamento.Margin = new Padding(3, 2, 3, 2);
            comboDepartamento.Name = "comboDepartamento";
            comboDepartamento.Size = new Size(314, 27);
            comboDepartamento.TabIndex = 19;
            // 
            // comMunucipio
            // 
            comMunucipio.BackColor = Color.FromArgb(245, 245, 242);
            comMunucipio.DropDownStyle = ComboBoxStyle.DropDownList;
            comMunucipio.FormattingEnabled = true;
            comMunucipio.Location = new Point(157, 324);
            comMunucipio.Margin = new Padding(3, 2, 3, 2);
            comMunucipio.Name = "comMunucipio";
            comMunucipio.Size = new Size(314, 27);
            comMunucipio.TabIndex = 20;
            // 
            // pabelNav
            // 
            pabelNav.Controls.Add(btnAtras);
            pabelNav.Controls.Add(label1);
            pabelNav.Dock = DockStyle.Top;
            pabelNav.Location = new Point(0, 0);
            pabelNav.Margin = new Padding(3, 2, 3, 2);
            pabelNav.Name = "pabelNav";
            pabelNav.Size = new Size(1111, 50);
            pabelNav.TabIndex = 0;
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 2);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 3;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(338, 7);
            label1.Name = "label1";
            label1.Size = new Size(439, 39);
            label1.TabIndex = 2;
            label1.Text = "Información de la Empresa";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // timerNit
            // 
            timerNit.Interval = 500;
            timerNit.Tick += timerNit_Tick;
            // 
            // timerTelefono
            // 
            timerTelefono.Interval = 500;
            timerTelefono.Tick += timerTelefono_Tick;
            // 
            // timerCorreo
            // 
            timerCorreo.Interval = 500;
            timerCorreo.Tick += timerCorreo_Tick;
            // 
            // InfoEmpresacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 638);
            Controls.Add(containerInfoEmpresa);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InfoEmpresacs";
            Text = "InfoEmpresacs";
            Load += InfoEmpresacs_Load;
            Shown += InfoEmpresacs_Shown;
            containerInfoEmpresa.ResumeLayout(false);
            contenidoInfo.ResumeLayout(false);
            groupBoxDoc.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBoxFormulario.ResumeLayout(false);
            groupBoxFormulario.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pabelNav.ResumeLayout(false);
            pabelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel containerInfoEmpresa;
        private Panel pabelNav;
        private Label label1;
        private Panel contenidoInfo;
        private PictureBox btnAtras;
        private GroupBox groupBoxFormulario;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNit;
        private TextBox txtRepresentante;
        private TextBox txtNombreEmpresa;
        private Label label6;
        private ComboBox comboDistrito;
        private Button btnRegistrar;
        private Button btnEdit;
        private Button btnDelete;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox1;
        private GroupBox groupBoxDoc;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox lblEmpresa;
        private TextBox lblDistrito;
        private TextBox lblAddres;
        private TextBox lblEmail;
        private TextBox lblPhone;
        private TextBox lblRepre;
        private TextBox lblNit;
        private TextBox lblComercio;
        private Panel panel1;
        private Button btnBuscarGiro;
        private TextBox textBox4;
        private Label label18;
        private Label label19;
        private ComboBox comboDepartamento;
        private ComboBox comMunucipio;
        private Label label20;
        private Label label21;
        private TextBox lblMunicipio;
        private TextBox lblDepartamento;
        private ErrorProvider errorProvider;
        private System.Windows.Forms.Timer timerNit;
        private System.Windows.Forms.Timer timerTelefono;
        private System.Windows.Forms.Timer timerCorreo;
    }
}