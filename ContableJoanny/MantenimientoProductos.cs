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
    public partial class MantenimientoProductos : Form
    {
        Conexion Conexion = new Conexion();
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("Exec  ActulizaArticulos '{0}', '{1}' , '{2}' ", idProTextBox.Text.Trim(), NomProTextBox.Text.Trim(), PrecioTextBox.Text.Trim());
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
                string data = string.Format("Exce EliminarArticulos '{0}' ", idProTextBox.Text.Trim());
                Conexion.Con(data);
                MessageBox.Show("Se guardó con satisfación");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar", ex.Message);

            }
          
        }

        private void SalirBbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
