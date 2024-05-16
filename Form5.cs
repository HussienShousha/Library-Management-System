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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "" && txtBookID.Text != "")
            {
                int studentId = int.Parse(txtStudentID.Text);
                int bookId = int.Parse(txtBookID.Text);
                string startdateborrowing = txtstart_date_borrowing.Text;
                string enddateborrowing = txtend_date_borrowing.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select * from BorrowedBooks where student_id='" + studentId + "' and bookk_id ='" + bookId + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    cmd.CommandText = "insert into BorrowedBooks(student_id,bookk_id,start_date_borrowing,end_date_borrowing) values ('" + studentId + "','" + bookId + "','" + startdateborrowing + "','" + enddateborrowing + "')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "insert into Fine(student_id_of_fine,book_id_of_fine,end_date_borrowing_of_book)values('" + studentId + "','" + bookId + "','" + enddateborrowing + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("This INFO Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                txtStudentID.Clear();
                txtBookID.Clear();
                txtstart_date_borrowing.Clear();
                txtend_date_borrowing.Clear();


            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtstart_date_borrowing_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtstart_date_borrowing.Text == "start_date_borrowing")
            {
                txtstart_date_borrowing.Clear();
            }
        }

        private void txtend_date_borrowing_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtend_date_borrowing.Text == "end_date_borrowing")
            {
                txtend_date_borrowing.Clear();
            }
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
