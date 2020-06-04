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
            string cmd = "select * from Usuarios where IdUsuario =" + LoginForm.codigo;
          
            DataSet ds = Conexion.Con(cmd);

            AdminLabel.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();
            UserLabel.Text = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
            CodigoLabel.Text = ds.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();

        }

        private void ContenedorPrincipalButton_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedor = new ContenedorPrincipal();
            this.Hide();
            contenedor.Show();

        }

        private void AdminUsuariosButton_Click(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where IdUsuario =" + LoginForm.codigo;

            DataSet ds = Conexion.Con(cmd);

            AdminLabel.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();
            UserLabel.Text = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
            CodigoLabel.Text = ds.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();

        }
    }
}
