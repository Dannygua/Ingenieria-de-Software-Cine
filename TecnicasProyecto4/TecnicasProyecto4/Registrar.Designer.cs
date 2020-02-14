namespace TecnicasProyecto4
{
    partial class Registrar
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
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.TextBox();
            this.lblNombreU = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.TextBox();
            this.FechaN = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombre.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(200, 123);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(405, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRES";
            this.lblNombre.TextChanged += new System.EventHandler(this.lblNombre_TextChanged);
            this.lblNombre.Enter += new System.EventHandler(this.lblNombre_Enter);
            this.lblNombre.Leave += new System.EventHandler(this.lblNombre_Leave);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Silver;
            this.btnCrear.Location = new System.Drawing.Point(83, 409);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(322, 45);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "REGISTRAR";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblApellido.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(200, 173);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(405, 19);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "APELLIDOS";
            this.lblApellido.Enter += new System.EventHandler(this.lblApellido_Enter);
            this.lblApellido.Leave += new System.EventHandler(this.lblApellido_Leave);
            // 
            // lblNombreU
            // 
            this.lblNombreU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.lblNombreU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombreU.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreU.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombreU.Location = new System.Drawing.Point(169, 220);
            this.lblNombreU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(405, 19);
            this.lblNombreU.TabIndex = 2;
            this.lblNombreU.Text = "NOMBRE USUARIO";
            this.lblNombreU.Enter += new System.EventHandler(this.lblNombreU_Enter);
            this.lblNombreU.Leave += new System.EventHandler(this.lblNombreU_Leave);
            // 
            // lblContra
            // 
            this.lblContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.lblContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblContra.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.DimGray;
            this.lblContra.Location = new System.Drawing.Point(187, 265);
            this.lblContra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(405, 19);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "CONTRASEÑA";
            this.lblContra.Enter += new System.EventHandler(this.lblContra_Enter);
            this.lblContra.Leave += new System.EventHandler(this.lblContra_Leave);
            // 
            // lblCorreo
            // 
            this.lblCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.lblCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCorreo.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCorreo.Location = new System.Drawing.Point(209, 314);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(405, 19);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "CORREO";
            this.lblCorreo.TextChanged += new System.EventHandler(this.lblCorreo_TextChanged);
            this.lblCorreo.Enter += new System.EventHandler(this.lblCorreo_Enter);
            this.lblCorreo.Leave += new System.EventHandler(this.lblCorreo_Leave);
            // 
            // FechaN
            // 
            this.FechaN.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FechaN.CalendarMonthBackground = System.Drawing.Color.Gold;
            this.FechaN.Location = new System.Drawing.Point(143, 359);
            this.FechaN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FechaN.Name = "FechaN";
            this.FechaN.Size = new System.Drawing.Size(199, 20);
            this.FechaN.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(153, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "REGISTRO";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(499, 492);
            this.Controls.Add(this.FechaN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNombreU);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registrar_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblNombre;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox lblApellido;
        private System.Windows.Forms.TextBox lblNombreU;
        private System.Windows.Forms.TextBox lblContra;
        private System.Windows.Forms.TextBox lblCorreo;
        private System.Windows.Forms.DateTimePicker FechaN;
        private System.Windows.Forms.Label label1;
    }
}