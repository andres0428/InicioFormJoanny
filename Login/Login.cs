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
        Conexion conexion = new Conexion();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strin = string.Format("select * from Usuarios where Account = '{0}' and Password = '{1}' ", IDTextBox.Text.Trim());
                DataSet DS = conexion.Con(strin);

                string account = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = DS.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (account == IDTextBox.Text.Trim() && contraseña == PasswordTextBox.Text.Trim())
                {
                    MessageBox.Show("Conexion Exitosa");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o conytraseña incorrecta");
            }
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
