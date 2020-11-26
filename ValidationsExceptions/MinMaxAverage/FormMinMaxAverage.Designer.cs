namespace Lists
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormMinMaxAverage
    {
        private IContainer components = null;

        private Label label_title;
        private TextBox textBox_count;
        private Button button_generate;
        private ListBox listBox_numbers;
        private Button button_min;
        private TextBox textBox_min;
        private Button button_max;
        private TextBox textBox_max;
        private Button button_sum;
        private TextBox textBox_sum;
        private Button button_average;
        private TextBox textBox_average;
        private Button button_delete;
        private Button button_close;

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
            this.label_title = new Label();
            this.textBox_count = new TextBox();
            this.button_generate = new Button();
            this.listBox_numbers = new ListBox();
            this.button_min = new Button();
            this.textBox_min = new TextBox();
            this.button_max = new Button();
            this.textBox_max = new TextBox();
            this.button_sum = new Button();
            this.textBox_sum = new TextBox();
            this.button_average = new Button();
            this.textBox_average = new TextBox();
            this.button_delete = new Button();
            this.button_close = new Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new Point(12, 22);
            this.label_title.Name = "label_title";
            this.label_title.Size = new Size(150, 30);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Enter how many numbers \r\nyou want to generate";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new Point(181, 29);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new Size(56, 20);
            this.textBox_count.TabIndex = 1;
            // 
            // button_generate
            // 
            this.button_generate.Location = new Point(252, 27);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new Size(75, 23);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // listBox_numbers
            // 
            this.listBox_numbers.FormattingEnabled = true;
            this.listBox_numbers.Location = new Point(15, 81);
            this.listBox_numbers.Name = "listBox_numbers";
            this.listBox_numbers.Size = new Size(147, 121);
            this.listBox_numbers.TabIndex = 3;
            // 
            // button_min
            // 
            this.button_min.Location = new Point(252, 81);
            this.button_min.Name = "button_min";
            this.button_min.Size = new Size(75, 23);
            this.button_min.TabIndex = 5;
            this.button_min.Text = "Min";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // textBox_min
            // 
            this.textBox_min.Enabled = false;
            this.textBox_min.Location = new Point(181, 83);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new Size(56, 20);
            this.textBox_min.TabIndex = 4;
            // 
            // button_max
            // 
            this.button_max.Location = new Point(252, 110);
            this.button_max.Name = "button_max";
            this.button_max.Size = new Size(75, 23);
            this.button_max.TabIndex = 7;
            this.button_max.Text = "Max";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // textBox_max
            // 
            this.textBox_max.Enabled = false;
            this.textBox_max.Location = new Point(181, 112);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new Size(56, 20);
            this.textBox_max.TabIndex = 6;
            // 
            // button_sum
            // 
            this.button_sum.Location = new Point(252, 150);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new Size(75, 23);
            this.button_sum.TabIndex = 9;
            this.button_sum.Text = "Sum";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // textBox_sum
            // 
            this.textBox_sum.Enabled = false;
            this.textBox_sum.Location = new Point(181, 152);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new Size(56, 20);
            this.textBox_sum.TabIndex = 8;
            // 
            // button_average
            // 
            this.button_average.Location = new Point(252, 179);
            this.button_average.Name = "button_average";
            this.button_average.Size = new Size(75, 23);
            this.button_average.TabIndex = 11;
            this.button_average.Text = "Average";
            this.button_average.UseVisualStyleBackColor = true;
            this.button_average.Click += new System.EventHandler(this.button_average_Click);
            // 
            // textBox_average
            // 
            this.textBox_average.Enabled = false;
            this.textBox_average.Location = new Point(181, 181);
            this.textBox_average.Name = "textBox_average";
            this.textBox_average.Size = new Size(56, 20);
            this.textBox_average.TabIndex = 10;
            // 
            // button_delete
            // 
            this.button_delete.Location = new Point(15, 217);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new Size(75, 23);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new Point(252, 217);
            this.button_close.Name = "button_close";
            this.button_close.Size = new Size(75, 23);
            this.button_close.TabIndex = 13;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(348, 252);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_average);
            this.Controls.Add(this.textBox_average);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.listBox_numbers);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label_title);
            this.Name = "MinMaxAverageForm";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

