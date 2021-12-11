using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
         
        List<users> all_users = new List<users>();

        List<books> all_books = new List<books>();


        public Form1()
        {
            InitializeComponent();
        }

        private void history_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_box.Text);  
            string name = name_box.Text;
            int taken_id = Convert.ToInt32(taken_id_box.Text);
            int borrowed = 0;

            users user1 = new users();

            user1.id = id;
            user1.name = name;
            user1.taken_id = taken_id;
            user1.borrowed = borrowed;

            all_users.Add(user1);

            MessageBox.Show("Added!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int book_id = Convert.ToInt32(book_id_box.Text);
            int quantity = Convert.ToInt32(quantity_box.Text);
            string book_name = book_name_box.Text;

            books book1 = new books();

            book1.book_id = book_id;
            book1.quantity = quantity;
            book1.book_name = book_name;

            all_books.Add(book1);

            MessageBox.Show("Added!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            history_listbox.Items.Clear();

            int show = Convert.ToInt32(show_box.Text);

            for(int i=0; i < all_users.Count; i++)
            {
                if( (i+1) == show )
                {
                    history_listbox.Items.Add(all_users[i].getinfo_u());
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            book_history_listbox.Items.Clear();

            int show = Convert.ToInt32(book_show_box.Text);

            for (int i = 0; i < all_books.Count; i++)
            {
                if ( (i + 1) == show )
                {
                    book_history_listbox.Items.Add(all_books[i].getinfo_b());
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_borrow_box.Text);
            int book_id = Convert.ToInt32(book_id_borrow_box.Text);


            foreach(books book1 in all_books)
            {
                if(book1.quantity > 0)
                {
                    book1.quantity = book1.quantity - 1;
                    
                    MessageBox.Show("Succes!");
                }
                
                else
                {
                    MessageBox.Show("Not enough books!");
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
