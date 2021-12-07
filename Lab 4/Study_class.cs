using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    internal class Study_class : Books 
    {
        public int id;
        public int quantity;
        int isbn;
        
        public Study_class(int id, int quantity, int isbn)
        {
            this.id = id;
            this.quantity = quantity;
            this.isbn = isbn;
        }

        public string getinfo_s()
        {
            return "ID: " + id.ToString() + "      " + "Quantity: " + quantity.ToString() + "      " + "ISBN: " + isbn.ToString();
        }

    }
}
