using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoesTortilleria.views
{
    public partial class AddProduccionModule : Form
    {
        public AddProduccionModule()
        {
            InitializeComponent();
            addProduccion.Enabled = false;
            harinaMinUsada.Enabled = false;
            masaExtra.Enabled = false;
        }

        private void harinaUsada_TextChanged(object sender, EventArgs e)
        {
            if(harinaUsada.Text != null )
            {
                harinaMinUsada.Enabled = true;
            }
        }

        private void harinaMinUsada_TextChanged(object sender, EventArgs e)
        {
            if (harinaMinUsada.Text != null )
            {
                masaExtra.Enabled = true;
            }
            
        }

        private void masaExtra_TextChanged(object sender, EventArgs e)
        {
            if ( masaExtra.Text != null)
            {
                addProduccion.Enabled = true;
            }
        }
    }
}
