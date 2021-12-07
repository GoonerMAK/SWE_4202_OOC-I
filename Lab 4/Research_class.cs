using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    internal class Research_class : Books
    {
        int id;
        public int quantity;
        int doi;

        public Research_class(int id, int quantity, int doi)
        {
            this.id = id;
            this.doi = doi;
            this.quantity = quantity;
        }

        public string getinfo_a()
        {
            return "ID:" + id.ToString() + "      " + "Quantity:" + quantity.ToString() + "       " + "DOI: " + doi.ToString();
        }

    }
}
