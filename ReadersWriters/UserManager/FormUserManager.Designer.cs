namespace UserManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormUserManager
    {
        private IContainer components = null;

        private TextBox textBox_username;
        private TextBox textBox_password;
        private Label label_username;
        private Label label_password;
        private Button button_save;
        private ListBox listBox_users;
        private Button button_viewAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox_username = new TextBox();
            this.textBox_password = new TextBox();
            this.label_username = new Label();
            this.label_password = new Label();
            this.button_save = new Button();
            this.listBox_users = new ListBox();
            this.button_viewAll = new Button();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new Point(99, 7);
            this.textBox_username.Margin = new Padding(4, 3, 4, 3);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new Size(146, 23);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new Point(99, 37);
            this.textBox_password.Margin = new Padding(4, 3, 4, 3);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new Size(146, 23);
            this.textBox_password.TabIndex = 1;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new Point(14, 10);
            this.label_username.Margin = new Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new Size(63, 15);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new Point(14, 40);
            this.label_password.Margin = new Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new Size(60, 15);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password:";
            // 
            // button_save
            // 
            this.button_save.Location = new Point(159, 67);
            this.button_save.Margin = new Padding(4, 3, 4, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new Size(88, 27);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new EventHandler(this.button_save_Click);
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.ItemHeight = 15;
            this.listBox_users.Location = new Point(18, 129);
            this.listBox_users.Margin = new Padding(4, 3, 4, 3);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.Size = new Size(228, 109);
            this.listBox_users.TabIndex = 5;
            // 
            // button_viewAll
            // 
            this.button_viewAll.Location = new Point(159, 246);
            this.button_viewAll.Margin = new Padding(4, 3, 4, 3);
            this.button_viewAll.Name = "button_viewAll";
            this.button_viewAll.Size = new Size(88, 27);
            this.button_viewAll.TabIndex = 6;
            this.button_viewAll.Text = "View All";
            this.button_viewAll.UseVisualStyleBackColor = true;
            this.button_viewAll.Click += new EventHandler(this.button_viewAll_Click);
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(270, 285);
            this.Controls.Add(this.button_viewAll);
            this.Controls.Add(this.listBox_users);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Margin = new Padding(4, 3, 4, 3);
            this.Name = "UserManagerForm";
            this.Text = "User Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}