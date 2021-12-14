using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class medicine
    {
        public int id;
        public int quantity;
        public string name;

        public string getinfo()
        {
            return ("Name: " + name + "    ID: " + id + "   Quantity: " + quantity );
        }
        public void setinfo(string name, int id, int quantity)
        {
            this.name = name;
            this.id = id;
            this.quantity = quantity;
        }

    }
}
