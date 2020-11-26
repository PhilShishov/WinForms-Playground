namespace MathWorld
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormMathWorld
    {
        private IContainer components = null;

        private RadioButton radioButton_triangle;
        private RadioButton radioButton_square;
        private RadioButton radioButton_rectangle;
        private Label label_a;
        private TextBox textBox_a;
        private TextBox textBox_b;
        private Label label_b;
        private TextBox textBox_c;
        private Label label_c;
        private Label label_perimeter;
        private Label label_surface;
        private Button button_calculate;

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
            this.radioButton_triangle = new RadioButton();
            this.radioButton_square = new RadioButton();
            this.radioButton_rectangle = new RadioButton();
            this.label_a = new Label();
            this.textBox_a = new TextBox();
            this.textBox_b = new TextBox();
            this.label_b = new Label();
            this.textBox_c = new TextBox();
            this.label_c = new Label();
            this.label_perimeter = new Label();
            this.label_surface = new Label();
            this.button_calculate = new Button();
            this.SuspendLayout();
            // 
            // radioButton_triangle
            // 
            this.radioButton_triangle.AutoSize = true;
            this.radioButton_triangle.Location = new Point(12, 12);
            this.radioButton_triangle.Name = "radioButton_triangle";
            this.radioButton_triangle.Size = new Size(63, 17);
            this.radioButton_triangle.TabIndex = 0;
            this.radioButton_triangle.TabStop = true;
            this.radioButton_triangle.Text = "Triangle";
            this.radioButton_triangle.UseVisualStyleBackColor = true;
            this.radioButton_triangle.CheckedChanged += new EventHandler(this.radioButton_triangle_CheckedChanged);
            // 
            // radioButton_square
            // 
            this.radioButton_square.AutoSize = true;
            this.radioButton_square.Location = new Point(99, 12);
            this.radioButton_square.Name = "radioButton_square";
            this.radioButton_square.Size = new Size(59, 17);
            this.radioButton_square.TabIndex = 1;
            this.radioButton_square.TabStop = true;
            this.radioButton_square.Text = "Square";
            this.radioButton_square.UseVisualStyleBackColor = true;
            this.radioButton_square.CheckedChanged += new EventHandler(this.radioButton_square_CheckedChanged);
            // 
            // radioButton_rectangle
            // 
            this.radioButton_rectangle.AutoSize = true;
            this.radioButton_rectangle.Location = new Point(183, 12);
            this.radioButton_rectangle.Name = "radioButton_rectangle";
            this.radioButton_rectangle.Size = new Size(74, 17);
            this.radioButton_rectangle.TabIndex = 2;
            this.radioButton_rectangle.TabStop = true;
            this.radioButton_rectangle.Text = "Rectangle";
            this.radioButton_rectangle.UseVisualStyleBackColor = true;
            this.radioButton_rectangle.CheckedChanged += new EventHandler(this.radioButton_rectangle_CheckedChanged);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new Point(9, 67);
            this.label_a.Name = "label_a";
            this.label_a.Size = new Size(26, 13);
            this.label_a.TabIndex = 3;
            this.label_a.Text = "A = ";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new Point(41, 64);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new Size(69, 20);
            this.textBox_a.TabIndex = 4;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new Point(41, 90);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new Size(69, 20);
            this.textBox_b.TabIndex = 6;
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new Point(9, 93);
            this.label_b.Name = "label_b";
            this.label_b.Size = new Size(26, 13);
            this.label_b.TabIndex = 5;
            this.label_b.Text = "B = ";
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new Point(41, 116);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new Size(69, 20);
            this.textBox_c.TabIndex = 8;
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new Point(9, 119);
            this.label_c.Name = "label_c";
            this.label_c.Size = new Size(26, 13);
            this.label_c.TabIndex = 7;
            this.label_c.Text = "C = ";
            // 
            // label_perimeter
            // 
            this.label_perimeter.AutoSize = true;
            this.label_perimeter.Location = new Point(162, 67);
            this.label_perimeter.Name = "label_perimeter";
            this.label_perimeter.Size = new Size(23, 13);
            this.label_perimeter.TabIndex = 9;
            this.label_perimeter.Text = "P =";
            // 
            // label_surface
            // 
            this.label_surface.AutoSize = true;
            this.label_surface.Location = new Point(162, 93);
            this.label_surface.Name = "label_surface";
            this.label_surface.Size = new Size(23, 13);
            this.label_surface.TabIndex = 10;
            this.label_surface.Text = "S =";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new Point(165, 114);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new Size(92, 23);
            this.button_calculate.TabIndex = 11;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new EventHandler(this.button_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 262);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.label_surface);
            this.Controls.Add(this.label_perimeter);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.radioButton_rectangle);
            this.Controls.Add(this.radioButton_square);
            this.Controls.Add(this.radioButton_triangle);
            this.Name = "MathWorldForm";
            this.Text = "Math World";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}