using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class AppBody : Form
    {

        public AppBody()
        {
            InitializeComponent();

            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();
        }

        private void Log_in_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_Timer.Stop();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        public void expandSlidingPanelGUI()
        {
            BooksTabButton.Text = "BOOKS";
            BorrowersTabButton.Text = "BORROWERS";
            TransactionTabButton.Text = "TRANSACTION";
            SettingsTabButton.Text = "SETTINGS";
            AboutTabButton.Text = "ABOUT";

            

        }

        public void retractSlidingPanelGUI()
        {
            BooksTabButton.Text = "B";
            BorrowersTabButton.Text = "BR";
            TransactionTabButton.Text = "T";
            SettingsTabButton.Text = "S";
            AboutTabButton.Text = "A";

        }


        //
        bool isSlidingPanelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;

        private void SlidingPannel_ToggleButton_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                retractSlidingPanelGUI();
            }
            SlidingPanel_Timer.Start();
        }

        private void SlidingPanel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                SlidingPanel.Width -= 30;
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    isSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }

            else
            {
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width>= MaxSliderWidth)
                {
                    isSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();
                    retractSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }

        private void BooksTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Books_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Books_UserControl.Instance);
                Books_UserControl.Instance.Dock = DockStyle.Fill;
                Books_UserControl.Instance.BringToFront();
            }
            else
            {
                Books_UserControl.Instance.BringToFront();
            }
        }

         
        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Settings_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock = DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl.Instance.BringToFront();
            }
        }

    

        private void BorrowersTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Borrowers_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Borrowers_UserControl.Instance);
                Borrowers_UserControl.Instance.Dock = DockStyle.Fill;
                Borrowers_UserControl.Instance.BringToFront();
            }
            else
            {
                Borrowers_UserControl.Instance.BringToFront();
            }
        }

        private void TransactionTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Transaction_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Transaction_UserControl.Instance);
                Transaction_UserControl.Instance.Dock = DockStyle.Fill;
                Transaction_UserControl.Instance.BringToFront();
            }
            else
            {
                Transaction_UserControl.Instance.BringToFront();
            }
        }

        private void AboutTabButton_Click_1(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPannel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }
    }
}
