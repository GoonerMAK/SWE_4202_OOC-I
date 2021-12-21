using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {

        List<User> users = new List<User>();

        List<Order> orders = new List<Order>();

        List<Owner> owners = new List<Owner>();

        int balance = 0;

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

            MessageBox.Show("Done!");
        }

        private void place_order_Click(object sender, EventArgs e)
        {
            int user_order_id = Convert.ToInt32(user_order_box.Text);
            
            
            int quantity = Convert.ToInt32(type_box.Text);
            string to_do = do_combo_box.Text;
            string cloth = clothes_combo_box.Text;

            Order order1 = new Order(quantity, to_do, cloth);

            orders.Add(order1);

            MessageBox.Show("Done!");


        }

        private void see_details_Click(object sender, EventArgs e)
        {
            orders_listbox.Items.Clear();

            for (int i = 0; i < orders.Count; i++)
            {
                orders_listbox.Items.Add(users[i].get_user());

                Console.WriteLine("\n");
            }

            for (int i = 0; i < orders.Count; i++)
            {
                orders_listbox.Items.Add(orders[i].get_order());
          
                Console.WriteLine("\n");
            }

            for (int i = 0; i < orders.Count; i++)
            {
                orders_listbox.Items.Add(owners[i].get_owner());

                Console.WriteLine("\n");
            }

        }

        private void set_status_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(order_id_box.Text);
            int add_amount = Convert.ToInt32(add_amount_box.Text);
            string status = status_combo_box.Text;

            balance = balance + add_amount;

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
