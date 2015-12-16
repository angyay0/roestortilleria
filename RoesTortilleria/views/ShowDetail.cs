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
    public partial class ShowDetail : Form
    {
        public DateTime date;
        public Production production;

        public ShowDetail(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            production = new Production();
            production.retrieveGivenData(date);

            this.sMaseca.Text = ""+production.sMas;
            this.kgMinsa.Text = "" + production.sMin;
            this.kgMasaExtra.Text = "" + production.sKg;
            this.kgHarina.Text = "" + production.kgHarinas;
            this.kgTortilla.Text = "" + production.kgTortilla;
            this.kgPFT.Text = "" + (production.kgFinalProd+production.sobraMasa+production.sobraSabor+production.sobraTortilla);
            this.kgPMasa.Text = "" + production.sobraMasa;
            this.kgTSabor.Text = "" + production.sobraSabor;
            this.kgSTortilla.Text = "" + production.sobraTortilla;
            this.kgTortillaFinal.Text = "" + production.kgFinalProd;
        }

      
    }
}
