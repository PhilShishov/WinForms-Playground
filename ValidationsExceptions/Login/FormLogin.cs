namespace Login
{
    using System;
    using System.Windows.Forms;

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                if (textBox_username.Text == "admin" && textBox_password.Text == "qwerty")
                {
                    MessageBox.Show("Login successful");
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
            }
            else
            {
                MessageBox.Show("All fields required");
                return;
            }
        }
    }
}
