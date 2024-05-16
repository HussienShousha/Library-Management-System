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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "UserName")
            {
                txtUserName.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtAdminID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAdminID.Text == "Admin ID")
            {
                txtAdminID.Clear();
            }
        }

        private void txtAdminRole_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAdminRole.Text == "Admin Role")
            {
                txtAdminRole.Clear();
            }
        }

        private void txtUniversityEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUniversityEmail.Text == "University Email")
            {
                txtUniversityEmail.Clear();
            }
        }

        private void txtGender_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtGender.Text == "Gender")
            {
                txtGender.Clear();
            }
        }

        private void txtAge_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAge.Text == "Age")
            {
                txtAge.Clear();
            }
        }

        private void txtPhoneNumber_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPhoneNumber.Text == "Phone Number")
            {
                txtPhoneNumber.Clear();
            }
        }

        private void txtSSN_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSSN.Text == "SSN")
            {
                txtSSN.Clear();
            }
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Admin where Name='" + txtName.Text + "' and username ='" + txtUserName.Text + "' and password ='" + txtPassword.Text + "' and admin_id ='" + txtAdminID.Text + "'and admin_role='" + txtAdminRole + "' and uni_mail ='" + txtUniversityEmail.Text + "'  and gender ='" + txtGender.Text + "' and age ='" + txtAge.Text + "' and phone ='" + txtPhoneNumber.Text + "' and SSN='" + txtSSN.Text + "' and address = '" + txtAddress.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                DashboardofForm3 dashboardofForm3 = new DashboardofForm3();
                dashboardofForm3.Show();

            }
            else
            {
                MessageBox.Show("Wrong INFO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtAdminID.Text != ""&&txtAdminRole.Text!="" && txtUniversityEmail.Text != ""  && txtGender.Text != "" && txtAge.Text != "" && txtPhoneNumber.Text != "" && txtSSN.Text != "" && txtAddress.Text != "")
            {
                string name = txtName.Text;
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                int AdminID = int.Parse(txtAdminID.Text);
                string adminRole = txtAdminRole.Text;
                string universityEmail = txtUniversityEmail.Text;
                string gender = txtGender.Text;
                int age = int.Parse(txtAge.Text);
                string phone = txtPhoneNumber.Text;
                string ssn = txtSSN.Text;
                string address = txtAddress.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select * from Admin where Name='" + txtName.Text + "' and username ='" + txtUserName.Text + "' and password ='" + txtPassword.Text + "' and admin_id ='" + txtAdminID.Text + "'and admin_role='"+txtAdminRole+"' and uni_mail ='" + txtUniversityEmail.Text + "' and gender ='" + txtGender.Text + "' and age ='" + txtAge.Text + "' and phone ='" + txtPhoneNumber.Text + "' and SSN='" + txtSSN.Text + "' and address = '" + txtAddress.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    cmd.CommandText = "insert into Admin(Name,username,password,admin_id,admin_role,uni_mail,gender,age,phone,SSN,address) values ('" + name + "','" + username + "','" + password + "','" + AdminID + "','"+ adminRole + "','" + universityEmail + "','" + gender + "','" + age + "','" + phone + "','" + ssn + "','" + address + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DashboardofForm3 dashboardofForm3 = new DashboardofForm3();
                    dashboardofForm3.Show();
                }
                else
                {
                    MessageBox.Show("This INFO Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                txtName.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                txtAdminRole.Clear();
             
                txtGender.Clear();
                txtAge.Clear();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
                txtAdminID.Clear();
                txtSSN.Clear();
                txtUniversityEmail.Clear();


            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //
        }
    }
}
