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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtAuthorName.Text != "" && txtCategory.Text != "" && txtBookID.Text != "" && txtAdminID.Text != "" && txtNumberOfCopies.Text != "" && txtPublisherID.Text != "")
            {
                string Title = txtTitle.Text;
                string AuthorName = txtAuthorName.Text;
                string Category = txtCategory.Text;
                int BookID = int.Parse(txtBookID.Text);
                int AdminID = int.Parse(txtAdminID.Text);
                int NumOfCopies = int.Parse(txtNumberOfCopies.Text);
                int PublisherID = int.Parse(txtPublisherID.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select * from Book where title='" + txtTitle.Text + "' and author_name ='" + txtAuthorName.Text + "' and category ='" + txtCategory.Text + "' and book_id ='" + txtBookID.Text + "' and admin_id ='" + txtAdminID.Text + "' and number_of_copies ='" + txtNumberOfCopies.Text + "' and publisher_id ='" + txtPublisherID.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    cmd.CommandText = "INSERT INTO Book (title, author_name, category, book_id, admin_id, number_of_copies, publisher_id) VALUES('" + Title + "','" + AuthorName + "','" + Category + "','" + BookID + "','" + AdminID + "','" + NumOfCopies + "','" + PublisherID + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("This Book Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                txtTitle.Clear();
                txtAuthorName.Clear();
                txtCategory.Clear();
                txtBookID.Clear();
                txtAdminID.Clear();
                txtNumberOfCopies.Clear();
                txtPublisherID.Clear();



            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtTitle.Text == "Title")
            {
                txtTitle.Clear();
            }
        }

        private void txtAuthorName_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtAuthorName.Text == "Author Name")
            {
                txtAuthorName.Clear();
            }
        }

        private void txtBookID_MouseClick(object sender, MouseEventArgs e)
        {


            if (txtBookID.Text == "Book ID")
            {
                txtBookID.Clear();
            }
        }

        private void txtAdminID_MouseClick(object sender, MouseEventArgs e)
        {


            if (txtAdminID.Text == "Admin ID")
            {
                txtAdminID.Clear();
            }
        }

        private void txtNumberOfCopies_TextChanged(object sender, EventArgs e)
        {


            if (txtNumberOfCopies.Text == "Number Of Copies")
            {
                txtNumberOfCopies.Clear();
            }
        }

        private void txtPublisherID_MouseClick(object sender, MouseEventArgs e)
        {


            if (txtPublisherID.Text == "Publisher ID")
            {
                txtPublisherID.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCategory.Text == "Category")
            {
                txtCategory.Clear();
            }
        }
    }
}
