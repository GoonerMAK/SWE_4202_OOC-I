using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class users
    {
        public int id;
        public string name;
        public int taken_id;
        public int borrowed;

        public string getinfo_u()
        { 
            string user_info = id.ToString() + "   " + name + "   " + taken_id + "     " + borrowed;
            return user_info;
        }

        /*public void setinfo_u(int id, string name, int taken)
        {
            this.id = id;
            this.name = name;
            this.taken_id = taken;
        }
        */
    }
}
