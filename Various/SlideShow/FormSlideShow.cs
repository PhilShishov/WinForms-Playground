namespace SlideShow
{
    using System;
    using System.Windows.Forms;

    public partial class FormSlideShow : Form
    {
        public FormSlideShow()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.Desert;
            timer.Enabled = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(1, 10);

            switch (number)
            {
                case 1:
                case 5:
                case 7:
                    pictureBox.Image = Properties.Resources.Desert;
                    break;
                case 2:
                case 4:
                case 9:
                    pictureBox.Image = Properties.Resources.Jellyfish;
                    break;
                default:
                    pictureBox.Image = Properties.Resources.Penguins;
                    break;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            // int a = 5;
            DialogResult result = MessageBox.Show("Are you sure?", "Form Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
