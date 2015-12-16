using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoesTortilleria.controllers;

namespace RoesTortilleria.views
{
    public partial class AddProduccionModule : Form
    {
        public Production p;
        public MainModule module;

        public AddProduccionModule(MainModule module)
        {
            InitializeComponent();
            addBtn.Enabled = false;
            kgMinUsado.Enabled = false;
            masaExtra.Enabled = false;
            p = new Production();
            this.module = module;
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            p.makeDailyProduction((float)Convert.ToDouble(this.sacoUsado.Text),
                (float)Convert.ToDouble(this.kgMinUsado.Text),(float)Convert.ToDouble(this.masaExtra.Text));
            module.setProduccionData();
            this.Close();
        }
    }
}
