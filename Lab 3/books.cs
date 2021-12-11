using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class books
    {
        public int book_id;
        public int quantity;
        public string book_name;

        public string getinfo_b()
        {
            string book_info = book_id.ToString() + "  " + book_name + "  " + quantity;
            return book_info;

        }

        /*public void setinfo_b(int id, int quantity, string name)
        {
            this.book_id = id;
            this.quantity = quantity;
            this.book_name = name;
        }
        */


    }
}
