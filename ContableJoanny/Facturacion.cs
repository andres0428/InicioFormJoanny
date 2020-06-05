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
    public partial class Facturacion : Form
    {
        Conexion Conexion = new Conexion();

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from Usuarios where IdUsuario = " + LoginForm.codigo);
            DataSet ds = Conexion.Con(cmd);
            LeAtiendeLabel.Text = ds.Tables[0].Rows[1]["NombreUsuario"].ToString().Trim();
        }
    }
}
