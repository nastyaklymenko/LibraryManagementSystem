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


    public partial class Books_UserControl : UserControl
    {

        private static Books_UserControl _instance;

        public static Books_UserControl Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new Books_UserControl();
                }
                return _instance;
            }
        }
        public Books_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");


        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBooksData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

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
                dataGridView1.DataSource = DS.Tables[0];
                /*this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void addNew_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", accNo_textbox.Text);
            cmd.Parameters.AddWithValue("@isbn", ISBN_textbox.Text);
            cmd.Parameters.AddWithValue("@name", Name_textbox.Text);
            cmd.Parameters.AddWithValue("@author", Author_textbox.Text);
            cmd.Parameters.AddWithValue("@publisher", Publisher_textbox.Text);
            cmd.Parameters.AddWithValue("@dId", department_combobox.Text);
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
            refresh_DataGridView();
        }

        private void Books_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", accNo_textbox.Text);
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
                refresh_DataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchBook_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", BookSearch_textbox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


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
                dataGridView1.DataSource = DS.Tables[0];
                /*this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
           
                SqlCommand cmd = new SqlCommand("Update_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", accNo_textbox.Text);
                cmd.Parameters.AddWithValue("@isbn", ISBN_textbox.Text);
                cmd.Parameters.AddWithValue("@name", Name_textbox.Text);
                cmd.Parameters.AddWithValue("@author", Author_textbox.Text);
                cmd.Parameters.AddWithValue("@publisher", Publisher_textbox.Text);
                cmd.Parameters.AddWithValue("@dId", department_combobox.Text);
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
                refresh_DataGridView();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            BookSearch_textbox.Text = "";
            accNo_textbox.Text = "";
            Name_textbox.Text = "";
            Publisher_textbox.Text = "";
            ISBN_textbox.Text = "";
            Author_textbox.Text = "";
            department_combobox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
