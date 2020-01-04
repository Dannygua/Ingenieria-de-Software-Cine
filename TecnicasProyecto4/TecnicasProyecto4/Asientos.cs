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
    public partial class Asientos : Form
    {

        int asientostotales = 0;
        int asiento = 0;
        int asiento2 = 0;
        int asiento3 = 0;
        int asiento4 = 0;
        int asiento5 = 0;
        int asiento6 = 0;
        int asiento7 = 0;
        int asiento8 = 0;
        int asiento9 = 0;
        int asiento10 = 0;
        public int Too;
        public Asientos(string text)
        {
            InitializeComponent();



            this.asientosTableAdapter.FindAsientoa(cineDataSet1.Asientos, Int32.Parse(text));
            Too = Int32.Parse(text);
            nameUseTextBox.Text = Cliente.Too;

        }

        private void asientosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asientosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }

        private void Asientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.cineDataSet1.Compras);
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Asientos' Puede moverla o quitarla según sea necesario.
            this.asientosTableAdapter.Fill(this.cineDataSet1.Asientos);

        }

        private void AS1_Click(object sender, EventArgs e)
        {
            if (asiento == 0)
            {
                AS1.BackColor = Color.FromArgb(248, 19, 40);
                asiento = 1;
                asientostotales += asiento;
            }
            else
            {
                asientostotales -= asiento;
                asiento = 0;
                AS1.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS2_Click(object sender, EventArgs e)
        {
            if (asiento2 == 0)
            {
                AS2.BackColor = Color.FromArgb(248, 19, 40);
                asiento2 = 1;
                asientostotales += asiento2;
            }
            else
            {
                asientostotales -= asiento2;
                asiento2 = 0;
                AS2.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS3_Click(object sender, EventArgs e)
        {
            if (asiento3 == 0)
            {
                AS3.BackColor = Color.FromArgb(248, 19, 40);
                asiento3 = 1;
                asientostotales += asiento3;
            }
            else
            {
                asientostotales -= asiento3;
                asiento3 = 0;
                AS3.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS4_Click(object sender, EventArgs e)
        {
            if (asiento4 == 0)
            {
                AS4.BackColor = Color.FromArgb(248, 19, 40);
                asiento4 = 1;
                asientostotales += asiento4;
            }
            else
            {
                asientostotales -= asiento4;
                asiento4 = 0;
                AS4.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS5_Click(object sender, EventArgs e)
        {
            if (asiento5 == 0)
            {
                AS5.BackColor = Color.FromArgb(248, 19, 40);
                asiento5 = 1;
                asientostotales += asiento5;
            }
            else
            {
                asientostotales -= asiento5;
                asiento5 = 0;
                AS5.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS6_Click(object sender, EventArgs e)
        {
            if (asiento6 == 0)
            {
                AS6.BackColor = Color.FromArgb(248, 19, 40);
                asiento6 = 1;
                asientostotales += asiento6;
            }
            else
            {
                asientostotales -= asiento6;
                asiento6 = 0;
                AS6.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS7_Click(object sender, EventArgs e)
        {
            if (asiento7 == 0)
            {
                AS7.BackColor = Color.FromArgb(248, 19, 40);
                asiento7 = 1;
                asientostotales += asiento7;
            }
            else
            {
                asientostotales -= asiento7;
                asiento7 = 0;
                AS7.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS8_Click(object sender, EventArgs e)
        {
            if (asiento8 == 0)
            {
                AS8.BackColor = Color.FromArgb(248, 19, 40);
                asiento8 = 1;
                asientostotales += asiento8;
            }
            else
            {
                asientostotales -= asiento8;
                asiento8 = 0;
                AS8.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS9_Click(object sender, EventArgs e)
        {
            if (asiento9 == 0)
            {
                AS9.BackColor = Color.FromArgb(248, 19, 40);
                asiento9 = 1;
                asientostotales += asiento9;
            }
            else
            {
                asientostotales -= asiento9;
                asiento9 = 0;
                AS9.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }

        private void AS10_Click(object sender, EventArgs e)
        {
            if (asiento10 == 0)
            {
                AS10.BackColor = Color.FromArgb(248, 19, 40);
                asiento10 = 1;
                asientostotales += asiento10;
            }
            else
            {
                asientostotales -= asiento10;
                asiento10 = 0;
                AS10.BackColor = Color.FromArgb(17, 50, 83);

            }

            AsientosC.Text = "" + asientostotales;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            descripcionVeTextBox.Visible = true;
            fechaVeDateTimePicker.Visible = true;
            montoVeTextBox.Visible = true;
            nameUseTextBox.Visible = true;
            funciOComboTextBox.Visible = true;
            btnComprar.Visible = true;
            this.asientosTableAdapter.FindAsientoa(cineDataSet1.Asientos, Too);
            nameUseTextBox.Text = Cliente.Too;
            descripcionVeTextBox.Text = "Venta";
            funciOComboTextBox.Text = "1";
            int Asientos1 = Int32.Parse(AsientosC.Text);
            int SumaAsientos = Asientos1 * 6;
            montoVeTextBox.Text = "" + SumaAsientos;
            fechaVeDateTimePicker.Text = DateTime.Now.ToString("dd/MM/yyyy");


        }

        private void asientosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            this.comprasTableAdapter.AgregarVenta(descripcionVeTextBox.Text,fechaVeDateTimePicker.Text, Convert.ToDecimal(montoVeTextBox.Text),nameUseTextBox.Text, Int32.Parse(funciOComboTextBox.Text));
            this.Visible = false;
        }
    }
}
