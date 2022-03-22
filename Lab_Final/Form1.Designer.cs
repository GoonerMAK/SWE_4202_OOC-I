namespace Lab_Final
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
            this.show_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.student_listbox = new System.Windows.Forms.ListBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.details_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(910, 88);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 0;
            this.show_button.Text = "show";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // student_listbox
            // 
            this.student_listbox.FormattingEnabled = true;
            this.student_listbox.ItemHeight = 16;
            this.student_listbox.Location = new System.Drawing.Point(12, 48);
            this.student_listbox.Name = "student_listbox";
            this.student_listbox.Size = new System.Drawing.Size(580, 324);
            this.student_listbox.TabIndex = 3;
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(897, 48);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 22);
            this.id_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student ID:";
            // 
            // details_listbox
            // 
            this.details_listbox.FormattingEnabled = true;
            this.details_listbox.ItemHeight = 16;
            this.details_listbox.Location = new System.Drawing.Point(737, 141);
            this.details_listbox.Name = "details_listbox";
            this.details_listbox.Size = new System.Drawing.Size(506, 228);
            this.details_listbox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 450);
            this.Controls.Add(this.details_listbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.student_listbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.show_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox student_listbox;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox details_listbox;
    }
}

