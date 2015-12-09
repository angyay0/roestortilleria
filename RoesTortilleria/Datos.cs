using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RoesTortilleria
{
    class Datos
    {
        #region LogIn
        public static int LogIn(String Usuario, String Contraseña)
        {
            int resultado = -1;
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            String query="Select Usuario, Password From SysUsuarios Where Usuario = '" + Usuario + "' and Password = '" + Contraseña + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }
        #endregion


    }
}
