using System;
using System.Windows.Forms;

namespace RoesTortilleria.views
{
    internal class button : Button
    {
        public int count;

        public button(int count)
        {
            this.count = count;
        }

        public int getId() {

            return count;
        }

        internal void setId(int v)
        {
            count = v;
        }
    }
    }