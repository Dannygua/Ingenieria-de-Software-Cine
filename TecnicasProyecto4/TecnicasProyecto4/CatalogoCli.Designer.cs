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
            this.btnCompra = new System.Windows.Forms.Button();
            this.peliculasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineDataSet1 = new TecnicasProyecto4.CineDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.peliculasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            Pelicula = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingNavigator)).BeginInit();
            this.peliculasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
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
            this.btnCompra.Location = new System.Drawing.Point(30, 646);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 41);
            this.btnCompra.TabIndex = 6;
            this.btnCompra.Text = "COMPRAR";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // peliculasBindingNavigator
            // 
            this.peliculasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peliculasBindingNavigator.BindingSource = this.peliculasBindingSource;
            this.peliculasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peliculasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.peliculasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.peliculasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.peliculasBindingNavigatorSaveItem});
            this.peliculasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peliculasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peliculasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peliculasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peliculasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peliculasBindingNavigator.Name = "peliculasBindingNavigator";
            this.peliculasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peliculasBindingNavigator.Size = new System.Drawing.Size(1167, 27);
            this.peliculasBindingNavigator.TabIndex = 8;
            this.peliculasBindingNavigator.Text = "bindingNavigator1";
            this.peliculasBindingNavigator.RefreshItems += new System.EventHandler(this.peliculasBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // peliculasBindingNavigatorSaveItem
            // 
            this.peliculasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peliculasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peliculasBindingNavigatorSaveItem.Image")));
            this.peliculasBindingNavigatorSaveItem.Name = "peliculasBindingNavigatorSaveItem";
            this.peliculasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.peliculasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.peliculasBindingNavigatorSaveItem.Click += new System.EventHandler(this.peliculasBindingNavigatorSaveItem_Click);
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
            this.codigoPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "CodigoPe", true));
            this.codigoPeTextBox.Enabled = false;
            this.codigoPeTextBox.Location = new System.Drawing.Point(435, 317);
            this.codigoPeTextBox.Name = "codigoPeTextBox";
            this.codigoPeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoPeTextBox.TabIndex = 20;
            // 
            // CatalogoCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 718);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton peliculasBindingNavigatorSaveItem;
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
    }
}