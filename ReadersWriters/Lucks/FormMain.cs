namespace Lucks
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.IO;

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string fileName = "lucks.txt";
        public static List<string> lucks = new List<string>();

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        lucks.Add(line);
                    }
                }
            }
        }

        private void button_getLuck_Click(object sender, EventArgs e)
        {
            if (lucks.Count == 0)
            {
                MessageBox.Show("Lucks list is empty. Please add a luck from the lucks toolbar.");
                return;
            }

            Random rand = new Random();
            int generatedNum = rand.Next(0, lucks.Count);
            label_luck.Text = lucks[generatedNum];
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewAll formViewAll = new FormViewAll();
            formViewAll.ShowDialog();
        }
    }
}
