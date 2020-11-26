using System.Drawing;
using System.Windows.Forms;

namespace Lucks
{
    partial class FormAdd
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
            this.textBox_add = new TextBox();
            this.button_add = new Button();
            this.label_addLuck = new Label();
            this.SuspendLayout();
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new Point(85, 16);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new Size(127, 20);
            this.textBox_add.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new Point(137, 57);
            this.button_add.Name = "button_add";
            this.button_add.Size = new Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_addLuck
            // 
            this.label_addLuck.AutoSize = true;
            this.label_addLuck.Location = new Point(26, 19);
            this.label_addLuck.Name = "label_addLuck";
            this.label_addLuck.Size = new Size(52, 13);
            this.label_addLuck.TabIndex = 2;
            this.label_addLuck.Text = "Add luck:";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(235, 92);
            this.Controls.Add(this.label_addLuck);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_add);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_add;
        private Button button_add;
        private Label label_addLuck;
    }
}