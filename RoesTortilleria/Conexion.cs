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
                SqlConnection cn = new SqlConnection("Data Source=ENKERUPC\\AIMOS;Initial Catalog=RoesDB;User ID=sa;Password=1234");
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
