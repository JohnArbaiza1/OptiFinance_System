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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmpresacs));
            containerInfoEmpresa = new Panel();
            contenidoInfo = new Panel();
            groupBoxDoc = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblDistrito = new TextBox();
            lblAddres = new TextBox();
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
            label16 = new Label();
            label17 = new Label();
            lblEmpresa = new TextBox();
            groupBoxFormulario = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRegistrar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtNombreEmpresa = new TextBox();
            comboDistrito = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtNit = new TextBox();
            label3 = new Label();
            txtRepresentante = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btnBuscarGiro = new Button();
            textBox4 = new TextBox();
            pabelNav = new Panel();
            btnAtras = new PictureBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            containerInfoEmpresa.SuspendLayout();
            contenidoInfo.SuspendLayout();
            groupBoxDoc.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxFormulario.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            pabelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // containerInfoEmpresa
            // 
            containerInfoEmpresa.BackColor = Color.White;
            containerInfoEmpresa.Controls.Add(contenidoInfo);
            containerInfoEmpresa.Controls.Add(pabelNav);
            containerInfoEmpresa.Dock = DockStyle.Fill;
            containerInfoEmpresa.Location = new Point(0, 0);
            containerInfoEmpresa.Name = "containerInfoEmpresa";
            containerInfoEmpresa.Size = new Size(1270, 851);
            containerInfoEmpresa.TabIndex = 0;
            // 
            // contenidoInfo
            // 
            contenidoInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contenidoInfo.Controls.Add(groupBoxDoc);
            contenidoInfo.Controls.Add(groupBoxFormulario);
            contenidoInfo.Location = new Point(0, 67);
            contenidoInfo.Name = "contenidoInfo";
            contenidoInfo.Size = new Size(1270, 783);
            contenidoInfo.TabIndex = 1;
            // 
            // groupBoxDoc
            // 
            groupBoxDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDoc.Controls.Add(tableLayoutPanel2);
            groupBoxDoc.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDoc.Location = new Point(613, 40);
            groupBoxDoc.Name = "groupBoxDoc";
            groupBoxDoc.Size = new Size(634, 715);
            groupBoxDoc.TabIndex = 0;
            groupBoxDoc.TabStop = false;
            groupBoxDoc.Text = "Datos de la Empresa";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.7691231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.2308769F));
            tableLayoutPanel2.Controls.Add(lblDistrito, 1, 7);
            tableLayoutPanel2.Controls.Add(lblAddres, 1, 6);
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
            tableLayoutPanel2.Controls.Add(label16, 0, 6);
            tableLayoutPanel2.Controls.Add(label17, 0, 7);
            tableLayoutPanel2.Controls.Add(lblEmpresa, 1, 0);
            tableLayoutPanel2.Location = new Point(18, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Size = new Size(597, 535);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDistrito
            // 
            lblDistrito.BackColor = Color.White;
            lblDistrito.BorderStyle = BorderStyle.None;
            lblDistrito.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDistrito.Location = new Point(276, 465);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.PlaceholderText = "San MIguel Centro";
            lblDistrito.ReadOnly = true;
            lblDistrito.Size = new Size(289, 24);
            lblDistrito.TabIndex = 22;
            // 
            // lblAddres
            // 
            lblAddres.BackColor = Color.White;
            lblAddres.BorderStyle = BorderStyle.None;
            lblAddres.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddres.Location = new Point(276, 399);
            lblAddres.Multiline = true;
            lblAddres.Name = "lblAddres";
            lblAddres.PlaceholderText = "San Miguel, El Salvador";
            lblAddres.ReadOnly = true;
            lblAddres.Size = new Size(289, 27);
            lblAddres.TabIndex = 21;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.White;
            lblEmail.BorderStyle = BorderStyle.None;
            lblEmail.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(276, 333);
            lblEmail.Name = "lblEmail";
            lblEmail.PlaceholderText = "optiFinance@gmail.com";
            lblEmail.ReadOnly = true;
            lblEmail.Size = new Size(289, 24);
            lblEmail.TabIndex = 20;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.White;
            lblPhone.BorderStyle = BorderStyle.None;
            lblPhone.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(276, 267);
            lblPhone.Name = "lblPhone";
            lblPhone.PlaceholderText = "00000000";
            lblPhone.ReadOnly = true;
            lblPhone.Size = new Size(289, 24);
            lblPhone.TabIndex = 19;
            // 
            // lblRepre
            // 
            lblRepre.BackColor = Color.White;
            lblRepre.BorderStyle = BorderStyle.None;
            lblRepre.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRepre.Location = new Point(276, 201);
            lblRepre.Name = "lblRepre";
            lblRepre.PlaceholderText = "Pedro ";
            lblRepre.ReadOnly = true;
            lblRepre.Size = new Size(289, 24);
            lblRepre.TabIndex = 18;
            // 
            // lblNit
            // 
            lblNit.BackColor = Color.White;
            lblNit.BorderStyle = BorderStyle.None;
            lblNit.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNit.Location = new Point(276, 135);
            lblNit.Name = "lblNit";
            lblNit.PlaceholderText = "0000000";
            lblNit.ReadOnly = true;
            lblNit.Size = new Size(289, 24);
            lblNit.TabIndex = 17;
            // 
            // lblComercio
            // 
            lblComercio.BackColor = Color.White;
            lblComercio.BorderStyle = BorderStyle.None;
            lblComercio.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblComercio.Location = new Point(276, 69);
            lblComercio.Name = "lblComercio";
            lblComercio.PlaceholderText = "Comercio";
            lblComercio.ReadOnly = true;
            lblComercio.Size = new Size(289, 24);
            lblComercio.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(101, 23);
            label10.TabIndex = 1;
            label10.Text = "Empresa:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 66);
            label11.Name = "label11";
            label11.Size = new Size(167, 23);
            label11.TabIndex = 3;
            label11.Text = "Giro Economico:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 132);
            label12.Name = "label12";
            label12.Size = new Size(261, 46);
            label12.TabIndex = 4;
            label12.Text = "Número de Identificación Tributaria (NIT):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 198);
            label13.Name = "label13";
            label13.Size = new Size(217, 23);
            label13.TabIndex = 5;
            label13.Text = "Representante Legal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(3, 264);
            label14.Name = "label14";
            label14.Size = new Size(97, 23);
            label14.TabIndex = 11;
            label14.Text = "Telefono:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(3, 330);
            label15.Name = "label15";
            label15.Size = new Size(82, 23);
            label15.TabIndex = 12;
            label15.Text = "Correo:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(3, 396);
            label16.Name = "label16";
            label16.Size = new Size(108, 23);
            label16.TabIndex = 13;
            label16.Text = "Dirección:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(3, 462);
            label17.Name = "label17";
            label17.Size = new Size(90, 23);
            label17.TabIndex = 14;
            label17.Text = "Distrito:";
            // 
            // lblEmpresa
            // 
            lblEmpresa.BackColor = Color.White;
            lblEmpresa.BorderStyle = BorderStyle.None;
            lblEmpresa.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpresa.Location = new Point(276, 3);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.PlaceholderText = "OptiFinance";
            lblEmpresa.ReadOnly = true;
            lblEmpresa.Size = new Size(289, 24);
            lblEmpresa.TabIndex = 15;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Controls.Add(btnDelete);
            groupBoxFormulario.Controls.Add(btnEdit);
            groupBoxFormulario.Controls.Add(btnRegistrar);
            groupBoxFormulario.Controls.Add(tableLayoutPanel1);
            groupBoxFormulario.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxFormulario.Location = new Point(25, 77);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Size = new Size(554, 678);
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
            btnDelete.Location = new Point(385, 620);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 52);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "  Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(44, 161, 232);
            btnEdit.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(216, 620);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(163, 52);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "  Editar";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.BackColor = Color.FromArgb(35, 58, 89);
            btnRegistrar.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(14, 561);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(527, 53);
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
            tableLayoutPanel1.Controls.Add(textBox3, 1, 6);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 7);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNombreEmpresa, 1, 0);
            tableLayoutPanel1.Controls.Add(comboDistrito, 1, 7);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(txtNit, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(txtRepresentante, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 6);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Location = new Point(6, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(542, 491);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(245, 245, 242);
            textBox3.Location = new Point(179, 369);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(245, 245, 242);
            textBox2.Location = new Point(179, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 27);
            textBox2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 244);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 10;
            label7.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 427);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 8;
            label6.Text = "Distrito:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreEmpresa.BackColor = Color.FromArgb(245, 245, 242);
            txtNombreEmpresa.Location = new Point(179, 3);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(360, 27);
            txtNombreEmpresa.TabIndex = 4;
            // 
            // comboDistrito
            // 
            comboDistrito.BackColor = Color.FromArgb(245, 245, 242);
            comboDistrito.FormattingEnabled = true;
            comboDistrito.Location = new Point(179, 430);
            comboDistrito.Name = "comboDistrito";
            comboDistrito.Size = new Size(356, 29);
            comboDistrito.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 61);
            label4.Name = "label4";
            label4.Size = new Size(167, 23);
            label4.TabIndex = 2;
            label4.Text = "Giro Economico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 122);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 3;
            label5.Text = "Nit:";
            // 
            // txtNit
            // 
            txtNit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNit.BackColor = Color.FromArgb(245, 245, 242);
            txtNit.Location = new Point(179, 125);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(360, 27);
            txtNit.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 183);
            label3.Name = "label3";
            label3.Size = new Size(159, 46);
            label3.TabIndex = 1;
            label3.Text = "Representante Legal:";
            // 
            // txtRepresentante
            // 
            txtRepresentante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRepresentante.BackColor = Color.FromArgb(245, 245, 242);
            txtRepresentante.Location = new Point(179, 186);
            txtRepresentante.Name = "txtRepresentante";
            txtRepresentante.Size = new Size(360, 27);
            txtRepresentante.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 305);
            label8.Name = "label8";
            label8.Size = new Size(82, 23);
            label8.TabIndex = 11;
            label8.Text = "Correo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 366);
            label9.Name = "label9";
            label9.Size = new Size(108, 23);
            label9.TabIndex = 12;
            label9.Text = "Dirección:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(245, 245, 242);
            textBox1.Location = new Point(179, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 27);
            textBox1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscarGiro);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(179, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 55);
            panel1.TabIndex = 16;
            // 
            // btnBuscarGiro
            // 
            btnBuscarGiro.BackColor = Color.FromArgb(215, 143, 35);
            btnBuscarGiro.Image = (Image)resources.GetObject("btnBuscarGiro.Image");
            btnBuscarGiro.Location = new Point(300, 6);
            btnBuscarGiro.Name = "btnBuscarGiro";
            btnBuscarGiro.Size = new Size(53, 40);
            btnBuscarGiro.TabIndex = 1;
            btnBuscarGiro.UseVisualStyleBackColor = false;
            btnBuscarGiro.Click += btnBuscarGiro_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(245, 245, 242);
            textBox4.Location = new Point(3, 13);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(291, 27);
            textBox4.TabIndex = 16;
            // 
            // pabelNav
            // 
            pabelNav.Controls.Add(btnAtras);
            pabelNav.Controls.Add(label1);
            pabelNav.Dock = DockStyle.Top;
            pabelNav.Location = new Point(0, 0);
            pabelNav.Name = "pabelNav";
            pabelNav.Size = new Size(1270, 67);
            pabelNav.TabIndex = 0;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(386, 9);
            label1.Name = "label1";
            label1.Size = new Size(549, 45);
            label1.TabIndex = 2;
            label1.Text = "Información de la Empresa";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // InfoEmpresacs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 851);
            Controls.Add(containerInfoEmpresa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoEmpresacs";
            Text = "InfoEmpresacs";
            Load += InfoEmpresacs_Load;
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
    }
}