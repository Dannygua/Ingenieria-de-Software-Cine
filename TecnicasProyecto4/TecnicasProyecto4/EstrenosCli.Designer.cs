namespace TecnicasProyecto4
{
    partial class EstrenosCli
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
            this.C2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            this.SuspendLayout();
            // 
            // C2
            // 
            this.C2.Image = global::TecnicasProyecto4.Properties.Resources.C2;
            this.C2.Location = new System.Drawing.Point(157, 80);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(180, 274);
            this.C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.C2.TabIndex = 1;
            this.C2.TabStop = false;
            // 
            // ESTRENOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 840);
            this.Controls.Add(this.C2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ESTRENOS";
            this.Text = "ESTRENOS";
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox C2;
    }
}