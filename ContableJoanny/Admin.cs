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
    public partial class Admin : Form
    {
        Conexion Conexion = new Conexion();

        public Admin()
        {
            InitializeComponent();
        }

        public static string codigo;

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
