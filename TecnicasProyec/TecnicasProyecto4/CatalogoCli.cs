using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class CatalogoCli : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O15S8EP;Initial Catalog=Cine;User ID=Danny;Password=12345");
        String Categoria ;

        public DataTable TablaCodigo()
        {
            SqlCommand cmd;
            if (Categoria.Equals("C"))
            {

                 cmd  = new SqlCommand("Select ImagenPe ,CodigoPe from Peliculas where CategoriaPe = 'Estreno'", con);

            } else 
            {
                 cmd = new SqlCommand("Select ImagenPe ,CodigoPe from Peliculas where CategoriaPe = 'Proximo Estreno'", con);
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        private void Abrirform(object formhija)
        {
            if (this.Descripcion1.Controls.Count > 0)
            {
                this.Descripcion1.Controls.RemoveAt(0);

            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Descripcion1.Controls.Add(fh);
            this.Descripcion1.Tag = fh;
            fh.Show();
        }

        public CatalogoCli()
        {
            InitializeComponent();

        }

        public CatalogoCli(String text)

        {
            InitializeComponent();
            Categoria = text;

            con.Open();


            DataTable dt = TablaCodigo();

            C1.BackgroundImage = Image.FromFile(@"" + dt.Rows[0][0].ToString());
            C2.BackgroundImage = Image.FromFile(@"" + dt.Rows[1][0].ToString());
            C3.BackgroundImage = Image.FromFile(@"" + dt.Rows[2][0].ToString());
            C4.BackgroundImage = Image.FromFile(@"" + dt.Rows[3][0].ToString());
            C5.BackgroundImage = Image.FromFile(@"" + dt.Rows[4][0].ToString());
            C6.BackgroundImage = Image.FromFile(@"" + dt.Rows[5][0].ToString());
            C7.BackgroundImage = Image.FromFile(@"" + dt.Rows[6][0].ToString());
            C8.BackgroundImage = Image.FromFile(@"" + dt.Rows[7][0].ToString());
            con.Close();


        }

        public void MandarDatos(string codigo)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand("Select NombrePe, DirectoresPe from Peliculas where CodigoPe =@codigo ", con);
            cmd.Parameters.AddWithValue("codigo", codigo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            SqlCommand cmd2 = new SqlCommand("Select ActoresPe ,DescripcionPe  from Peliculas where CodigoPe =@codigo ", con);
            cmd2.Parameters.AddWithValue("codigo", codigo);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            if (Descripcion1.Visible == true)
            {
                Titulo.Text = dt.Rows[0][0].ToString();
                directores.Text = dt.Rows[0][1].ToString();
                actores.Text = dt2.Rows[0][0].ToString();
            }
            else if (Descripcion2.Visible == true)
            {
                Titulo2.Text = dt.Rows[0][0].ToString();
                directores2.Text = dt.Rows[0][1].ToString();
                actores2.Text = dt2.Rows[0][0].ToString();
            }


            con.Close();

        }



        private void C1_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            Descripcion2.Visible = false;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[0][1].ToString();
            MandarDatos(codigo);

        }

        private void C2_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            Descripcion2.Visible = false;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[1][1].ToString();
            MandarDatos(codigo);
        }

        private void CatalogoCli_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = false;
            Descripcion2.Visible = false;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Abrirform(new Compra());
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            Descripcion2.Visible = false;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[2][1].ToString();
            MandarDatos(codigo);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = true;
            Descripcion2.Visible = false;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[3][1].ToString();
            MandarDatos(codigo);

        }

        private void C5_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = false;
            Descripcion2.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[4][1].ToString();
            MandarDatos(codigo);
        }

        private void C6_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = false;
            Descripcion2.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[5][1].ToString();
            MandarDatos(codigo);
        }

        private void C7_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = false;
            Descripcion2.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[6][1].ToString();
            MandarDatos(codigo);

        }

        private void C8_Click(object sender, EventArgs e)
        {
            Descripcion1.Visible = false;
            Descripcion2.Visible = true;
            DataTable dt = TablaCodigo();
            String codigo = dt.Rows[7][1].ToString();
            MandarDatos(codigo);
        }

        private void Descripcion2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CatalogoCli_Load(object sender, EventArgs e)
        {

        }
    }
}
