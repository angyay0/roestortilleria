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
    public partial class finalizeProd : Form
    {
        private Production p;
        private MainModule module;

        public finalizeProd(MainModule module)
        {
            InitializeComponent();
            this.p = new Production();
            p.retrieveDailyData();
            this.module = module;
        }

        private void finalBtn_Click(object sender, EventArgs e)
        {
            p.finalizeProduction((float)Convert.ToDouble(this.kgTortilla.Text), 
                (float)Convert.ToDouble(this.kgSabor.Text), (float)Convert.ToDouble(this.kgMasa.Text));
            module.setProduccionData();
            this.Close();
        }
    }
}
