using System.Drawing;
using System.Windows.Forms;

namespace RandomNumber
{
    partial class FormRandomNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.label_generatedNum = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_start
            // 
            this.textBox_start.Location = new System.Drawing.Point(24, 31);
            this.textBox_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(90, 23);
            this.textBox_start.TabIndex = 0;
            // 
            // textBox_end
            // 
            this.textBox_end.Location = new System.Drawing.Point(212, 31);
            this.textBox_end.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.Size = new System.Drawing.Size(88, 23);
            this.textBox_end.TabIndex = 1;
            // 
            // label_generatedNum
            // 
            this.label_generatedNum.AutoSize = true;
            this.label_generatedNum.Location = new System.Drawing.Point(142, 34);
            this.label_generatedNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_generatedNum.Name = "label_generatedNum";
            this.label_generatedNum.Size = new System.Drawing.Size(38, 15);
            this.label_generatedNum.TabIndex = 2;
            this.label_generatedNum.Text = "label1";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(112, 100);
            this.button_generate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(88, 27);
            this.button_generate.TabIndex = 3;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Num";
            // 
            // FormRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.label_generatedNum);
            this.Controls.Add(this.textBox_end);
            this.Controls.Add(this.textBox_start);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormRandomNumber";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_start;
        private TextBox textBox_end;
        private Label label_generatedNum;
        private Button button_generate;
        private Label label1;
        private Label label2;
    }
}

