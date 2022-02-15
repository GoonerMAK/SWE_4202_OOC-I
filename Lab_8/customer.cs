using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class customer
    {
        public string id;
        public float amount;
        public customer(string id, float amount)
        {
            this.id = id;
            this.amount = amount;
        }

        public string get_customer()
        {
            return "Customer ID: " + id + "    " + "Amount: " + amount;
        }
    }
}
