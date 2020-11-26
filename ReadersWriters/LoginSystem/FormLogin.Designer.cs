namespace LoginSystem
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormLogin
    {
        private IContainer components = null;

        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button button_login;
        private Label label_username;
        private Label label_password;

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
            this.button_login = new Button();
            this.label_username = new Label();
            this.label_password = new Label();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new Point(104, 12);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new Size(108, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new Point(104, 44);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new Size(108, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Location = new Point(137, 73);
            this.button_login.Name = "button_login";
            this.button_login.Size = new Size(75, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new EventHandler(this.button_login_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new Point(25, 15);
            this.label_username.Name = "label_username";
            this.label_username.Size = new Size(58, 13);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new Point(25, 51);
            this.label_password.Name = "label_password";
            this.label_password.Size = new Size(56, 13);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(229, 108);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}