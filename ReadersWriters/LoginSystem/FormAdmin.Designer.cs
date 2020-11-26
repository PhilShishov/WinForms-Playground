namespace LoginSystem
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormAdmin
    {
        private IContainer components = null;

        private Label label_password;
        private Label label_username;
        private Button button_save;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private ListBox listBox_users;
        private Label label1;
        private Label label2;
        private TextBox textBox_viewPassword;
        private TextBox textBox_viewUsername;

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
            this.label_password = new Label();
            this.label_username = new Label();
            this.button_save = new Button();
            this.textBox_password = new TextBox();
            this.textBox_username = new TextBox();
            this.listBox_users = new ListBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBox_viewPassword = new TextBox();
            this.textBox_viewUsername = new TextBox();
            this.SuspendLayout();
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new Point(13, 49);
            this.label_password.Name = "label_password";
            this.label_password.Size = new Size(56, 13);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Password:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new Point(13, 13);
            this.label_username.Name = "label_username";
            this.label_username.Size = new Size(58, 13);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "Username:";
            // 
            // button_save
            // 
            this.button_save.Location = new Point(125, 71);
            this.button_save.Name = "button_save";
            this.button_save.Size = new Size(75, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new EventHandler(this.button_save_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new Point(92, 42);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new Size(108, 20);
            this.textBox_password.TabIndex = 6;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new Point(92, 10);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new Size(108, 20);
            this.textBox_username.TabIndex = 5;
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.Location = new Point(20, 140);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.Size = new Size(180, 134);
            this.listBox_users.TabIndex = 10;
            this.listBox_users.SelectedIndexChanged += new EventHandler(this.listBox_users_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(219, 177);
            this.label1.Name = "label1";
            this.label1.Size = new Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(219, 141);
            this.label2.Name = "label2";
            this.label2.Size = new Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // textBox_viewPassword
            // 
            this.textBox_viewPassword.Enabled = false;
            this.textBox_viewPassword.Location = new Point(298, 170);
            this.textBox_viewPassword.Name = "textBox_viewPassword";
            this.textBox_viewPassword.Size = new Size(108, 20);
            this.textBox_viewPassword.TabIndex = 12;
            // 
            // textBox_viewUsername
            // 
            this.textBox_viewUsername.Enabled = false;
            this.textBox_viewUsername.Location = new Point(298, 138);
            this.textBox_viewUsername.Name = "textBox_viewUsername";
            this.textBox_viewUsername.Size = new Size(108, 20);
            this.textBox_viewUsername.TabIndex = 11;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(491, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_viewPassword);
            this.Controls.Add(this.textBox_viewUsername);
            this.Controls.Add(this.listBox_users);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Name = "FormAdmin";
            this.Text = "Admin Panel";
            this.Load += new EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}