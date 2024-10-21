namespace OptiFinance_System.Views
{
    partial class estado_Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estado_Resultado));
            panel1 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            panel2 = new Panel();
            btnResultados = new Button();
            contenedorEstadoResultados = new Panel();
            listView1 = new ListView();
            lblFechaEResultados = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            panel2.SuspendLayout();
            contenedorEstadoResultados.SuspendLayout();
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
            label1.Location = new Point(366, 9);
            label1.Name = "label1";
            label1.Size = new Size(554, 45);
            label1.TabIndex = 8;
            label1.Text = "ESTADO DE RESULTADOS";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 5;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnResultados);
            panel2.Controls.Add(contenedorEstadoResultados);
            panel2.Controls.Add(lblFechaEResultados);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 781);
            panel2.TabIndex = 1;
            // 
            // btnResultados
            // 
            btnResultados.BackColor = Color.FromArgb(31, 58, 93);
            btnResultados.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResultados.ForeColor = Color.White;
            btnResultados.Location = new Point(664, 705);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(339, 45);
            btnResultados.TabIndex = 10;
            btnResultados.Text = "Generar Estado de Resultados ";
            btnResultados.UseVisualStyleBackColor = false;
            // 
            // contenedorEstadoResultados
            // 
            contenedorEstadoResultados.BorderStyle = BorderStyle.Fixed3D;
            contenedorEstadoResultados.Controls.Add(listView1);
            contenedorEstadoResultados.Location = new Point(277, 58);
            contenedorEstadoResultados.Name = "contenedorEstadoResultados";
            contenedorEstadoResultados.Size = new Size(726, 641);
            contenedorEstadoResultados.TabIndex = 9;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(722, 637);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // lblFechaEResultados
            // 
            lblFechaEResultados.Anchor = AnchorStyles.Top;
            lblFechaEResultados.AutoSize = true;
            lblFechaEResultados.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaEResultados.ForeColor = Color.FromArgb(35, 55, 80);
            lblFechaEResultados.Location = new Point(434, 20);
            lblFechaEResultados.Name = "lblFechaEResultados";
            lblFechaEResultados.Size = new Size(390, 23);
            lblFechaEResultados.TabIndex = 8;
            lblFechaEResultados.Text = "Estado de resultados del día/mes/ año";
            // 
            // estado_Resultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 850);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "estado_Resultado";
            Text = "estado_Resultado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contenedorEstadoResultados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnAtras;
        private Label label1;
        private Panel panel2;
        private Label lblFechaEResultados;
        private Panel contenedorEstadoResultados;
        private ListView listView1;
        private Button btnResultados;
    }
}