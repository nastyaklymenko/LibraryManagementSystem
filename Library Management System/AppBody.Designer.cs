namespace Library_Management_System
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.TableBarPanel = new System.Windows.Forms.Panel();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.BooksTabButton = new System.Windows.Forms.Button();
            this.BorrowersTabButton = new System.Windows.Forms.Button();
            this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPannel = new System.Windows.Forms.Panel();
            this.SlidingPannel_ToggleButton = new System.Windows.Forms.Button();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.TransactionTabButton = new System.Windows.Forms.Button();
            this.TableBarPanel.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Tick += new System.EventHandler(this.Log_in_Timer_Tick);
            // 
            // TableBarPanel
            // 
            this.TableBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TableBarPanel.Controls.Add(this.LogOffButton);
            this.TableBarPanel.Controls.Add(this.MinimizeButton);
            this.TableBarPanel.Controls.Add(this.closeButton);
            this.TableBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TableBarPanel.Name = "TableBarPanel";
            this.TableBarPanel.Size = new System.Drawing.Size(722, 33);
            this.TableBarPanel.TabIndex = 0;
            // 
            // LogOffButton
            // 
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.Location = new System.Drawing.Point(601, 0);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(31, 33);
            this.LogOffButton.TabIndex = 3;
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(638, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(31, 33);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(675, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 33);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SlidingPanel.Controls.Add(this.TransactionTabButton);
            this.SlidingPanel.Controls.Add(this.AboutTabButton);
            this.SlidingPanel.Controls.Add(this.SettingsTabButton);
            this.SlidingPanel.Controls.Add(this.BooksTabButton);
            this.SlidingPanel.Controls.Add(this.BorrowersTabButton);
            this.SlidingPanel.Controls.Add(this.SlidingPannel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 33);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(303, 383);
            this.SlidingPanel.TabIndex = 1;
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Location = new System.Drawing.Point(3, 216);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(300, 85);
            this.AboutTabButton.TabIndex = 4;
            this.AboutTabButton.Text = "ABOUT";
            this.AboutTabButton.UseVisualStyleBackColor = true;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click_1);
            // 
            // BooksTabButton
            // 
            this.BooksTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksTabButton.Location = new System.Drawing.Point(3, 20);
            this.BooksTabButton.Name = "BooksTabButton";
            this.BooksTabButton.Size = new System.Drawing.Size(300, 80);
            this.BooksTabButton.TabIndex = 2;
            this.BooksTabButton.Text = "BOOKS";
            this.BooksTabButton.UseVisualStyleBackColor = true;
            this.BooksTabButton.Click += new System.EventHandler(this.BooksTabButton_Click);
            // 
            // BorrowersTabButton
            // 
            this.BorrowersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersTabButton.Location = new System.Drawing.Point(3, 117);
            this.BorrowersTabButton.Name = "BorrowersTabButton";
            this.BorrowersTabButton.Size = new System.Drawing.Size(300, 77);
            this.BorrowersTabButton.TabIndex = 1;
            this.BorrowersTabButton.Text = "BORROWERS";
            this.BorrowersTabButton.UseVisualStyleBackColor = true;
            this.BorrowersTabButton.Click += new System.EventHandler(this.BorrowersTabButton_Click);
            // 
            // SlidingPanel_Timer
            // 
            this.SlidingPanel_Timer.Tick += new System.EventHandler(this.SlidingPanel_Timer_Tick);
            // 
            // ContentPannel
            // 
            this.ContentPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPannel.Location = new System.Drawing.Point(306, 33);
            this.ContentPannel.Name = "ContentPannel";
            this.ContentPannel.Size = new System.Drawing.Size(416, 383);
            this.ContentPannel.TabIndex = 2;
            // 
            // SlidingPannel_ToggleButton
            // 
            this.SlidingPannel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPannel_ToggleButton.Location = new System.Drawing.Point(-293, 6);
            this.SlidingPannel_ToggleButton.Name = "SlidingPannel_ToggleButton";
            this.SlidingPannel_ToggleButton.Size = new System.Drawing.Size(287, 48);
            this.SlidingPannel_ToggleButton.TabIndex = 0;
            this.SlidingPannel_ToggleButton.UseVisualStyleBackColor = true;
            this.SlidingPannel_ToggleButton.Click += new System.EventHandler(this.SlidingPannel_ToggleButton_Click);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Location = new System.Drawing.Point(-293, 216);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(287, 48);
            this.SettingsTabButton.TabIndex = 3;
            this.SettingsTabButton.Text = "SETTINGS";
            this.SettingsTabButton.UseVisualStyleBackColor = true;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // TransactionTabButton
            // 
            this.TransactionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionTabButton.Location = new System.Drawing.Point(-293, 162);
            this.TransactionTabButton.Name = "TransactionTabButton";
            this.TransactionTabButton.Size = new System.Drawing.Size(290, 48);
            this.TransactionTabButton.TabIndex = 5;
            this.TransactionTabButton.Text = "TRANSACTION";
            this.TransactionTabButton.UseVisualStyleBackColor = true;
            this.TransactionTabButton.Click += new System.EventHandler(this.TransactionTabButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 416);
            this.Controls.Add(this.ContentPannel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.TableBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TableBarPanel.ResumeLayout(false);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel TableBarPanel;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button BooksTabButton;
        private System.Windows.Forms.Button BorrowersTabButton;
        private System.Windows.Forms.Panel ContentPannel;
        private System.Windows.Forms.Button TransactionTabButton;
        private System.Windows.Forms.Button SettingsTabButton;
        private System.Windows.Forms.Button SlidingPannel_ToggleButton;
    }
}