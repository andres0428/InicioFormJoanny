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
    public partial class ConsultaProductos : Form
    {
        Conexion Conexion = new Conexion();

        public ConsultaProductos()
        {
            InitializeComponent();
        }

        public DataSet llenarDataGridView(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("select * from " + tabla);
            DS = Conexion.Con(cmd);
            return DS;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDataGridView("Articulo").Tables[0];

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NombreTextBox.Text.Trim()) == false)
            {
                try
                {
                    string buscar = string.Format("select * from Articulo where NombreProducto like ('%" + NombreTextBox.Text + "%')");
                    DataSet ds = Conexion.Con(buscar);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error", ex.Message);
                }

            }
        }
    }
}
