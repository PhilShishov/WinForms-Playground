using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFood
{
    public partial class FormFoodOrder : Form
    {
        public FormFoodOrder()
        {
            InitializeComponent();
        }

        private void radioButton_foods_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_foods.Checked)
            {
                pictureBox_foods.Image = Properties.Resources.Desert;

                checkBox_bigMac.Enabled = true;
                checkBox_duner.Enabled = true;
                checkBox_hamburger.Enabled = true;
            }
            else
            {
                checkBox_bigMac.Enabled = false;
                checkBox_duner.Enabled = false;
                checkBox_hamburger.Enabled = false;
            }
        }

        private void radioButton_ads_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ads.Checked)
            {
                pictureBox_foods.Image = Properties.Resources.Hydrangeas;

                checkBox_chicolate.Enabled = true;
                checkBox1_salad.Enabled = true;
            }
            else
            {
                checkBox_chicolate.Enabled = false;
                checkBox1_salad.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_foods.Checked = true;
            pictureBox_foods.Image = Properties.Resources.Desert;
            checkBox_chicolate.Enabled = false;
            checkBox1_salad.Enabled = false;

            radioButton_fizzy.Checked = true;
            pictureBox_drinks.Image = Properties.Resources.Jellyfish;
            checkBox_orange.Enabled = false;
            checkBox_water.Enabled = false;
        }

        private void radioButton_fizzy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_fizzy.Checked)
            {
                checkBox_fanta.Enabled = true;
                checkBox2.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
                checkBox_fanta.Enabled = false;
            }
        }

        private void radioButton_juice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_juice.Checked)
            {
                checkBox_orange.Enabled = true;
                checkBox_water.Enabled = true;
            }
            else
            {
                checkBox_water.Enabled = false;
                checkBox_orange.Enabled = false;
            }
        }
    }
}
