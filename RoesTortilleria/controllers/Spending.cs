using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoesTortilleria.models;

namespace RoesTortilleria.controllers
{
    class Spending
    {
        public bool saveSpend(Spend spend)
        {
            //Bd Connection to save Spend

            return true;
        }

        public Spend[] getSpendsPerMonth(int month)
        {
            ArrayList spendings = new ArrayList();
            //BD Conection to get all monthly spending

            return (Spend[]) spendings.ToArray();
        }

    }
}
