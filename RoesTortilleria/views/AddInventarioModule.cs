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
    public partial class AddInventarioModule : Form
    {
        private int maseca = 0;
        private int minsa = 0;
        private MainModule module;

        public AddInventarioModule(int maseca,int minsa,MainModule module)
        {
            this.minsa = minsa;
            this.maseca = maseca;
            this.module = module;

            InitializeComponent();
        }

        private void addInv_Click(object sender, EventArgs e)
        {
            addInventario();
        }

        public void addInventario()
        {
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            DateTime date = DateTime.Now;

            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(fecha);

            String query =
            "UPDATE Almacen SET sMaseca = @maseca, kgMinsa = @minsa, updated = @date";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.Add("@maseca", (Convert.ToInt32(this.sacosMaseca.Text)+maseca) );
            command.Parameters.Add("@minsa", (Convert.ToInt32(this.kgMinsa.Text)+ minsa) );
            command.Parameters.Add("@date", fecha);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Exitosamente!", "Correcto");
                module.setAlmacenData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");
            }

            conexion.Close();

            this.Close();
        }
    }
}
