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

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
                con.Open();
                MessageBox.Show("conexion true");

            }
            catch (Exception ex)
            {

                MessageBox.Show("conexion false", ex.Message);
            }
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
