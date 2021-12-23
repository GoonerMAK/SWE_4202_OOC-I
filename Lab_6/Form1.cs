using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {

        List<User> users = new List<User>();

        List<Order> orders = new List<Order>();

        List<Owner> owners = new List<Owner>();

        int balance = 0, order_number = 0;
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(user_id_box.Text);
            string name = name_box.Text;
            
            User user1 = new User(user_id, name);
            users.Add(user1);

/*
            flag += 1;
            if(flag >= 1)
            {
                foreach (User user1 in users)
                {
                    if (user_id == user1.id)
                    {
                        orders_listbox.Items.Add(user1.get_user());
                    }
                }
            }    
*/
            MessageBox.Show("Done!");
        }

        private void place_order_Click(object sender, EventArgs e)
        {
            order_number += 1;

            int quantity = Convert.ToInt32(quantity_box.Text);
            string to_do = do_combo_box.Text;
            string cloth = clothes_combo_box.Text;
            int number = order_number;

            Order order1 = new Order(quantity, cloth, to_do, number);

            orders.Add(order1);

            MessageBox.Show("Your Order ID is " + order_number);

        }

        private void see_details_Click(object sender, EventArgs e)
        {
            orders_listbox.Items.Clear();

            int id = Convert.ToInt32(id_for_details_box.Text);
            int user_order_id = Convert.ToInt32(user_order_box.Text);

            foreach (User user1 in users)
            {
                if(user_order_id == user1.id )
                {
                    orders_listbox.Items.Add(user1.get_user());
                }
            }

            foreach (Order order1 in orders)
            {
                if (id == order1.number)
                {
                    orders_listbox.Items.Add(order1.get_order());

                    if(flag == 0)
                    {
                        orders_listbox.Items.Add("Status:    Pending");
                    }
                }
            }

            foreach(Owner owner1 in owners)
            {
                if (id == owner1.id)
                {
                    orders_listbox.Items.Add(owner1.get_owner());
                }
            }

/*             for (int i = 0; i < orders.Count; i++)
             {
                if( (i+1) == id)
                {
                    orders_listbox.Items.Add(owners[i].get_owner());
                }
             }
*/            

        }

        private void set_status_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(order_id_box.Text);
            int add_amount = Convert.ToInt32(add_amount_box.Text);
            string status = status_combo_box.Text;

            balance = balance + add_amount;
            flag += 1;

            Owner owner1 = new Owner(order_id, add_amount, status);
            owners.Add(owner1);

            MessageBox.Show("Done!");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            orders_listbox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void show_current_balance_Click(object sender, EventArgs e)
        {
            current_balance_box.Text = Convert.ToString(balance);
        }
    }
}
