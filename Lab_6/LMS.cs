using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class User
    {
        public int id;
        string name;

        public User()
        {

        }
        public User(int id, string name)
        {
            this.id = id;   
            this.name = name;
        }

        public string get_user()
        {
            return "User id:   " + id + "        " + "Name:     " +  name;
        }

    }

    class Order
    {
        int quantity;
        string cloth;
        string to_do;
        public int number;


        public Order(int quantity, string cloth, string to_do, int number)
        {
            this.quantity = quantity;
            this.cloth = cloth;
            this.to_do = to_do;
            this.number = number;
        }

        public string get_order()
        {
            return "\n" + "Quantity:   " + quantity + "      " + "Type:   " + cloth + "        " + "To-Do:   "  + to_do;
        }
    }

    class Owner
    {
        public int id;
        int amount;
        string status;

        public Owner(int id, int amount, string status)
        {
            this.id = id;
            this.amount = amount;
            this.status = status;
        }

        public string get_owner()
        {
            return "\nStatus:    " + status;
        }

    }

    internal class LMS
    {
       
    }

   
}
