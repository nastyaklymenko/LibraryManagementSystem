using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUserName() {
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private String getPassword()
        {
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String Uname = getUserName(), UPass = getPassword()  , name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname) && pass.Equals(UPass))
            {
                label4.Hide();
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();
            }
            else {
                label4.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
