namespace TecnicasProyecto4
{
    partial class InicioSesion
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.NomUsu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Silver;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.Location = new System.Drawing.Point(368, 228);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(421, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INICIAR SESION";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 393);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TecnicasProyecto4.Properties.Resources.popcorn__1_;
            this.pictureBox1.Location = new System.Drawing.Point(48, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Image = global::TecnicasProyecto4.Properties.Resources.SC;
            this.Logo.Location = new System.Drawing.Point(26, 11);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(234, 123);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // Contra
            // 
            this.Contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.Contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contra.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contra.ForeColor = System.Drawing.Color.LightGray;
            this.Contra.Location = new System.Drawing.Point(368, 164);
            this.Contra.Margin = new System.Windows.Forms.Padding(2);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(421, 25);
            this.Contra.TabIndex = 2;
            this.Contra.Text = "CONTRASEÑA";
            this.Contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Contra.Enter += new System.EventHandler(this.Contra_Enter);
            this.Contra.Leave += new System.EventHandler(this.Contra_Leave);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Silver;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(368, 292);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(421, 45);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "REGISTRATE";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(514, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "SING IN";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::TecnicasProyecto4.Properties.Resources.minimazar;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Location = new System.Drawing.Point(814, 5);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 21);
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::TecnicasProyecto4.Properties.Resources.cerrar__1_;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(838, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NomUsu
            // 
            this.NomUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.NomUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomUsu.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsu.ForeColor = System.Drawing.Color.LightGray;
            this.NomUsu.Location = new System.Drawing.Point(368, 108);
            this.NomUsu.Margin = new System.Windows.Forms.Padding(2);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(421, 25);
            this.NomUsu.TabIndex = 1;
            this.NomUsu.Text = "USUARIO";
            this.NomUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NomUsu.Enter += new System.EventHandler(this.NomUsu_Enter);
            this.NomUsu.Leave += new System.EventHandler(this.NomUsu_Leave);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(863, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.NomUsu);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InicioSesion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InicioSesion_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NomUsu;
    }
}