﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-PDSAJ08\\SQLEXPRESS ; database=Library;integrated security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private string sql;

        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            sql = "select * from Book";
            searchData(sql, dataGridView1);
            //  fillCombo(sql, comboBox1);
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

        /*   private void fillCombo(string sql, ComboBox cbo)
           {
               try
               {
                   con.Open();
                   cmd = new SqlCommand();

                     da= new SqlDataAdapter();
                   dt = new DataTable();
                   {
                       var withBlocks= cmd;
                       cmd.Connection = con;
                       withBlocks.CommandText= sql;
                   }
                   {
                       var withBlocks = da;
                       withBlocks.SelectCommand = cmd;
                       withBlocks.Fill(dt);
                   }

                       cbo.DataSource = dt;
                       cbo.DisplayMember = dt.Columns[3].ColumnName;
                       cbo.ValueMember = dt.Columns[3].ColumnName;
                   con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
               finally
               {
                   con.Close();
                   da.Dispose();
               }
           }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "select Book.book_id,title as 'Book Name',author_name,category,number_of_copies,Book.publisher_id from Book where title like '%" + textBox1.Text + "%' ";
            searchData(sql, dataGridView1);
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {

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