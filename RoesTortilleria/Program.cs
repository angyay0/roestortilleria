using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoesTortilleria.views;
using RoesTortilleria.test;

namespace RoesTortilleria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            //
            ProductionTest pt = new ProductionTest();
            //Produccion del 11 de Noviembre. Resultado 290kg
            //Datos del dia anterior. Prod 1100 kg Tortilla
            //Datos del dia anterior. 20 Kg Sobrante
            //
            //Resultado 290kg
            pt.assertUnitPreFinal(20,0,15,290);
            //
            //Resultado de la produccion final de tortilla del dia
            //Resultado 261.73
            pt.assertUnitFinal(11.1f, 8.9f, 8.27f, 261.73f);
                        */

            /*Prueba de Inventario
            InventoryTest it = new InventoryTest();
            it.assertUnitAdd(10, 10, 1000, 1000, new float[] { 10, 10, 1000, 1000 });
            it.assertUnitSubtract(1, 1, 100, 100, new float[] { -1, -1, -100, -100 });
            */

            Application.Run(new LoginModule());
        }
    }
}
