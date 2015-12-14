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
            addBtn.Enabled = false;
            kgMinUsado.Enabled = false;
            masaExtra.Enabled = false;
        }

        private void harinaUsada_TextChanged(object sender, EventArgs e)
        {
            if(sacoUsado.Text != null )
            {
                kgMinUsado.Enabled = true;
            }
        }

        private void harinaMinUsada_TextChanged(object sender, EventArgs e)
        {
            if (kgMinUsado.Text != null )
            {
                masaExtra.Enabled = true;
            }
            
        }

        private void masaExtra_TextChanged(object sender, EventArgs e)
        {
            if ( masaExtra.Text != null)
            {
                addBtn.Enabled = true;
            }
        }
    }
}
