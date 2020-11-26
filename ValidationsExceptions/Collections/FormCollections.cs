namespace Collections
{
    using System;
    using System.Windows.Forms;

    public partial class FormCollections : Form
    {
        public FormCollections()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_add.Text.Trim() != "")
            {
                listBox_items.Items.Add(textBox_add.Text.Trim());
                textBox_add.Clear();
                label_count.Text = "Count: " + listBox_items.Items.Count;
            }
            else
            {
                MessageBox.Show("You cannot add empty string");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //listBox_items.Items.Remove(listBox_items.SelectedItem);

            //try
            //{
            //    listBox_items.Items.RemoveAt(listBox_items.SelectedIndex);
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    MessageBox.Show("Choose item");
            //}

            if (listBox_items.SelectedIndex >= 0)
            {
                listBox_items.Items.RemoveAt(listBox_items.SelectedIndex);
                label_count.Text = "Count: " + listBox_items.Items.Count;
            }
            else
            {
                MessageBox.Show("Choose item");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int index = listBox_items.SelectedIndex;

            if (index >= 0)
            {
                listBox_items.Items.RemoveAt(index);
                listBox_items.Items.Insert(index, textBox_update.Text);
            }
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            listBox_items.Items.Clear();
            label_count.Text = "Count: " + listBox_items.Items.Count;
        }

        // not work
        private void button_search_Click(object sender, EventArgs e)
        {
            string searched = textBox_search.Text;
            for (int i = 0; i < listBox_items.Items.Count; i++)
            {
                if (listBox_items.SelectedItem.ToString() == searched)
                {
                    MessageBox.Show("Test");
                }
            }
        }
    }
}
