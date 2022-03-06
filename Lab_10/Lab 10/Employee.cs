using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    internal class Employee
    {
        string id, first_name, last_name, email;

        public Employee()
        {

        }
        public Employee(string id, string first_name, string last_name, string email)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string id_and_name()
        {
            return id + "  " + first_name + " " + last_name;
        }
        public string getinfo()
        {
            return "ID: " + id + "   First Name: " + first_name + "  Last Name: " + last_name + "   E-mail: " + email;
        }

    }
}
