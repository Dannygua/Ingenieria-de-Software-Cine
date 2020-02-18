using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source =LAPTOP-NEOBUSS0; Initial Catalog = Cine; User ID = pablo; Password=pablo");

        public void logear(string usuario, string contrasena)
        {


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select NameUse, TipoUsuario from Usuarios where NameUse =@usuario and Pass=@contrasena ", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count == 1)
                {


                    if (dt.Rows[0][1].ToString() == "Administador")
                    {

                        String texto = dt.Rows[0][0].ToString();
                        
                        Admi formulario = new Admi(texto);
                        formulario.Visible = true;
                        Visible = false;




                    }
                    else if (dt.Rows[0][1].ToString() == "Cliente")
                    {

                        String texto = dt.Rows[0][0].ToString();
                        Cliente formulario = new Cliente(texto);
                        formulario.Visible = true;
                        Visible = false;

                    }

                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto");
                }

                con.Close();
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            logear(NomUsu.Text, Contra.Text);

        }

        private void NomUsu_Enter(object sender, EventArgs e)
        {
            if (NomUsu.Text == "USUARIO")
            {
                NomUsu.Text = "";
                NomUsu.ForeColor = Color.LightGray;
            }
        }

        private void NomUsu_Leave(object sender, EventArgs e)
        {
            if (NomUsu.Text == "")
            {
                NomUsu.Text = "USUARIO";
                NomUsu.ForeColor = Color.DimGray;

            }
        }

        private void Contra_Enter(object sender, EventArgs e)
        {
            if (Contra.Text == "CONTRASEÑA")
            {
                Contra.Text = "";
                Contra.ForeColor = Color.LightGray;
                Contra.UseSystemPasswordChar = true;
            }
        }

        private void Contra_Leave(object sender, EventArgs e)
        {
            if (Contra.Text == "")
            {
                Contra.Text = "CONTRASEÑA";
                Contra.ForeColor = Color.DimGray;
                Contra.UseSystemPasswordChar = false;
            }
        }

        private void InicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            Registrar formulario = new Registrar();
            formulario.Visible = true;
            Visible = false;

        }
    }
}
