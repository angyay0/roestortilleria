using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RoesTortilleria
{
    class Datos
    {
        #region LogIn
        public static bool LogIn(String Usuario, String Contraseña)
        {
            SqlConnection conexion = Conexion.getConexion() ;
            conexion.Open();
            String query="Select Usuario, Password From SysUsuarios Where Usuario = '" + Usuario + "' and Password = '" + Contraseña + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();
            
            return reader.Read();
            conexion.Close();
        }
        #endregion


    }
}
