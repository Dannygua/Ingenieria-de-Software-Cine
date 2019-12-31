using System;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class CarteleraCli : Form
    {
        public CarteleraCli()
        {
            InitializeComponent();
            Abrirform(new Inicio());
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

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Abrirform(new CatalogoCli("Estreno"));
        }

        private void PEstrenos_Click(object sender, EventArgs e)
        {
            Abrirform(new CatalogoCli("Proximo Estreno"));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Abrirform(new Inicio());
        }

        private void btnCombrar_Click(object sender, EventArgs e)
        {
            Abrirform(new Compra());
        }
    }
}
