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
    public partial class MantenimientoCliente : Form
    {
        Conexion Conexion = new Conexion();

        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            try
            {
                string data = string.Format("Exec  ActualizaClientes '{0}', '{1}' , '{2}' ", idCliTextBox.Text.Trim(), NomCliTextBox.Text.Trim(), ApeCliTexBox.Text.Trim());
                Conexion.Con(data);
                MessageBox.Show("Se guardó con satisfación");

            }

            catch (Exception ex)
            {

                MessageBox.Show("Sin guardar", ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("Exec EliminarClientes '{0}' ", idCliTextBox.Text.Trim());
                Conexion.Con(data);
                MessageBox.Show("Se eliminó con satisfación");
            }
            catch ( Exception ex)
            {
                MessageBox.Show("No se pudo eliminar", ex.Message);
            }
        }

        private void SalirBbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
