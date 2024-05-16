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

namespace Library_Management_System
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Clear();
            }
        }

        private void txtPublisherID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPublisherID.Text == "Publisher ID")
            {
                txtPublisherID.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtPublisherID.Text != "" && txtAddress.Text != "")
            {
                string Name = txtName.Text;
                int PublisherID = int.Parse(txtPublisherID.Text);
                string Address = txtAddress.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select * from Publisher where Name='" + txtName.Text + "' and publisher_id ='" + txtPublisherID.Text + "' and address ='" + txtAddress.Text + "'  ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    cmd.CommandText = "INSERT INTO Publisher (publisher_id, Name, address)VALUES ('" + PublisherID + "','" + Name + "','" + Address + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("This Publisher Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                txtAddress.Clear();
                txtName.Clear();
                txtPublisherID.Clear();



            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Clear();
            }
        }
    }
}
