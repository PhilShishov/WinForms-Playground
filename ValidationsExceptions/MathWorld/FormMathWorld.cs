namespace MathWorld
{
    using System;
    using System.Windows.Forms;

    public partial class FormMathWorld : Form
    {
        public FormMathWorld()
        {
            InitializeComponent();
        }

        private void ClearTextbox()
        {
            textBox_a.Text = "";
            textBox_b.Clear();
            textBox_c.Clear();
        }

        private void radioButton_triangle_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Visible = true;
            label_b.Visible = true;
            label_c.Visible = true;

            textBox_a.Visible = true;
            textBox_b.Visible = true;
            textBox_c.Visible = true;

            ClearTextbox();
        }

        private void radioButton_square_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Visible = true;
            label_b.Visible = false;
            label_c.Visible = false;

            textBox_a.Visible = true;
            textBox_b.Visible = false;
            textBox_c.Visible = false;

            ClearTextbox();
        }

        private void radioButton_rectangle_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Visible = true;
            label_b.Visible = true;
            label_c.Visible = false;

            textBox_a.Visible = true;
            textBox_b.Visible = true;
            textBox_c.Visible = false;

            ClearTextbox();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double a, b, c, p, s;

            if (radioButton_triangle.Checked)
            {
                try
                {
                    a = double.Parse(textBox_a.Text);
                    b = double.Parse(textBox_b.Text);
                    c = double.Parse(textBox_c.Text);

                    p = a + b + c;
                    double halfP = p / 2;
                    s = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));

                    label_perimeter.Text = "P = " + p;
                    label_surface.Text = "S = " + s;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter only numbers");
                }
            }

            if (radioButton_square.Checked)
            {
                try
                {
                    a = double.Parse(textBox_a.Text);

                    p = 4 * a;
                    s = a * a;

                    label_perimeter.Text = "P = " + p;
                    label_surface.Text = "S = " + s;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter only numbers");
                }
            }

            if (radioButton_rectangle.Checked)
            {
                try
                {
                    a = double.Parse(textBox_a.Text);
                    b = double.Parse(textBox_b.Text);

                    p = 2 * (a + b);
                    s = a * b;

                    label_perimeter.Text = "P = " + p;
                    label_surface.Text = "S = " + s;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter only numbers");
                }
            }
        }
    }
}
