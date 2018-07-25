using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Borrowers_UserControl : UserControl
    {
        private static Borrowers_UserControl _instance;

        public static Borrowers_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrowers_UserControl();
                }
                return _instance;
            }
        }

        public Borrowers_UserControl()
        {
            InitializeComponent();
        }

        public string Book1, Book2, Borrower;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public SqlCommand cmd;

        private void searchbook_textbox_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT borrower  FROM books where accNo='" + accnosearch_textbox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label9.Text = Borrower = dr[0].ToString();
            con.Close();
        }

        private void issuebook_textbox_Click(object sender, EventArgs e)
        {
            searchbook_textbox.PerformClick();
            if (Borrower != "")
            {
                MessageBox.Show("Book is already borrowed by someone with id:\n" + Borrower);
                return;
            }

            searchborrowers_button.PerformClick();
            if ((Book1 != "") && (Book2 != ""))
            {
                MessageBox.Show("borrower has already borrowed maximum number of books");
                return;
            }

            try
            {
                if (Book1 == "")
                {
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);

                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accno", accnosearch_textbox.Text);
                cmd.Parameters.AddWithValue("@brid", borrowersid_textbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invali sql operation \n" + ex);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", accnosearch_textbox.Text);
            cmd.Parameters.AddWithValue("@brid", borrowersid_textbox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid sql operation\n" + ex);
            }
            con.Close();

            searchbook_textbox.PerformClick();
            searchborrowers_button.PerformClick();
            MessageBox.Show("Success");

        }

        private void returnbook_textbox_Click(object sender, EventArgs e)
        {
            searchbook_textbox.PerformClick();
            searchborrowers_button.PerformClick();
            if ((accnosearch_textbox.Text != Book1)&&(accnosearch_textbox.Text!= Book2))
            {
                MessageBox.Show("the inputed borrower has not borrowed the book inputed");
                return;
            }

           

            try
            {
                if (Book1 == accnosearch_textbox.Text)
                {
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);

                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accno",(object)DBNull.Value);
                cmd.Parameters.AddWithValue("@brid", borrowersid_textbox.Text);



                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid sql operation \n" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", accnosearch_textbox.Text);
            cmd.Parameters.AddWithValue("@brid", (object)DBNull.Value);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid sql operation\n" + ex);
            }
            con.Close();

            searchbook_textbox.PerformClick();
            searchborrowers_button.PerformClick();
            MessageBox.Show("Success");
        }

        public SqlDataReader dr;

        private void searchborrowers_button_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT Book1 FROM Borrowers where brId ='"+borrowersid_textbox.Text+"'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label6.Text = Book1 = dr[0].ToString();
            con.Close();

            con.Open();
            syntax = "SELECT Book2 FROM Borrowers where brId ='" + borrowersid_textbox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label7.Text = Book2 = dr[0].ToString();
            con.Close();
        }
    }
}
