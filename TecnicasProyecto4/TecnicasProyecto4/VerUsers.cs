﻿using System;
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
    public partial class VerUsers : Form
    {
        public VerUsers()
        {
            InitializeComponent();
        }

        private void VerUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.cineDataSet1.Compras);
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.cineDataSet.Usuarios);

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
