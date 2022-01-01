using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class student : participant
    {

        public student(int id, string level)
        {
            this.id = id;
            this.level = level;
        }

        public string get_student()
        {
            return "ID:   " + id + "Student:   "  + level;
        }
    }
}
