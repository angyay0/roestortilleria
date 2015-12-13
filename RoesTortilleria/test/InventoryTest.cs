using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoesTortilleria.controllers;

namespace RoesTortilleria.test
{
    class InventoryTest
    {
        Inventory inv = new Inventory();

        public void assertUnitSubtract(int maseca,float minsa,float agua,float gas,float[] res)
        {
            inv.retrieveData();

            inv.subtractMaseca(maseca);
            inv.subtractKgMinsa(minsa);
            inv.subtractLtAgua(agua);
            inv.subtractGas(gas);
            
            for(int i = 0; i < res.Length; i++)
            {
                if (inv.getByIndex(i) == res[i])
                    Console.WriteLine("Test Successful");
                else
                    Console.WriteLine("Test Unsuccessful");
            }

           
        }

        public void assertUnitAdd(int maseca,float minsa,float agua,float gas,float[] res)
        {
            inv.retrieveData();

            inv.addSacoMaseca(maseca);
            inv.addKgMinsa(minsa);
            inv.addLtAgua(agua);
            inv.addGas(gas);

            for (int i = 0; i < res.Length; i++)
            {
                if (inv.getByIndex(i) == res[i])
                    Console.WriteLine("Test Successful");
                else
                    Console.WriteLine("Test Unsuccessful");
            }

        }

    }
}
