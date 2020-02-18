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
    public partial class Venta : Form
    {
        public int Too =1;
        public int numAsientos = 0;
        public double costo = 0;
        public double costoT = 0; 
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NEOBUSS0;Initial Catalog=Cine;User ID=pablo;Password=pablo");

        private void Abrirform(object formhija)
        {
           /* if (this.VAsientos.Controls.Count > 0)
            {
                this.VAsientos.Controls.RemoveAt(0);

            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.VAsientos.Controls.Add(fh);
            this.VAsientos.Tag = fh;
            fh.Show();
            */
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT * FROM Asientos WHERE Libre='S' ";
            //Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            Comando.ExecuteNonQuery();
            SqlDataReader respuesta = Comando.ExecuteReader();
            int y = 30;
            int x = 30; 
            while (respuesta.Read())
            {
                Image image1 = Image.FromFile("c:\\asiento.png"); 
                Label lb = new Label();
                lb.Text = respuesta[0].ToString();
                lb.TextAlign = ContentAlignment.MiddleCenter; 
                lb.Location = new Point(x, y);
                //lb.Width = 20;
                lb.Size = new Size(image1.Width, image1.Height);
                lb.Image = image1; 
                x = x + 40;
                if (x >= 516)
                {
                   x = 30; 
                   y = y + 35;
               
                }


                string cod = respuesta[0].ToString();
                lb.Name = cod;
                lb.Click += new EventHandler(handlerComun_click);
                panelAsientos.Controls.Add(lb);
                
                
                //label1.Text = respuesta[1].ToString();  
            }
            con.Close();

        
        }

        private void handlerComun_click(object sender, EventArgs e)
        {
            string libre = "";
            Label asiento = sender as Label;
            lblAsiento.Text = asiento.Name;
            
            con.Open();
            SqlCommand Comando2 = new SqlCommand();
            Comando2.CommandText = "SELECT * FROM Asientos WHERE CodigoAs= @codigoAs";
            Comando2.Parameters.AddWithValue("@codigoAs", lblAsiento.Text);
            Comando2.Connection = con;
            Comando2.ExecuteNonQuery();
            SqlDataReader respuesta = Comando2.ExecuteReader();
            while (respuesta.Read())
            {
                libre = respuesta[2].ToString();
            }
            con.Close();
            if (libre == "N")
            {
                con.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = "UPDATE Asientos SET Libre='S' WHERE CodigoAs= @codigoAs";
                Comando.Parameters.AddWithValue("@codigoAs", lblAsiento.Text);
                Comando.Connection = con;
                Comando.ExecuteNonQuery();
                con.Close();
                asiento.BackColor = Color.Transparent;
                numAsientos = numAsientos - 1 ;
                lblNumAsientos.Text = numAsientos.ToString();
                costo = 5.00;
                costoT = costo * numAsientos;
                lblCostoT.Text = costoT.ToString();
            }
            else
            {
                con.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = "UPDATE Asientos SET Libre='N' WHERE CodigoAs= @codigoAs";
                Comando.Parameters.AddWithValue("@codigoAs", lblAsiento.Text);
                Comando.Connection = con;
                Comando.ExecuteNonQuery();
                con.Close();
                asiento.BackColor = Color.FromArgb(217, 83, 79);
                numAsientos = numAsientos + 1;
                lblNumAsientos.Text = numAsientos.ToString();
                costo = 5.00;
                costoT = costo * numAsientos;
                lblCostoT.Text = costoT.ToString();  
            }

            
            
            
            
        }

        public Venta(string text)
        {

            InitializeComponent();
            this.funcionTableAdapter.FindCodHo(cineDataSet1.Funcion, Int32.Parse(text));
            lblPelicula.Text =CatalogoCli.PeliToo;
            label1.Text =text;
            Too = Int32.Parse(text);


        }

        private void funcionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }

        private void funcionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cineDataSet1);

        }

        private void Venta_Load(object sender, EventArgs e)
        {
 
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Horarios' Puede moverla o quitarla según sea necesario.
            this.horariosTableAdapter.Fill(this.cineDataSet1.Horarios);
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet1.Funcion' Puede moverla o quitarla según sea necesario.
            this.funcionTableAdapter.Fill(this.cineDataSet1.Funcion);

           /* SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "SELECT CodigoAs FROM Asientos WHERE Libre='S'";
            //Comando.Parameters.AddWithValue("@idPeli", codigoPeTextBox.Text);
            Comando.Connection = con;
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            asientos.DataSource = tabla;
            con.Close();
            */
        }
        private void findCodHoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionTableAdapter.FindCodHo(this.cineDataSet1.Funcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        private void funcionBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.horariosTableAdapter.horaP1(cineDataSet1.Horarios, Int32.Parse(codigoHoTextBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.funcionTableAdapter.FindCodHo(cineDataSet1.Funcion, Too);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionFuncion_Click_1(object sender, EventArgs e)
        {
            Abrirform(new Asientos(codigoFuTextBox.Text));
            //Label selec = sender as Label;
            //asiento.Text = selec.Name;
            
        }

        private void lb_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void LblCosto_Click(object sender, EventArgs e)
        {

        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            SqlCommand Comando = new SqlCommand();
            Comando.CommandText = "INSERT INTO Compras(DescripcionVe, FechaVe, MontoVe, NameUse, FunciOCombo) VALUES (@descripcionVe,@fechaVe, @montoVe,@nameUse, @foc)";
            string descripcion = "Pelicula:" + lblPelicula.Text + " " + lblNumAsientos.Text + " asientos";
            DateTime fecha = DateTime.Now;
            Comando.Parameters.AddWithValue("@descripcionVe", descripcion);
            Comando.Parameters.AddWithValue("@fechaVe", fecha);
            Comando.Parameters.AddWithValue("@montoVe", lblCostoT.Text);
            Comando.Parameters.AddWithValue("@nameUse", "Kuroke");
            Comando.Parameters.AddWithValue("@foc", 1); 
            Comando.Connection = con;
            con.Open();
            Comando.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Compra realizada exitosamente!");
        }

        private void LblCI_Click(object sender, EventArgs e)
        {

        }
    }
}
