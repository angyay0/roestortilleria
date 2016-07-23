using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoesTortilleria.controllers
{
    class Inventory
    {
        private int maseca;
        private float minsa;
        private float gas;
        private float agua;

        public void retrieveData()
        {
            //Conexion a la base de datos para obtener los registros

            maseca = 0;
            minsa = 0;
            gas = 0;
            agua = 0;
        }

        public void saveUpdate()
        {

        }

        public void addSacoMaseca(int sacos)
        {
            maseca += sacos;
        }

        public void addKgMinsa(float kg)
        {
            minsa += kg;
        }

        public void addLtAgua(float lt)
        {
            agua += lt;
        }

        public void addGas(float gas)
        {
            this.gas += gas;
        }

        public void subtractMaseca(int sacos)
        {
            maseca -= sacos;
        }

        public void subtractKgMinsa(float kg)
        {
            minsa -= kg;
        }

        public void subtractLtAgua(float lt)
        {
            agua -= lt;
        }

        public void subtractGas(float gas)
        {
            this.gas -= gas;
        }

        public int getMaseca()
        {
            return maseca;
        }

        public float getMinsa()
        {
            return minsa;
        }

        public float getAgua()
        {
            return agua;
        }

        public float getGas()
        {
            return gas;
        }

        public float getByIndex(int index)
        {
            switch (index)
            {
                case 0:
                    return (float)getMaseca();
                 //   break;
                case 1:
                    return getMinsa();
                   // break;
                case 2:
                    return getAgua();
                case 3:
                    return getGas();
            }
            return 0;
        }
    }
}
