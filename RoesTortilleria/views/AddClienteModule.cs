﻿using System;
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
    public partial class AddClienteModule : Form
    {
        private MainModule mainModule;

        public AddClienteModule(MainModule mainModule)
        {
            this.mainModule = mainModule;
            InitializeComponent();
        }

        private void addcliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text) ||
                string.IsNullOrEmpty(Contacto.Text) ||
                string.IsNullOrEmpty(Direccion.Text) ||
                string.IsNullOrEmpty(Telefono.Text))
            {
                MessageBox.Show("Ingrese bien los datos");
            }
            else
            {
                Datos.addCliente(Nombre.Text, Contacto.Text, Direccion.Text, Telefono.Text);
                MessageBox.Show(Nombre.Text + " agregado correctamente");
                mainModule.addRowToTableG(mainModule.getTableClientes(), new RowStyle(SizeType.Absolute, 50F),
                    new string[] { this.Nombre.Text, this.Contacto.Text, this.Telefono.Text, this.Direccion.Text, "Eliminar" });

                this.Close();
            }

            
        }
    }
}
