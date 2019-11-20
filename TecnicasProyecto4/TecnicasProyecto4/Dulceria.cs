using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class Dulceria : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O15S8EP;Initial Catalog=Cine;User ID=Danny;Password=12345");

        public DataTable TablaCodigo()
        {

            SqlCommand cmd = new SqlCommand("Select ImagenCo ,CodigoCo from Combos  ", con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void MandarDatos(string codigo)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand("Select NombreCo ,PrecioCo from Combos where CodigoCo =@codigo ", con);
            cmd.Parameters.AddWithValue("codigo", codigo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            SqlCommand cmd2 = new SqlCommand("Select ContenidoCo ,ImagenCo  from Combos where CodigoCo =@codigo ", con);
            cmd2.Parameters.AddWithValue("codigo", codigo);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            Titulo.Text = dt.Rows[0][0].ToString();
            Precio.Text = dt.Rows[0][1].ToString();
            Contenido.Text = dt2.Rows[0][0].ToString();
            ComboT1.BackgroundImage = Image.FromFile(@"" + dt2.Rows[0][1].ToString());



            con.Close();

        }


        public Dulceria()
        {

            InitializeComponent();


            con.Open();


            DataTable dt = TablaCodigo();

            T1.BackgroundImage = Image.FromFile(@"" + dt.Rows[0][0].ToString());
            T2.BackgroundImage = Image.FromFile(@"" + dt.Rows[1][0].ToString());
            T3.BackgroundImage = Image.FromFile(@"" + dt.Rows[2][0].ToString());
            T4.BackgroundImage = Image.FromFile(@"" + dt.Rows[3][0].ToString());
            T5.BackgroundImage = Image.FromFile(@"" + dt.Rows[4][0].ToString());
            T6.BackgroundImage = Image.FromFile(@"" + dt.Rows[5][0].ToString());
            T7.BackgroundImage = Image.FromFile(@"" + dt.Rows[6][0].ToString());

            con.Close();
        }

        private void T1_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[0][1].ToString();
            MandarDatos(codigo);
        }

        private void Dulceria_Load(object sender, EventArgs e)
        {

        }

        private void Dulceria_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = false;
        }

        private void T2_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[1][1].ToString();
            MandarDatos(codigo);
        }

        private void T3_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[2][1].ToString();
            MandarDatos(codigo);
        }

        private void T4_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[3][1].ToString();
            MandarDatos(codigo);
        }

        private void T5_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[4][1].ToString();
            MandarDatos(codigo);
        }

        private void T6_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[5][1].ToString();
            MandarDatos(codigo);
        }

        private void T7_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[6][1].ToString();
            MandarDatos(codigo);
        }
    }
}
