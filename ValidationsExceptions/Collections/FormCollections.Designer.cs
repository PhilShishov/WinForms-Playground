namespace Collections
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormCollections
    {        
        private IContainer components = null;

        private ListBox listBox_items;
        private TextBox textBox_add;
        private Button button_add;
        private Button button_delete;
        private TextBox textBox_update;
        private Button button_update;
        private Button button_clearAll;
        private Label label_count;
        private Button button_search;
        private TextBox textBox_search;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBox_items = new ListBox();
            this.textBox_add = new TextBox();
            this.button_add = new Button();
            this.button_delete = new Button();
            this.textBox_update = new TextBox();
            this.button_update = new Button();
            this.button_clearAll = new Button();
            this.label_count = new Label();
            this.button_search = new Button();
            this.textBox_search = new TextBox();
            this.SuspendLayout();
            // 
            // listBox_items
            // 
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.Location = new Point(12, 42);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.Size = new Size(113, 121);
            this.listBox_items.TabIndex = 0;
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new Point(12, 12);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new Size(113, 20);
            this.textBox_add.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new Point(164, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new Size(87, 21);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new Point(164, 42);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new Size(87, 21);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_update
            // 
            this.textBox_update.Location = new Point(12, 169);
            this.textBox_update.Name = "textBox_update";
            this.textBox_update.Size = new Size(113, 20);
            this.textBox_update.TabIndex = 4;
            // 
            // button_update
            // 
            this.button_update.Location = new Point(164, 168);
            this.button_update.Name = "button_update";
            this.button_update.Size = new Size(87, 21);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_clearAll
            // 
            this.button_clearAll.Location = new Point(164, 69);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new Size(87, 21);
            this.button_clearAll.TabIndex = 6;
            this.button_clearAll.Text = "Clear All";
            this.button_clearAll.UseVisualStyleBackColor = true;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new Point(161, 104);
            this.label_count.Name = "label_count";
            this.label_count.Size = new Size(41, 13);
            this.label_count.TabIndex = 7;
            this.label_count.Text = "Count: ";
            // 
            // button_search
            // 
            this.button_search.Location = new Point(164, 195);
            this.button_search.Name = "button_search";
            this.button_search.Size = new Size(87, 21);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new Point(12, 196);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new Size(113, 20);
            this.textBox_search.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 235);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.button_clearAll);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.listBox_items);
            this.Name = "CollectionsForm";
            this.Text = "Collections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

