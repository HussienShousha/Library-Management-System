using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtName_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Clear();
            }
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

        private void txtStudentID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtStudentID.Text == "Student ID")
            {
                txtStudentID.Clear();
            }
        }

        private void txtUniversityEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUniversityEmail.Text == "University Email")
            {
                txtUniversityEmail.Clear();
            }
        }

        private void txtDepartmentName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDepartmentName.Text == "Department Name")
            {
                txtDepartmentName.Clear();
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

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

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
            cmd.CommandText = "select * from Student where Name='" + txtName.Text + "' and username ='" + txtUserName.Text + "' and password ='" + txtPassword.Text + "' and stu_id ='" + txtStudentID.Text + "' and uni_mail ='" + txtUniversityEmail.Text + "' and dept_name ='" + txtDepartmentName.Text + "' and gender ='" + txtGender.Text + "' and age ='" + txtAge.Text + "' and phone ='" + txtPhoneNumber.Text + "' and SSN='" + txtSSN.Text + "' and address = '" + txtAddress.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                DashboardofForm2 dashboardofForm2 = new DashboardofForm2();
                dashboardofForm2.Show();
            }
            else
            {
                MessageBox.Show("Wrong INFO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtGender_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtGender.Text == "Gender")
            {
                txtGender.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (txtName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtStudentID.Text != "" && txtUniversityEmail.Text != "" && txtDepartmentName.Text != "" && txtGender.Text != "" && txtAge.Text != "" && txtPhoneNumber.Text != "" && txtSSN.Text != "" && txtAddress.Text != "")
            {
                string name = txtName.Text;
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                int studentID = int.Parse(txtStudentID.Text);
                string universityEmail = txtUniversityEmail.Text;
                string departmentName = txtDepartmentName.Text;
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
                cmd.CommandText = "select * from Student where Name='" + txtName.Text + "' and username ='" + txtUserName.Text + "' and password ='" + txtPassword.Text + "' and stu_id ='" + txtStudentID.Text + "' and uni_mail ='" + txtUniversityEmail.Text + "' and dept_name ='" + txtDepartmentName.Text + "' and gender ='" + txtGender.Text + "' and age ='" + txtAge.Text + "' and phone ='" + txtPhoneNumber.Text + "' and SSN='" + txtSSN.Text + "' and address = '" + txtAddress.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    cmd.CommandText = "insert into Student(Name,username,password,stu_id,uni_mail,dept_name,gender,age,phone,SSN,address) values ('" + name + "','" + username + "','" + password + "','" + studentID + "','" + universityEmail + "','" + departmentName + "','" + gender + "','" + age + "','" + phone + "','" + ssn + "','" + address + "')";
                    cmd.ExecuteNonQuery();
                
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DashboardofForm2 dashboardofForm2 = new DashboardofForm2();
                    dashboardofForm2.Show();
                }
                else
                {
                    MessageBox.Show("This INFO Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                txtName.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                txtDepartmentName.Clear();
                txtGender.Clear();
                txtAge.Clear();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
                txtStudentID.Clear();
                txtSSN.Clear();
                txtUniversityEmail.Clear();


            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
