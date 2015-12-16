﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoesTortilleria.controllers;

namespace RoesTortilleria.views
{
    public partial class MainModule : Form
    {
        private Production production;
               
        public MainModule()
        {
            InitializeComponent();

            production = new Production();

            setGastosData();
            setAlmacenData();
            setProduccionData();
        }

        private void addVenta_Click(object sender, EventArgs e)
        {
            AddVentaModule addventa = new AddVentaModule();
            addventa.ShowDialog();

        }

        private void addProduccion_Click(object sender, EventArgs e)
        {
            AddProduccionModule addprod = new AddProduccionModule(this);
            addprod.ShowDialog();
        }

        private void addInventario_Click(object sender, EventArgs e)
        {
            AddInventarioModule addinv = new AddInventarioModule(Convert.ToInt32(this.lSacosInv.Text), Convert.ToInt32(this.lKGMInv.Text),this);
            addinv.ShowDialog();
        }

        private void addGasto_Click(object sender, EventArgs e)
        {
            AddGastoModule addgas = new AddGastoModule(this);
            addgas.ShowDialog();
        }

        private void addCliente_Click(object sender, EventArgs e)
        {
            AddClienteModule addcliente = new AddClienteModule();
            addcliente.ShowDialog();
        }
        
        public void setAlmacenData()
        {
            SqlConnection conexion = Conexion.getConexion();
            DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            conexion.Open();
            string query = "SELECT * FROM Almacen";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                try
                {
                    this.lSacosInv.Text = "" + (float)(double)reader.GetDouble(2);// + " Sacos";
                    this.lKGMInv.Text = "" + (float)(double)reader.GetDouble(3);// + " KG";
                }
                catch (Exception e)
                {
                }
            }
            conexion.Close();


        }

        public void setProduccionData()
        {
            SqlConnection conexion = Conexion.getConexion();
            DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            //   Console.WriteLine(fecha);
            conexion.Open();
            string query = "SELECT * FROM Produccion WHERE fecha like '" + fecha + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                try
                {
                    this.lSacoMaseca.Text = "" + (float)(double)reader.GetDouble(1) + " Sacos";
                    this.lKiloMinsa.Text = "" + (float)(double)reader.GetDouble(2) + " Kg";
                    this.lKiloMas.Text = "" + (float)(double)reader.GetDouble(3) + " Kg";
                    this.lKGHarina.Text = "" + (float)(double)reader.GetDouble(4) + " Kg";
                    this.lTortilla.Text = "" + (float)(double)reader.GetDouble(5) + " Kg";
                    this.lKGSobra.Text = "" + (float)(double)reader.GetDouble(7) + " Kg";
                    this.lFTortilla.Text = "" + (float)(double)reader.GetDouble(9) + " Kg";

                    this.finalizarBtn.Enabled = true;

                    if ((float)(double)reader.GetDouble(6) != 0)
                    {
                        this.finalizarBtn.Enabled = false;
                    }

                    this.detalleBtn.Enabled = true;

                }
                catch (Exception e)
                {
                }
            }
            else
            {
                this.detalleBtn.Enabled = false;
                this.finalizarBtn.Enabled = false;
                this.lSacoMaseca.Text = "No Hay Registro";
                this.lKiloMinsa.Text = "No Hay Registro";
                this.lKiloMas.Text = "No Hay Registro";
                this.lKGHarina.Text = "No Hay Registro";
                this.lTortilla.Text = "No Hay Registro";
                this.lKGSobra.Text = "No Hay Registro";
                this.lFTortilla.Text = "No Hay Registro";

            }
            conexion.Close();/*
            production.retrieveDailyData();
            if( production.hasData)
            {
                this.lSacoMaseca.Text = "" + production.sMas + " Sacos";
                this.lKiloMinsa.Text = "" + production.sMin + " Kg";
                this.lKiloMas.Text = "" + production.sKg + " Kg";
                this.lKGHarina.Text = "" + production.kgHarinas + " Kg";
                this.lTortilla.Text = "" + production.kgTortilla + " Kg";
                this.lKGSobra.Text = "" + production.sobraTortilla + " Kg";
                this.lFTortilla.Text = "" + production.kgFinalProd + " Kg";
                this.finalizarBtn.Enabled = true;

                if (production.sobraTortilla != 0)
                {
                    this.finalizarBtn.Enabled = false;
                }

                this.detalleBtn.Enabled = true;
            }
            else
            {
                this.detalleBtn.Enabled = false;
                this.finalizarBtn.Enabled = false;
                this.lSacoMaseca.Text = "No Hay Registro";
                this.lKiloMinsa.Text = "No Hay Registro";
                this.lKiloMas.Text = "No Hay Registro";
                this.lKGHarina.Text = "No Hay Registro";
                this.lTortilla.Text = "No Hay Registro";
                this.lKGSobra.Text = "No Hay Registro";
                this.lFTortilla.Text = "No Hay Registro";
            }
            */

        }

        public void setProduccionData(DateTime date)
        {
            SqlConnection conexion = Conexion.getConexion();
           // DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            //   Console.WriteLine(fecha);
            conexion.Open();
            string query = "SELECT * FROM Produccion WHERE fecha like '" + fecha + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                try
                {
                    this.lSacoMaseca.Text = "" + (float)(double)reader.GetDouble(1) + " Sacos";
                    this.lKiloMinsa.Text = "" + (float)(double)reader.GetDouble(2) + " Kg";
                    this.lKiloMas.Text = "" + (float)(double)reader.GetDouble(3) + " Kg";
                    this.lKGHarina.Text = "" + (float)(double)reader.GetDouble(4) + " Kg";
                    this.lTortilla.Text = "" + (float)(double)reader.GetDouble(5) + " Kg";
                    this.lKGSobra.Text = "" + (float)(double)reader.GetDouble(7) + " Kg";
                    this.lFTortilla.Text = "" + (float)(double)reader.GetDouble(9) + " Kg";

                    this.finalizarBtn.Enabled = true;

                    if ((float)(double)reader.GetDouble(6) != 0)
                    {
                        this.finalizarBtn.Enabled = false;
                    }

                    this.detalleBtn.Enabled = true;

                }
                catch (Exception e)
                {
                }
            }
            else
            {
                this.detalleBtn.Enabled = false;
                this.finalizarBtn.Enabled = false;
                this.lSacoMaseca.Text = "No Hay Registro";
                this.lKiloMinsa.Text = "No Hay Registro";
                this.lKiloMas.Text = "No Hay Registro";
                this.lKGHarina.Text = "No Hay Registro";
                this.lTortilla.Text = "No Hay Registro";
                this.lKGSobra.Text = "No Hay Registro";
                this.lFTortilla.Text = "No Hay Registro";
            }
            conexion.Close();/*
            production.retrieveGivenData(date);
            if (production.hasData)
            {
                this.lSacoMaseca.Text = "" + production.sMas + " Sacos";
                this.lKiloMinsa.Text = "" + production.sMin + " Kg";
                this.lKiloMas.Text = "" + production.sKg + " Kg";
                this.lKGHarina.Text = "" + production.kgHarinas + " Kg";
                this.lTortilla.Text = "" + production.kgTortilla + " Kg";
                this.lKGSobra.Text = "" + production.sobraTortilla + " Kg";
                this.lFTortilla.Text = "" + production.kgFinalProd + " Kg";
                this.finalizarBtn.Enabled = true;

                if (production.sobraTortilla != 0)
                {
                    this.finalizarBtn.Enabled = false;
                }

                this.detalleBtn.Enabled = true;
            }
            else
            {
                this.detalleBtn.Enabled = false;
                this.finalizarBtn.Enabled = false;
                this.lSacoMaseca.Text = "No Hay Registro";
                this.lKiloMinsa.Text = "No Hay Registro";
                this.lKiloMas.Text = "No Hay Registro";
                this.lKGHarina.Text = "No Hay Registro";
                this.lTortilla.Text = "No Hay Registro";
                this.lKGSobra.Text = "No Hay Registro";
                this.lFTortilla.Text = "No Hay Registro";
            }
            */

        }

        public void setGastosData()
        {

            SqlConnection conexion = Conexion.getConexion();
            DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM", CultureInfo.InvariantCulture);

            Console.WriteLine(fecha);
            conexion.Open();
            string query = "SELECT * FROM Gastos WHERE fecha like '" + fecha + "%'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();


            this.tableGastos.RowCount = 1;


            while (reader.Read())
            {
                try
                {
                    // For Add New Row (Loop this code for add multiple rows)
                    if (reader.GetString(4) != "Si")
                    {
                        this.tableGastos.RowCount = this.tableGastos.RowCount + 1;
                        this.tableGastos.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                        this.tableGastos.Controls.Add(new Label() { Text = reader.GetString(1) }, 0, this.tableGastos.RowCount - 1);
                        this.tableGastos.Controls.Add(new Label() { Text = Convert.ToString(reader.GetInt32(2)) }, 1, this.tableGastos.RowCount - 1);
                        this.tableGastos.Controls.Add(new Label() { Text = Convert.ToString(reader.GetInt32(3)) }, 2, this.tableGastos.RowCount - 1);
                        this.tableGastos.Controls.Add(new Label() { Text = reader.GetDateTime(5).ToString() }, 3, this.tableGastos.RowCount - 1);
                    }
                }
                catch (Exception e)
                {
                }
            }

            conexion.Close();

        }

        public TableLayoutPanel getTableGastos()
        {
            return this.tableGastos;
        }

        public void addRowToTable(TableLayoutPanel panel, RowStyle row,string[] p) {
            panel.RowCount = panel.RowCount + 1;
            panel.RowStyles.Add(row);
            for(int i = 0; i < p.Length; i++)
            {
                panel.Controls.Add(new Label() { Text = Convert.ToString(p[i]) }, i, panel.RowCount - 1);
            }
            
        }

        private void datePickerProd_ValueChanged(object sender, EventArgs e)
        {
            setProduccionData(this.datePickerProd.Value);
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            finalizeProd finalize = new finalizeProd(this);
            finalize.ShowDialog();
        }

        private void detalleBtn_Click(object sender, EventArgs e)
        {
            ShowDetail details = new ShowDetail(this.datePickerProd.Value);
            details.ShowDialog();
        }

    }
}
