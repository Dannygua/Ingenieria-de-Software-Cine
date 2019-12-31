using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TecnicasProyecto4
{

    
    public partial class CatalogoCli : Form
    {
        
        int asientostotales =0;
        int asiento= 0;
        int asiento2 = 0;
        int asiento3 = 0;
        int asiento4 = 0;
        int asiento5 = 0;
        int asiento6 = 0;
        int asiento7 = 0;
        int asiento8 = 0;
        int asiento9 = 0;
        int asiento10 = 0;


        public CatalogoCli(string EoP)
        {
            InitializeComponent();
          
            this.peliculasTableAdapter.EoP(cineDataSet1.Peliculas, EoP);

           
        }





        private void btnCompra_Click(object sender, EventArgs e)
        {

            /*Compra.Visible = true;
            btnCompra.Visible = false;
            btnVCartelera.Visible = true;*/
            Venta formulario = new Venta(codigoPeTextBox.Text);
            formulario.Visible = true;
            


        }

        private void btnVCartelera_Click(object sender, EventArgs e)
        {
            Compra.Visible = false;
            btnCompra.Visible = true;
            btnVCartelera.Visible = false;
            Asientos.Text =""+0;
            asientostotales =0;
            asiento= 0;
            asiento2 = 0;
            asiento3 = 0;
            asiento4 = 0;
            asiento5 = 0;
            asiento6 = 0;
            asiento7 = 0;
            asiento8 = 0;
            asiento9 = 0;
            asiento10 = 0;
            AS1.BackColor = Color.FromArgb(17, 50, 83);
            AS2.BackColor = Color.FromArgb(17, 50, 83);
            AS3.BackColor = Color.FromArgb(17, 50, 83);
            AS4.BackColor = Color.FromArgb(17, 50, 83);
            AS5.BackColor = Color.FromArgb(17, 50, 83);
            AS6.BackColor = Color.FromArgb(17, 50, 83);
            AS7.BackColor = Color.FromArgb(17, 50, 83);
            AS8.BackColor = Color.FromArgb(17, 50, 83);
            AS9.BackColor = Color.FromArgb(17, 50, 83);
            AS10.BackColor = Color.FromArgb(17, 50, 83);
        }

        private void AS1_Click(object sender, EventArgs e)
        {
            if (asiento ==0)
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
            
            Asientos.Text =""+ asientostotales;
        }

        private void Compra_Paint(object sender, PaintEventArgs e)
        {

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
            
            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
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

            Asientos.Text = "" + asientostotales;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }



        private void peliculasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            this.horariosTableAdapter.horaP1(cineDataSet1.Horarios,1);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionTableAdapter.FillBy(this.cineDataSet1.Funcion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
