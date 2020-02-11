using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class Venta : Form
    {
        public int Too =1;

        private void Abrirform(object formhija)
        {
            if (this.VAsientos.Controls.Count > 0)
            {
                this.VAsientos.Controls.RemoveAt(0);

            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.VAsientos.Controls.Add(fh);
            this.VAsientos.Tag = fh;
            fh.Show();
        }

        public Venta(string text)
        {

            InitializeComponent();
            this.funcionTableAdapter.FindCodHo(cineDataSet1.Funcion, Int32.Parse(text));
            lblPelicula.Text =CatalogoCli.PeliToo;
            label1.Text =text;
            Too = Int32.Parse(text);


        }

        private void funcionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }

        private void funcionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Horarios' Puede moverla o quitarla según sea necesario.
            this.horariosTableAdapter.Fill(this.cineDataSet1.Horarios);
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Funcion' Puede moverla o quitarla según sea necesario.
            this.funcionTableAdapter.Fill(this.cineDataSet1.Funcion);

        }

        private void findCodHoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionTableAdapter.FindCodHo(this.cineDataSet1.Funcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        private void funcionBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.horariosTableAdapter.horaP1(cineDataSet1.Horarios, Int32.Parse(codigoHoTextBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.funcionTableAdapter.FindCodHo(cineDataSet1.Funcion, Too);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionFuncion_Click_1(object sender, EventArgs e)
        {
            Abrirform(new Asientos(codigoFuTextBox.Text));
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
