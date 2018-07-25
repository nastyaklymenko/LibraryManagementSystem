namespace Library_Management_System
{
    partial class Books_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookSearch_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addNew_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Publisher_textbox = new System.Windows.Forms.TextBox();
            this.ISBN_textbox = new System.Windows.Forms.TextBox();
            this.Author_textbox = new System.Windows.Forms.TextBox();
            this.accNo_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.department_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookSearch_textbox
            // 
            this.BookSearch_textbox.Location = new System.Drawing.Point(116, 27);
            this.BookSearch_textbox.Name = "BookSearch_textbox";
            this.BookSearch_textbox.Size = new System.Drawing.Size(204, 20);
            this.BookSearch_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID:";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(148, 53);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(137, 23);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search Books";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 111);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addNew_button
            // 
            this.addNew_button.Location = new System.Drawing.Point(23, 229);
            this.addNew_button.Name = "addNew_button";
            this.addNew_button.Size = new System.Drawing.Size(75, 23);
            this.addNew_button.TabIndex = 4;
            this.addNew_button.Text = "Add New";
            this.addNew_button.UseVisualStyleBackColor = true;
            this.addNew_button.Click += new System.EventHandler(this.addNew_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(116, 229);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(210, 229);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(297, 229);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 7;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Acc No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publisher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Author:";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(65, 299);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(126, 20);
            this.Name_textbox.TabIndex = 13;
            // 
            // Publisher_textbox
            // 
            this.Publisher_textbox.Location = new System.Drawing.Point(65, 335);
            this.Publisher_textbox.Name = "Publisher_textbox";
            this.Publisher_textbox.Size = new System.Drawing.Size(126, 20);
            this.Publisher_textbox.TabIndex = 14;
            // 
            // ISBN_textbox
            // 
            this.ISBN_textbox.Location = new System.Drawing.Point(274, 266);
            this.ISBN_textbox.Name = "ISBN_textbox";
            this.ISBN_textbox.Size = new System.Drawing.Size(126, 20);
            this.ISBN_textbox.TabIndex = 15;
            // 
            // Author_textbox
            // 
            this.Author_textbox.Location = new System.Drawing.Point(274, 301);
            this.Author_textbox.Name = "Author_textbox";
            this.Author_textbox.Size = new System.Drawing.Size(126, 20);
            this.Author_textbox.TabIndex = 16;
            // 
            // accNo_textbox
            // 
            this.accNo_textbox.Location = new System.Drawing.Point(65, 266);
            this.accNo_textbox.Name = "accNo_textbox";
            this.accNo_textbox.Size = new System.Drawing.Size(126, 20);
            this.accNo_textbox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Department:";
            // 
            // department_combobox
            // 
            this.department_combobox.FormattingEnabled = true;
            this.department_combobox.Location = new System.Drawing.Point(274, 338);
            this.department_combobox.Name = "department_combobox";
            this.department_combobox.Size = new System.Drawing.Size(126, 21);
            this.department_combobox.TabIndex = 19;
            // 
            // Books_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.department_combobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.accNo_textbox);
            this.Controls.Add(this.Author_textbox);
            this.Controls.Add(this.ISBN_textbox);
            this.Controls.Add(this.Publisher_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.addNew_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookSearch_textbox);
            this.Name = "Books_UserControl";
            this.Size = new System.Drawing.Size(416, 383);
            this.Load += new System.EventHandler(this.Books_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookSearch_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNew_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox Publisher_textbox;
        private System.Windows.Forms.TextBox ISBN_textbox;
        private System.Windows.Forms.TextBox Author_textbox;
        private System.Windows.Forms.TextBox accNo_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox department_combobox;
    }
}
