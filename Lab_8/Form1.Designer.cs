namespace Lab_8
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
            this.withdraw_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_id_box = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.Label();
            this.withdraw_amount_box = new System.Windows.Forms.TextBox();
            this.deposit_box = new System.Windows.Forms.TextBox();
            this.account_type_combo_box = new System.Windows.Forms.ComboBox();
            this.create_acc_button = new System.Windows.Forms.Button();
            this.customers_listbox = new System.Windows.Forms.ListBox();
            this.show_listbox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deposit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.withdraw_button = new System.Windows.Forms.Button();
            this.pay_id_box = new System.Windows.Forms.TextBox();
            this.pay_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pay_loan_button = new System.Windows.Forms.Button();
            this.due_button = new System.Windows.Forms.Button();
            this.due_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loan_id_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // withdraw_box
            // 
            this.withdraw_box.Location = new System.Drawing.Point(452, 239);
            this.withdraw_box.Name = "withdraw_box";
            this.withdraw_box.Size = new System.Drawing.Size(100, 22);
            this.withdraw_box.TabIndex = 0;
            this.withdraw_box.TextChanged += new System.EventHandler(this.id_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter ID";
            // 
            // enter_id_box
            // 
            this.enter_id_box.Location = new System.Drawing.Point(189, 242);
            this.enter_id_box.Name = "enter_id_box";
            this.enter_id_box.Size = new System.Drawing.Size(100, 22);
            this.enter_id_box.TabIndex = 2;
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(101, 37);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(84, 16);
            this.Account.TabIndex = 3;
            this.Account.Text = "Account type";
            // 
            // withdraw_amount_box
            // 
            this.withdraw_amount_box.Location = new System.Drawing.Point(452, 282);
            this.withdraw_amount_box.Name = "withdraw_amount_box";
            this.withdraw_amount_box.Size = new System.Drawing.Size(100, 22);
            this.withdraw_amount_box.TabIndex = 4;
            // 
            // deposit_box
            // 
            this.deposit_box.Location = new System.Drawing.Point(189, 285);
            this.deposit_box.Name = "deposit_box";
            this.deposit_box.Size = new System.Drawing.Size(100, 22);
            this.deposit_box.TabIndex = 5;
            this.deposit_box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // account_type_combo_box
            // 
            this.account_type_combo_box.FormattingEnabled = true;
            this.account_type_combo_box.Items.AddRange(new object[] {
            "Current",
            "Savings",
            "Loan"});
            this.account_type_combo_box.Location = new System.Drawing.Point(218, 34);
            this.account_type_combo_box.Name = "account_type_combo_box";
            this.account_type_combo_box.Size = new System.Drawing.Size(121, 24);
            this.account_type_combo_box.TabIndex = 6;
            // 
            // create_acc_button
            // 
            this.create_acc_button.Location = new System.Drawing.Point(376, 22);
            this.create_acc_button.Name = "create_acc_button";
            this.create_acc_button.Size = new System.Drawing.Size(123, 46);
            this.create_acc_button.TabIndex = 7;
            this.create_acc_button.Text = "Create Account";
            this.create_acc_button.UseVisualStyleBackColor = true;
            this.create_acc_button.Click += new System.EventHandler(this.create_acc_button_Click);
            // 
            // customers_listbox
            // 
            this.customers_listbox.FormattingEnabled = true;
            this.customers_listbox.ItemHeight = 16;
            this.customers_listbox.Location = new System.Drawing.Point(994, 97);
            this.customers_listbox.Name = "customers_listbox";
            this.customers_listbox.Size = new System.Drawing.Size(333, 196);
            this.customers_listbox.TabIndex = 8;
            // 
            // show_listbox
            // 
            this.show_listbox.Location = new System.Drawing.Point(1004, 322);
            this.show_listbox.Name = "show_listbox";
            this.show_listbox.Size = new System.Drawing.Size(123, 46);
            this.show_listbox.TabIndex = 9;
            this.show_listbox.Text = "Show";
            this.show_listbox.UseVisualStyleBackColor = true;
            this.show_listbox.Click += new System.EventHandler(this.show_listbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deposit";
            // 
            // deposit_button
            // 
            this.deposit_button.Location = new System.Drawing.Point(188, 322);
            this.deposit_button.Name = "deposit_button";
            this.deposit_button.Size = new System.Drawing.Size(123, 46);
            this.deposit_button.TabIndex = 11;
            this.deposit_button.Text = "Deposit";
            this.deposit_button.UseVisualStyleBackColor = true;
            this.deposit_button.Click += new System.EventHandler(this.deposit_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Withdraw";
            // 
            // withdraw_button
            // 
            this.withdraw_button.Location = new System.Drawing.Point(452, 322);
            this.withdraw_button.Name = "withdraw_button";
            this.withdraw_button.Size = new System.Drawing.Size(123, 46);
            this.withdraw_button.TabIndex = 14;
            this.withdraw_button.Text = "Withdraw";
            this.withdraw_button.UseVisualStyleBackColor = true;
            this.withdraw_button.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // pay_id_box
            // 
            this.pay_id_box.Location = new System.Drawing.Point(706, 236);
            this.pay_id_box.Name = "pay_id_box";
            this.pay_id_box.Size = new System.Drawing.Size(100, 22);
            this.pay_id_box.TabIndex = 15;
            // 
            // pay_box
            // 
            this.pay_box.Location = new System.Drawing.Point(706, 276);
            this.pay_box.Name = "pay_box";
            this.pay_box.Size = new System.Drawing.Size(100, 22);
            this.pay_box.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pay";
            // 
            // pay_loan_button
            // 
            this.pay_loan_button.Location = new System.Drawing.Point(693, 322);
            this.pay_loan_button.Name = "pay_loan_button";
            this.pay_loan_button.Size = new System.Drawing.Size(123, 46);
            this.pay_loan_button.TabIndex = 20;
            this.pay_loan_button.Text = "Pay";
            this.pay_loan_button.UseVisualStyleBackColor = true;
            this.pay_loan_button.Click += new System.EventHandler(this.pay_loan_button_Click);
            // 
            // due_button
            // 
            this.due_button.Location = new System.Drawing.Point(339, 166);
            this.due_button.Name = "due_button";
            this.due_button.Size = new System.Drawing.Size(123, 27);
            this.due_button.TabIndex = 21;
            this.due_button.Text = "Due";
            this.due_button.UseVisualStyleBackColor = true;
            this.due_button.Click += new System.EventHandler(this.due_button_Click);
            // 
            // due_box
            // 
            this.due_box.Location = new System.Drawing.Point(218, 166);
            this.due_box.Name = "due_box";
            this.due_box.Size = new System.Drawing.Size(100, 22);
            this.due_box.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "If \"Loan account\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Enter ID";
            // 
            // loan_id_box
            // 
            this.loan_id_box.Location = new System.Drawing.Point(218, 133);
            this.loan_id_box.Name = "loan_id_box";
            this.loan_id_box.Size = new System.Drawing.Size(100, 22);
            this.loan_id_box.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 450);
            this.Controls.Add(this.loan_id_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.due_box);
            this.Controls.Add(this.due_button);
            this.Controls.Add(this.pay_loan_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pay_box);
            this.Controls.Add(this.pay_id_box);
            this.Controls.Add(this.withdraw_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deposit_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show_listbox);
            this.Controls.Add(this.customers_listbox);
            this.Controls.Add(this.create_acc_button);
            this.Controls.Add(this.account_type_combo_box);
            this.Controls.Add(this.deposit_box);
            this.Controls.Add(this.withdraw_amount_box);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.enter_id_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdraw_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox withdraw_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enter_id_box;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.TextBox withdraw_amount_box;
        private System.Windows.Forms.TextBox deposit_box;
        private System.Windows.Forms.ComboBox account_type_combo_box;
        private System.Windows.Forms.Button create_acc_button;
        private System.Windows.Forms.ListBox customers_listbox;
        private System.Windows.Forms.Button show_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deposit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button withdraw_button;
        private System.Windows.Forms.TextBox pay_id_box;
        private System.Windows.Forms.TextBox pay_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pay_loan_button;
        private System.Windows.Forms.Button due_button;
        private System.Windows.Forms.TextBox due_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox loan_id_box;
    }
}

