using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TecnicasProyecto4
{

    
    public partial class CatalogoCli : Form
    {

        static public String PeliToo;
        public CatalogoCli(string EoP)
        {
            InitializeComponent();
            

            this.peliculasTableAdapter.EoP(cineDataSet1.Peliculas, EoP);

           
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O15S8EP;Initial Catalog=Cine;User ID=Danny;Password=12345");



        private void btnCompra_Click(object sender, EventArgs e)
        {
            PeliToo = nombrePeTextBox.Text;
            /*Compra.Visible = true;
            btnCompra.Visible = false;
            btnVCartelera.Visible = true;*/
            Venta formulario = new Venta(codigoPeTextBox.Text);
            formulario.Visible = true;
            Visible = false;



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

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            C1.BackgroundImage = Image.FromFile(@"" + imagenPeTextBox.Text);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            C1.BackgroundImage = Image.FromFile(@"" + imagenPeTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string st = "insert into Comentarios(comentario) values(@comentario)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@comentario", lblComentario.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
