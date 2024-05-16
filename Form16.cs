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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPublisherID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPublisherID.Text == "Publisher ID")
            {
                txtPublisherID.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNewName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNewName.Text == "New Name")
            {
                txtNewName.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPublisherID.Text != "" && txtNewName.Text != "")
            {
                int PublisherID=int.Parse(txtPublisherID.Text);
                string NewName=txtNewName.Text;
               
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select * from Publisher where publisher_id='" + txtPublisherID.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    cmd.CommandText = "update Publisher set Name='" + NewName + "' where publisher_id='" + PublisherID + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Updated and Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("This INFO Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                txtNewName.Clear();
                txtPublisherID.Clear();


            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //
        }
    }
}
