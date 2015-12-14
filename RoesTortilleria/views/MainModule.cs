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
    public partial class MainModule : Form
    {
        public MainModule()
        {
            InitializeComponent();
        }

        private void addVenta_Click(object sender, EventArgs e)
        {
            AddVentaModule addventa = new AddVentaModule();
            addventa.ShowDialog();

        }

        private void addProduccion_Click(object sender, EventArgs e)
        {
            AddProduccionModule addprod = new AddProduccionModule();
            addprod.ShowDialog();
        }

        private void addInventario_Click(object sender, EventArgs e)
        {
            AddInventarioModule addinv = new AddInventarioModule();
            addinv.ShowDialog();
        }

        private void addGasto_Click(object sender, EventArgs e)
        {
            AddGastoModule addgas = new AddGastoModule();
            addgas.ShowDialog();
        }

        private void addCliente_Click(object sender, EventArgs e)
        {
            AddClienteModule addcliente = new AddClienteModule();
            addcliente.ShowDialog();
        }

    }
}
