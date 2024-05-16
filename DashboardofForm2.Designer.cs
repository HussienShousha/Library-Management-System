namespace Library_Management_System
{
    partial class DashboardofForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardofForm2));
            menuStrip1 = new MenuStrip();
            bookToolStripMenuItem = new ToolStripMenuItem();
            borrowBookToolStripMenuItem1 = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            updateStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem1 = new ToolStripMenuItem();
            finesToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            finesToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { bookToolStripMenuItem, updateStudentDetailsToolStripMenuItem, finesToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { borrowBookToolStripMenuItem1, searchToolStripMenuItem });
            bookToolStripMenuItem.Image = (Image)resources.GetObject("bookToolStripMenuItem.Image");
            bookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(101, 54);
            bookToolStripMenuItem.Text = "Books";
            // 
            // borrowBookToolStripMenuItem1
            // 
            borrowBookToolStripMenuItem1.Image = (Image)resources.GetObject("borrowBookToolStripMenuItem1.Image");
            borrowBookToolStripMenuItem1.Name = "borrowBookToolStripMenuItem1";
            borrowBookToolStripMenuItem1.Size = new Size(142, 22);
            borrowBookToolStripMenuItem1.Text = "Borrow Book";
            borrowBookToolStripMenuItem1.Click += borrowBookToolStripMenuItem1_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = (Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(142, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            updateStudentDetailsToolStripMenuItem.BackColor = Color.OldLace;
            updateStudentDetailsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, returnBookToolStripMenuItem1 });
            updateStudentDetailsToolStripMenuItem.Image = (Image)resources.GetObject("updateStudentDetailsToolStripMenuItem.Image");
            updateStudentDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            updateStudentDetailsToolStripMenuItem.Size = new Size(155, 54);
            updateStudentDetailsToolStripMenuItem.Text = "Borrowed Books";
            updateStudentDetailsToolStripMenuItem.Click += updateStudentDetailsToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Image = (Image)resources.GetObject("viewToolStripMenuItem.Image");
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(180, 22);
            viewToolStripMenuItem.Text = "View Book";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // returnBookToolStripMenuItem1
            // 
            returnBookToolStripMenuItem1.Image = (Image)resources.GetObject("returnBookToolStripMenuItem1.Image");
            returnBookToolStripMenuItem1.Name = "returnBookToolStripMenuItem1";
            returnBookToolStripMenuItem1.Size = new Size(180, 22);
            returnBookToolStripMenuItem1.Text = "Return Book";
            returnBookToolStripMenuItem1.Click += returnBookToolStripMenuItem1_Click;
            // 
            // finesToolStripMenuItem
            // 
            finesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem1, finesToolStripMenuItem1 });
            finesToolStripMenuItem.Image = (Image)resources.GetObject("finesToolStripMenuItem.Image");
            finesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            finesToolStripMenuItem.Size = new Size(146, 54);
            finesToolStripMenuItem.Text = "Student Details";
            finesToolStripMenuItem.Click += finesToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.Image = (Image)resources.GetObject("viewToolStripMenuItem1.Image");
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(101, 22);
            viewToolStripMenuItem1.Text = "View";
            viewToolStripMenuItem1.Click += viewToolStripMenuItem1_Click;
            // 
            // finesToolStripMenuItem1
            // 
            finesToolStripMenuItem1.Image = (Image)resources.GetObject("finesToolStripMenuItem1.Image");
            finesToolStripMenuItem1.Name = "finesToolStripMenuItem1";
            finesToolStripMenuItem1.Size = new Size(101, 22);
            finesToolStripMenuItem1.Text = "Fines";
            finesToolStripMenuItem1.Click += finesToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.OldLace;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(88, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // DashboardofForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "DashboardofForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardofForm2";
            WindowState = FormWindowState.Maximized;
            Load += DashboardofForm2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private ToolStripMenuItem finesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem borrowBookToolStripMenuItem1;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem1;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem finesToolStripMenuItem1;
    }
}