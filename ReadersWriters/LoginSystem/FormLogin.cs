namespace LoginSystem
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        string fileName = "users.txt";

        private void button_login_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] userArray = line.Split(',');
                            string username = userArray[0];
                            string password = userArray[1];

                            if (textBox_username.Text == username && textBox_password.Text == password)
                            {
                                isFound = true;
                            }
                        }
                    }
                }
            }
            if (isFound)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
            }
        }
    }
}
