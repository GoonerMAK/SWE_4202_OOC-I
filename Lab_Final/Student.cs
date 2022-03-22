using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final
{
    internal class Student
    {
        string id, name;
        string att, q1, q2, q3, q4, mid, final, viva;

        public Student()
        {

        }
        public Student(string id, string name, string att, string q1, string q2, string q3, string q4, string mid, string final, string viva)
        {
            this.id = id;
            this.name = name;

            this.att = att;
            this.q1 = q1;
            this.q2 = q2;
            this.q3 = q3;
            this.q4 = q4;

            this.mid = mid;
            this.final = final;
            this.viva = viva;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string id_and_name()
        {
            return id + "  " + name;
        }
        public string getinfo()
        {
            return "ID: " + id + "        Name: " + name + "      Attendance: " + att;
        }

        public string get_quiz_marks()
        {
            return "Quiz I: " + q1 + "      Quiz II: " + q2 + "           Quiz III: " + q3 + "        Quiz IV: " + q4;

        }

        public string get_mid_final()
        {
            return "MID: " + mid + "      Final: " + final + "           Viva: " + viva;

        }

        public string get_percentage()
        {

            double sum = Convert.ToDouble(att) + Convert.ToDouble(q1) + Convert.ToDouble(q2) + Convert.ToDouble(q3) + Convert.ToDouble(q4) + Convert.ToDouble(mid) + Convert.ToDouble(final) + Convert.ToDouble(viva);
            double ans = sum * 100 / 300;
            return "Percentage:   " + ans + "%";
        }

        public string get_grade()
        {
            double sum = ( (Convert.ToDouble(att) + Convert.ToDouble(q1) + Convert.ToDouble(q2) + Convert.ToDouble(q3) + Convert.ToDouble(q4) + Convert.ToDouble(mid) + Convert.ToDouble(final) + Convert.ToDouble(viva) )*100) / 300;

            string grade = "F";

            if (sum>= 80)
            {
                grade = "A+";
            }

            else if(sum>=75)
            {
                grade = "A";
            }

            else if (sum >= 70)
            {
                grade = "A-";
            }

            else if (sum >= 65)
            {
                grade = "B+";
            }

            else if (sum >= 60)
            {
                grade = "B";
            }

            else if (sum >= 55)
            {
                grade = "B-";
            }

            else if (sum >= 50)
            {
                grade = "C+";
            }

            else if (sum >= 45)
            {
                grade = "C";
            }

            else if (sum >= 40)
            {
                grade = "D";
            }

            else if (sum >= 0)
            {
                grade = "F";
            }

            return "Grade : " + grade;
        }
    }
}
