using System;
using System.Windows.Forms;

namespace RoesTortilleria
{
    public partial class AddVentaModule : Form
    { 
        public AddVentaModule()
        {
            InitializeComponent();
            conceptoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            clientesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            cuotaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            kilosNormal.Enabled = false;
            kilosSabor.Enabled = false;
        }

        private void conceptoCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            String getCombo = "";
            Object selectedItem = conceptoCombo.SelectedItem;
            getCombo = selectedItem.ToString();

            if(getCombo == "Cliente")
            {
                clientesCombo.Enabled = true;
                cuotaCombo.Enabled = true;
                kilosNormal.Enabled = true;
                kilosSabor.Enabled = true;
            }
            else if(getCombo == "Mostrador")
            {
                clientesCombo.Enabled = false;
                cuotaCombo.Enabled = false;
                kilosNormal.Enabled = true;
                kilosSabor.Enabled = true;
            }
        }
    }
}
