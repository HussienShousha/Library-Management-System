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

    public partial class Form15 : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private string sql;
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            sql = "select * from Fine";
            searchData(sql, dataGridView1);
        }
        private void searchData(string sql, DataGridView dtg)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();




                da = new SqlDataAdapter(cmd);
                dt = new DataTable();

                {
                    var withBlocks = cmd;
                    withBlocks.Connection = con;
                    withBlocks.CommandText = sql;
                }
                {
                    var withBlocks = da;
                    withBlocks.SelectCommand = cmd;
                    withBlocks.Fill(dt);
                }
                dtg.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            //
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            sql = "select Student.Name as 'Student Name',Student.stu_id as 'Student ID',Fine.book_id_of_fine,Fine.amount,Fine.status,Fine.end_date_borrowing_of_book from Student left outer join Fine on Student.stu_id=Fine.student_id_of_fine where Student.stu_id='" + txtStudentID.Text + "'";
            searchData(sql, dataGridView1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
