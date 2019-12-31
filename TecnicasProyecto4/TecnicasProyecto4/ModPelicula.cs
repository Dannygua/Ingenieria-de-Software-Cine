using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasProyecto4
{
    public partial class ModPelicula : Form
    {
        private int CodigoPe;

        public ModPelicula()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }

        private void ModPelicula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.cineDataSet1.Peliculas);

        }


        private void btnAgregarPeli_Click(object sender, EventArgs e)
        {
            this.peliculasTableAdapter.AgregarPelicula(nombrePeTextBox.Text, webPeTextBox.Text, directoresPeTextBox.Text, actoresPeTextBox.Text, descripcionPeTextBox.Text, imagenPeTextBox.Text, categoriaPeTextBox.Text);
            this.peliculasTableAdapter.Fill(this.cineDataSet1.Peliculas);
        }

        private void btnModificarPeli_Click(object sender, EventArgs e)
        {
            int CodigoP = Int32.Parse(codigoPeTextBox.Text);

            this.peliculasTableAdapter.ModificarPelicula(nombrePeTextBox.Text, webPeTextBox.Text, directoresPeTextBox.Text, actoresPeTextBox.Text, descripcionPeTextBox.Text, imagenPeTextBox.Text, categoriaPeTextBox.Text, CodigoP, CodigoPe);
            this.peliculasTableAdapter.Fill(this.cineDataSet1.Peliculas);
        }

        private void btnEliminarPeli_Click(object sender, EventArgs e)
        {
            this.peliculasTableAdapter.EliminarPelicula(Int32.Parse(codigoPeTextBox.Text));
            this.peliculasTableAdapter.Fill(this.cineDataSet1.Peliculas);

        }

        private void btnBuscarPeli_Click(object sender, EventArgs e)
        {
            this.peliculasTableAdapter.BuscarPelicula(cineDataSet1.Peliculas, Int32.Parse(codigoPeTextBox.Text));

        }

        private void btnMostrarPeli_Click(object sender, EventArgs e)
        {
            this.peliculasTableAdapter.Fill(this.cineDataSet1.Peliculas);
        }
    }
}
