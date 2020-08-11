namespace TecnicasProyecto4
{
    partial class ModPelicula
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
            System.Windows.Forms.Label nombrePeLabel;
            System.Windows.Forms.Label webPeLabel;
            System.Windows.Forms.Label directoresPeLabel;
            System.Windows.Forms.Label actoresPeLabel;
            System.Windows.Forms.Label descripcionPeLabel;
            System.Windows.Forms.Label imagenPeLabel;
            System.Windows.Forms.Label categoriaPeLabel;
            System.Windows.Forms.Label codigoPeLabel;
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineDataSet1 = new TecnicasProyecto4.CineDataSet1();
            this.nombrePeTextBox = new System.Windows.Forms.TextBox();
            this.webPeTextBox = new System.Windows.Forms.TextBox();
            this.directoresPeTextBox = new System.Windows.Forms.TextBox();
            this.actoresPeTextBox = new System.Windows.Forms.TextBox();
            this.descripcionPeTextBox = new System.Windows.Forms.TextBox();
            this.categoriaPeTextBox = new System.Windows.Forms.TextBox();
            this.peliculasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPeli = new System.Windows.Forms.Button();
            this.btnModificarPeli = new System.Windows.Forms.Button();
            this.btnEliminarPeli = new System.Windows.Forms.Button();
            this.btnBuscarPeli = new System.Windows.Forms.Button();
            this.btnMostrarPeli = new System.Windows.Forms.Button();
            this.peliculasTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.PeliculasTableAdapter();
            this.tableAdapterManager = new TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager();
            this.codigoPeTextBox = new System.Windows.Forms.TextBox();
            this.imagenPeTextBox = new System.Windows.Forms.TextBox();
            nombrePeLabel = new System.Windows.Forms.Label();
            webPeLabel = new System.Windows.Forms.Label();
            directoresPeLabel = new System.Windows.Forms.Label();
            actoresPeLabel = new System.Windows.Forms.Label();
            descripcionPeLabel = new System.Windows.Forms.Label();
            imagenPeLabel = new System.Windows.Forms.Label();
            categoriaPeLabel = new System.Windows.Forms.Label();
            codigoPeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrePeLabel
            // 
            nombrePeLabel.AutoSize = true;
            nombrePeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombrePeLabel.Location = new System.Drawing.Point(21, 174);
            nombrePeLabel.Name = "nombrePeLabel";
            nombrePeLabel.Size = new System.Drawing.Size(47, 13);
            nombrePeLabel.TabIndex = 3;
            nombrePeLabel.Text = "Nombre:";
            // 
            // webPeLabel
            // 
            webPeLabel.AutoSize = true;
            webPeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            webPeLabel.Location = new System.Drawing.Point(21, 200);
            webPeLabel.Name = "webPeLabel";
            webPeLabel.Size = new System.Drawing.Size(36, 13);
            webPeLabel.TabIndex = 5;
            webPeLabel.Text = "Web :";
            // 
            // directoresPeLabel
            // 
            directoresPeLabel.AutoSize = true;
            directoresPeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            directoresPeLabel.Location = new System.Drawing.Point(21, 226);
            directoresPeLabel.Name = "directoresPeLabel";
            directoresPeLabel.Size = new System.Drawing.Size(58, 13);
            directoresPeLabel.TabIndex = 7;
            directoresPeLabel.Text = "Directores:";
            // 
            // actoresPeLabel
            // 
            actoresPeLabel.AutoSize = true;
            actoresPeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            actoresPeLabel.Location = new System.Drawing.Point(21, 252);
            actoresPeLabel.Name = "actoresPeLabel";
            actoresPeLabel.Size = new System.Drawing.Size(46, 13);
            actoresPeLabel.TabIndex = 9;
            actoresPeLabel.Text = "Actores:";
            // 
            // descripcionPeLabel
            // 
            descripcionPeLabel.AutoSize = true;
            descripcionPeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionPeLabel.Location = new System.Drawing.Point(21, 278);
            descripcionPeLabel.Name = "descripcionPeLabel";
            descripcionPeLabel.Size = new System.Drawing.Size(66, 13);
            descripcionPeLabel.TabIndex = 11;
            descripcionPeLabel.Text = "Descripcion:";
            // 
            // imagenPeLabel
            // 
            imagenPeLabel.AutoSize = true;
            imagenPeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagenPeLabel.Location = new System.Drawing.Point(21, 304);
            imagenPeLabel.Name = "imagenPeLabel";
            imagenPeLabel.Size = new System.Drawing.Size(45, 13);
            imagenPeLabel.TabIndex = 13;
            imagenPeLabel.Text = "Imagen:";
            // 
            // categoriaPeLabel
            // 
            categoriaPeLabel.AutoSize = true;
            categoriaPeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaPeLabel.Location = new System.Drawing.Point(21, 425);
            categoriaPeLabel.Name = "categoriaPeLabel";
            categoriaPeLabel.Size = new System.Drawing.Size(55, 13);
            categoriaPeLabel.TabIndex = 15;
            categoriaPeLabel.Text = "Categoria:";
            // 
            // codigoPeLabel
            // 
            codigoPeLabel.AutoSize = true;
            codigoPeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoPeLabel.Location = new System.Drawing.Point(21, 148);
            codigoPeLabel.Name = "codigoPeLabel";
            codigoPeLabel.Size = new System.Drawing.Size(43, 13);
            codigoPeLabel.TabIndex = 1;
            codigoPeLabel.Text = "Codigo:";
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
            // nombrePeTextBox
            // 
            this.nombrePeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nombrePeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "NombrePe", true));
            this.nombrePeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePeTextBox.Location = new System.Drawing.Point(120, 171);
            this.nombrePeTextBox.Name = "nombrePeTextBox";
            this.nombrePeTextBox.Size = new System.Drawing.Size(185, 20);
            this.nombrePeTextBox.TabIndex = 4;
            // 
            // webPeTextBox
            // 
            this.webPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.webPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "WebPe", true));
            this.webPeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webPeTextBox.Location = new System.Drawing.Point(120, 197);
            this.webPeTextBox.Name = "webPeTextBox";
            this.webPeTextBox.Size = new System.Drawing.Size(185, 20);
            this.webPeTextBox.TabIndex = 6;
            // 
            // directoresPeTextBox
            // 
            this.directoresPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.directoresPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "DirectoresPe", true));
            this.directoresPeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoresPeTextBox.Location = new System.Drawing.Point(120, 223);
            this.directoresPeTextBox.Name = "directoresPeTextBox";
            this.directoresPeTextBox.Size = new System.Drawing.Size(185, 20);
            this.directoresPeTextBox.TabIndex = 8;
            // 
            // actoresPeTextBox
            // 
            this.actoresPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actoresPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "ActoresPe", true));
            this.actoresPeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actoresPeTextBox.Location = new System.Drawing.Point(120, 249);
            this.actoresPeTextBox.Name = "actoresPeTextBox";
            this.actoresPeTextBox.Size = new System.Drawing.Size(185, 20);
            this.actoresPeTextBox.TabIndex = 10;
            // 
            // descripcionPeTextBox
            // 
            this.descripcionPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.descripcionPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "DescripcionPe", true));
            this.descripcionPeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionPeTextBox.Location = new System.Drawing.Point(120, 275);
            this.descripcionPeTextBox.Name = "descripcionPeTextBox";
            this.descripcionPeTextBox.Size = new System.Drawing.Size(185, 20);
            this.descripcionPeTextBox.TabIndex = 12;
            // 
            // categoriaPeTextBox
            // 
            this.categoriaPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriaPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "CategoriaPe", true));
            this.categoriaPeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaPeTextBox.Location = new System.Drawing.Point(120, 422);
            this.categoriaPeTextBox.Name = "categoriaPeTextBox";
            this.categoriaPeTextBox.Size = new System.Drawing.Size(185, 20);
            this.categoriaPeTextBox.TabIndex = 16;
            // 
            // peliculasDataGridView
            // 
            this.peliculasDataGridView.AutoGenerateColumns = false;
            this.peliculasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.peliculasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.peliculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.peliculasDataGridView.DataSource = this.peliculasBindingSource;
            this.peliculasDataGridView.Location = new System.Drawing.Point(324, 64);
            this.peliculasDataGridView.Name = "peliculasDataGridView";
            this.peliculasDataGridView.RowHeadersWidth = 51;
            this.peliculasDataGridView.Size = new System.Drawing.Size(843, 487);
            this.peliculasDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoPe";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoPe";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombrePe";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombrePe";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WebPe";
            this.dataGridViewTextBoxColumn3.HeaderText = "WebPe";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DirectoresPe";
            this.dataGridViewTextBoxColumn4.HeaderText = "DirectoresPe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ActoresPe";
            this.dataGridViewTextBoxColumn5.HeaderText = "ActoresPe";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DescripcionPe";
            this.dataGridViewTextBoxColumn6.HeaderText = "DescripcionPe";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ImagenPe";
            this.dataGridViewTextBoxColumn7.HeaderText = "ImagenPe";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CategoriaPe";
            this.dataGridViewTextBoxColumn8.HeaderText = "CategoriaPe";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "CARTELERA";
            // 
            // btnAgregarPeli
            // 
            this.btnAgregarPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnAgregarPeli.FlatAppearance.BorderSize = 0;
            this.btnAgregarPeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnAgregarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPeli.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPeli.Location = new System.Drawing.Point(23, 468);
            this.btnAgregarPeli.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPeli.Name = "btnAgregarPeli";
            this.btnAgregarPeli.Size = new System.Drawing.Size(135, 54);
            this.btnAgregarPeli.TabIndex = 19;
            this.btnAgregarPeli.Text = "AGREGAR";
            this.btnAgregarPeli.UseVisualStyleBackColor = false;
            this.btnAgregarPeli.Click += new System.EventHandler(this.btnAgregarPeli_Click);
            // 
            // btnModificarPeli
            // 
            this.btnModificarPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnModificarPeli.FlatAppearance.BorderSize = 0;
            this.btnModificarPeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnModificarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPeli.ForeColor = System.Drawing.Color.White;
            this.btnModificarPeli.Location = new System.Drawing.Point(159, 468);
            this.btnModificarPeli.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarPeli.Name = "btnModificarPeli";
            this.btnModificarPeli.Size = new System.Drawing.Size(135, 54);
            this.btnModificarPeli.TabIndex = 19;
            this.btnModificarPeli.Text = "MODIFICAR";
            this.btnModificarPeli.UseVisualStyleBackColor = false;
            this.btnModificarPeli.Click += new System.EventHandler(this.btnModificarPeli_Click);
            // 
            // btnEliminarPeli
            // 
            this.btnEliminarPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnEliminarPeli.FlatAppearance.BorderSize = 0;
            this.btnEliminarPeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnEliminarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPeli.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPeli.Location = new System.Drawing.Point(23, 523);
            this.btnEliminarPeli.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPeli.Name = "btnEliminarPeli";
            this.btnEliminarPeli.Size = new System.Drawing.Size(135, 54);
            this.btnEliminarPeli.TabIndex = 19;
            this.btnEliminarPeli.Text = "ELIMINAR";
            this.btnEliminarPeli.UseVisualStyleBackColor = false;
            this.btnEliminarPeli.Click += new System.EventHandler(this.btnEliminarPeli_Click);
            // 
            // btnBuscarPeli
            // 
            this.btnBuscarPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscarPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnBuscarPeli.FlatAppearance.BorderSize = 0;
            this.btnBuscarPeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnBuscarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPeli.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPeli.Location = new System.Drawing.Point(159, 523);
            this.btnBuscarPeli.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarPeli.Name = "btnBuscarPeli";
            this.btnBuscarPeli.Size = new System.Drawing.Size(135, 54);
            this.btnBuscarPeli.TabIndex = 19;
            this.btnBuscarPeli.Text = "BUSCAR";
            this.btnBuscarPeli.UseVisualStyleBackColor = false;
            this.btnBuscarPeli.Click += new System.EventHandler(this.btnBuscarPeli_Click);
            // 
            // btnMostrarPeli
            // 
            this.btnMostrarPeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrarPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            this.btnMostrarPeli.FlatAppearance.BorderSize = 0;
            this.btnMostrarPeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.btnMostrarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPeli.ForeColor = System.Drawing.Color.White;
            this.btnMostrarPeli.Location = new System.Drawing.Point(23, 578);
            this.btnMostrarPeli.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarPeli.Name = "btnMostrarPeli";
            this.btnMostrarPeli.Size = new System.Drawing.Size(271, 27);
            this.btnMostrarPeli.TabIndex = 19;
            this.btnMostrarPeli.Text = "ENLISTAR";
            this.btnMostrarPeli.UseVisualStyleBackColor = false;
            this.btnMostrarPeli.Click += new System.EventHandler(this.btnMostrarPeli_Click);
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
            this.tableAdapterManager.HorariosTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // codigoPeTextBox
            // 
            this.codigoPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.codigoPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "CodigoPe", true));
            this.codigoPeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoPeTextBox.Location = new System.Drawing.Point(120, 145);
            this.codigoPeTextBox.Name = "codigoPeTextBox";
            this.codigoPeTextBox.Size = new System.Drawing.Size(185, 20);
            this.codigoPeTextBox.TabIndex = 2;
            this.codigoPeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // imagenPeTextBox
            // 
            this.imagenPeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenPeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "ImagenPe", true));
            this.imagenPeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagenPeTextBox.Location = new System.Drawing.Point(120, 301);
            this.imagenPeTextBox.Name = "imagenPeTextBox";
            this.imagenPeTextBox.Size = new System.Drawing.Size(185, 20);
            this.imagenPeTextBox.TabIndex = 14;
            // 
            // ModPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 634);
            this.Controls.Add(this.btnMostrarPeli);
            this.Controls.Add(this.btnBuscarPeli);
            this.Controls.Add(this.btnEliminarPeli);
            this.Controls.Add(this.btnModificarPeli);
            this.Controls.Add(this.btnAgregarPeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peliculasDataGridView);
            this.Controls.Add(codigoPeLabel);
            this.Controls.Add(this.codigoPeTextBox);
            this.Controls.Add(nombrePeLabel);
            this.Controls.Add(this.nombrePeTextBox);
            this.Controls.Add(webPeLabel);
            this.Controls.Add(this.webPeTextBox);
            this.Controls.Add(directoresPeLabel);
            this.Controls.Add(this.directoresPeTextBox);
            this.Controls.Add(actoresPeLabel);
            this.Controls.Add(this.actoresPeTextBox);
            this.Controls.Add(descripcionPeLabel);
            this.Controls.Add(this.descripcionPeTextBox);
            this.Controls.Add(imagenPeLabel);
            this.Controls.Add(this.imagenPeTextBox);
            this.Controls.Add(categoriaPeLabel);
            this.Controls.Add(this.categoriaPeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModPelicula";
            this.Text = "ModPelicula";
            this.Load += new System.EventHandler(this.ModPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CineDataSet1 cineDataSet1;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private CineDataSet1TableAdapters.PeliculasTableAdapter peliculasTableAdapter;
        private CineDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombrePeTextBox;
        private System.Windows.Forms.TextBox webPeTextBox;
        private System.Windows.Forms.TextBox directoresPeTextBox;
        private System.Windows.Forms.TextBox actoresPeTextBox;
        private System.Windows.Forms.TextBox descripcionPeTextBox;
        private System.Windows.Forms.TextBox categoriaPeTextBox;
        private System.Windows.Forms.DataGridView peliculasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarPeli;
        private System.Windows.Forms.Button btnModificarPeli;
        private System.Windows.Forms.Button btnEliminarPeli;
        private System.Windows.Forms.Button btnBuscarPeli;
        private System.Windows.Forms.Button btnMostrarPeli;
        private System.Windows.Forms.TextBox codigoPeTextBox;
        private System.Windows.Forms.TextBox imagenPeTextBox;
    }
}