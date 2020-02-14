namespace TecnicasProyecto4
{
    partial class Dulceria
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
            System.Windows.Forms.Label codigoVeLabel;
            System.Windows.Forms.Label descripcionVeLabel;
            System.Windows.Forms.Label fechaVeLabel;
            System.Windows.Forms.Label montoVeLabel;
            System.Windows.Forms.Label nameUseLabel;
            System.Windows.Forms.Label funciOComboLabel;
            System.Windows.Forms.Label NOMBRE;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dulceria));
            this.cineDataSet1 = new TecnicasProyecto4.CineDataSet1();
            this.combosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combosTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.CombosTableAdapter();
            this.tableAdapterManager = new TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager();
            this.combosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.nombreCoTextBox = new System.Windows.Forms.TextBox();
            this.precioCoTextBox = new System.Windows.Forms.TextBox();
            this.contenidoCoTextBox = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Panel();
            this.codigoVeTextBox = new System.Windows.Forms.TextBox();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionVeTextBox = new System.Windows.Forms.TextBox();
            this.fechaVeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montoVeTextBox = new System.Windows.Forms.TextBox();
            this.nameUseTextBox = new System.Windows.Forms.TextBox();
            this.funciOComboTextBox = new System.Windows.Forms.TextBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCombo = new System.Windows.Forms.Button();
            this.comprasTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.ComprasTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.asientosTableAdapter1 = new TecnicasProyecto4.CineDataSet2TableAdapters.AsientosTableAdapter();
            codigoVeLabel = new System.Windows.Forms.Label();
            descripcionVeLabel = new System.Windows.Forms.Label();
            fechaVeLabel = new System.Windows.Forms.Label();
            montoVeLabel = new System.Windows.Forms.Label();
            nameUseLabel = new System.Windows.Forms.Label();
            funciOComboLabel = new System.Windows.Forms.Label();
            NOMBRE = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combosBindingNavigator)).BeginInit();
            this.combosBindingNavigator.SuspendLayout();
            this.Descripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoVeLabel
            // 
            codigoVeLabel.AutoSize = true;
            codigoVeLabel.Location = new System.Drawing.Point(47, 202);
            codigoVeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codigoVeLabel.Name = "codigoVeLabel";
            codigoVeLabel.Size = new System.Drawing.Size(59, 13);
            codigoVeLabel.TabIndex = 15;
            codigoVeLabel.Text = "Codigo Ve:";
            // 
            // descripcionVeLabel
            // 
            descripcionVeLabel.AutoSize = true;
            descripcionVeLabel.Location = new System.Drawing.Point(47, 225);
            descripcionVeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descripcionVeLabel.Name = "descripcionVeLabel";
            descripcionVeLabel.Size = new System.Drawing.Size(82, 13);
            descripcionVeLabel.TabIndex = 17;
            descripcionVeLabel.Text = "Descripcion Ve:";
            // 
            // fechaVeLabel
            // 
            fechaVeLabel.AutoSize = true;
            fechaVeLabel.Location = new System.Drawing.Point(47, 249);
            fechaVeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fechaVeLabel.Name = "fechaVeLabel";
            fechaVeLabel.Size = new System.Drawing.Size(56, 13);
            fechaVeLabel.TabIndex = 19;
            fechaVeLabel.Text = "Fecha Ve:";
            // 
            // montoVeLabel
            // 
            montoVeLabel.AutoSize = true;
            montoVeLabel.Location = new System.Drawing.Point(47, 271);
            montoVeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            montoVeLabel.Name = "montoVeLabel";
            montoVeLabel.Size = new System.Drawing.Size(56, 13);
            montoVeLabel.TabIndex = 21;
            montoVeLabel.Text = "Monto Ve:";
            // 
            // nameUseLabel
            // 
            nameUseLabel.AutoSize = true;
            nameUseLabel.Location = new System.Drawing.Point(47, 293);
            nameUseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameUseLabel.Name = "nameUseLabel";
            nameUseLabel.Size = new System.Drawing.Size(60, 13);
            nameUseLabel.TabIndex = 23;
            nameUseLabel.Text = "Name Use:";
            // 
            // funciOComboLabel
            // 
            funciOComboLabel.AutoSize = true;
            funciOComboLabel.Location = new System.Drawing.Point(47, 316);
            funciOComboLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            funciOComboLabel.Name = "funciOComboLabel";
            funciOComboLabel.Size = new System.Drawing.Size(80, 13);
            funciOComboLabel.TabIndex = 25;
            funciOComboLabel.Text = "Funci OCombo:";
            // 
            // NOMBRE
            // 
            NOMBRE.AutoSize = true;
            NOMBRE.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NOMBRE.ForeColor = System.Drawing.Color.RoyalBlue;
            NOMBRE.Location = new System.Drawing.Point(405, 216);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new System.Drawing.Size(82, 18);
            NOMBRE.TabIndex = 16;
            NOMBRE.Text = "PRECIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.RoyalBlue;
            label2.Location = new System.Drawing.Point(405, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 18);
            label2.TabIndex = 16;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.RoyalBlue;
            label3.Location = new System.Drawing.Point(405, 314);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 18);
            label3.TabIndex = 16;
            label3.Text = "CONTENIDO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.RoyalBlue;
            label4.Location = new System.Drawing.Point(405, 459);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 18);
            label4.TabIndex = 16;
            label4.Text = "CANTIDAD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.RoyalBlue;
            label1.Location = new System.Drawing.Point(582, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 18);
            label1.TabIndex = 16;
            label1.Text = "COMBO";
            // 
            // cineDataSet1
            // 
            this.cineDataSet1.DataSetName = "CineDataSet1";
            this.cineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combosBindingSource
            // 
            this.combosBindingSource.DataMember = "Combos";
            this.combosBindingSource.DataSource = this.cineDataSet1;
            // 
            // combosTableAdapter
            // 
            this.combosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsientosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombosTableAdapter = this.combosTableAdapter;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.FuncionTableAdapter = null;
            this.tableAdapterManager.HorariosTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // combosBindingNavigator
            // 
            this.combosBindingNavigator.AddNewItem = null;
            this.combosBindingNavigator.BindingSource = this.combosBindingSource;
            this.combosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.combosBindingNavigator.DeleteItem = null;
            this.combosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.combosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem});
            this.combosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.combosBindingNavigator.MoveFirstItem = null;
            this.combosBindingNavigator.MoveLastItem = null;
            this.combosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.combosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.combosBindingNavigator.Name = "combosBindingNavigator";
            this.combosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.combosBindingNavigator.Size = new System.Drawing.Size(1167, 27);
            this.combosBindingNavigator.TabIndex = 0;
            this.combosBindingNavigator.Text = "bindingNavigator1";
            this.combosBindingNavigator.RefreshItems += new System.EventHandler(this.combosBindingNavigator_RefreshItems);
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
            // nombreCoTextBox
            // 
            this.nombreCoTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nombreCoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreCoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combosBindingSource, "NombreCo", true));
            this.nombreCoTextBox.Enabled = false;
            this.nombreCoTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.nombreCoTextBox.Location = new System.Drawing.Point(570, 125);
            this.nombreCoTextBox.Name = "nombreCoTextBox";
            this.nombreCoTextBox.Size = new System.Drawing.Size(268, 15);
            this.nombreCoTextBox.TabIndex = 5;
            // 
            // precioCoTextBox
            // 
            this.precioCoTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.precioCoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioCoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combosBindingSource, "PrecioCo", true));
            this.precioCoTextBox.Enabled = false;
            this.precioCoTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.precioCoTextBox.Location = new System.Drawing.Point(570, 216);
            this.precioCoTextBox.Name = "precioCoTextBox";
            this.precioCoTextBox.Size = new System.Drawing.Size(268, 15);
            this.precioCoTextBox.TabIndex = 7;
            // 
            // contenidoCoTextBox
            // 
            this.contenidoCoTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contenidoCoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contenidoCoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combosBindingSource, "ContenidoCo", true));
            this.contenidoCoTextBox.Enabled = false;
            this.contenidoCoTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.contenidoCoTextBox.Location = new System.Drawing.Point(570, 314);
            this.contenidoCoTextBox.Multiline = true;
            this.contenidoCoTextBox.Name = "contenidoCoTextBox";
            this.contenidoCoTextBox.Size = new System.Drawing.Size(268, 104);
            this.contenidoCoTextBox.TabIndex = 9;
            this.contenidoCoTextBox.TextChanged += new System.EventHandler(this.contenidoCoTextBox_TextChanged);
            // 
            // Descripcion
            // 
            this.Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.Descripcion.Controls.Add(codigoVeLabel);
            this.Descripcion.Controls.Add(this.codigoVeTextBox);
            this.Descripcion.Controls.Add(descripcionVeLabel);
            this.Descripcion.Controls.Add(this.descripcionVeTextBox);
            this.Descripcion.Controls.Add(fechaVeLabel);
            this.Descripcion.Controls.Add(this.fechaVeDateTimePicker);
            this.Descripcion.Controls.Add(montoVeLabel);
            this.Descripcion.Controls.Add(this.montoVeTextBox);
            this.Descripcion.Controls.Add(nameUseLabel);
            this.Descripcion.Controls.Add(this.nameUseTextBox);
            this.Descripcion.Controls.Add(funciOComboLabel);
            this.Descripcion.Controls.Add(this.funciOComboTextBox);
            this.Descripcion.Controls.Add(this.btnCompra);
            this.Descripcion.Dock = System.Windows.Forms.DockStyle.Right;
            this.Descripcion.Location = new System.Drawing.Point(854, 27);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(313, 607);
            this.Descripcion.TabIndex = 14;
            this.Descripcion.Visible = false;
            // 
            // codigoVeTextBox
            // 
            this.codigoVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "CodigoVe", true));
            this.codigoVeTextBox.Location = new System.Drawing.Point(132, 200);
            this.codigoVeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoVeTextBox.Name = "codigoVeTextBox";
            this.codigoVeTextBox.Size = new System.Drawing.Size(151, 20);
            this.codigoVeTextBox.TabIndex = 16;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.cineDataSet1;
            // 
            // descripcionVeTextBox
            // 
            this.descripcionVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "DescripcionVe", true));
            this.descripcionVeTextBox.Location = new System.Drawing.Point(132, 223);
            this.descripcionVeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descripcionVeTextBox.Name = "descripcionVeTextBox";
            this.descripcionVeTextBox.Size = new System.Drawing.Size(151, 20);
            this.descripcionVeTextBox.TabIndex = 18;
            // 
            // fechaVeDateTimePicker
            // 
            this.fechaVeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.comprasBindingSource, "FechaVe", true));
            this.fechaVeDateTimePicker.Location = new System.Drawing.Point(132, 245);
            this.fechaVeDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaVeDateTimePicker.Name = "fechaVeDateTimePicker";
            this.fechaVeDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.fechaVeDateTimePicker.TabIndex = 20;
            // 
            // montoVeTextBox
            // 
            this.montoVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "MontoVe", true));
            this.montoVeTextBox.Location = new System.Drawing.Point(132, 268);
            this.montoVeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.montoVeTextBox.Name = "montoVeTextBox";
            this.montoVeTextBox.Size = new System.Drawing.Size(151, 20);
            this.montoVeTextBox.TabIndex = 22;
            // 
            // nameUseTextBox
            // 
            this.nameUseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "NameUse", true));
            this.nameUseTextBox.Location = new System.Drawing.Point(132, 291);
            this.nameUseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameUseTextBox.Name = "nameUseTextBox";
            this.nameUseTextBox.Size = new System.Drawing.Size(151, 20);
            this.nameUseTextBox.TabIndex = 24;
            // 
            // funciOComboTextBox
            // 
            this.funciOComboTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "FunciOCombo", true));
            this.funciOComboTextBox.Location = new System.Drawing.Point(132, 314);
            this.funciOComboTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.funciOComboTextBox.Name = "funciOComboTextBox";
            this.funciOComboTextBox.Size = new System.Drawing.Size(151, 20);
            this.funciOComboTextBox.TabIndex = 26;
            // 
            // btnCompra
            // 
            this.btnCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompra.Location = new System.Drawing.Point(80, 405);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(163, 61);
            this.btnCompra.TabIndex = 15;
            this.btnCompra.Text = "COMPRAR";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cantidad.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.Cantidad.Location = new System.Drawing.Point(570, 461);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(268, 22);
            this.Cantidad.TabIndex = 15;
            // 
            // btnSeleccionarCombo
            // 
            this.btnSeleccionarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeleccionarCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnSeleccionarCombo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarCombo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnSeleccionarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarCombo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarCombo.Location = new System.Drawing.Point(496, 515);
            this.btnSeleccionarCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionarCombo.Name = "btnSeleccionarCombo";
            this.btnSeleccionarCombo.Size = new System.Drawing.Size(235, 61);
            this.btnSeleccionarCombo.TabIndex = 14;
            this.btnSeleccionarCombo.Text = "COMPROBAR INFORMACION";
            this.btnSeleccionarCombo.UseVisualStyleBackColor = false;
            this.btnSeleccionarCombo.Click += new System.EventHandler(this.btnSeleccionarCombo_Click);
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TecnicasProyecto4.Properties.Resources.popc;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // asientosTableAdapter1
            // 
            this.asientosTableAdapter1.ClearBeforeFill = true;
            // 
            // Dulceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(NOMBRE);
            this.Controls.Add(this.btnSeleccionarCombo);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.nombreCoTextBox);
            this.Controls.Add(this.precioCoTextBox);
            this.Controls.Add(this.contenidoCoTextBox);
            this.Controls.Add(this.combosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dulceria";
            this.Text = "Dulceria";
            this.Load += new System.EventHandler(this.Dulceria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combosBindingNavigator)).EndInit();
            this.combosBindingNavigator.ResumeLayout(false);
            this.combosBindingNavigator.PerformLayout();
            this.Descripcion.ResumeLayout(false);
            this.Descripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CineDataSet1 cineDataSet1;
        private System.Windows.Forms.BindingSource combosBindingSource;
        private CineDataSet1TableAdapters.CombosTableAdapter combosTableAdapter;
        private CineDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator combosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.TextBox nombreCoTextBox;
        private System.Windows.Forms.TextBox precioCoTextBox;
        private System.Windows.Forms.TextBox contenidoCoTextBox;
        private System.Windows.Forms.Panel Descripcion;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnSeleccionarCombo;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private CineDataSet1TableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.TextBox codigoVeTextBox;
        private System.Windows.Forms.TextBox descripcionVeTextBox;
        private System.Windows.Forms.DateTimePicker fechaVeDateTimePicker;
        private System.Windows.Forms.TextBox montoVeTextBox;
        private System.Windows.Forms.TextBox nameUseTextBox;
        private System.Windows.Forms.TextBox funciOComboTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CineDataSet2TableAdapters.AsientosTableAdapter asientosTableAdapter1;
    }
}