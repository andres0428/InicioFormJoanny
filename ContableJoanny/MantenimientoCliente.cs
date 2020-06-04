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
                string data = string.Format("Exec  ActulizaClientes '{0}', '{1}' , '{2}' ", idCliTextBox.Text.Trim(), NomCliTextBox.Text.Trim(), ApeCliTextBox.Text.Trim());
                Conexion.Con(data);
                MessageBox.Show("se guardo con satisfacion");

            }

            catch (Exception ex)
            {

                MessageBox.Show("Sin guardar", ex.Message);
            }
        }
    }
}
