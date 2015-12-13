using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoesTortilleria.controllers
{
    class Production
    {
        private float kgProduction = 0;
        private float kgFinalProd = 0;

        public void retrieveDailyData()
        {
            //Crear conexion y solicitar los datos del dia
            //si hay es porque es la segunda vez que se abre el programa y ya existe
            //un registro, que mantendra los datos hasta que se finalize y se reste
            //la produccion al final, se realiza una nueva insercion de los datos y presto

            kgFinalProd = 0;
            kgProduction = 0;
        }

        public void saveProduction()
        {

        }

        public void saveFinalizedProduction()
        {

        }

        #region Produccion Diaria
        public void makeDailyProduction(int sacoMaseca, int sacoMinsa, float kgMasaExtra)
        {
            float pesoMaseca = 20;
            float pesoMinsa = 1;

            float kgProdAyer = retrieveProdDayBefore();
            float kgSobraAyer = retrieveKgSobraDayBefore();

            //Se calcula el peso total en masa, y se convierte en el doble
            //cuando se produce la tortilla
            kgProduction = (sacoMaseca * pesoMaseca) + (sacoMinsa * pesoMinsa) + kgMasaExtra;
            kgProduction *= 2;

            //Ajuste de la produccion basado en la tabla de excel
            //Que toma los kilos producidos del dia anterior y los resta a los actuales
            // In-1 - In
            kgProduction = kgProdAyer - kgProduction;

            //Ajuste de la produccion basado en la tabla de excel
            //Agrega a la resta los kilos que sobraron ayer
            //In + Ln-1
            kgProduction = kgProduction + kgSobraAyer;

            //Guardado temporal para ajustes al final del dia
            kgFinalProd = kgProduction;
        }

        private float retrieveProdDayBefore()
        {
            return 1100;
        }

        private float retrieveKgSobraDayBefore()
        {
            return 20;
        }

        private bool subtractSacoMaseca(int sacos)
        {

            return true;
        }

        private bool subtractSacoMinsa(int sacos)
        {
            return true;
        }

        private bool subtractAgua(float litros)
        {
            return true;
        }

        private bool subtractGas(float kg)
        {
            return true;
        }

        //Resta la tortilla que sobro de la produccion
        private void subtractTortilla( float kgSobra)
        {
            kgFinalProd -= kgSobra;
        }

        //resta la cantidad de masa o tortilla que queda en la maquina
        private void subtractMasa(float kgMasa)
        {
            kgFinalProd -= kgMasa;
        }

        public float getFinalProd()
        {
            return kgFinalProd;
        }

        public void finalizeProduction(float sobrante,float sabor,float masa)
        {
            subtractTortilla(sobrante);
            subtractTortilla(sabor);
            subtractMasa(masa);
        }

        #endregion
    }
}
