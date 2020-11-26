namespace Gallery
{
    using System;
    using System.Windows.Forms;

    public partial class FormGallery : Form
    {
        public FormGallery()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox_image.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox_image.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox_image.Image = pictureBox3.Image;
        }
    }
}
