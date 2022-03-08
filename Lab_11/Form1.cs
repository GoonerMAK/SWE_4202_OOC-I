using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {

        public int i = 0;

        public int flag = 0;

        int red_win = 0, black_win = 0, draw = 0;


        public void check_win()
        {
            if(box1.BackColor == Color.Black && box2.BackColor == Color.Black && box3.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if(box4.BackColor == Color.Black && box5.BackColor == Color.Black && box6.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if(box7.BackColor == Color.Black && box8.BackColor == Color.Black && box9.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if (box1.BackColor == Color.Black && box4.BackColor == Color.Black && box7.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if (box2.BackColor == Color.Black && box5.BackColor == Color.Black && box8.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if (box3.BackColor == Color.Black && box6.BackColor == Color.Black && box9.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if (box1.BackColor == Color.Black && box5.BackColor == Color.Black && box9.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if (box7.BackColor == Color.Black && box5.BackColor == Color.Black && box3.BackColor == Color.Black)
            {
                MessageBox.Show("BLACK WON");
                flag = 1;
                black_win++;

                black_box.Text = Convert.ToString(black_win);
            }

            else if (box1.BackColor == Color.Red && box2.BackColor == Color.Red && box3.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if (box4.BackColor == Color.Red && box5.BackColor == Color.Red && box6.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if (box7.BackColor == Color.Red && box8.BackColor == Color.Red && box9.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if (box1.BackColor == Color.Red && box4.BackColor == Color.Red && box7.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if (box2.BackColor == Color.Red && box5.BackColor == Color.Red && box8.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if (box3.BackColor == Color.Red && box6.BackColor == Color.Red && box9.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if (box1.BackColor == Color.Red && box5.BackColor == Color.Red && box9.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if (box7.BackColor == Color.Red && box5.BackColor == Color.Red && box3.BackColor == Color.Red)
            {
                MessageBox.Show("RED WON");
                flag = 1;
                red_win++;

                red_box.Text = Convert.ToString(red_win);
            }

            else if( i%9==0 && flag == 0)
            {
                MessageBox.Show("It's a DRAW!");
                draw++;

                draw_box.Text = Convert.ToString(draw);
            }
        }
        public Form1()
        {
            InitializeComponent();

            black_box.Text = Convert.ToString(0);

            red_box.Text = Convert.ToString(0);

            draw_box.Text = Convert.ToString(0);
        }

        private void box1_Click(object sender, EventArgs e)
        {
            i++;

            if(i%2 == 1)
            {
                box1.BackColor = Color.Black;
            }
            
            else
            {
                box1.BackColor = Color.Red;
            }

            check_win();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box2.BackColor = Color.Black;
            }

            else
            {
                box2.BackColor = Color.Red;
            }

            check_win();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box3.BackColor = Color.Black;
            }

            else
            {
                box3.BackColor = Color.Red;
            }

            check_win();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box4.BackColor = Color.Black;
            }

            else
            {
                box4.BackColor = Color.Red;
            }

            check_win();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box5.BackColor = Color.Black;
            }

            else
            {
                box5.BackColor = Color.Red;
            }

            check_win();
        }

        private void box6_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box6.BackColor = Color.Black;
            }

            else
            {
                box6.BackColor = Color.Red;
            }

            check_win();
        }

        private void box7_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box7.BackColor = Color.Black;
            }

            else
            {
                box7.BackColor = Color.Red;
            }

            check_win();
        }

        private void box8_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box8.BackColor = Color.Black;
            }

            else
            {
                box8.BackColor = Color.Red;
            }

            check_win();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void box9_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                box9.BackColor = Color.Black;
            }

            else
            {
                box9.BackColor = Color.Red;
            }

            check_win();
        }

        private void play_again_Click(object sender, EventArgs e)
        {
            box1.BackColor = Color.White;
            box2.BackColor = Color.White;
            box3.BackColor = Color.White;
            box4.BackColor = Color.White;
            box5.BackColor = Color.White;
            box6.BackColor = Color.White;
            box7.BackColor = Color.White;
            box8.BackColor = Color.White;
            box9.BackColor = Color.White;

            i = 0;
        }
    }
}
