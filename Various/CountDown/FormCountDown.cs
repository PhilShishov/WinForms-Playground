namespace CountDown
{
    using System;
    using System.Windows.Forms;

    public partial class FormCountDown : Form
    {
        public FormCountDown()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_time.Text, out _))
            {
                MessageBox.Show("Please insert a number.");
                return;
            }

            timer.Enabled = true;
            timer.Start();

            label_time.Visible = true;
            label_time.Text = textBox_time.Text;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int time = int.Parse(label_time.Text);
            time--;
            label_time.Text = time.ToString();

            if (time == 0)
            {
                timer.Stop();
                label_timeUp.Visible = true;
                label_timeUp.Text = "Time up!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_time.Visible = false;
            label_timeUp.Visible = false;
        }
    }
}
