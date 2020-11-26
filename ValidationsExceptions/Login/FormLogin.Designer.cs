namespace Login
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
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new Point(21, 12);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new Size(126, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new Point(21, 50);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new Size(126, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Location = new Point(190, 48);
            this.button_login.Name = "button_login";
            this.button_login.Size = new Size(75, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(321, 290);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}