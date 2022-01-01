using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class enrolled
    {
        public int id;
        public string name;

        public enrolled(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string get_enrolls()
        {
            return "   Course Name:   " + name + "   ID:   " + id ;
        }
    }
}
