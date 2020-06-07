using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContableJoanny
{
    public partial class Facturacion : Form
    {
        Conexion Conexion = new Conexion();

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from Usuarios where IdUsuario = "+LoginForm.codigo);
            DataSet ds = Conexion.Con(cmd);
            LeAtiendeLabel.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(CodigoTextBox.Text.Trim()) == false)
            {
                try
                {
                    string data = string.Format("select NombreCliente from Clientes where IdClientes = '{0}' ", CodigoTextBox.Text.Trim());
                    DataSet DS = Conexion.Con(data);
                    ClienteTextBox.Text = DS.Tables[0].Rows[0]["NombreCliente"].ToString().Trim();
                    CodigoTextBox.Focus();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error", ex.Message);
                }

            }
        }
        public static int contadorFila;

        private void ColocarButton_Click(object sender, EventArgs e)
        {


            try
            {
                bool existe = false;
                int NumFila = 0;

                if (contadorFila == 0)
                {
                    dataGridView1.Rows.Add(CodigoTextBox2.Text, DescripcionTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) *
                                     Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                    contadorFila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        ////if (Fila.Cells[0].Value.ToString() == CodigoTextBox2.Text)
                        //{
                        //    existe = true;
                        //    NumFila = Fila.Index;
                        //}
                        existe = true;
                        NumFila = Fila.Index;
                    }

                    if (existe == true)
                    {
                        dataGridView1.Rows[NumFila].Cells[3].Value = (Convert.ToDouble(CantidadTextBox.Text) +
                                                                    Convert.ToDouble(dataGridView1.Rows[NumFila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[NumFila].Cells[2].Value) *
                                     Convert.ToDouble(dataGridView1.Rows[NumFila].Cells[3].Value);

                        dataGridView1.Rows[NumFila].Cells[4].Value = importe;

                    }
                    else
                    {
                        dataGridView1.Rows.Add(CodigoTextBox2.Text, DescripcionTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) *
                                         Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                        dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                        contadorFila++;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);

            }     
           
        }
    }
}
