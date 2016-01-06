using System;
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
        static double totalGastos;
        static int cantidad;
        static int normal;
        static int sabor;
        static int total;
        static int count;
        static string nombre, contacto, telefono, direccion, id;
        static bool admin = false;


        public MainModule(string user,string type)
        {
            InitializeComponent();
            totalGastos = 0;
            
            this.username.Text = user;
            this.usertype.Text = "["+type+"]";
            
            if( type.Equals("Admin"))
            {
                admin = true;
               
            }
            else
            {
                this.tabControl.TabPages.Remove(this.tabCorte);
                this.tabControl.TabPages.Remove(this.tabFactNot);
                this.tabControl.TabPages.Remove(this.tabSysUser);
                this.btnCorte.Hide();
                this.tableGastos.Hide();
            }
            production = new Production();
            DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            SetValores(fecha, "Mostrador");
            SetValores(fecha, "800gr");
            SetValores(fecha, "900gr");
            SetValores(fecha, "especialOasis");
            SetClientes();
            setGastosData();
            setAlmacenData();
            setProduccionData();
        }

        #region EventosVistas
        private void addVenta_Click(object sender, EventArgs e)
        {
            AddVentaModule addventa = new AddVentaModule(this);
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
            AddClienteModule addcliente = new AddClienteModule(this);
            addcliente.ShowDialog();
        }
        #endregion Eventos Vistas

        #region setters
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
                        totalGastos += reader.GetInt32(3);
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

            this.montoTotal.Text = "$" + totalGastos;

        }

        public void updateGastos(float value)
        {
            totalGastos += value;
            this.montoTotal.Text = "$" + totalGastos;
        }

        public void SetClientes()
        {
            DataTable clientedt = Datos.BuscarClientes();
            for (int x = 0; x < clientedt.Rows.Count; x++)
            {
                DataRow row = clientedt.Rows[x];
                //guardo datos en variables
                nombre = Convert.ToString(row["Nombre"]);
                contacto = Convert.ToString(row["Contacto"]);
                telefono = Convert.ToString(row["Telefono"]);
                direccion = Convert.ToString(row["Direccion"]);
                id = Convert.ToString(row["idCliente"]);
                addRowToTableG(getTableClientes(), new RowStyle(SizeType.Absolute, 40F),
                    new string[] { nombre, contacto, telefono, direccion, id });
            }


        }

        public void SetValores(string fecha, string concepto)
        {
            cantidad = 0;
            normal = 0;
            sabor = 0;
            total = 0;

            if (concepto == "Mostrador")
            {
                DataTable dt = Datos.setVentas(fecha, concepto);
                if (dt.Rows.Count == 0)
                {
                    cantidadMostrador.Text = Convert.ToString(cantidad);
                    mostrador_Normal.Text = Convert.ToString(normal);
                    mostador_Sabor.Text = Convert.ToString(sabor);
                    monto_Mostrador.Text = Convert.ToString("$" + total + ".00");
                }
                else
                {
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        DataRow row = dt.Rows[x];
                        //guardo datos en variables
                        cantidad = cantidad + Convert.ToInt32(row["Cantidad"]);
                        normal = normal + Convert.ToInt32(row["Normal"]);
                        sabor = sabor + Convert.ToInt32(row["sabor"]);
                        total = total + Convert.ToInt32(row["Total"]);

                        cantidadMostrador.Text = Convert.ToString(cantidad);
                        mostrador_Normal.Text = Convert.ToString(normal);
                        mostador_Sabor.Text = Convert.ToString(sabor);
                        monto_Mostrador.Text = Convert.ToString("$" + total + ".00");
                    }
                }
            }
            else if (concepto == "800gr")
            {

                DataTable dt = Datos.setVentas(fecha, concepto);
                if (dt.Rows.Count == 0)
                {
                    cantidad_800.Text = Convert.ToString(cantidad);
                    normal_800.Text = Convert.ToString(normal);
                    sabor_800.Text = Convert.ToString(sabor);
                    monto_800.Text = Convert.ToString("$" + total + ".00");
                }
                else
                {
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        DataRow row = dt.Rows[x];
                        //guardo datos en variables
                        cantidad = cantidad + Convert.ToInt32(row["Cantidad"]);
                        normal = normal + Convert.ToInt32(row["Normal"]);
                        sabor = sabor + Convert.ToInt32(row["sabor"]);
                        total = total + Convert.ToInt32(row["Total"]);

                        cantidad_800.Text = Convert.ToString(cantidad);
                        normal_800.Text = Convert.ToString(normal);
                        sabor_800.Text = Convert.ToString(sabor);
                        monto_800.Text = Convert.ToString("$" + total + ".00");
                    }
                }
            }
            else if (concepto == "900gr")
            {

                DataTable dt = Datos.setVentas(fecha, concepto);
                if (dt.Rows.Count == 0)
                {
                    cantidad_900.Text = Convert.ToString(cantidad);
                    normal_900.Text = Convert.ToString(normal);
                    sabor_900.Text = Convert.ToString(sabor);
                    monto_900.Text = Convert.ToString("$" + total + ".00");
                }
                else
                {
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        DataRow row = dt.Rows[x];
                        //guardo datos en variables
                        cantidad = cantidad + Convert.ToInt32(row["Cantidad"]);
                        normal = normal + Convert.ToInt32(row["Normal"]);
                        sabor = sabor + Convert.ToInt32(row["sabor"]);
                        total = total + Convert.ToInt32(row["Total"]);

                        cantidad_900.Text = Convert.ToString(cantidad);
                        normal_900.Text = Convert.ToString(normal);
                        sabor_900.Text = Convert.ToString(sabor);
                        monto_900.Text = Convert.ToString("$" + total + ".00");
                    }
                }
            }
            else if (concepto == "especialOasis")
            {

                DataTable dt = Datos.setVentas(fecha, concepto);
                if (dt.Rows.Count == 0)
                {
                    especial_cantidad.Text = Convert.ToString(cantidad);
                    especial_Normal.Text = Convert.ToString(normal);
                    especial_Sabor.Text = Convert.ToString(sabor);
                    especial_monto.Text = Convert.ToString("$" + total + ".00");
                }
                else
                {
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        DataRow row = dt.Rows[x];
                        //guardo datos en variables
                        cantidad = cantidad + Convert.ToInt32(row["Cantidad"]);
                        normal = normal + Convert.ToInt32(row["Normal"]);
                        sabor = sabor + Convert.ToInt32(row["sabor"]);
                        total = total + Convert.ToInt32(row["Total"]);

                        especial_cantidad.Text = Convert.ToString(cantidad);
                        especial_Normal.Text = Convert.ToString(normal);
                        especial_Sabor.Text = Convert.ToString(sabor);
                        especial_monto.Text = Convert.ToString("$" + total + ".00");
                    }
                }
            }


        }
#endregion setters

        public TableLayoutPanel getTableGastos()
        {
            return this.tableGastos;
        }

        public TableLayoutPanel getTableClientes()
        {
            return this.tableCliente;
        }

        public void addRowToTable(TableLayoutPanel panel, RowStyle row,string[] p) {
            panel.RowCount = panel.RowCount + 1;
            panel.RowStyles.Add(row);
            for(int i = 0; i < p.Length; i++)
            {
                panel.Controls.Add(new Label() { Text = Convert.ToString(p[i]) }, i, panel.RowCount - 1);
            }
            
        }

        public void addRowToTableG(TableLayoutPanel panel, RowStyle row, string[] p)
        {
            panel.RowCount = panel.RowCount + 1;
            panel.RowStyles.Add(row);

            for (int i = 0; i < p.Length; i++)
            {
                if (i == 4)
                {
                    setButtons(panel, i);
                }
                else
                {

                    panel.Controls.Add(new Label() { Text = Convert.ToString(p[i]), Size = new System.Drawing.Size(220, 13) }, i, panel.RowCount - 1);
                }
            }

        }

        public void setButtons(TableLayoutPanel panel, int i)
        {
            //MessageBox.Show(Convert.ToString(tableCliente.RowCount-1));
            Button btn = new button(tableCliente.RowCount - 1);
            btn.Text = "Eliminar";
            btn.Name = id;
            btn.Click += new EventHandler(this.btnDelet);
            panel.Controls.Add(btn, i, panel.RowCount - 1);


        }

        private void btnDelet(object sender, EventArgs e)
        {
            button btn = sender as button;
            int delete = Convert.ToInt32(btn.Name);
            int id = btn.getId();
            //MessageBox.Show(Convert.ToString(id));
            DialogResult result = MessageBox.Show("Seguro que deseas eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:
                    Datos.deleteCliente(delete);
                    remove_row(tableCliente, id);
                    //setButtons(tableCliente,4);

                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void remove_row(TableLayoutPanel panel, int row_index_to_remove)
        {
            if (row_index_to_remove >= panel.RowCount)
            {
                MessageBox.Show("No puedo borrar por que la tabla es de tamaño " + panel.RowCount + " y tu quieres borrar el" + row_index_to_remove);
                return;
            }

            // delete all controls of row that we want to delete
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                var control = panel.GetControlFromPosition(i, row_index_to_remove);
                panel.Controls.Remove(control);

            }

            // move up row controls that comes after row we want to remove
            for (int i = row_index_to_remove + 1; i < panel.RowCount; i++)
            {
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    var control = panel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        panel.SetRow(control, i - 1);
                        if (j == 4)
                        {
                            button controlbtn = control as button;
                            //Aqui se modifica el boton
                            if (controlbtn != null)
                            {
                                if (controlbtn.getId() > 0)
                                {
                                    controlbtn.setId(controlbtn.getId() - 1);
                                }
                            }

                        }
                    }
                }
            }
            // remove last row
            panel.RowStyles.RemoveAt(panel.RowCount - 1);
            panel.RowCount--;
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            VentaDelDia vdia = new VentaDelDia(DateTime.Now);
            vdia.ShowDialog();
        }

        private void datePickerProd_ValueChanged(object sender, EventArgs e)
        {
            setProduccionData(this.datePickerProd.Value);
        }

        private void datePickerVenta_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSelect = datePickerVenta.Value;
            string fecha = fechaSelect.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            SetValores(fecha, "Mostrador");
            SetValores(fecha, "800gr");
            SetValores(fecha, "900gr");
            SetValores(fecha, "especialOasis");
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
