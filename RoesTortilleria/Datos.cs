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
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            String query = "Select Usuario, Password From SysUsuarios Where Usuario = '" + Usuario + "' and Password = '" + Contraseña + "'";
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
            String query = "Insert into Cliente values ('" + Nombre + "','" + Contacto + "','" + Direccion + "','" + Telefono + "')";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();
            conexion.Close();
        }
        #endregion

        #region AddVneta

        #region BuscarCOncepto
        public static DataTable BuscarConcepto(string concepto)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = Conexion.getConexion();//cadena conexion
            conexion.Open();
            string consulta = "SELECT * FROM Cuota WHERE Tipo=@concepto"; //consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@concepto", concepto);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            return dt;
            conexion.Close();
        }
        #endregion

        #region multiplicacion kilos * costo de la cuota
        public static int multiplica(int kilos, int costo)
        {
            int multi;
            multi = kilos * costo;
            return multi;
        }


        #endregion

        public static bool addVenta(int idCliente, int idCuota, string concepto, int totalTortilla, int tortillaSabor, int toritllaNormal, int kilostotal, string fecha)
        {
            SqlConnection conexion = Conexion.getConexion();

            conexion.Open();
            String query = "Insert into Ventas values (" + idCliente + "," + idCuota + ",'" + concepto + "'," + totalTortilla + "," + toritllaNormal + "," + tortillaSabor + "," + kilostotal + ",'" + fecha + "')";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();
            setVentas(fecha, concepto);
            return reader.Read();
            conexion.Close();
        }

        #region PoneVentasEnTabla
        public static DataTable setVentas(string fecha, string concepto)
        {
            SqlConnection conexion = Conexion.getConexion();
            DataTable dt = new DataTable();
            conexion.Open();
            string consulta = "SELECT * FROM Ventas WHERE Tipo like @concepto and Fecha like @fecha";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@concepto", concepto);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            return dt;
            conexion.Close();
        }
        
        #endregion

        #endregion

        #region BuscaLosClientes y Cuotas

        public static DataTable BuscarClientes()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = Conexion.getConexion();//cadena conexion
            conexion.Open();
            string consulta = "SELECT * FROM Cliente"; //consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            return dt;
            conexion.Close();
        }
        public static DataTable BuscarClientesbyName(string getComboCliente)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = Conexion.getConexion();//cadena conexion
            conexion.Open();
            string consulta = "SELECT * FROM Cliente WHERE Nombre=@nombre"; //consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@nombre", getComboCliente);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            return dt;
            conexion.Close();
        }
        public static DataTable GetCuota()
        {
            DataTable cuotadt = new DataTable();
            SqlConnection conexion = Conexion.getConexion();//cadena conexion
            conexion.Open();
            string consulta = "SELECT * FROM Cuota WHERE (idCuota) != (3)"; //consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(cuotadt);
            return cuotadt;
            conexion.Close();
        }


        internal static void deleteCliente(int delete)
        {
            SqlConnection conexion = Conexion.getConexion();//cadena conexion
            conexion.Open();
            string consulta = "DELETE FROM Cliente WHERE idCliente = @delete"; //consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@delete", delete);
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliene Eliminado satisfactoriamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }

            conexion.Close();
        }
        #endregion

    }
}
