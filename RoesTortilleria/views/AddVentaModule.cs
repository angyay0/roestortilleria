using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace RoesTortilleria
{
    public partial class AddVentaModule : Form
    {
        int toritllaNormal;
        int tortillaSabor;
        int totalTortilla;
        int normal;
        int sabor;
        int totalTnormal;
        int totalTsabor;
        int kilostotal;
        int idCuota;
        int idCliente;
        String getCombo = "";
        String concepto = "";
        public AddVentaModule()
        {
            InitializeComponent();
            conceptoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            clientesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            cuotaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            kilosNormal.Enabled = false;
            kilosSabor.Enabled = false;
            Total.Enabled = false;
            precioNormal.Enabled = false;
            precioSabor.Enabled = false;
            addVenta.Enabled = false;
        }

        private void conceptoCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            Object selectedItem = conceptoCombo.SelectedItem;
            
            getCombo = selectedItem.ToString();

            /*if(getCombo == "Cliente")
            {
                clientesCombo.Enabled = true;
                cuotaCombo.Enabled = true;
                kilosNormal.Enabled = true;
                kilosSabor.Enabled = true;
            }*/
            if(getCombo == "Mostrador")
            {
                DataTable dt = Datos.BuscarConcepto(getCombo);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    //guardo datos en variables
                    normal = Convert.ToInt32(row["Normal"]);
                    sabor = Convert.ToInt32(row["sabor"]);
                    concepto = Convert.ToString(row["Tipo"]);
                    idCuota = Convert.ToInt32(row["idCuota"]);
                    idCliente = 0;
                }
                clientesCombo.Enabled = false;
                cuotaCombo.Enabled = false;
                kilosNormal.Enabled = true;
                kilosSabor.Enabled = true;
            }
        }

        private void cuotaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = cuotaCombo.SelectedItem;
            if (getCombo == "Especial")
            {
                precioSabor.Enabled = true;
                precioNormal.Enabled = true;
            }
        }

        private void kilosNormal_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(kilosNormal.Text))
            {
                addVenta.Enabled = false;
            }
            else
            {
                toritllaNormal = Convert.ToInt32(kilosNormal.Text);
                totalTnormal = Datos.multiplica(toritllaNormal, normal);
                precioNormal.Text= "$ " + totalTnormal + ".00";
            }
        }

        private void kilosSabor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kilosSabor.Text))
            {
                addVenta.Enabled = false;

            }
            else
            {
                tortillaSabor = Convert.ToInt32(kilosSabor.Text);
                totalTsabor = Datos.multiplica(tortillaSabor, sabor);
                precioSabor.Text = "$ " + totalTsabor + ".00";
                kilostotal = totalTnormal + totalTsabor;
                totalTortilla = toritllaNormal + tortillaSabor;
                Total.Text = "$ " + kilostotal + ".00";
                addVenta.Enabled = true;
            }
        }

        private void addVenta_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            if (Datos.addVenta(idCliente,idCuota,concepto,totalTortilla,tortillaSabor,toritllaNormal, kilostotal, localDate))
            {
                MessageBox.Show(localDate + "\n" + "Tortilla Normal: $" + totalTnormal + ".00" + "\n" + "Tortilla de Sabor: $" + totalTsabor + ".00" + "\n" + "Total: $" + kilostotal + ".00");
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
            
        }
    }
}
