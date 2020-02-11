namespace TecnicasProyecto4
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btnCartelera = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.barrainicio = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.barracontenido = new System.Windows.Forms.Panel();
            this.NomUsu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.barrainicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCartelera
            // 
            this.btnCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartelera.FlatAppearance.BorderSize = 0;
            this.btnCartelera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCartelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartelera.ForeColor = System.Drawing.Color.White;
            this.btnCartelera.Location = new System.Drawing.Point(299, 1);
            this.btnCartelera.Margin = new System.Windows.Forms.Padding(2);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(273, 126);
            this.btnCartelera.TabIndex = 8;
            this.btnCartelera.Text = "CARTELERA";
            this.btnCartelera.UseVisualStyleBackColor = true;
            this.btnCartelera.Click += new System.EventHandler(this.btnCartelera_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(577, 1);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(274, 126);
            this.button7.TabIndex = 6;
            this.button7.Text = "DULCERIA";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::TecnicasProyecto4.Properties.Resources.cerrar__1_;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1199, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::TecnicasProyecto4.Properties.Resources.minimazar;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Location = new System.Drawing.Point(1175, 8);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 21);
            this.btnMin.TabIndex = 11;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(11, 30);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(272, 69);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 15;
            this.Logo.TabStop = false;
            // 
            // barrainicio
            // 
            this.barrainicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.barrainicio.Controls.Add(this.NomUsu);
            this.barrainicio.Controls.Add(this.Logo);
            this.barrainicio.Controls.Add(this.btnClose);
            this.barrainicio.Controls.Add(this.btnMin);
            this.barrainicio.Controls.Add(this.btnCartelera);
            this.barrainicio.Controls.Add(this.button1);
            this.barrainicio.Controls.Add(this.button7);
            this.barrainicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrainicio.Location = new System.Drawing.Point(0, 0);
            this.barrainicio.Margin = new System.Windows.Forms.Padding(2);
            this.barrainicio.Name = "barrainicio";
            this.barrainicio.Size = new System.Drawing.Size(1225, 126);
            this.barrainicio.TabIndex = 16;
            this.barrainicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barrainicio_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1132, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "CERRAR SESION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barracontenido
            // 
            this.barracontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barracontenido.Location = new System.Drawing.Point(0, 126);
            this.barracontenido.Margin = new System.Windows.Forms.Padding(2);
            this.barracontenido.Name = "barracontenido";
            this.barracontenido.Size = new System.Drawing.Size(1225, 634);
            this.barracontenido.TabIndex = 17;
            // 
            // NomUsu
            // 
            this.NomUsu.AutoSize = true;
            this.NomUsu.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.NomUsu.Location = new System.Drawing.Point(26, 7);
            this.NomUsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(51, 16);
            this.NomUsu.TabIndex = 16;
            this.NomUsu.Text = "label1";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 760);
            this.Controls.Add(this.barracontenido);
            this.Controls.Add(this.barrainicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.barrainicio.ResumeLayout(false);
            this.barrainicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barrainicio;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnCartelera;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel barracontenido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NomUsu;
    }
}