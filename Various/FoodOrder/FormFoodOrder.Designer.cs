namespace MyFood
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormFoodOrder
    {
        private IContainer components = null;

        private PictureBox pictureBox_foods;
        private PictureBox pictureBox_drinks;
        private GroupBox groupBox_foods;
        private CheckBox checkBox_chicolate;
        private CheckBox checkBox1_salad;
        private RadioButton radioButton_ads;
        private CheckBox checkBox_bigMac;
        private CheckBox checkBox_duner;
        private CheckBox checkBox_hamburger;
        private RadioButton radioButton_foods;
        private GroupBox groupBox_drinks;
        private CheckBox checkBox_water;
        private CheckBox checkBox_orange;
        private RadioButton radioButton_juice;
        private CheckBox checkBox_fanta;
        private CheckBox checkBox2;
        private RadioButton radioButton_fizzy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_foods = new GroupBox();
            this.radioButton_foods = new RadioButton();
            this.checkBox_hamburger = new CheckBox();
            this.checkBox_duner = new CheckBox();
            this.checkBox_bigMac = new CheckBox();
            this.radioButton_ads = new RadioButton();
            this.checkBox1_salad = new CheckBox();
            this.checkBox_chicolate = new CheckBox();
            this.groupBox_drinks = new GroupBox();
            this.radioButton_fizzy = new RadioButton();
            this.checkBox_fanta = new CheckBox();
            this.checkBox2 = new CheckBox();
            this.radioButton_juice = new RadioButton();
            this.checkBox_water = new CheckBox();
            this.checkBox_orange = new CheckBox();
            this.pictureBox_drinks = new PictureBox();
            this.pictureBox_foods = new PictureBox();
            this.groupBox_foods.SuspendLayout();
            this.groupBox_drinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_foods
            // 
            this.groupBox_foods.Controls.Add(this.checkBox_chicolate);
            this.groupBox_foods.Controls.Add(this.checkBox1_salad);
            this.groupBox_foods.Controls.Add(this.radioButton_ads);
            this.groupBox_foods.Controls.Add(this.checkBox_bigMac);
            this.groupBox_foods.Controls.Add(this.checkBox_duner);
            this.groupBox_foods.Controls.Add(this.checkBox_hamburger);
            this.groupBox_foods.Controls.Add(this.radioButton_foods);
            this.groupBox_foods.Location = new Point(12, 103);
            this.groupBox_foods.Name = "groupBox_foods";
            this.groupBox_foods.Size = new Size(165, 183);
            this.groupBox_foods.TabIndex = 2;
            this.groupBox_foods.TabStop = false;
            this.groupBox_foods.Text = "Foods";
            // 
            // radioButton_foods
            // 
            this.radioButton_foods.AutoSize = true;
            this.radioButton_foods.Checked = true;
            this.radioButton_foods.Location = new Point(16, 19);
            this.radioButton_foods.Name = "radioButton_foods";
            this.radioButton_foods.Size = new Size(54, 17);
            this.radioButton_foods.TabIndex = 0;
            this.radioButton_foods.TabStop = true;
            this.radioButton_foods.Text = "Foods";
            this.radioButton_foods.UseVisualStyleBackColor = true;
            this.radioButton_foods.CheckedChanged += new System.EventHandler(this.radioButton_foods_CheckedChanged);
            // 
            // checkBox_hamburger
            // 
            this.checkBox_hamburger.AutoSize = true;
            this.checkBox_hamburger.Location = new Point(32, 42);
            this.checkBox_hamburger.Name = "checkBox_hamburger";
            this.checkBox_hamburger.Size = new Size(108, 17);
            this.checkBox_hamburger.TabIndex = 1;
            this.checkBox_hamburger.Text = "Hamburger - 2.99";
            this.checkBox_hamburger.UseVisualStyleBackColor = true;
            // 
            // checkBox_duner
            // 
            this.checkBox_duner.AutoSize = true;
            this.checkBox_duner.Location = new Point(32, 65);
            this.checkBox_duner.Name = "checkBox_duner";
            this.checkBox_duner.Size = new Size(85, 17);
            this.checkBox_duner.TabIndex = 2;
            this.checkBox_duner.Text = "Duner - 4.99";
            this.checkBox_duner.UseVisualStyleBackColor = true;
            // 
            // checkBox_bigMac
            // 
            this.checkBox_bigMac.AutoSize = true;
            this.checkBox_bigMac.Location = new Point(32, 88);
            this.checkBox_bigMac.Name = "checkBox_bigMac";
            this.checkBox_bigMac.Size = new Size(95, 17);
            this.checkBox_bigMac.TabIndex = 3;
            this.checkBox_bigMac.Text = "Big Mac - 5.99";
            this.checkBox_bigMac.UseVisualStyleBackColor = true;
            // 
            // radioButton_ads
            // 
            this.radioButton_ads.AutoSize = true;
            this.radioButton_ads.Location = new Point(16, 111);
            this.radioButton_ads.Name = "radioButton_ads";
            this.radioButton_ads.Size = new Size(43, 17);
            this.radioButton_ads.TabIndex = 4;
            this.radioButton_ads.Text = "Ads";
            this.radioButton_ads.UseVisualStyleBackColor = true;
            this.radioButton_ads.CheckedChanged += new System.EventHandler(this.radioButton_ads_CheckedChanged);
            // 
            // checkBox1_salad
            // 
            this.checkBox1_salad.AutoSize = true;
            this.checkBox1_salad.Location = new Point(32, 134);
            this.checkBox1_salad.Name = "checkBox1_salad";
            this.checkBox1_salad.Size = new Size(83, 17);
            this.checkBox1_salad.TabIndex = 5;
            this.checkBox1_salad.Text = "Salad - 3.25";
            this.checkBox1_salad.UseVisualStyleBackColor = true;
            // 
            // checkBox_chicolate
            // 
            this.checkBox_chicolate.AutoSize = true;
            this.checkBox_chicolate.Location = new Point(32, 157);
            this.checkBox_chicolate.Name = "checkBox_chicolate";
            this.checkBox_chicolate.Size = new Size(104, 17);
            this.checkBox_chicolate.TabIndex = 6;
            this.checkBox_chicolate.Text = "Chocolate - 1.25";
            this.checkBox_chicolate.UseVisualStyleBackColor = true;
            // 
            // groupBox_drinks
            // 
            this.groupBox_drinks.Controls.Add(this.checkBox_water);
            this.groupBox_drinks.Controls.Add(this.checkBox_orange);
            this.groupBox_drinks.Controls.Add(this.radioButton_juice);
            this.groupBox_drinks.Controls.Add(this.checkBox_fanta);
            this.groupBox_drinks.Controls.Add(this.checkBox2);
            this.groupBox_drinks.Controls.Add(this.radioButton_fizzy);
            this.groupBox_drinks.Location = new Point(214, 105);
            this.groupBox_drinks.Name = "groupBox_drinks";
            this.groupBox_drinks.Size = new Size(165, 181);
            this.groupBox_drinks.TabIndex = 3;
            this.groupBox_drinks.TabStop = false;
            this.groupBox_drinks.Text = "Drinks";
            // 
            // radioButton_fizzy
            // 
            this.radioButton_fizzy.AutoSize = true;
            this.radioButton_fizzy.Location = new Point(22, 19);
            this.radioButton_fizzy.Name = "radioButton_fizzy";
            this.radioButton_fizzy.Size = new Size(81, 17);
            this.radioButton_fizzy.TabIndex = 0;
            this.radioButton_fizzy.TabStop = true;
            this.radioButton_fizzy.Text = "Fizzy Drinks";
            this.radioButton_fizzy.UseVisualStyleBackColor = true;
            this.radioButton_fizzy.CheckedChanged += new System.EventHandler(this.radioButton_fizzy_CheckedChanged);
            // 
            // checkBox_fanta
            // 
            this.checkBox_fanta.AutoSize = true;
            this.checkBox_fanta.Location = new Point(37, 63);
            this.checkBox_fanta.Name = "checkBox_fanta";
            this.checkBox_fanta.Size = new Size(83, 17);
            this.checkBox_fanta.TabIndex = 4;
            this.checkBox_fanta.Text = "Fanta - 2.49";
            this.checkBox_fanta.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(37, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(105, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Coca Cola - 2.49";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton_juice
            // 
            this.radioButton_juice.AutoSize = true;
            this.radioButton_juice.Location = new Point(22, 98);
            this.radioButton_juice.Name = "radioButton_juice";
            this.radioButton_juice.Size = new Size(55, 17);
            this.radioButton_juice.TabIndex = 5;
            this.radioButton_juice.TabStop = true;
            this.radioButton_juice.Text = "Juices";
            this.radioButton_juice.UseVisualStyleBackColor = true;
            this.radioButton_juice.CheckedChanged += new System.EventHandler(this.radioButton_juice_CheckedChanged);
            // 
            // checkBox_water
            // 
            this.checkBox_water.AutoSize = true;
            this.checkBox_water.Location = new Point(37, 144);
            this.checkBox_water.Name = "checkBox_water";
            this.checkBox_water.Size = new Size(85, 17);
            this.checkBox_water.TabIndex = 7;
            this.checkBox_water.Text = "Water - 1.00";
            this.checkBox_water.UseVisualStyleBackColor = true;
            // 
            // checkBox_orange
            // 
            this.checkBox_orange.AutoSize = true;
            this.checkBox_orange.Location = new Point(37, 121);
            this.checkBox_orange.Name = "checkBox_orange";
            this.checkBox_orange.Size = new Size(116, 17);
            this.checkBox_orange.TabIndex = 6;
            this.checkBox_orange.Text = "Orange juice - 1.49";
            this.checkBox_orange.UseVisualStyleBackColor = true;
            // 
            // pictureBox_drinks
            // 
            this.pictureBox_drinks.Location = new Point(214, 12);
            this.pictureBox_drinks.Name = "pictureBox_drinks";
            this.pictureBox_drinks.Size = new Size(165, 71);
            this.pictureBox_drinks.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox_drinks.TabIndex = 1;
            this.pictureBox_drinks.TabStop = false;
            // 
            // pictureBox_foods
            // 
            this.pictureBox_foods.Location = new Point(12, 12);
            this.pictureBox_foods.Name = "pictureBox_foods";
            this.pictureBox_foods.Size = new Size(165, 71);
            this.pictureBox_foods.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox_foods.TabIndex = 0;
            this.pictureBox_foods.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(391, 357);
            this.Controls.Add(this.groupBox_drinks);
            this.Controls.Add(this.groupBox_foods);
            this.Controls.Add(this.pictureBox_drinks);
            this.Controls.Add(this.pictureBox_foods);
            this.Name = "FormFoodOrder";
            this.Text = "Food Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_foods.ResumeLayout(false);
            this.groupBox_foods.PerformLayout();
            this.groupBox_drinks.ResumeLayout(false);
            this.groupBox_drinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}