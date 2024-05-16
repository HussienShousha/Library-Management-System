using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class DashboardofForm2 : Form
    {
        public DashboardofForm2()
        {
            InitializeComponent();
        }

        private void DashboardofForm2_Load(object sender, EventArgs e)
        {

        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void finesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void borrowBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void returnBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            form8.Show();
        }

        private void finesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();  
            form9.Show();
        }
    }
}
