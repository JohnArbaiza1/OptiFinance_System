﻿namespace OptiFinance_System.Views
{
    partial class busquedaGiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(busquedaGiro));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            barraTiulo = new Panel();
            btnSalir = new PictureBox();
            txtBusquedaGiro = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            dataGiros = new DataGridView();
            btnGuardarGiro = new Button();
            barraTiulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGiros).BeginInit();
            SuspendLayout();
            // 
            // barraTiulo
            // 
            barraTiulo.Controls.Add(btnSalir);
            barraTiulo.Controls.Add(txtBusquedaGiro);
            barraTiulo.Dock = DockStyle.Top;
            barraTiulo.Location = new Point(0, 0);
            barraTiulo.Margin = new Padding(3, 2, 3, 2);
            barraTiulo.Name = "barraTiulo";
            barraTiulo.Size = new Size(411, 49);
            barraTiulo.TabIndex = 0;
            barraTiulo.MouseDown += barraTiulo_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(355, 1);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(64, 64);
            btnSalir.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSalir.TabIndex = 13;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBusquedaGiro
            // 
            txtBusquedaGiro.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusquedaGiro.Location = new Point(32, 11);
            txtBusquedaGiro.Margin = new Padding(3, 2, 3, 2);
            txtBusquedaGiro.Name = "txtBusquedaGiro";
            txtBusquedaGiro.PlaceholderText = "Ingrese su Giro";
            txtBusquedaGiro.Size = new Size(294, 26);
            txtBusquedaGiro.TabIndex = 3;
            txtBusquedaGiro.KeyPress += txtBusquedaGiro_KeyPress;
            txtBusquedaGiro.KeyUp += txtBusquedaGiro_KeyUp;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 55, 80);
            label1.Location = new Point(91, 51);
            label1.Name = "label1";
            label1.Size = new Size(216, 25);
            label1.TabIndex = 2;
            label1.Text = "Giros Comerciales.";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(215, 143, 35);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(330, 86);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(46, 30);
            btnBuscar.TabIndex = 4;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGiros
            // 
            dataGiros.AllowUserToAddRows = false;
            dataGiros.AllowUserToDeleteRows = false;
            dataGiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGiros.BackgroundColor = Color.White;
            dataGiros.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 58, 93);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGiros.EnableHeadersVisualStyles = false;
            dataGiros.Location = new Point(0, 49);
            dataGiros.Margin = new Padding(3, 2, 3, 2);
            dataGiros.MultiSelect = false;
            dataGiros.Name = "dataGiros";
            dataGiros.ReadOnly = true;
            dataGiros.RowHeadersWidth = 51;
            dataGiros.RowTemplate.Height = 29;
            dataGiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGiros.Size = new Size(411, 301);
            dataGiros.TabIndex = 5;
            // 
            // btnGuardarGiro
            // 
            btnGuardarGiro.BackColor = Color.FromArgb(31, 58, 93);
            btnGuardarGiro.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarGiro.ForeColor = Color.White;
            btnGuardarGiro.Location = new Point(32, 354);
            btnGuardarGiro.Margin = new Padding(3, 2, 3, 2);
            btnGuardarGiro.Name = "btnGuardarGiro";
            btnGuardarGiro.Size = new Size(345, 36);
            btnGuardarGiro.TabIndex = 6;
            btnGuardarGiro.Text = "Guardar Giro";
            btnGuardarGiro.UseVisualStyleBackColor = false;
            btnGuardarGiro.Click += btnGuardarGiro_Click;
            // 
            // busquedaGiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 242);
            ClientSize = new Size(411, 399);
            Controls.Add(btnGuardarGiro);
            Controls.Add(dataGiros);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(barraTiulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "busquedaGiro";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += busquedaGiro_Shown;
            barraTiulo.ResumeLayout(false);
            barraTiulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGiros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel barraTiulo;
        private PictureBox btnSalir;
        private Label label1;
        private TextBox txtBusquedaGiro;
        private Button btnBuscar;
        private DataGridView dataGiros;
        private Button btnGuardarGiro;
    }
}