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
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NEOBUSS0;Initial Catalog=Cine;User ID=pablo;Password=pablo");
        public CatalogoCli(string EoP)
        {
            InitializeComponent();
            

            this.peliculasTableAdapter.EoP(cineDataSet1.Peliculas, EoP);
           

        }


        



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

            /*SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT * FROM Comentarios WHERE idPelicula=@idPeli";
            Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            Comando.ExecuteNonQuery();
            SqlDataReader respuesta = Comando.ExecuteReader();
            int p = 30;

            while (respuesta.Read())
            {
                Label lb = new Label();
                lb.Text = respuesta[2].ToString();
                lb.Location = new Point(58, p);
                p = p + 25;
                panel1.Controls.Add(lb);
                //label1.Text = respuesta[1].ToString();  
            }
            con.Close();
            */
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT comentario FROM Comentarios WHERE idPelicula=@idPeli";
            Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comentarios.DataSource = tabla;
            con.Close();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            C1.BackgroundImage = Image.FromFile(@"" + imagenPeTextBox.Text);
            /*SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT * FROM Comentarios WHERE idPelicula=@idPeli";
            Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            Comando.ExecuteNonQuery();
            SqlDataReader respuesta = Comando.ExecuteReader();
            int p = 30;
            while (respuesta.Read())
            {
                Label lb = new Label();
                lb.Text = respuesta[2].ToString();
                lb.Location = new Point(58, p);
                p = p + 25;
                panel1.Controls.Add(lb);
                //label1.Text = respuesta[1].ToString();  
            }
            con.Close();
            */
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT comentario FROM Comentarios WHERE idPelicula=@idPeli";
            Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comentarios.DataSource = tabla;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string st = "insert into Comentarios(idPelicula, comentario) values(@idPeli , @comentario)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@comentario", lblComentario.Text);
            cmd.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT comentario FROM Comentarios WHERE idPelicula=@idPeli";
            Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comentarios.DataSource = tabla;
            con.Close();
        }

        private void CatalogoCli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet3.Comentarios' Puede moverla o quitarla según sea necesario.
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT comentario FROM Comentarios WHERE idPelicula=@idPeli";
            Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando; 
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comentarios.DataSource = tabla;
            con.Close();


        }

        private void FillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.comentariosTableAdapter.FillBy(this.cineDataSet3.Comentarios, new System.Nullable<int>(((int)(System.Convert.ChangeType(idPeliculaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
