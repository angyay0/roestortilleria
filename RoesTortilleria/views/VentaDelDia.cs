using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoesTortilleria.views
{
    public partial class VentaDelDia : Form
    {
        public VentaDelDia(DateTime date)
        {
            InitializeComponent();
            fillData(date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
        }

        public void fillData(string fecha)
        {
            int pesoNormal = 0;
            int pesoSabor = 0;
            float pesoTotal = 0f;
            float venta = 0f;

            List<PesoCuota> pesos = new List<PesoCuota>();
            List<ResVenta> ventas = getVentas(fecha);
            
            SqlConnection con2 = Conexion.getConexion();
            string queryPeso =
                "SELECT c.idCuota,c.Normal,c.Sabor,pc.pesoNormal,pc.pesoSabor FROM Cuota c INNER JOIN PesoCuota pc ON pc.idCuota = c.idCuota";
            con2.Open();
            SqlCommand command = new SqlCommand(queryPeso, con2);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PesoCuota p = new PesoCuota();
                try
                {
                    p.precioNormal = reader.GetInt32(1);
                    p.precioSabor = reader.GetInt32(2);
                    p.pesoNormal = Convert.ToInt32(reader.GetString(3));
                    p.pesoSabor = Convert.ToInt32(reader.GetString(4));
                    p.idCuota = reader.GetInt32(0);
                    pesos.Add(p);
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message, "ERROR");
                }
            }
            con2.Close();


            MessageBox.Show("" + pesos.Count, "INFO");
          
            con2.Close();

            MessageBox.Show("" + ventas.Count, "INFOR");// return;

            for(int i = 0; i < pesos.Count; i++)
            {
                for(int j = 0; j < ventas.Count; j++)
                {
                    if( ventas.ElementAt<ResVenta>(j).idCuota == pesos.ElementAt<PesoCuota>(i).idCuota)
                    {
                        pesoNormal += ventas.ElementAt<ResVenta>(j).npTotal * pesos.ElementAt<PesoCuota>(i).pesoNormal;
                        venta += (float)ventas.ElementAt<ResVenta>(j).npTotal * pesos.ElementAt<PesoCuota>(i).precioNormal;
                       // continue;
                    }
                }
            }
            pesoNormal /= 1000;

            this.ventaPrecio.Text = "$"+venta;
            this.ventaTortilla.Text = ""+pesoNormal+" KG";
        }

        public List<ResVenta> getVentas(string fecha)
        {
            int cantidad = 0;
            int normal = 0;
            int sabor = 0;
            int total = 0;
            ResVenta venta = null;
            List<ResVenta> ventas = new List<ResVenta>();
            string[] TYPE = new String[] { "800gr", "900gr", "Mostrador", "especialOasis" };

            for (int i = 0; i < TYPE.Length; i++)
            {
                cantidad = 0;
                normal = 0;
                sabor = 0;
                total = 0;
                DataTable dt = Datos.setVentas(fecha, TYPE[i]);
                if (dt.Rows.Count > 0)
                {
                    venta = new ResVenta();
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        DataRow row = dt.Rows[x];
                        //guardo datos en variables
                        cantidad = cantidad + Convert.ToInt32(row["Cantidad"]);
                        normal = normal + Convert.ToInt32(row["Normal"]);
                        sabor = sabor + Convert.ToInt32(row["sabor"]);
                        total = total + Convert.ToInt32(row["Total"]);
                        
                    }
                    venta.cantidad = cantidad;
                    venta.idCuota = (i + 1);
                    venta.npTotal = normal;
                    venta.spTotal = sabor;
                    venta.total = total;

                    ventas.Add(venta);
                }
            }

            return ventas;

        }

        public class PesoCuota
        {
            public int pesoNormal = 0;
            public int precioNormal = 0;
            public int precioSabor = 0;
            public int pesoSabor = 0;
            public int idCuota = 0;
        }

        public class ResVenta
        {
            public int npTotal = 0;
            public int spTotal = 0;
            public int cantidad = 0;
            public int total;

            public int idCuota = 0;

        }
    }
}
