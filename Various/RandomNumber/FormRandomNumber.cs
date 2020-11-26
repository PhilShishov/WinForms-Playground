using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class FormRandomNumber : Form
    {
        public FormRandomNumber()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            int start = int.Parse(textBox_start.Text);
            int end = int.Parse(textBox_end.Text);

            if (start < end)
            {
                Random rand = new Random();
                int number = rand.Next(start, end + 1);

                label_generatedNum.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Second number should be greater");
            }
        }
    }
}
