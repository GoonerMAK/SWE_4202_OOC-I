using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class professional : participant
    {
        public professional(int id, string level)
        {
            this.id = id;
            this.level = level;
        }

        public string get_professional()
        {
            return id + level;
        }
    }
}
