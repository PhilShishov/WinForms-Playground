namespace UserManager
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class FormUserManager : Form
    {
        public FormUserManager()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                using (FileStream fileStream = new FileStream("users.txt", FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(textBox_username.Text);
                        writer.WriteLine(textBox_password.Text);
                        MessageBox.Show("Successfully saved");
                    }
                }
            }
        }

        private void button_viewAll_Click(object sender, EventArgs e)
        {
            listBox_users.Items.Clear();

            FileStream fs = new FileStream("users.txt", FileMode.OpenOrCreate);
            try
            {
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    listBox_users.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
