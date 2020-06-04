using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContableJoanny
{
    public partial class LoginForm : Form
    {
        Conexion conexion = new Conexion();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            IDTextBox.Focus();
        }

        public static string codigo;

        private void StarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strin = string.Format("select * from Usuarios where Account = '{0}' and Password = '{1}' ", IDTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet DS = conexion.Con(strin);

                codigo = DS.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();

                string account = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = DS.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (account == IDTextBox.Text.Trim() && contraseña == PasswordTextBox.Text.Trim())
                {
                    if (Convert.ToBoolean(DS.Tables[0].Rows[0]["StatusAdmin"].ToString()) == true)
                    {
                        Admin admin = new Admin();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        User user = new User();
                        this.Hide();
                        user.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario o contraseña incorrecta" + ex.Message);              
            }
            
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
