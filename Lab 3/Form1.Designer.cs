namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.book_id_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.book_name_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.show_box = new System.Windows.Forms.TextBox();
            this.history_listbox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.book_show_box = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.book_history_listbox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.id_borrow_box = new System.Windows.Forms.TextBox();
            this.book_id_borrow_box = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.taken_id_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(745, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "User History ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Book Name";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(139, 61);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 22);
            this.id_box.TabIndex = 6;
            // 
            // book_id_box
            // 
            this.book_id_box.Location = new System.Drawing.Point(427, 61);
            this.book_id_box.Name = "book_id_box";
            this.book_id_box.Size = new System.Drawing.Size(100, 22);
            this.book_id_box.TabIndex = 7;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(139, 107);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 22);
            this.name_box.TabIndex = 8;
            // 
            // book_name_box
            // 
            this.book_name_box.Location = new System.Drawing.Point(427, 110);
            this.book_name_box.Name = "book_name_box";
            this.book_name_box.Size = new System.Drawing.Size(100, 22);
            this.book_name_box.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity";
            // 
            // quantity_box
            // 
            this.quantity_box.Location = new System.Drawing.Point(427, 159);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(100, 22);
            this.quantity_box.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(942, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // show_box
            // 
            this.show_box.Location = new System.Drawing.Point(804, 85);
            this.show_box.Name = "show_box";
            this.show_box.Size = new System.Drawing.Size(100, 22);
            this.show_box.TabIndex = 16;
            // 
            // history_listbox
            // 
            this.history_listbox.FormattingEnabled = true;
            this.history_listbox.ItemHeight = 16;
            this.history_listbox.Location = new System.Drawing.Point(751, 126);
            this.history_listbox.Name = "history_listbox";
            this.history_listbox.Size = new System.Drawing.Size(172, 116);
            this.history_listbox.TabIndex = 17;
            this.history_listbox.SelectedIndexChanged += new System.EventHandler(this.history_listbox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(745, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Book History ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Book ID";
            // 
            // book_show_box
            // 
            this.book_show_box.Location = new System.Drawing.Point(823, 322);
            this.book_show_box.Name = "book_show_box";
            this.book_show_box.Size = new System.Drawing.Size(100, 22);
            this.book_show_box.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(942, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // book_history_listbox
            // 
            this.book_history_listbox.FormattingEnabled = true;
            this.book_history_listbox.ItemHeight = 16;
            this.book_history_listbox.Location = new System.Drawing.Point(751, 362);
            this.book_history_listbox.Name = "book_history_listbox";
            this.book_history_listbox.Size = new System.Drawing.Size(172, 116);
            this.book_history_listbox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Book ID";
            // 
            // id_borrow_box
            // 
            this.id_borrow_box.Location = new System.Drawing.Point(130, 356);
            this.id_borrow_box.Name = "id_borrow_box";
            this.id_borrow_box.Size = new System.Drawing.Size(100, 22);
            this.id_borrow_box.TabIndex = 25;
            // 
            // book_id_borrow_box
            // 
            this.book_id_borrow_box.Location = new System.Drawing.Point(414, 356);
            this.book_id_borrow_box.Name = "book_id_borrow_box";
            this.book_id_borrow_box.Size = new System.Drawing.Size(100, 22);
            this.book_id_borrow_box.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(249, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Borrow";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Address";
            // 
            // taken_id_box
            // 
            this.taken_id_box.Location = new System.Drawing.Point(139, 159);
            this.taken_id_box.Name = "taken_id_box";
            this.taken_id_box.Size = new System.Drawing.Size(100, 22);
            this.taken_id_box.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 505);
            this.Controls.Add(this.taken_id_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.book_id_borrow_box);
            this.Controls.Add(this.id_borrow_box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.book_history_listbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.book_show_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.history_listbox);
            this.Controls.Add(this.show_box);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.book_name_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.book_id_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox book_id_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox book_name_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox show_box;
        private System.Windows.Forms.ListBox history_listbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox book_show_box;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox book_history_listbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id_borrow_box;
        private System.Windows.Forms.TextBox book_id_borrow_box;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox taken_id_box;
    }
}

