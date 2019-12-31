using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class Admi : Form
    {
        public Admi()
        {
            InitializeComponent();
        }

        public Admi(String text, String tipo)

        {
            InitializeComponent();
            String Nombre = text;
            NomUsu.Text = "Welcome " + Nombre + tipo;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Abrirform(object formhija)
        {
            if (this.barracontenido.Controls.Count > 0)
            {
                this.barracontenido.Controls.RemoveAt(0);

            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.barracontenido.Controls.Add(fh);
            this.barracontenido.Tag = fh;
            fh.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barrainicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            InicioSesion formulario = new InicioSesion();
            formulario.Visible = true;
            Visible = false;


        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Abrirform(new CarteleraCli());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrirform(new Dulceria());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abrirform(new RegistrarAdmi());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Abrirform(new VerUsers());
        }

        private void ModPeli_Click(object sender, EventArgs e)
        {
            Abrirform(new ModPelicula());
        }
    }
}
