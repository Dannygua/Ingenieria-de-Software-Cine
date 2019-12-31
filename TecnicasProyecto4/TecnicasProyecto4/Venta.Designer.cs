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
            System.Windows.Forms.Label codigoHoLabel;
            System.Windows.Forms.Label horaHoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.cineDataSet1 = new TecnicasProyecto4.CineDataSet1();
            this.funcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.FuncionTableAdapter();
            this.tableAdapterManager = new TecnicasProyecto4.CineDataSet1TableAdapters.TableAdapterManager();
            this.funcionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.horariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horariosTableAdapter = new TecnicasProyecto4.CineDataSet1TableAdapters.HorariosTableAdapter();
            this.horaHoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            codigoHoLabel = new System.Windows.Forms.Label();
            horaHoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingNavigator)).BeginInit();
            this.funcionBindingNavigator.SuspendLayout();
            this.findCodHoToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoHoLabel
            // 
            codigoHoLabel.AutoSize = true;
            codigoHoLabel.Location = new System.Drawing.Point(305, 140);
            codigoHoLabel.Name = "codigoHoLabel";
            codigoHoLabel.Size = new System.Drawing.Size(60, 13);
            codigoHoLabel.TabIndex = 1;
            codigoHoLabel.Text = "Codigo Ho:";
            // 
            // horaHoLabel
            // 
            horaHoLabel.AutoSize = true;
            horaHoLabel.Location = new System.Drawing.Point(314, 206);
            horaHoLabel.Name = "horaHoLabel";
            horaHoLabel.Size = new System.Drawing.Size(50, 13);
            horaHoLabel.TabIndex = 4;
            horaHoLabel.Text = "Hora Ho:";
            // 
            // cineDataSet1
            // 
            this.cineDataSet1.DataSetName = "CineDataSet1";
            this.cineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionBindingSource
            // 
            this.funcionBindingSource.DataMember = "Funcion";
            this.funcionBindingSource.DataSource = this.cineDataSet1;
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
            // funcionBindingNavigator
            // 
            this.funcionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionBindingNavigator.BindingSource = this.funcionBindingSource;
            this.funcionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.funcionBindingNavigator.Size = new System.Drawing.Size(800, 25);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // funcionBindingNavigatorSaveItem
            // 
            this.funcionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionBindingNavigatorSaveItem.Image")));
            this.funcionBindingNavigatorSaveItem.Name = "funcionBindingNavigatorSaveItem";
            this.funcionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.funcionBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionBindingNavigatorSaveItem_Click_1);
            // 
            // codigoHoTextBox
            // 
            this.codigoHoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionBindingSource, "CodigoHo", true));
            this.codigoHoTextBox.Location = new System.Drawing.Point(371, 137);
            this.codigoHoTextBox.Name = "codigoHoTextBox";
            this.codigoHoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoHoTextBox.TabIndex = 2;
            // 
            // findCodHoToolStrip
            // 
            this.findCodHoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.findCodHoToolStripButton});
            this.findCodHoToolStrip.Location = new System.Drawing.Point(0, 25);
            this.findCodHoToolStrip.Name = "findCodHoToolStrip";
            this.findCodHoToolStrip.Size = new System.Drawing.Size(800, 25);
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
            // horariosBindingSource
            // 
            this.horariosBindingSource.DataMember = "Horarios";
            this.horariosBindingSource.DataSource = this.cineDataSet1;
            // 
            // horariosTableAdapter
            // 
            this.horariosTableAdapter.ClearBeforeFill = true;
            // 
            // horaHoTextBox
            // 
            this.horaHoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horariosBindingSource, "HoraHo", true));
            this.horaHoTextBox.Location = new System.Drawing.Point(370, 203);
            this.horaHoTextBox.Name = "horaHoTextBox";
            this.horaHoTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaHoTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(horaHoLabel);
            this.Controls.Add(this.horaHoTextBox);
            this.Controls.Add(this.findCodHoToolStrip);
            this.Controls.Add(codigoHoLabel);
            this.Controls.Add(this.codigoHoTextBox);
            this.Controls.Add(this.funcionBindingNavigator);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingNavigator)).EndInit();
            this.funcionBindingNavigator.ResumeLayout(false);
            this.funcionBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton funcionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoHoTextBox;
        private System.Windows.Forms.ToolStrip findCodHoToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findCodHoToolStripButton;
        private System.Windows.Forms.BindingSource horariosBindingSource;
        private CineDataSet1TableAdapters.HorariosTableAdapter horariosTableAdapter;
        private System.Windows.Forms.TextBox horaHoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}