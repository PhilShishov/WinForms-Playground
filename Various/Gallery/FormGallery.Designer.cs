namespace Gallery
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormGallery
    {
        private IContainer components = null;

        private PictureBox pictureBox_image;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox3 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.pictureBox_image = new PictureBox();
            ((ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gallery.Properties.Resources.Koala;
            this.pictureBox3.Location = new Point(228, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(100, 50);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gallery.Properties.Resources.Jellyfish;
            this.pictureBox2.Location = new Point(118, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(100, 50);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gallery.Properties.Resources.Penguins;
            this.pictureBox1.Location = new Point(12, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(100, 50);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new Point(12, 12);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new Size(316, 168);
            this.pictureBox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(340, 254);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_image);
            this.Name = "FormGallery";
            this.Text = "Gallery";
            ((ISupportInitialize)(this.pictureBox3)).EndInit();
            ((ISupportInitialize)(this.pictureBox2)).EndInit();
            ((ISupportInitialize)(this.pictureBox1)).EndInit();
            ((ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}