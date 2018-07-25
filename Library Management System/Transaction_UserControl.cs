using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Transaction_UserControl : UserControl
    {
        private static Transaction_UserControl _instance;

        public static Transaction_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transaction_UserControl();
                }
                return _instance;
            }
        }

        public Transaction_UserControl()
        {
            InitializeComponent();
        }
    }
}
