namespace TecnicasProyecto4
{
    partial class Admi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barrainicio = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.NomUsu = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.barramenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCS = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.barracontenido = new System.Windows.Forms.Panel();
            this.barrainicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.barramenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barrainicio
            // 
            this.barrainicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.barrainicio.Controls.Add(this.Logo);
            this.barrainicio.Controls.Add(this.NomUsu);
            this.barrainicio.Controls.Add(this.btnMin);
            this.barrainicio.Controls.Add(this.btnClose);
            this.barrainicio.Controls.Add(this.button1);
            this.barrainicio.Controls.Add(this.button7);
            this.barrainicio.Controls.Add(this.button6);
            this.barrainicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrainicio.Location = new System.Drawing.Point(0, 0);
            this.barrainicio.Margin = new System.Windows.Forms.Padding(2);
            this.barrainicio.Name = "barrainicio";
            this.barrainicio.Size = new System.Drawing.Size(1469, 126);
            this.barrainicio.TabIndex = 0;
            this.barrainicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barrainicio_MouseDown);
            // 
            // Logo
            // 
            this.Logo.Image = global::TecnicasProyecto4.Properties.Resources.SC;
            this.Logo.Location = new System.Drawing.Point(11, 37);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(272, 69);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // NomUsu
            // 
            this.NomUsu.AutoSize = true;
            this.NomUsu.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.NomUsu.Location = new System.Drawing.Point(11, 9);
            this.NomUsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(51, 16);
            this.NomUsu.TabIndex = 3;
            this.NomUsu.Text = "label1";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::TecnicasProyecto4.Properties.Resources.minimazar;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Location = new System.Drawing.Point(1419, 7);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 21);
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::TecnicasProyecto4.Properties.Resources.cerrar__1_;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1443, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1125, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "ESTADISTICAS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(847, 1);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(274, 126);
            this.button7.TabIndex = 0;
            this.button7.Text = "VENTAS";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(569, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(274, 126);
            this.button6.TabIndex = 0;
            this.button6.Text = "REGISTRO USUARIOS";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // barramenu
            // 
            this.barramenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.barramenu.Controls.Add(this.panel3);
            this.barramenu.Controls.Add(this.panel2);
            this.barramenu.Controls.Add(this.panel1);
            this.barramenu.Controls.Add(this.btnCS);
            this.barramenu.Controls.Add(this.button3);
            this.barramenu.Controls.Add(this.button2);
            this.barramenu.Controls.Add(this.btnCatalogo);
            this.barramenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barramenu.Location = new System.Drawing.Point(0, 126);
            this.barramenu.Margin = new System.Windows.Forms.Padding(2);
            this.barramenu.Name = "barramenu";
            this.barramenu.Size = new System.Drawing.Size(244, 634);
            this.barramenu.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.panel3.Location = new System.Drawing.Point(1, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 45);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.panel2.Location = new System.Drawing.Point(1, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 45);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.panel1.Location = new System.Drawing.Point(1, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnCS
            // 
            this.btnCS.FlatAppearance.BorderSize = 0;
            this.btnCS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCS.ForeColor = System.Drawing.Color.White;
            this.btnCS.Location = new System.Drawing.Point(1, 561);
            this.btnCS.Margin = new System.Windows.Forms.Padding(2);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(244, 72);
            this.btnCS.TabIndex = 0;
            this.btnCS.Text = "CERRAR SESION";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(8, 151);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "AGREGAR ADMINISTRADOR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(8, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "DULCERIA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCatalogo.Image = global::TecnicasProyecto4.Properties.Resources.pagos;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(8, 33);
            this.btnCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(236, 45);
            this.btnCatalogo.TabIndex = 0;
            this.btnCatalogo.Text = "CATALOGO";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // barracontenido
            // 
            this.barracontenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.barracontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barracontenido.Location = new System.Drawing.Point(244, 126);
            this.barracontenido.Margin = new System.Windows.Forms.Padding(2);
            this.barracontenido.Name = "barracontenido";
            this.barracontenido.Size = new System.Drawing.Size(1225, 634);
            this.barracontenido.TabIndex = 2;
            // 
            // Admi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 760);
            this.Controls.Add(this.barracontenido);
            this.Controls.Add(this.barramenu);
            this.Controls.Add(this.barrainicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barrainicio.ResumeLayout(false);
            this.barrainicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.barramenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barrainicio;
        private System.Windows.Forms.Panel barramenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Panel barracontenido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.Label NomUsu;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
    }
}

