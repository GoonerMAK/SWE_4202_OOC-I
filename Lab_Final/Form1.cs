using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Final
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>();


        //List<Mark> marks = new List<Mark>();

        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr1 = new StreamReader(@"D:\SWE4201MarkSheet.csv"))
            {
                List<string> id = new List<string>();
                List<string> name = new List<string>();

                while (!sr1.EndOfStream)
                {
                    var line = sr1.ReadLine();
                    var values = line.Split(',');

                      //id.Add(values[0]);
                      //name.Add(values[1]);

                    Student s1 = new Student(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
                    
                 
                    //Mark m1 = new Mark(values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);

                    //marks.Add(m1);

                    students.Add(s1);
                }

               
                student_listbox.Items.Add("ID" + "\t" + "\t" + "name");

                
                foreach (Student s1 in students)
                {
                    student_listbox.Items.Add(s1.id_and_name());
                    student_listbox.Items.Add(s1.get_percentage());
                    student_listbox.Items.Add(s1.get_grade());
                    student_listbox.Items.Add("");
                }
                
                /*
                for (int i = 1; i < 50; i++)
                {
                    student_listbox.Items.Add(id[i] + "\t" );
                }
                */
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void show_button_Click(object sender, EventArgs e)
        {
            foreach (Student s1 in students)
            {
                if (s1.Id == id_box.Text)
                {
                    details_listbox.Items.Add(s1.getinfo());
                    details_listbox.Items.Add(s1.get_quiz_marks());
                    details_listbox.Items.Add(s1.get_mid_final());
                    details_listbox.Items.Add(s1.get_percentage());
                    details_listbox.Items.Add(s1.get_grade());
                }

            }

        }
    }
}
