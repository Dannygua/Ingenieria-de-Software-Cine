using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O15S8EP;Initial Catalog=Cine;User ID=Danny;Password=12345");

        public void logear(String NombreUsu, String contra, String Nombre, String Apellido, String Correo, String Fecha, String Cargo)
        {


            try
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(@"insert into Usuarios (NameUse ,Pass ,Nombres, Apellidos ,Correo ,fechanacimiento,TipoUsuario ) values @NombreUsu,@contra,@Nombre, @Apellido,@Correo,@Fecha,@Cargo", con);
                    cmd.Parameters.AddWithValue("NombreUsu", NombreUsu);
                    cmd.Parameters.AddWithValue("contra", contra);
                    cmd.Parameters.AddWithValue("Nombre", Nombre);
                    cmd.Parameters.AddWithValue("Apellido", Apellido);
                    cmd.Parameters.AddWithValue("Correo", Correo);
                    cmd.Parameters.AddWithValue("Fecha", Fecha);
                    cmd.Parameters.AddWithValue("Cargo", Cargo);
                    MessageBox.Show("Usuario Registrado");

                }
                catch (Exception exe)
                {

                    MessageBox.Show(exe.Message);
                }


                con.Close();
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }

        }
        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Registrar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblNombre_Enter(object sender, EventArgs e)
        {
            if (lblNombre.Text == "NOMBRES")
            {
                lblNombre.Text = "";
                lblNombre.ForeColor = Color.LightGray;

            }

        }

        private void lblNombre_Leave(object sender, EventArgs e)
        {

            if (lblNombre.Text == "")
            {
                lblNombre.Text = "NOMBRES";
                lblNombre.ForeColor = Color.DimGray;

            }

        }

        private void lblApellido_Enter(object sender, EventArgs e)
        {
            if (lblApellido.Text == "APELLIDOS")
            {
                lblApellido.Text = "";
                lblApellido.ForeColor = Color.LightGray;

            }

        }

        private void lblApellido_Leave(object sender, EventArgs e)
        {
            if (lblApellido.Text == "")
            {
                lblApellido.Text = "APELLIDOS";
                lblApellido.ForeColor = Color.DimGray;

            }
        }

        private void lblNombreU_Enter(object sender, EventArgs e)
        {
            if (lblNombreU.Text == "NOMBRE USUARIO")
            {
                lblNombreU.Text = "";
                lblNombreU.ForeColor = Color.LightGray;

            }

        }

        private void lblNombreU_Leave(object sender, EventArgs e)
        {
            if (lblNombreU.Text == "")
            {
                lblNombreU.Text = "NOMBRE USUARIO";
                lblNombreU.ForeColor = Color.DimGray;

            }
        }

        private void lblContra_Enter(object sender, EventArgs e)
        {
            if (lblContra.Text == "CONTRASEÑA")
            {
                lblContra.Text = "";
                lblContra.ForeColor = Color.LightGray;

            }

        }

        private void lblContra_Leave(object sender, EventArgs e)
        {
            if (lblContra.Text == "")
            {
                lblContra.Text = "CONTRASEÑA";
                lblContra.ForeColor = Color.DimGray;

            }
        }

        private void lblCorreo_Enter(object sender, EventArgs e)
        {
            if (lblCorreo.Text == "CORREO")
            {
                lblCorreo.Text = "";
                lblCorreo.ForeColor = Color.LightGray;

            }

        }

        private void lblCorreo_Leave(object sender, EventArgs e)
        {
            if (lblContra.Text == "")
            {
                lblContra.Text = "CORREO";
                lblContra.ForeColor = Color.DimGray;

            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.Open();
            string st = "insert into Usuarios(NameUse, Pass, Nombres, Apellidos, Correo, fechanacimiento) values(@nombreU, @contra, @nombre, @apellido, @correo, @fecha)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@nombre", lblNombre.Text);
            cmd.Parameters.AddWithValue("@apellido", lblApellido.Text);
            cmd.Parameters.AddWithValue("@nombreU", lblNombreU.Text);
            cmd.Parameters.AddWithValue("@contra", lblContra.Text);
            cmd.Parameters.AddWithValue("@correo", lblCorreo.Text);
            cmd.Parameters.AddWithValue("@fecha", FechaN.Value);
            cmd.ExecuteNonQuery();
            con.Close();
      
          //  string cadena = "insert into Usuarios(NameUse, Pass, Nombres, Apellidos, Correo, fechanacimiento, TipoUsuario) values ('" & nombre & "'," & apellido & ")";
         //   comando = new SqlCommand()

          //  logear(lblNombreU.Text, lblContra.Text, lblNombre.Text, lblApellido.Text, lblCorreo.Text, FechaN.Text, "Cliente");
        }

        private void lblNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
