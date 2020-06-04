using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Conexion
    {
        public DataSet Con(String cmd)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            connection.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, connection);
            DA.Fill(DS);
            connection.Close();
            return DS;
        }
    }
}
