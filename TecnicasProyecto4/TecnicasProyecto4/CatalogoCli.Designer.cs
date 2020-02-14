using System;

namespace TecnicasProyecto4
{
    partial class CatalogoCli
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Pelicula;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCli));
            System.Windows.Forms.Label label5;
            this.btnCompra = new System.Windows.Forms.Button();
            this.peliculasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineDataSet1 = new TecnicasProyecto4.CineDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nombrePeTextBox = new System.Windows.Forms.TextBox();
            this.webPeTextBox = new System.Windows.Forms.TextBox();
            this.directoresPeTextBox = new System.Windows.Forms.TextBox();
            this.actoresPeTextBox = new System.Windows.Forms.TextBox();
            this.descripcionPeTextBox = new System.Windows.Forms.TextBox();
            this.horariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.PeliculasTableAdapter();
            this.tableAdapterManager = new TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager();
            this.horariosTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.HorariosTableAdapter();
            this.funcionTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.FuncionTableAdapter();
            this.funcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.codigoPeTextBox = new System.Windows.Forms.TextBox();
            this.imagenPeTextBox = new System.Windows.Forms.TextBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            this.lblComentario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            Pelicula = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingNavigator)).BeginInit();
            this.peliculasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pelicula
            // 
            Pelicula.AutoSize = true;
            Pelicula.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Pelicula.ForeColor = System.Drawing.Color.RoyalBlue;
            Pelicula.Location = new System.Drawing.Point(358, 90);
            Pelicula.Name = "Pelicula";
            Pelicula.Size = new System.Drawing.Size(103, 18);
            Pelicula.TabIndex = 8;
            Pelicula.Text = "PELICULA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.RoyalBlue;
            label1.Location = new System.Drawing.Point(358, 135);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 18);
            label1.TabIndex = 8;
            label1.Text = "WEB OFICIAL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.RoyalBlue;
            label2.Location = new System.Drawing.Point(358, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 18);
            label2.TabIndex = 8;
            label2.Text = "DIRECTOR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.RoyalBlue;
            label3.Location = new System.Drawing.Point(360, 225);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 18);
            label3.TabIndex = 8;
            label3.Text = "ACTORES:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.RoyalBlue;
            label4.Location = new System.Drawing.Point(360, 269);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(99, 18);
            label4.TabIndex = 8;
            label4.Text = "SINOPSIS:";
            // 
            // btnCompra
            // 
            this.btnCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.Location = new System.Drawing.Point(30, 588);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 41);
            this.btnCompra.TabIndex = 6;
            this.btnCompra.Text = "COMPRAR";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // peliculasBindingNavigator
            // 
            this.peliculasBindingNavigator.AddNewItem = null;
            this.peliculasBindingNavigator.BindingSource = this.peliculasBindingSource;
            this.peliculasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peliculasBindingNavigator.DeleteItem = null;
            this.peliculasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.peliculasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2});
            this.peliculasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peliculasBindingNavigator.MoveFirstItem = null;
            this.peliculasBindingNavigator.MoveLastItem = null;
            this.peliculasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peliculasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peliculasBindingNavigator.Name = "peliculasBindingNavigator";
            this.peliculasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peliculasBindingNavigator.Size = new System.Drawing.Size(1167, 27);
            this.peliculasBindingNavigator.TabIndex = 8;
            this.peliculasBindingNavigator.Text = "bindingNavigator1";
            this.peliculasBindingNavigator.RefreshItems += new System.EventHandler(this.peliculasBindingNavigator_RefreshItems);
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "Peliculas";
            this.peliculasBindingSource.DataSource = this.cineDataSet1;
            // 
            // cineDataSet1
            // 
            this.cineDataSet1.DataSetName = "CineDataSet1";
            this.cineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // nombrePeTextBox
            // 
            this.nombrePeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nombrePeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombrePeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "NombrePe", true));
            this.nombrePeTextBox.Enabled = false;
            this.nombrePeTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePeTextBox.Location = new System.Drawing.Point(534, 87);
            this.nombrePeTextBox.Name = "nombrePeTextBox";
            this.nombrePeTextBox.Size = new System.Drawing.Size(420, 15);
            this.nombrePeTextBox.TabIndex = 9;
            this.nombrePeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webPeTextBox
            // 
            this.webPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.webPeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.webPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "WebPe", true));
            this.webPeTextBox.Enabled = false;
            this.webPeTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webPeTextBox.Location = new System.Drawing.Point(534, 133);
            this.webPeTextBox.Name = "webPeTextBox";
            this.webPeTextBox.Size = new System.Drawing.Size(420, 15);
            this.webPeTextBox.TabIndex = 11;
            // 
            // directoresPeTextBox
            // 
            this.directoresPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.directoresPeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directoresPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "DirectoresPe", true));
            this.directoresPeTextBox.Enabled = false;
            this.directoresPeTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoresPeTextBox.Location = new System.Drawing.Point(534, 179);
            this.directoresPeTextBox.Name = "directoresPeTextBox";
            this.directoresPeTextBox.Size = new System.Drawing.Size(420, 15);
            this.directoresPeTextBox.TabIndex = 12;
            // 
            // actoresPeTextBox
            // 
            this.actoresPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actoresPeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actoresPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "ActoresPe", true));
            this.actoresPeTextBox.Enabled = false;
            this.actoresPeTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actoresPeTextBox.Location = new System.Drawing.Point(534, 223);
            this.actoresPeTextBox.Name = "actoresPeTextBox";
            this.actoresPeTextBox.Size = new System.Drawing.Size(420, 15);
            this.actoresPeTextBox.TabIndex = 13;
            // 
            // descripcionPeTextBox
            // 
            this.descripcionPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.descripcionPeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcionPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "DescripcionPe", true));
            this.descripcionPeTextBox.Enabled = false;
            this.descripcionPeTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionPeTextBox.Location = new System.Drawing.Point(534, 269);
            this.descripcionPeTextBox.Multiline = true;
            this.descripcionPeTextBox.Name = "descripcionPeTextBox";
            this.descripcionPeTextBox.Size = new System.Drawing.Size(420, 208);
            this.descripcionPeTextBox.TabIndex = 14;
            // 
            // horariosBindingSource
            // 
            this.horariosBindingSource.DataMember = "Horarios";
            this.horariosBindingSource.DataSource = this.cineDataSet1;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsientosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombosTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.FuncionTableAdapter = null;
            this.tableAdapterManager.HorariosTableAdapter = this.horariosTableAdapter;
            this.tableAdapterManager.PeliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // horariosTableAdapter
            // 
            this.horariosTableAdapter.ClearBeforeFill = true;
            // 
            // funcionTableAdapter
            // 
            this.funcionTableAdapter.ClearBeforeFill = true;
            // 
            // funcionBindingSource
            // 
            this.funcionBindingSource.DataMember = "Funcion";
            this.funcionBindingSource.DataSource = this.cineDataSet1;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1167, 25);
            this.fillByToolStrip.TabIndex = 19;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // codigoPeTextBox
            // 
            this.codigoPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.codigoPeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "CodigoPe", true));
            this.codigoPeTextBox.Enabled = false;
            this.codigoPeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.codigoPeTextBox.Location = new System.Drawing.Point(411, 327);
            this.codigoPeTextBox.Name = "codigoPeTextBox";
            this.codigoPeTextBox.Size = new System.Drawing.Size(99, 13);
            this.codigoPeTextBox.TabIndex = 20;
            // 
            // imagenPeTextBox
            // 
            this.imagenPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenPeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagenPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "ImagenPe", true));
            this.imagenPeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenPeTextBox.Location = new System.Drawing.Point(435, 392);
            this.imagenPeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagenPeTextBox.Name = "imagenPeTextBox";
            this.imagenPeTextBox.Size = new System.Drawing.Size(75, 13);
            this.imagenPeTextBox.TabIndex = 21;
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(51, 98);
            this.C1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(260, 390);
            this.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.C1.TabIndex = 22;
            this.C1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.RoyalBlue;
            label5.Location = new System.Drawing.Point(358, 504);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(132, 18);
            label5.TabIndex = 23;
            label5.Text = "COMENTARIO";
            // 
            // lblComentario
            // 
            this.lblComentario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblComentario.Location = new System.Drawing.Point(534, 504);
            this.lblComentario.Multiline = true;
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(420, 76);
            this.lblComentario.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(534, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Agregar Comentario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatalogoCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(label5);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.imagenPeTextBox);
            this.Controls.Add(this.codigoPeTextBox);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.descripcionPeTextBox);
            this.Controls.Add(this.actoresPeTextBox);
            this.Controls.Add(this.directoresPeTextBox);
            this.Controls.Add(this.webPeTextBox);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(Pelicula);
            this.Controls.Add(this.peliculasBindingNavigator);
            this.Controls.Add(this.nombrePeTextBox);
            this.Controls.Add(this.btnCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CatalogoCli";
            this.Text = "CatalogoCli";
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingNavigator)).EndInit();
            this.peliculasBindingNavigator.ResumeLayout(false);
            this.peliculasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CatalogoCli_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void C8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnCompra;
        private CineDataSet1 cineDataSet1;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private CineDataSet1TableAdapters.PeliculasTableAdapter peliculasTableAdapter;
        private CineDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator peliculasBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private CineDataSet1TableAdapters.HorariosTableAdapter horariosTableAdapter;
        private System.Windows.Forms.TextBox nombrePeTextBox;
        private System.Windows.Forms.BindingSource horariosBindingSource;
        private System.Windows.Forms.TextBox directoresPeTextBox;
        private System.Windows.Forms.TextBox webPeTextBox;
        private System.Windows.Forms.TextBox actoresPeTextBox;
        private System.Windows.Forms.TextBox descripcionPeTextBox;
        private CineDataSet1TableAdapters.FuncionTableAdapter funcionTableAdapter;
        private System.Windows.Forms.BindingSource funcionBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.TextBox codigoPeTextBox;
        private System.Windows.Forms.TextBox imagenPeTextBox;
        private System.Windows.Forms.PictureBox C1;
        private System.Windows.Forms.TextBox lblComentario;
        private System.Windows.Forms.Button button1;
    }
}