﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoesTortilleria.controllers
{
    public class Production
    {
        public float kgProduction = 0;
        public float kgFinalProd = 0;
        public float kgProdYes = 0;
        public float kgSobraYes = 0;
        public float sMas = 0;
        public float sMin = 0;
        public float sKg = 0;
        public float kgHarinas = 0;
        public float kgTortilla = 0;
        public float sobraMasa = 0;
        public float sobraTortilla = 0;
        public float sobraSabor = 0;
        public float defaultValue = 0;
        public bool hasData = false;
        public int idProdDay = 0;

        public DateTime dateToLook;

        public Production()
        {

        }

        public Production(DateTime date)
        {
            dateToLook = date;
        }

        public void retrieveGivenData(DateTime date)
        {
            //Crear conexion y solicitar los datos del dia
            //si hay es porque es la segunda vez que se abre el programa y ya existe
            //un registro, que mantendra los datos hasta que se finalize y se reste
            //la produccion al final, se realiza una nueva insercion de los datos y presto

            SqlConnection conexion = Conexion.getConexion();
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            conexion.Open();
            string query = "SELECT * FROM Produccion WHERE Fecha like '" + fecha + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                try
                {
                    idProdDay = (int)reader.GetInt32(0);
                    sMas = (float)(double)reader.GetDouble(1);
                    sMin = (float)(double)reader.GetDouble(2);
                    sKg = (float)(double)reader.GetDouble(3);
                    kgHarinas = (float)(double)reader.GetDouble(4);
                    kgTortilla = (float)(double)reader.GetDouble(5);
                    sobraMasa = (float)(double)reader.GetDouble(6);
                    sobraTortilla = (float)(double)reader.GetDouble(7);
                    sobraSabor = (float)(double)reader.GetDouble(8);
                    kgFinalProd = (float)(double)reader.GetDouble(9);


                    hasData = true;

                }
                catch (Exception e)
                {
                }
            }
            else
            {
                hasData = false;
            }
            conexion.Close();
        }

        public void retrieveDailyData()
        {
            //Crear conexion y solicitar los datos del dia
            //si hay es porque es la segunda vez que se abre el programa y ya existe
            //un registro, que mantendra los datos hasta que se finalize y se reste
            //la produccion al final, se realiza una nueva insercion de los datos y presto

            SqlConnection conexion = Conexion.getConexion();
            DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            conexion.Open();
            string query = "SELECT * FROM Produccion WHERE Fecha like '" + fecha + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                try
                {
                    idProdDay = (int)reader.GetInt32(0);
                    sMas = (float)(double)reader.GetDouble(1);
                    sMin = (float)(double)reader.GetDouble(2);
                    sKg = (float)(double)reader.GetDouble(3);
                    kgHarinas = (float)(double)reader.GetDouble(4);
                    kgTortilla = (float)(double)reader.GetDouble(5);
                    sobraMasa = (float)(double)reader.GetDouble(6);
                    sobraTortilla = (float)(double)reader.GetDouble(7);
                    sobraSabor = (float)(double)reader.GetDouble(8);
                    kgFinalProd = (float)(double)reader.GetDouble(9);

                    hasData = true;
                }
                catch (Exception e)
                {
                }
            }
            else
            {
                hasData = false;
            }
            conexion.Close();
        }
        
        public void retrieveDayBefore()
        {
            //Crear conexion y solicitar los datos del dia
            //si hay es porque es la segunda vez que se abre el programa y ya existe
            //un registro, que mantendra los datos hasta que se finalize y se reste
            //la produccion al final, se realiza una nueva insercion de los datos y presto

            SqlConnection conexion = Conexion.getConexion();
            DateTime date = DateTime.Now.AddDays(-1);
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            conexion.Open();
            string query = "SELECT * FROM Produccion WHERE Fecha like '" + fecha + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                try
                {
                    kgProdYes = (float)(double)reader.GetDouble(5);
                    kgSobraYes = (float)(double)reader.GetDouble(7);
                }
                catch (Exception e)
                {
                }
            }
            else
            {
                kgProdYes = 0;
                kgSobraYes = 0;
            }
            conexion.Close();
        }

        public void saveProduction()
        {
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            String query = 
            "INSERT INTO Produccion (sacoMaseca,kgMinsa,kgMExtra,kgMasa,kgTortilla,sMasa,sTortilla,tSabor,fTortilla,fecha) "+
            " VALUES(@saco,@kgmin,@kgme,@kgm,@kgtor,@sM,@smin,@tsa,@ft,@fec)";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.Add("@saco", sMas);
            command.Parameters.Add("@kgmin", sMin);
            command.Parameters.Add("@kgme", sKg);
            command.Parameters.Add("@kgm", kgHarinas);
            command.Parameters.Add("@kgtor", kgTortilla);
            command.Parameters.Add("@sM", defaultValue);
            command.Parameters.Add("@smin", defaultValue);
            command.Parameters.Add("@tsa", defaultValue);
            command.Parameters.Add("@ft", kgFinalProd);
            command.Parameters.Add("@fec", fecha);
            
            try
            {
               idProdDay= command.ExecuteNonQuery();
                MessageBox.Show(
                "Se ha agregado la Produccion!\nFinalizar la Producción al cuando se tengan los datos de la ventana finalizar!", "Correcto");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");
            }

            conexion.Close();
        }

        public void saveFinalizedProduction()
        {
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            DateTime date = DateTime.Now;
            string fecha = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            String query =
            "UPDATE Produccion SET sMasa = @a,sTortilla = @b,tSabor = @c, fTortilla = @ft"+
            " Where idProduccion = @id";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.Add("@a", sobraMasa);
            command.Parameters.Add("@b", sobraTortilla);
            command.Parameters.Add("@c", sobraSabor);
            command.Parameters.Add("@ft", kgFinalProd);
            command.Parameters.Add("@id", idProdDay);
            //command.Parameters.Add("@fecha", fecha);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Proceso de Producción Finalizado!", "Correcto");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");
            }

            conexion.Close();
        }
        
        public void makeDailyProduction(float sacoMaseca, float sacoMinsa, float kgMasaExtra)
        {
            retrieveDailyData();
            retrieveDayBefore();

            sMas = sacoMaseca;
            sMin = sacoMinsa;
            sKg = kgMasaExtra;

            float pesoMaseca = 20;
            float pesoMinsa = 1;

            float kgProdAyer = retrieveProdDayBefore();
            float kgSobraAyer = retrieveKgSobraDayBefore();

            //Se calcula el peso total en masa, y se convierte en el doble
            //cuando se produce la tortilla
            kgProduction = (sacoMaseca * pesoMaseca) + (sacoMinsa * pesoMinsa) + kgMasaExtra;
            kgHarinas = kgProduction;
            kgProduction *= 2;
            kgTortilla = kgProduction;

            //Ajuste de la produccion basado en la tabla de excel
            //Que toma los kilos producidos del dia anterior y los resta a los actuales
            // In-1 - In
            if( kgProdAyer != 0 )
                kgProduction = kgProdAyer - kgProduction;

            //Ajuste de la produccion basado en la tabla de excel
            //Agrega a la resta los kilos que sobraron ayer
            //In + Ln-1
            kgProduction = kgProduction + kgSobraAyer;

            //Guardado temporal para ajustes al final del dia
            kgFinalProd = kgProduction;

            saveProduction();
        }

        #region Produccion Diaria
        public float retrieveProdDayBefore()
        {
            return kgProdYes;
        }

        public float retrieveKgSobraDayBefore()
        {
            return kgSobraYes;
        }

        public bool subtractSacoMaseca(int sacos)
        {

            return true;
        }

        public bool subtractSacoMinsa(int sacos)
        {
            return true;
        }

        public bool subtractAgua(float litros)
        {
            return true;
        }

        public bool subtractGas(float kg)
        {
            return true;
        }

        //Resta la tortilla que sobro de la produccion
        public void subtractTortilla( float kgSobra)
        {
            kgFinalProd -= kgSobra;
        }

        //resta la cantidad de masa o tortilla que queda en la maquina
        public void subtractMasa(float kgMasa)
        {
            kgFinalProd -= kgMasa;
        }

        public float getFinalProd()
        {
            return kgFinalProd;
        }

        #endregion

        public void finalizeProduction(float sobrante,float sabor,float masa)
        {
            Console.WriteLine(sobrante + "-" + sabor + "-" + masa);

            sobraMasa = masa;
            sobraTortilla = sobrante;
            sobraSabor = sabor;

            subtractTortilla(sobrante);
            subtractTortilla(sabor);
            subtractMasa(masa);

            saveFinalizedProduction();
        }
        
    }
}
