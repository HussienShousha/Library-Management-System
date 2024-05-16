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
    public partial class Form8 : Form
    {

        SqlConnection con = new SqlConnection("data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private string sql;
        public Form8()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "select * from Student where stu_id='" + textBox1.Text + "'";
            searchData(sql, dataGridView1);

        }

        private void Form8_Load(object sender, EventArgs e)
        {

            sql = "select * from Student";
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
    }
}
