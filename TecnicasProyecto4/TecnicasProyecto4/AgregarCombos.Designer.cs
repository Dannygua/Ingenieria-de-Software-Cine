namespace TecnicasProyecto4
{
    partial class AgregarCombos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.registrar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.combos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(322, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combos";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.registrar);
            this.panel1.Controls.Add(this.txtContenido);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(52, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(52, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.LimeGreen;
            this.registrar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.ForeColor = System.Drawing.SystemColors.Info;
            this.registrar.Location = new System.Drawing.Point(52, 386);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(99, 23);
            this.registrar.TabIndex = 6;
            this.registrar.Text = "REGISTRAR";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.BackColor = System.Drawing.Color.Gold;
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.ForeColor = System.Drawing.Color.Navy;
            this.txtContenido.Location = new System.Drawing.Point(29, 234);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(142, 88);
            this.txtContenido.TabIndex = 4;
            this.txtContenido.Text = "Contenido";
            this.txtContenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Gold;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Navy;
            this.txtPrecio.Location = new System.Drawing.Point(29, 190);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 15);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "Precio";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Gold;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Navy;
            this.txtNombre.Location = new System.Drawing.Point(29, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 15);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Gold;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Navy;
            this.txtCodigo.Location = new System.Drawing.Point(29, 114);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.Size = new System.Drawing.Size(142, 15);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Text = "Código";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(52, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // combos
            // 
            this.combos.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.combos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.combos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combos.Location = new System.Drawing.Point(206, 114);
            this.combos.Name = "combos";
            this.combos.Size = new System.Drawing.Size(582, 254);
            this.combos.TabIndex = 2;
            this.combos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Combos_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 83);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(186, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "GESTIÓN DE COMBOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.combos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCombos";
            this.Text = "AgregarCombos";
            this.Load += new System.EventHandler(this.AgregarCombos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView combos;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button registrar;
    }
}