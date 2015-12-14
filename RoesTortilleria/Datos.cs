using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

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

        #region AddCliente
        public static void addCliente(string Nombre, string Contacto, string Direccion, string Telefono)
        {
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            String query = "Insert into Cliente values ('"+Nombre+ "','" + Contacto + "','" + Direccion + "','" + Telefono + "')";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();
            conexion.Close();
        }
        #endregion

        #region AddVneta

        #region BuscarCOncepto
        internal static DataTable BuscarConcepto(string concepto)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = Conexion.getConexion();//cadena conexion

            string consulta = "SELECT * FROM Cuota WHERE Tipo=@concepto"; //consulta

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@concepto", concepto);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }
        #endregion

        #region multiplicacion kilos * costo de la cuota
        public static int multiplica(int kilos,int costo)
        {
            int multi;
            multi = kilos * costo;
            return multi;
        }


        #endregion

        public static bool addVenta(int idCliente, int idCuota, string concepto, int totalTortilla, int tortillaSabor, int toritllaNormal, int kilostotal, DateTime localDate)
        {
            SqlConnection conexion = Conexion.getConexion();
            string fecha = localDate.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
            conexion.Open();
            String query = "Insert into Ventas values ("+idCliente+","+idCuota+",'"+concepto+"',"+totalTortilla+","+toritllaNormal+","+tortillaSabor+","+kilostotal+",'"+fecha+"')";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();
            return reader.Read();
            conexion.Close();
        }
        #endregion

    }
}
