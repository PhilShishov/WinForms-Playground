
namespace CountDown
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormCountDown
    {       
        private System.ComponentModel.IContainer components = null;

        private Timer timer;
        private TextBox textBox_time;
        private Button button_start;
        private Label label_time;
        private Label label_timeUp;

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
            this.components = new System.ComponentModel.Container();
            this.timer = new Timer(this.components);
            this.textBox_time = new TextBox();
            this.button_start = new Button();
            this.label_time = new Label();
            this.label_timeUp = new Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new Point(12, 12);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new Size(66, 20);
            this.textBox_time.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new Point(105, 10);
            this.button_start.Name = "button_start";
            this.button_start.Size = new Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new EventHandler(this.button_start_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new Point(66, 59);
            this.label_time.Name = "label_time";
            this.label_time.Size = new Size(64, 22);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "label1";
            // 
            // label_timeUp
            // 
            this.label_timeUp.AutoSize = true;
            this.label_timeUp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label_timeUp.Location = new Point(32, 110);
            this.label_timeUp.Name = "label_timeUp";
            this.label_timeUp.Size = new Size(41, 15);
            this.label_timeUp.TabIndex = 3;
            this.label_timeUp.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(247, 145);
            this.Controls.Add(this.label_timeUp);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_time);
            this.Name = "FormCountDown";
            this.Text = "Count Down";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

