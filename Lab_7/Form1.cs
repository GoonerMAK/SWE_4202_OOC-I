using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        List <course> courses = new List <course> ();

        List <student> students = new List <student> ();

        List <professional> professionals = new List <professional> ();

        List <enrolled> enrolls = new List <enrolled> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_course_Click(object sender, EventArgs e)
        {
            string course_name = course_box.Text;
            int fee = Convert.ToInt32(fee_box.Text);
            string level;

            if(i_course.Checked)
            {
                level = "Intermediate";
            }

            else if(a_course.Checked)
            {
                level = "Advanced";
            }

            else
            {
                level = "Beginner";
            }

            course c1 = new course(course_name, fee, level);

            courses.Add(c1);

            course_combo_box.Items.Add(course_name);

            MessageBox.Show("DONE!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pay_and_enroll_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_combo_box.Text);

            select_id_combo_box.Items.Add(id);

            foreach(course c1 in courses)
            {
                if(c1.name == course_combo_box.Text )
                {
                    automatic_fee_box.Text = Convert.ToString(c1.fee);
                }
            }

            enrolled e1 = new enrolled(id, course_combo_box.Text);

            enrolls.Add(e1);

            MessageBox.Show("DONE!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_participant_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_box.Text);
            string level;

            if(student_button.Checked)
            {
                
                if(i_button.Checked)
                {
                    level = "Intermediate";
                }

                else if(a_button.Checked)
                {
                    level = "Advanced";
                }

                else
                {
                    level = "Beginner";
                }
                
                student s1 = new student(id, level);

                students.Add(s1);

                id_combo_box.Items.Add(id);

                MessageBox.Show("DONE!");
            }

            else
            {
                if (i_button.Checked)
                {
                    level = "Intermediate";
                }

                else if (a_button.Checked)
                {
                    level = "Advanced";
                }

                else
                {
                    level = "Beginner";
                }

                professional p1 = new professional(id, level);

                professionals.Add(p1);

                id_combo_box.Items.Add(id);

                MessageBox.Show("DONE!");
            }
        }

        private void show_courses_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(select_id_combo_box.Text);

            foreach(student s1 in students)
            {
                if(id == s1.id)
                {
                    courses_listbox.Items.Add(s1.get_student() );
                }
            }

            foreach (enrolled e1 in enrolls)
            {
                if (id == e1.id)
                {
                    courses_listbox.Items.Add(e1.get_enrolls());
                }
            }



        }

        private void course_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
