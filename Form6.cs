using System.Data;
using System.Data.SqlClient;


namespace Library_Management_System
{
    public partial class Form6 : Form

    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private string sql;
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "select title,author_name,category,book_id from Book join BorrowedBooks on Book.book_id=BorrowedBooks.bookk_id where BorrowedBooks.student_id='" + textBox1.Text + "'";

            searchData(sql, dataGridView1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            sql = "select * from BorrowedBooks";
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
