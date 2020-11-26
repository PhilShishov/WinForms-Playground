namespace Lucks
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        string fileName = "lucks.txt";

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_add.Text != "")
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(textBox_add.Text);
                        MessageBox.Show("Successfully added");
                        textBox_add.Clear();
                    }
                }
            }

            FormMain.lucks.Clear();
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        FormMain.lucks.Add(line);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
