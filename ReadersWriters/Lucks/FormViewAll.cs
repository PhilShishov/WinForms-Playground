using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lucks
{
    public partial class FormViewAll : Form
    {
        public FormViewAll()
        {
            InitializeComponent();
        }

        string fileName = "lucks.txt";

        public void FillListbox(List<string> lucks)
        {
            listBox_lucks.Items.Clear();
            for (int i = 0; i < lucks.Count; i++)
            {
                listBox_lucks.Items.Add(lucks[i]);
            }
        }

        private void FormViewAll_Load(object sender, EventArgs e)
        {
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

            FillListbox(FormMain.lucks);
        }
    }
}
