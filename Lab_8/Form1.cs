using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {

        int n = 1;

        List <customer> customers = new List <customer> ();


        public Form1()
        {
            InitializeComponent();
        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_acc_button_Click(object sender, EventArgs e)
        {
            if(account_type_combo_box.Text == "Current")
            {
                string id = n + "300";
                n++;
                float amount = 500;

                customer c1 = new customer(id, amount);

                customers.Add(c1);

                MessageBox.Show("Your ID is " + id);

            }

            else if(account_type_combo_box.Text == "Savings")
            {
                string id = n + "314";
                n++;
                float amount = 50000;

                customer c1 = new customer(id, amount);

                customers.Add(c1);

                MessageBox.Show("Your ID is " + id);
            }

            else
            {
                string id = n + "400";
                n++;

                float amount = 0;

                customer c1 = new customer(id, amount);

                customers.Add(c1);

                MessageBox.Show("Your ID is " + id);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void show_listbox_Click(object sender, EventArgs e)
        {
            customers_listbox.Items.Clear();   

            for(int i=0; i < customers.Count; i++ )
            {
                customers_listbox.Items.Add(customers[i].get_customer() );
            }

    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void deposit_button_Click(object sender, EventArgs e)
        {
            float deposit = Convert.ToInt32(deposit_box.Text);

            int enter_id = Convert.ToInt32(enter_id_box.Text);

            foreach(customer c1 in customers)
            {
                int number = Convert.ToInt32(c1.id);

                if(enter_id == number)
                {
                    c1.amount = c1.amount + deposit;
                }
            }

        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
            float withdraw = Convert.ToInt32(withdraw_amount_box.Text);

            int enter_id = Convert.ToInt32(withdraw_box.Text);

            foreach (customer c1 in customers)
            {
                int number = Convert.ToInt32(c1.id);

                if (enter_id == number)
                {
                    c1.amount = c1.amount - withdraw;

                    if(c1.amount < 0)
                    {
                        c1.amount = c1.amount + withdraw;
                        MessageBox.Show("You can't withdraw!");
                    }
                }
            }
        }

        private void pay_loan_button_Click(object sender, EventArgs e)
        {
            int enter_id = Convert.ToInt32(pay_id_box.Text);

            float pay = Convert.ToInt32(pay_box.Text);

            foreach (customer c1 in customers)
            {
                int number = Convert.ToInt32(c1.id);

                if (enter_id == number)
                {
                    c1.amount = c1.amount - pay;

                    if(c1.amount < 0)
                    {
                        MessageBox.Show("It can;t be done");
                        c1.amount = c1.amount + pay;
                    }
                }
            }

        }

        private void due_button_Click(object sender, EventArgs e)
        {
            int enter_id = Convert.ToInt32(loan_id_box.Text);

            float due = Convert.ToInt32(due_box.Text);

                foreach (customer c1 in customers)
                {
                    int number = Convert.ToInt32(c1.id);

                    if (enter_id == number)
                    {
                        c1.amount = (float)(c1.amount+ due + due * (0.09));
                    }
                }
           
        }
    }
}
