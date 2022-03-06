namespace Lab_10
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.employee_id_listbox = new System.Windows.Forms.ListBox();
            this.log_box = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.info_box = new System.Windows.Forms.ListBox();
            this.show_log = new System.Windows.Forms.Button();
            this.employee_name_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Analysis";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(426, 83);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 23);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(426, 48);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 22);
            this.id_box.TabIndex = 11;
            // 
            // employee_id_listbox
            // 
            this.employee_id_listbox.FormattingEnabled = true;
            this.employee_id_listbox.ItemHeight = 16;
            this.employee_id_listbox.Location = new System.Drawing.Point(53, 86);
            this.employee_id_listbox.Name = "employee_id_listbox";
            this.employee_id_listbox.Size = new System.Drawing.Size(255, 276);
            this.employee_id_listbox.TabIndex = 17;
            // 
            // log_box
            // 
            this.log_box.FormattingEnabled = true;
            this.log_box.ItemHeight = 16;
            this.log_box.Location = new System.Drawing.Point(868, 104);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(181, 276);
            this.log_box.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1195, 395);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1195, 502);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1195, 449);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1236, 546);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1236, 588);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 24;
            // 
            // info_box
            // 
            this.info_box.FormattingEnabled = true;
            this.info_box.ItemHeight = 16;
            this.info_box.Location = new System.Drawing.Point(350, 141);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(396, 276);
            this.info_box.TabIndex = 29;
            // 
            // show_log
            // 
            this.show_log.Location = new System.Drawing.Point(949, 35);
            this.show_log.Name = "show_log";
            this.show_log.Size = new System.Drawing.Size(100, 23);
            this.show_log.TabIndex = 30;
            this.show_log.Text = "show";
            this.show_log.UseVisualStyleBackColor = true;
            this.show_log.Click += new System.EventHandler(this.show_csv_Click);
            // 
            // employee_name_listbox
            // 
            this.employee_name_listbox.FormattingEnabled = true;
            this.employee_name_listbox.ItemHeight = 16;
            this.employee_name_listbox.Location = new System.Drawing.Point(1206, 86);
            this.employee_name_listbox.Name = "employee_name_listbox";
            this.employee_name_listbox.Size = new System.Drawing.Size(122, 276);
            this.employee_name_listbox.TabIndex = 31;
            this.employee_name_listbox.SelectedIndexChanged += new System.EventHandler(this.employee_name_listbox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 612);
            this.Controls.Add(this.employee_name_listbox);
            this.Controls.Add(this.show_log);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.employee_id_listbox);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.ListBox employee_id_listbox;
        private System.Windows.Forms.ListBox log_box;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox info_box;
        private System.Windows.Forms.Button show_log;
        private System.Windows.Forms.ListBox employee_name_listbox;
    }
}

