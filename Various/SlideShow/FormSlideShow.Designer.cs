using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SlideShow
{
    partial class FormSlideShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new Container();
            this.pictureBox = new PictureBox();
            this.timer = new Timer(this.components);
            this.button_start = new Button();
            this.button_close = new Button();
            ((ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.pictureBox.Location = new Point(3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new Size(455, 255);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new Point(329, 278);
            this.button_start.Name = "button_start";
            this.button_start.Size = new Size(122, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start slideshow";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new Point(12, 278);
            this.button_close.Name = "button_close";
            this.button_close.Size = new Size(92, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(463, 313);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormSlideShow";
            this.Text = "Slide Show";
            ((ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private Timer timer;
        private Button button_start;
        private Button button_close;
    }
}

