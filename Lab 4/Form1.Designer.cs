namespace WindowsFormsApp7
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
            this.add_study_onclick = new System.Windows.Forms.Button();
            this.add_research_onclick = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.borrow_book_id_box = new System.Windows.Forms.TextBox();
            this.doi_box = new System.Windows.Forms.TextBox();
            this.isbn_box = new System.Windows.Forms.TextBox();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.study_book_listbox = new System.Windows.Forms.ListBox();
            this.article_listbox = new System.Windows.Forms.ListBox();
            this.borrow_article_id_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_study_onclick
            // 
            this.add_study_onclick.Location = new System.Drawing.Point(264, 122);
            this.add_study_onclick.Name = "add_study_onclick";
            this.add_study_onclick.Size = new System.Drawing.Size(75, 67);
            this.add_study_onclick.TabIndex = 0;
            this.add_study_onclick.Text = "Add Study Book";
            this.add_study_onclick.UseVisualStyleBackColor = true;
            this.add_study_onclick.Click += new System.EventHandler(this.add_study_onclick_Click);
            // 
            // add_research_onclick
            // 
            this.add_research_onclick.Location = new System.Drawing.Point(532, 122);
            this.add_research_onclick.Name = "add_research_onclick";
            this.add_research_onclick.Size = new System.Drawing.Size(99, 64);
            this.add_research_onclick.TabIndex = 1;
            this.add_research_onclick.Text = "Add Research Article";
            this.add_research_onclick.UseVisualStyleBackColor = true;
            this.add_research_onclick.Click += new System.EventHandler(this.add_research_onclick_Click);
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(104, 63);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 22);
            this.id_box.TabIndex = 2;
            // 
            // borrow_book_id_box
            // 
            this.borrow_book_id_box.Location = new System.Drawing.Point(746, 261);
            this.borrow_book_id_box.Name = "borrow_book_id_box";
            this.borrow_book_id_box.Size = new System.Drawing.Size(100, 22);
            this.borrow_book_id_box.TabIndex = 3;
            // 
            // doi_box
            // 
            this.doi_box.Location = new System.Drawing.Point(596, 55);
            this.doi_box.Name = "doi_box";
            this.doi_box.Size = new System.Drawing.Size(100, 22);
            this.doi_box.TabIndex = 4;
            // 
            // isbn_box
            // 
            this.isbn_box.Location = new System.Drawing.Point(324, 57);
            this.isbn_box.Name = "isbn_box";
            this.isbn_box.Size = new System.Drawing.Size(100, 22);
            this.isbn_box.TabIndex = 5;
            // 
            // quantity_box
            // 
            this.quantity_box.Location = new System.Drawing.Point(104, 95);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(100, 22);
            this.quantity_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "DOI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Article ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Book ID";
            // 
            // study_book_listbox
            // 
            this.study_book_listbox.FormattingEnabled = true;
            this.study_book_listbox.ItemHeight = 16;
            this.study_book_listbox.Location = new System.Drawing.Point(23, 285);
            this.study_book_listbox.Name = "study_book_listbox";
            this.study_book_listbox.Size = new System.Drawing.Size(281, 84);
            this.study_book_listbox.TabIndex = 14;
            // 
            // article_listbox
            // 
            this.article_listbox.FormattingEnabled = true;
            this.article_listbox.ItemHeight = 16;
            this.article_listbox.Location = new System.Drawing.Point(359, 285);
            this.article_listbox.Name = "article_listbox";
            this.article_listbox.Size = new System.Drawing.Size(293, 84);
            this.article_listbox.TabIndex = 15;
            // 
            // borrow_article_id_box
            // 
            this.borrow_article_id_box.Location = new System.Drawing.Point(746, 321);
            this.borrow_article_id_box.Name = "borrow_article_id_box";
            this.borrow_article_id_box.Size = new System.Drawing.Size(100, 22);
            this.borrow_article_id_box.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(909, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Borrow Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(909, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 19;
            this.button2.Text = "Borrow Article";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(359, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 46);
            this.button4.TabIndex = 21;
            this.button4.Text = "Show Article";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 57);
            this.button3.TabIndex = 22;
            this.button3.Text = "Show Study Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borrow_article_id_box);
            this.Controls.Add(this.article_listbox);
            this.Controls.Add(this.study_book_listbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.isbn_box);
            this.Controls.Add(this.doi_box);
            this.Controls.Add(this.borrow_book_id_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.add_research_onclick);
            this.Controls.Add(this.add_study_onclick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_study_onclick;
        private System.Windows.Forms.Button add_research_onclick;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox borrow_book_id_box;
        private System.Windows.Forms.TextBox doi_box;
        private System.Windows.Forms.TextBox isbn_box;
        private System.Windows.Forms.TextBox quantity_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox study_book_listbox;
        private System.Windows.Forms.ListBox article_listbox;
        private System.Windows.Forms.TextBox borrow_article_id_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

