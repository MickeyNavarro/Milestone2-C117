namespace Milestone2_REDO
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.listBox_myClothes = new System.Windows.Forms.ListBox();
            this.tab_add = new System.Windows.Forms.TabPage();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_mark = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.textBox_material = new System.Windows.Forms.TextBox();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_restock = new System.Windows.Forms.TabPage();
            this.listBox_restock = new System.Windows.Forms.ListBox();
            this.tab_remove = new System.Windows.Forms.TabPage();
            this.listBox_remove = new System.Windows.Forms.ListBox();
            this.tab_search = new System.Windows.Forms.TabPage();
            this.dataGridView_srch = new System.Windows.Forms.DataGridView();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_type_srch = new System.Windows.Forms.ComboBox();
            this.comboBox_cat_srch = new System.Windows.Forms.ComboBox();
            this.textBox_col_srch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_home.SuspendLayout();
            this.tab_add.SuspendLayout();
            this.tab_restock.SuspendLayout();
            this.tab_remove.SuspendLayout();
            this.tab_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_srch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_home);
            this.tabControl1.Controls.Add(this.tab_add);
            this.tabControl1.Controls.Add(this.tab_restock);
            this.tabControl1.Controls.Add(this.tab_remove);
            this.tabControl1.Controls.Add(this.tab_search);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 569);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_home
            // 
            this.tab_home.Controls.Add(this.listBox_myClothes);
            this.tab_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_home.Location = new System.Drawing.Point(4, 34);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(1013, 531);
            this.tab_home.TabIndex = 1;
            this.tab_home.Text = "Home";
            this.tab_home.UseVisualStyleBackColor = true;
            // 
            // listBox_myClothes
            // 
            this.listBox_myClothes.FormattingEnabled = true;
            this.listBox_myClothes.ItemHeight = 31;
            this.listBox_myClothes.Location = new System.Drawing.Point(0, 6);
            this.listBox_myClothes.Name = "listBox_myClothes";
            this.listBox_myClothes.Size = new System.Drawing.Size(1013, 531);
            this.listBox_myClothes.TabIndex = 0;
            // 
            // tab_add
            // 
            this.tab_add.Controls.Add(this.textBox_quantity);
            this.tab_add.Controls.Add(this.label_quantity);
            this.tab_add.Controls.Add(this.label6);
            this.tab_add.Controls.Add(this.comboBox_mark);
            this.tab_add.Controls.Add(this.comboBox_type);
            this.tab_add.Controls.Add(this.comboBox_category);
            this.tab_add.Controls.Add(this.button_add);
            this.tab_add.Controls.Add(this.textBox_comment);
            this.tab_add.Controls.Add(this.textBox_material);
            this.tab_add.Controls.Add(this.textBox_color);
            this.tab_add.Controls.Add(this.label5);
            this.tab_add.Controls.Add(this.label4);
            this.tab_add.Controls.Add(this.label3);
            this.tab_add.Controls.Add(this.label2);
            this.tab_add.Controls.Add(this.label1);
            this.tab_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_add.Location = new System.Drawing.Point(4, 34);
            this.tab_add.Name = "tab_add";
            this.tab_add.Padding = new System.Windows.Forms.Padding(3);
            this.tab_add.Size = new System.Drawing.Size(1013, 531);
            this.tab_add.TabIndex = 0;
            this.tab_add.Text = "Add";
            this.tab_add.UseVisualStyleBackColor = true;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(172, 184);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(835, 38);
            this.textBox_quantity.TabIndex = 16;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(42, 187);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(124, 31);
            this.label_quantity.TabIndex = 15;
            this.label_quantity.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Comments:";
            // 
            // comboBox_mark
            // 
            this.comboBox_mark.FormattingEnabled = true;
            this.comboBox_mark.Items.AddRange(new object[] {
            "Keep",
            "Donate",
            "Sell"});
            this.comboBox_mark.Location = new System.Drawing.Point(172, 274);
            this.comboBox_mark.Name = "comboBox_mark";
            this.comboBox_mark.Size = new System.Drawing.Size(835, 39);
            this.comboBox_mark.TabIndex = 13;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Casual ",
            "Formal",
            "School",
            "Work",
            "Costume",
            "Other"});
            this.comboBox_type.Location = new System.Drawing.Point(172, 51);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(835, 39);
            this.comboBox_type.TabIndex = 12;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "Shirt(s)",
            "Tank(s)",
            "Jacket(s)",
            "Pants",
            "Shorts",
            "Skirt(s)",
            "Dress(es)",
            "Misc."});
            this.comboBox_category.Location = new System.Drawing.Point(172, 6);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(835, 39);
            this.comboBox_category.TabIndex = 11;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(887, 474);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(120, 51);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(172, 230);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(835, 38);
            this.textBox_comment.TabIndex = 9;
            // 
            // textBox_material
            // 
            this.textBox_material.Location = new System.Drawing.Point(172, 96);
            this.textBox_material.Name = "textBox_material";
            this.textBox_material.Size = new System.Drawing.Size(835, 38);
            this.textBox_material.TabIndex = 7;
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(172, 140);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(835, 38);
            this.textBox_color.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marked as:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // tab_restock
            // 
            this.tab_restock.Controls.Add(this.listBox_restock);
            this.tab_restock.Location = new System.Drawing.Point(4, 34);
            this.tab_restock.Name = "tab_restock";
            this.tab_restock.Size = new System.Drawing.Size(1013, 531);
            this.tab_restock.TabIndex = 2;
            this.tab_restock.Text = "Restock";
            this.tab_restock.UseVisualStyleBackColor = true;
            // 
            // listBox_restock
            // 
            this.listBox_restock.FormattingEnabled = true;
            this.listBox_restock.ItemHeight = 25;
            this.listBox_restock.Location = new System.Drawing.Point(0, 0);
            this.listBox_restock.Name = "listBox_restock";
            this.listBox_restock.Size = new System.Drawing.Size(1013, 529);
            this.listBox_restock.TabIndex = 0;
            // 
            // tab_remove
            // 
            this.tab_remove.Controls.Add(this.listBox_remove);
            this.tab_remove.Location = new System.Drawing.Point(4, 34);
            this.tab_remove.Name = "tab_remove";
            this.tab_remove.Size = new System.Drawing.Size(1013, 531);
            this.tab_remove.TabIndex = 3;
            this.tab_remove.Text = "Remove";
            this.tab_remove.UseVisualStyleBackColor = true;
            // 
            // listBox_remove
            // 
            this.listBox_remove.FormattingEnabled = true;
            this.listBox_remove.ItemHeight = 25;
            this.listBox_remove.Location = new System.Drawing.Point(0, 0);
            this.listBox_remove.Name = "listBox_remove";
            this.listBox_remove.Size = new System.Drawing.Size(1017, 529);
            this.listBox_remove.TabIndex = 0;
            // 
            // tab_search
            // 
            this.tab_search.Controls.Add(this.dataGridView_srch);
            this.tab_search.Controls.Add(this.button_search);
            this.tab_search.Controls.Add(this.comboBox_type_srch);
            this.tab_search.Controls.Add(this.comboBox_cat_srch);
            this.tab_search.Controls.Add(this.textBox_col_srch);
            this.tab_search.Controls.Add(this.label12);
            this.tab_search.Controls.Add(this.label13);
            this.tab_search.Controls.Add(this.label14);
            this.tab_search.Location = new System.Drawing.Point(4, 34);
            this.tab_search.Name = "tab_search";
            this.tab_search.Padding = new System.Windows.Forms.Padding(3);
            this.tab_search.Size = new System.Drawing.Size(1013, 531);
            this.tab_search.TabIndex = 4;
            this.tab_search.Text = "Search";
            this.tab_search.UseVisualStyleBackColor = true;
            // 
            // dataGridView_srch
            // 
            this.dataGridView_srch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_srch.Location = new System.Drawing.Point(348, 0);
            this.dataGridView_srch.Name = "dataGridView_srch";
            this.dataGridView_srch.Size = new System.Drawing.Size(662, 531);
            this.dataGridView_srch.TabIndex = 32;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(123, 161);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(120, 51);
            this.button_search.TabIndex = 31;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // comboBox_type_srch
            // 
            this.comboBox_type_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_type_srch.FormattingEnabled = true;
            this.comboBox_type_srch.Items.AddRange(new object[] {
            "Casual ",
            "Formal",
            "School",
            "Work",
            "Costume",
            "Other"});
            this.comboBox_type_srch.Location = new System.Drawing.Point(172, 51);
            this.comboBox_type_srch.Name = "comboBox_type_srch";
            this.comboBox_type_srch.Size = new System.Drawing.Size(170, 39);
            this.comboBox_type_srch.TabIndex = 29;
            // 
            // comboBox_cat_srch
            // 
            this.comboBox_cat_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cat_srch.FormattingEnabled = true;
            this.comboBox_cat_srch.Location = new System.Drawing.Point(172, 6);
            this.comboBox_cat_srch.Name = "comboBox_cat_srch";
            this.comboBox_cat_srch.Size = new System.Drawing.Size(170, 39);
            this.comboBox_cat_srch.TabIndex = 28;
            // 
            // textBox_col_srch
            // 
            this.textBox_col_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_col_srch.Location = new System.Drawing.Point(172, 96);
            this.textBox_col_srch.Name = "textBox_col_srch";
            this.textBox_col_srch.Size = new System.Drawing.Size(170, 38);
            this.textBox_col_srch.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 31);
            this.label12.TabIndex = 25;
            this.label12.Text = "Color:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 31);
            this.label13.TabIndex = 24;
            this.label13.Text = "Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 31);
            this.label14.TabIndex = 23;
            this.label14.Text = "Category:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ClothingInventory";
            this.tabControl1.ResumeLayout(false);
            this.tab_home.ResumeLayout(false);
            this.tab_add.ResumeLayout(false);
            this.tab_add.PerformLayout();
            this.tab_restock.ResumeLayout(false);
            this.tab_remove.ResumeLayout(false);
            this.tab_search.ResumeLayout(false);
            this.tab_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_srch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.ListBox listBox_myClothes;
        private System.Windows.Forms.TabPage tab_add;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_mark;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.TextBox textBox_material;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_restock;
        private System.Windows.Forms.ListBox listBox_restock;
        private System.Windows.Forms.TabPage tab_remove;
        private System.Windows.Forms.ListBox listBox_remove;
        private System.Windows.Forms.TabPage tab_search;
        private System.Windows.Forms.DataGridView dataGridView_srch;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_type_srch;
        private System.Windows.Forms.ComboBox comboBox_cat_srch;
        private System.Windows.Forms.TextBox textBox_col_srch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}