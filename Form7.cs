using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStudentID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtStudentID.Text == "Student ID")
            {
                txtStudentID.Clear();
            }
        }

        private void txtBookID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBookID.Text == "Book ID")
            {
                txtBookID.Clear();
            }
        }

        private void txtDatetoday_TextChanged(object sender, EventArgs e)
        {
            if (txtDatetoday.Text == "21-5-2024")
            {
                txtDatetoday.Clear();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            if (txtStudentID.Text != "" && txtBookID.Text != "" && txtDatetoday.Text != "")
            {
                int studentId = int.Parse(txtStudentID.Text);
                int bookID = int.Parse(txtBookID.Text);
                string date = txtDatetoday.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select * from BorrowedBooks where student_id='" + studentId + "' and bookk_id='" + bookID + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    cmd.CommandText = "update Fine set amount+=1 , status='have fine' where student_id_of_fine='" + studentId + "' and book_id_of_fine ='" + bookID + "' and end_date_borrowing_of_book <'" + date + "' ";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "Delete from BorrowedBooks where student_id='" + studentId + "' and bookk_id='" + bookID + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Returned...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("This INFO Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                txtStudentID.Clear();
                txtBookID.Clear();
                txtDatetoday.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

