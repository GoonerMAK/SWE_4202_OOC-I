using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_10
{
    public partial class Form1 : Form
    {

        List<Employee> employees = new List<Employee>();

        List<int> logs = new List<int>();

        public Form1()
        {
            InitializeComponent();
            using (StreamReader s1 = new StreamReader(@"C:\employees.csv"))
            {
                List<string> id = new List<string>();
                List<string> name = new List<string>();

                while (!s1.EndOfStream)
                {
                    var line = s1.ReadLine();
                    var values = line.Split(',');
                   
                    //  id.Add(values[0]);
                    //  name.Add(values[1]);

                    Employee e1 = new Employee(values[0], values[1], values[2], values[3]);

                    employees.Add(e1);
                }


                employee_id_listbox.Items.Add("ID" + "\t" + "name");

                foreach (Employee e1 in employees)
                {
                    employee_id_listbox.Items.Add(e1.id_and_name());
                }
                

                /*for (int i = 1; i < 50; i++)
                {
                    employee_id_listbox.Items.Add(id[i] + "\t" + name[i]);
                }*/
           
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void show_csv_Click(object sender, EventArgs e)
        {
            log_box.Items.Clear();

            for (int i=0; i<logs.Count; i++)
            {
                log_box.Items.Add(logs[i]);
            }

            /*using (StreamWriter writer = File.AppendText(@"C:\logs.txt"))
            {
                writer.WriteLine("wow");
            }*/
        }

        private void employee_name_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string search = id_box.Text;
            int flag = 0;

            foreach(Employee e1 in employees)
            {
                if(search == e1.Id )
                {
                    info_box.Items.Clear();
                    info_box.Items.Add(e1.getinfo());
                    int searched_id = Convert.ToInt32(id_box.Text);
                    logs.Add(searched_id);
                    flag = 1;
                }
                
            }

            if(flag == 0)
            {
                MessageBox.Show("INVALID");
            }    
        }

       
    }
}
