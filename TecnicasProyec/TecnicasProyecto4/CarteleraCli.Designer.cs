namespace TecnicasProyecto4
{
    partial class CarteleraCli
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
            this.barramenu = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.PEstrenos = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.barracontenido = new System.Windows.Forms.Panel();
            this.barramenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barramenu
            // 
            this.barramenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.barramenu.Controls.Add(this.btnInicio);
            this.barramenu.Controls.Add(this.PEstrenos);
            this.barramenu.Controls.Add(this.btnCatalogo);
            this.barramenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barramenu.Location = new System.Drawing.Point(0, 0);
            this.barramenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barramenu.Name = "barramenu";
            this.barramenu.Size = new System.Drawing.Size(244, 634);
            this.barramenu.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(2, 41);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(242, 53);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // PEstrenos
            // 
            this.PEstrenos.FlatAppearance.BorderSize = 0;
            this.PEstrenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.PEstrenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PEstrenos.ForeColor = System.Drawing.Color.White;
            this.PEstrenos.Location = new System.Drawing.Point(2, 154);
            this.PEstrenos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PEstrenos.Name = "PEstrenos";
            this.PEstrenos.Size = new System.Drawing.Size(242, 53);
            this.PEstrenos.TabIndex = 2;
            this.PEstrenos.Text = "PROXIMOS ESTRENOS";
            this.PEstrenos.UseVisualStyleBackColor = true;
            this.PEstrenos.Click += new System.EventHandler(this.PEstrenos_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(2, 98);
            this.btnCatalogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(242, 53);
            this.btnCatalogo.TabIndex = 4;
            this.btnCatalogo.Text = "CATALOGO";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // barracontenido
            // 
            this.barracontenido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.barracontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barracontenido.Location = new System.Drawing.Point(244, 0);
            this.barracontenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barracontenido.Name = "barracontenido";
            this.barracontenido.Size = new System.Drawing.Size(981, 634);
            this.barracontenido.TabIndex = 1;
            // 
            // CarteleraCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 634);
            this.Controls.Add(this.barracontenido);
            this.Controls.Add(this.barramenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CarteleraCli";
            this.Text = "CarteleraCli";
            this.barramenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barramenu;
        private System.Windows.Forms.Panel barracontenido;
        private System.Windows.Forms.Button PEstrenos;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnInicio;
    }
}