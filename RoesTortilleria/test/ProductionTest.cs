using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoesTortilleria.controllers;

namespace RoesTortilleria.test
{
    class ProductionTest
    {
        Production prod = new Production();

        public void assertUnitPreFinal(int maseca,int minsa,float extraMasa,float total)
        {
            float kgFinal = 0;
            
            prod.retrieveDailyData();
            prod.makeDailyProduction(maseca, minsa, extraMasa);
            kgFinal = prod.getFinalProd();
            Console.WriteLine("Produccion Pre Final del Dia: "+kgFinal);

            if (kgFinal == total)
                Console.WriteLine("Test Successful");
            else
                Console.WriteLine("Test Unsuccessful");
        }

        public void assertUnitFinal(float sobrante,float sabor,float masa,float total)
        {
            float kgFinal = 0;

            prod.finalizeProduction(sobrante, sabor, masa);
            kgFinal = prod.getFinalProd();
            Console.WriteLine("Produccion Final del Dia: " + kgFinal);

            if (kgFinal == total)
                Console.WriteLine("Test Successful");
            else
                Console.WriteLine("Test Unsuccessful");
        }
    }
}
