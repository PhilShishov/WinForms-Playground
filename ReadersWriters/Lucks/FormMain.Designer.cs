namespace Lucks
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormMain
    {
        private IContainer components = null;

        private Button button_getLuck;
        private Label label_luck;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lucksToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem viewAllToolStripMenuItem;

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
            this.button_getLuck = new Button();
            this.label_luck = new Label();
            this.menuStrip1 = new MenuStrip();
            this.lucksToolStripMenuItem = new ToolStripMenuItem();
            this.addNewToolStripMenuItem = new ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_getLuck
            // 
            this.button_getLuck.Dock = DockStyle.Bottom;
            this.button_getLuck.Location = new Point(0, 136);
            this.button_getLuck.Name = "button_getLuck";
            this.button_getLuck.Size = new Size(277, 38);
            this.button_getLuck.TabIndex = 0;
            this.button_getLuck.Text = "Get Luck";
            this.button_getLuck.UseVisualStyleBackColor = true;
            this.button_getLuck.Click += new System.EventHandler(this.button_getLuck_Click);
            // 
            // label_luck
            // 
            this.label_luck.AutoSize = true;
            this.label_luck.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.label_luck.Location = new Point(88, 54);
            this.label_luck.Name = "label_luck";
            this.label_luck.Size = new Size(58, 25);
            this.label_luck.TabIndex = 1;
            this.label_luck.Text = "Luck";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.lucksToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(277, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lucksToolStripMenuItem
            // 
            this.lucksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.viewAllToolStripMenuItem});
            this.lucksToolStripMenuItem.Name = "lucksToolStripMenuItem";
            this.lucksToolStripMenuItem.Size = new Size(49, 20);
            this.lucksToolStripMenuItem.Text = "Lucks";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Alt | Keys.A)));
            this.addNewToolStripMenuItem.Size = new Size(159, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new Size(159, 22);
            this.viewAllToolStripMenuItem.Text = "View All";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightSteelBlue;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(277, 174);
            this.Controls.Add(this.label_luck);
            this.Controls.Add(this.button_getLuck);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Main View";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}