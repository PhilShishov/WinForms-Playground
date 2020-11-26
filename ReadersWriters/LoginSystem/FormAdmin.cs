namespace LoginSystem
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        string fileName = "users.txt";

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(textBox_username.Text + "," + textBox_password.Text);
                        MessageBox.Show("Successfully saved");
                    }
                }
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listBox_users.Items.Add(line);
                    }
                }
            }
        }

        private void listBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user = listBox_users.SelectedItem.ToString();
            string[] userArray = user.Split(',');
            textBox_viewUsername.Text = userArray[0];
            textBox_viewPassword.Text = userArray[1];
        }
    }
}
