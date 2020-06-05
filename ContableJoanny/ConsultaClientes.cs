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
    public partial class ConsultaClientes : Form
    {
        Conexion Conexion = new Conexion();

        public ConsultaClientes()
        {
            InitializeComponent();
        }       

        public DataSet llenarDataGridView(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("select * from " + tabla);
            DS = Conexion.Con (cmd);
            return DS;
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDataGridView("Clientes").Tables[0];
        }

        

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
