using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        List<medicine> medicines = new List<medicine>();

        int balance = 0;

        ComboBox box = new ComboBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            balance = balance + Convert.ToInt32(balance_box.Text);
            MessageBox.Show("Succes!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(medicine_id_box.Text);
            int quantity = Convert.ToInt32(quantity_box.Text);
            string name = name_box.Text;

            medicine m1 = new medicine();
            m1.setinfo(name, id, quantity);
            medicines.Add(m1);

            MessageBox.Show("Succes!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current_balance_box.Text = Convert.ToString(balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medicine_listbox.Items.Clear();

            for (int i = 0; i < medicines.Count; i++)
            {
                medicine_listbox.Items.Add(medicines[i].getinfo() );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sell_id = Convert.ToInt32(sell_id_box.Text);
            int sell_for = Convert.ToInt32(sell_for_box.Text);

            foreach (medicine m1 in medicines)
            {
                if (m1.id == sell_id)
                {
                    if (m1.quantity > 0)
                    {
                        m1.quantity = m1.quantity - 1;

                        balance = balance + sell_for;

                        MessageBox.Show("Succes!");
                    }

                    else
                    {
                        MessageBox.Show("Not enough books!");

                    }
                }


            }

        }


        


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            balance_box.Text = String.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            medicine_id_box.Text = " ";
            quantity_box.Text = " ";
            name_box.Text = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sell_for_box.Text = " ";
            sell_id_box.Text = " ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current_balance_box.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            medicine_listbox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
