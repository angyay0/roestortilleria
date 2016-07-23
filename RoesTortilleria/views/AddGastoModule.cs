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
    public partial class AddGastoModule : Form
    {
        private MainModule module;

        public AddGastoModule(MainModule module)
        {
            this.module = module;
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            saveGasto();
        }

        public void saveGasto()
        {
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            DateTime date = this.fechaGasto.Value;

            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(fecha);

            String query =
            "INSERT INTO Gastos (Concepto,Cantidad,Precio,Almacen,Fecha) " +
            " VALUES(@con,@cant,@prec,@alm,@date)";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.Add("@con", this.conceptoGasto.Text);
            command.Parameters.Add("@cant", Convert.ToInt32(this.cantidadGasto.Text));
            command.Parameters.Add("@prec", Convert.ToInt32(this.totalBox.Text));
            command.Parameters.Add("@alm", "No");
            command.Parameters.Add("@date", fecha);

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Exitosamente!", "Correcto");
                module.addRowToTable(module.getTableGastos(), new RowStyle(SizeType.Absolute, 40F),
                    new string[] { this.conceptoGasto.Text, this.cantidadGasto.Text, this.totalBox.Text,fecha });
                module.updateGastos((float) Convert.ToInt32(this.totalBox.Text));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");
            }

            conexion.Close();

            this.Close();
        }
    }
}
