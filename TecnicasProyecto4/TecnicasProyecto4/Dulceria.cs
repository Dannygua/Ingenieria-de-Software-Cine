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
    public partial class Dulceria : Form
    {
        public Dulceria()
        {
            InitializeComponent();
        }

        private void combosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.combosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }

        private void Dulceria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.cineDataSet1.Compras);
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Combos' Puede moverla o quitarla según sea necesario.
            this.combosTableAdapter.Fill(this.cineDataSet1.Combos);

        }

        private void imagenCoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarCombo_Click(object sender, EventArgs e)
        {
            Descripcion.Visible = true;
            nameUseTextBox.Text = Cliente.Too;
            descripcionVeTextBox.Text = "Venta";
            funciOComboTextBox.Text = "2";
            int Canti = Int32.Parse(Cantidad.Text);
            decimal MontoPagar = Convert.ToDecimal(precioCoTextBox.Text);
            decimal SumaPagar = Canti* MontoPagar;
            montoVeTextBox.Text = "" + SumaPagar;
            fechaVeDateTimePicker.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            this.comprasTableAdapter.AgregarVenta(descripcionVeTextBox.Text, fechaVeDateTimePicker.Text, Convert.ToDecimal(montoVeTextBox.Text), nameUseTextBox.Text, Int32.Parse(funciOComboTextBox.Text));
            this.Visible = false;
        }

        private void contenidoCoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
