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
    public partial class DashboardofForm3 : Form
    {
        public DashboardofForm3()
        {
            InitializeComponent();
        }

        private void DashboardofForm3_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();

            form11.Show();
        }

        private void ViewPublisherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void AddPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
        }

        private void finesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void PublisherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
        }
    }
}
