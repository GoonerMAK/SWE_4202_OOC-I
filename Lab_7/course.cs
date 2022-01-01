using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class course
    {
        public string name;
        public int fee;
        string level;

        public course(string name, int fee, string level)
        {
            this.name = name;
            this.fee = fee;
            this.level = level;
        }

        public string get_course()
        {
            return "Course Name:   " + name + "Fee:   " + fee + "Level:    " + level;
        }

    }
}
