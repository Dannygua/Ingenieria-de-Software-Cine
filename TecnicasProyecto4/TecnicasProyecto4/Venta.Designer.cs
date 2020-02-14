namespace TecnicasProyecto4
{
    partial class Venta
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.funcionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.funcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.funcionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoHoTextBox = new System.Windows.Forms.TextBox();
            this.findCodHoToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findCodHoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.horaHoTextBox = new System.Windows.Forms.TextBox();
            this.horariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFHorario = new System.Windows.Forms.Button();
            this.btnFPelicula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VAsientos = new System.Windows.Forms.Panel();
            this.btnSeleccionFuncion = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.codigoFuTextBox = new System.Windows.Forms.TextBox();
            this.funcionTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.FuncionTableAdapter();
            this.tableAdapterManager = new TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager();
            this.horariosTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.HorariosTableAdapter();
            this.lblPelicula = new System.Windows.Forms.Label();
            Pelicula = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingNavigator)).BeginInit();
            this.funcionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            this.findCodHoToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pelicula
            // 
            Pelicula.AutoSize = true;
            Pelicula.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Pelicula.ForeColor = System.Drawing.Color.RoyalBlue;
            Pelicula.Location = new System.Drawing.Point(104, 241);
            Pelicula.Name = "Pelicula";
            Pelicula.Size = new System.Drawing.Size(99, 18);
            Pelicula.TabIndex = 10;
            Pelicula.Text = "HORARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.RoyalBlue;
            label2.Location = new System.Drawing.Point(104, 202);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 18);
            label2.TabIndex = 10;
            label2.Text = "PELICULA:";
            // 
            // funcionBindingNavigator
            // 
            this.funcionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionBindingNavigator.BindingSource = this.funcionBindingSource;
            this.funcionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.funcionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.funcionBindingNavigatorSaveItem});
            this.funcionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionBindingNavigator.Name = "funcionBindingNavigator";
            this.funcionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionBindingNavigator.Size = new System.Drawing.Size(1399, 27);
            this.funcionBindingNavigator.TabIndex = 0;
            this.funcionBindingNavigator.Text = "bindingNavigator1";
            this.funcionBindingNavigator.RefreshItems += new System.EventHandler(this.funcionBindingNavigator_RefreshItems);
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
            // funcionBindingSource
            // 
            this.funcionBindingSource.DataMember = "Funcion";
            this.funcionBindingSource.DataSource = this.cineDataSet1;
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
            // funcionBindingNavigatorSaveItem
            // 
            this.funcionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionBindingNavigatorSaveItem.Image")));
            this.funcionBindingNavigatorSaveItem.Name = "funcionBindingNavigatorSaveItem";
            this.funcionBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.funcionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.funcionBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionBindingNavigatorSaveItem_Click_1);
            // 
            // codigoHoTextBox
            // 
            this.codigoHoTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.codigoHoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoHoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionBindingSource, "CodigoHo", true));
            this.codigoHoTextBox.Enabled = false;
            this.codigoHoTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.codigoHoTextBox.Location = new System.Drawing.Point(283, 74);
            this.codigoHoTextBox.Name = "codigoHoTextBox";
            this.codigoHoTextBox.Size = new System.Drawing.Size(100, 13);
            this.codigoHoTextBox.TabIndex = 2;
            // 
            // findCodHoToolStrip
            // 
            this.findCodHoToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.findCodHoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.findCodHoToolStripButton});
            this.findCodHoToolStrip.Location = new System.Drawing.Point(0, 27);
            this.findCodHoToolStrip.Name = "findCodHoToolStrip";
            this.findCodHoToolStrip.Size = new System.Drawing.Size(1399, 25);
            this.findCodHoToolStrip.TabIndex = 3;
            this.findCodHoToolStrip.Text = "findCodHoToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.param1ToolStripLabel.Text = "Param1:";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // findCodHoToolStripButton
            // 
            this.findCodHoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findCodHoToolStripButton.Name = "findCodHoToolStripButton";
            this.findCodHoToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.findCodHoToolStripButton.Text = "FindCodHo";
            this.findCodHoToolStripButton.Click += new System.EventHandler(this.findCodHoToolStripButton_Click);
            // 
            // horaHoTextBox
            // 
            this.horaHoTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.horaHoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.horaHoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horariosBindingSource, "HoraHo", true));
            this.horaHoTextBox.Enabled = false;
            this.horaHoTextBox.Location = new System.Drawing.Point(226, 241);
            this.horaHoTextBox.Name = "horaHoTextBox";
            this.horaHoTextBox.Size = new System.Drawing.Size(111, 13);
            this.horaHoTextBox.TabIndex = 5;
            // 
            // horariosBindingSource
            // 
            this.horariosBindingSource.DataMember = "Horarios";
            this.horariosBindingSource.DataSource = this.cineDataSet1;
            // 
            // btnFHorario
            // 
            this.btnFHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnFHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFHorario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFHorario.FlatAppearance.BorderSize = 0;
            this.btnFHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnFHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFHorario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFHorario.Location = new System.Drawing.Point(26, 118);
            this.btnFHorario.Name = "btnFHorario";
            this.btnFHorario.Size = new System.Drawing.Size(133, 38);
            this.btnFHorario.TabIndex = 6;
            this.btnFHorario.Text = "Buscar Horarios";
            this.btnFHorario.UseVisualStyleBackColor = false;
            this.btnFHorario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFPelicula
            // 
            this.btnFPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnFPelicula.FlatAppearance.BorderSize = 0;
            this.btnFPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnFPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPelicula.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFPelicula.Location = new System.Drawing.Point(26, 64);
            this.btnFPelicula.Name = "btnFPelicula";
            this.btnFPelicula.Size = new System.Drawing.Size(133, 39);
            this.btnFPelicula.TabIndex = 7;
            this.btnFPelicula.Text = "Buscar Funciones";
            this.btnFPelicula.UseVisualStyleBackColor = false;
            this.btnFPelicula.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VAsientos
            // 
            this.VAsientos.Dock = System.Windows.Forms.DockStyle.Right;
            this.VAsientos.Location = new System.Drawing.Point(415, 52);
            this.VAsientos.Name = "VAsientos";
            this.VAsientos.Size = new System.Drawing.Size(984, 407);
            this.VAsientos.TabIndex = 12;
            // 
            // btnSeleccionFuncion
            // 
            this.btnSeleccionFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeleccionFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnSeleccionFuncion.FlatAppearance.BorderSize = 0;
            this.btnSeleccionFuncion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnSeleccionFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionFuncion.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionFuncion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionFuncion.Location = new System.Drawing.Point(26, 293);
            this.btnSeleccionFuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionFuncion.Name = "btnSeleccionFuncion";
            this.btnSeleccionFuncion.Size = new System.Drawing.Size(344, 78);
            this.btnSeleccionFuncion.TabIndex = 13;
            this.btnSeleccionFuncion.Text = "ESCOGER FUNCION";
            this.btnSeleccionFuncion.UseVisualStyleBackColor = false;
            this.btnSeleccionFuncion.Click += new System.EventHandler(this.btnSeleccionFuncion_Click_1);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolver.Location = new System.Drawing.Point(11, 405);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(110, 43);
            this.BtnVolver.TabIndex = 13;
            this.BtnVolver.Text = "CARTELERA";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // codigoFuTextBox
            // 
            this.codigoFuTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.codigoFuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoFuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionBindingSource, "CodigoFu", true));
            this.codigoFuTextBox.Enabled = false;
            this.codigoFuTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.codigoFuTextBox.Location = new System.Drawing.Point(285, 128);
            this.codigoFuTextBox.Name = "codigoFuTextBox";
            this.codigoFuTextBox.Size = new System.Drawing.Size(100, 13);
            this.codigoFuTextBox.TabIndex = 14;
            // 
            // funcionTableAdapter
            // 
            this.funcionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsientosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombosTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.FuncionTableAdapter = this.funcionTableAdapter;
            this.tableAdapterManager.HorariosTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // horariosTableAdapter
            // 
            this.horariosTableAdapter.ClearBeforeFill = true;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(234, 205);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(35, 13);
            this.lblPelicula.TabIndex = 15;
            this.lblPelicula.Text = "label3";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1399, 459);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.codigoFuTextBox);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.btnSeleccionFuncion);
            this.Controls.Add(this.VAsientos);
            this.Controls.Add(this.label1);
            this.Controls.Add(label2);
            this.Controls.Add(Pelicula);
            this.Controls.Add(this.btnFPelicula);
            this.Controls.Add(this.btnFHorario);
            this.Controls.Add(this.horaHoTextBox);
            this.Controls.Add(this.findCodHoToolStrip);
            this.Controls.Add(this.codigoHoTextBox);
            this.Controls.Add(this.funcionBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingNavigator)).EndInit();
            this.funcionBindingNavigator.ResumeLayout(false);
            this.funcionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).EndInit();
            this.findCodHoToolStrip.ResumeLayout(false);
            this.findCodHoToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CineDataSet1 cineDataSet1;
        private System.Windows.Forms.BindingSource funcionBindingSource;
        private CineDataSet1TableAdapters.FuncionTableAdapter funcionTableAdapter;
        private CineDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox codigoHoTextBox;
        private System.Windows.Forms.ToolStrip findCodHoToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findCodHoToolStripButton;
        private System.Windows.Forms.BindingSource horariosBindingSource;
        private CineDataSet1TableAdapters.HorariosTableAdapter horariosTableAdapter;
        private System.Windows.Forms.TextBox horaHoTextBox;
        private System.Windows.Forms.Button btnFHorario;
        private System.Windows.Forms.Button btnFPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel VAsientos;
        private System.Windows.Forms.Button btnSeleccionFuncion;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox codigoFuTextBox;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton funcionBindingNavigatorSaveItem;
    }
}