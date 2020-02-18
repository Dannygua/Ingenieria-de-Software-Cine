using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class AgregarCombos : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NEOBUSS0;Initial Catalog=Cine;User ID=pablo;Password=pablo");
        public AgregarCombos()
        {
            InitializeComponent();
        }

        public void cargarTabla()
        {
            SqlCommand Comando2 = new SqlCommand();
            Comando2.CommandText = "SELECT CodigoCo, NombreCo, PrecioCo, ContenidoCo FROM Combos WHERE Estado='E'";
            Comando2.Connection = con;
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            combos.DataSource = tabla;
            con.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Actualizacion de combos
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "UPDATE Combos SET NombreCo=@nombreCo , PrecioCo=@precioCo , ContenidoCo=@contenidoCo WHERE CodigoCo= @codigoCo";
            Comando.Parameters.AddWithValue("@codigoCo", txtCodigo.Text); 
            Comando.Parameters.AddWithValue("@nombreCo", txtNombre.Text);
            Comando.Parameters.AddWithValue("@precioCo", txtPrecio.Text);
            Comando.Parameters.AddWithValue("@contenidoCo", txtContenido.Text);
            Comando.Connection = con;
            con.Open();
            Comando.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Combo actualizado exitosamente");
            cargarTabla();
        }

        private void AgregarCombos_Load(object sender, EventArgs e)
        {
          
            cargarTabla(); 
        }

        private void Combos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = combos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = combos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = combos.CurrentRow.Cells[2].Value.ToString();
            txtContenido.Text = combos.CurrentRow.Cells[3].Value.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand Comando2 = new SqlCommand();
            Comando2.CommandText = "SELECT CodigoCo, NombreCo, PrecioCo, ContenidoCo FROM Combos WHERE CodigoCo=@codigoCo and NombreCo=@nombreCo and PrecioCo=@precioCo and Estado='E' ";
            Comando2.Parameters.AddWithValue("@codigoCo", txtCodigo.Text);
            Comando2.Parameters.AddWithValue("@nombreCo", txtNombre.Text);
            Comando2.Parameters.AddWithValue("@precioCo", txtPrecio.Text);
            Comando2.Parameters.AddWithValue("@contenidoCo", txtContenido.Text);
            Comando2.Connection = con;
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            combos.DataSource = tabla;
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Insercion de combos
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "INSERT INTO Combos(NombreCo, PrecioCo, ContenidoCo) VALUES (@nombreCo, @precioCo, @contenidoCo)";
            Comando.Parameters.AddWithValue("@nombreCo", txtNombre.Text);
            Comando.Parameters.AddWithValue("@precioCo", txtPrecio.Text);
            Comando.Parameters.AddWithValue("@contenidoCo", txtContenido.Text);
            Comando.Connection = con;
            con.Open();
            Comando.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Combo ingresado exitosamente.");
            cargarTabla();



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "UPDATE Combos SET Estado='NE' WHERE CodigoCo=@codigoCo";
            Comando.Parameters.AddWithValue("@codigoCo", txtCodigo.Text);
            Comando.Connection = con;
            con.Open();
            Comando.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Se ha eliminado el registro, pero seguirá apareciendo en los registros de compras.");
            cargarTabla();
                      

        }
    }
}
