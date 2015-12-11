using System;
using System.Windows.Forms;

namespace RoesTortilleria
{
    public partial class AddVentaModule : Form
    {
        int toritllaNormal;
        int tortillaSabor;
        int kilostotal;
        String getCombo = "";
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
            if(kilosNormal.Text != null)
            {
                addVenta.Enabled = true;
            }
        }

        private void kilosSabor_TextChanged(object sender, EventArgs e)
        {
            if (kilosSabor.Text != null)
            {
                addVenta.Enabled = true;
            }
        }

        private void addVenta_Click(object sender, EventArgs e)
        {

            DateTime localDate = DateTime.Now;
            if (kilosNormal.Text == null)
            {
                toritllaNormal = 0 ;
            }
            else
            {
                toritllaNormal = Convert.ToInt32(kilosNormal.Text);
            }
            if(kilosSabor.Text == null)
            {
                tortillaSabor = 0;
            }
            else
            {
                tortillaSabor = Convert.ToInt32(kilosSabor.Text);
            }
            kilostotal = toritllaNormal + tortillaSabor;
            MessageBox.Show( localDate + "\n" + "Tortilla Normal: " + toritllaNormal + "\n"+"Tortilla de Sabor: "+tortillaSabor+ "\n" +"Kilos totales: " +kilostotal);
        }
    }
}
