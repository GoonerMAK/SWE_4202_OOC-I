using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        List<Study_class> studybooks = new List<Study_class>();

        List<Research_class> articles = new List<Research_class>();

        List<Books> all_books = new List<Books>();


        public Form1()
        {
            InitializeComponent();
        }

        private void add_study_onclick_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_box.Text);
            int quantity = Convert.ToInt32(quantity_box.Text);
            int isbn = Convert.ToInt32(isbn_box.Text);
            //int doi = Convert.ToInt32(doi_box.Text);

            Study_class book1 = new Study_class(id, quantity, isbn);

            studybooks.Add(book1);

            MessageBox.Show("Added");
        }

        private void add_research_onclick_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_box.Text);
            int quantity = Convert.ToInt32(quantity_box.Text);
            //int isbn = Convert.ToInt32(isbn_box.Text);
            int doi = Convert.ToInt32(doi_box.Text);

            Research_class article1 = new Research_class(id, quantity, doi);

            articles.Add(article1);

            MessageBox.Show("Added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            study_book_listbox.Items.Clear();

            for(int i=0; i<studybooks.Count;i++)
            {
                study_book_listbox.Items.Add(studybooks[i].getinfo_s() );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            article_listbox.Items.Clear();

            for(int i=0; i < articles.Count;i++)
            {
                article_listbox.Items.Add(articles[i].getinfo_a());
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int borrow_book = Convert.ToInt32(borrow_book_id_box.Text);
            //int borrow_article = Convert.ToInt32(borrow_article_id_box.Text);

            foreach (Study_class book1 in studybooks)
            {
                if (book1.quantity > 0)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int borrow_article = Convert.ToInt32(borrow_article_id_box.Text);

            foreach (Research_class article1 in articles)
            {
                if (article1.quantity > 0)
                {
                    article1.quantity = article1.quantity - 1;

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
