using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Uname = "1", UPass = "1"  , name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname) && pass.Equals(UPass))
            {
                label4.Hide();
                MessageBox.Show("Log in success");
            }
            else {
                label4.Show();
            }
        }
    }
}
