namespace Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class FormMinMaxAverage : Form
    {
        public FormMinMaxAverage()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();

        public void FillListBox(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox_numbers.Items.Add(numbers[i]);
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int count = int.Parse(textBox_count.Text);

                for (int i = 0; i < count; i++)
                {
                    numbers.Add(rand.Next(1, 100));
                }

                FillListBox(numbers);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            textBox_min.Text = min.ToString();

            // textBox_min.Text = numbers.Min().ToString();
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            textBox_max.Text = numbers.Max().ToString();
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            textBox_sum.Text = numbers.Sum().ToString();
        }

        private void button_average_Click(object sender, EventArgs e)
        {
            textBox_average.Text = numbers.Average().ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox_numbers.SelectedIndex;
                numbers.RemoveAt(index);

                listBox_numbers.Items.Clear();
                FillListBox(numbers);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Choose item");
            }

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Form Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                //Application.Restart();
            }
        }
    }
}
