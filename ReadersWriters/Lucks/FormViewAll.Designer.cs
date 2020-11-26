namespace Lucks
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormViewAll
    {
        private IContainer components = null;

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
            this.listBox_lucks = new ListBox();
            this.SuspendLayout();
            // 
            // listBox_lucks
            // 
            this.listBox_lucks.FormattingEnabled = true;
            this.listBox_lucks.Location = new Point(12, 12);
            this.listBox_lucks.Name = "listBox_lucks";
            this.listBox_lucks.Size = new Size(187, 121);
            this.listBox_lucks.TabIndex = 0;
            // 
            // FormViewAll
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(215, 143);
            this.Controls.Add(this.listBox_lucks);
            this.Name = "FormViewAll";
            this.Text = "FormViewAll";
            this.Load += new EventHandler(this.FormViewAll_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_lucks;
    }
}