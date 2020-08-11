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
    public partial class RegistrarAdmi : Form
    {
        public RegistrarAdmi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source =LAPTOP-NEOBUSS0; Initial Catalog = Cine; User ID = pablo; Password=pablo");

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            con.Open();
            string st = "insert into Usuarios(NameUse, Pass, Nombres, Apellidos, Correo, fechanacimiento, TipoUsuario) values(@nombreU, @contra, @nombre, @apellido, @correo, @fecha, 'Administrador')";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@nombre", lblNombre.Text);
            cmd.Parameters.AddWithValue("@apellido", lblApellido.Text);
            cmd.Parameters.AddWithValue("@nombreU", lblNombreU.Text);
            cmd.Parameters.AddWithValue("@contra", lblContra.Text);
            cmd.Parameters.AddWithValue("@correo", lblCorreo.Text);
            cmd.Parameters.AddWithValue("@fecha", FechaN.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Administrador creado correctamente!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
