using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RoesTortilleria
{
    class Conexion
    {
        public static SqlConnection getConexion()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=george;Initial Catalog=ROES;Integrated Security=True");
               // cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
