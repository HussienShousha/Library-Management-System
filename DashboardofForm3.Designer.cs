namespace Library_Management_System
{
    partial class DashboardofForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardofForm3));
            menuStrip1 = new MenuStrip();
            bookToolStripMenuItem = new ToolStripMenuItem();
            AddBookToolStripMenuItem1 = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            PublisherDetailsToolStripMenuItem = new ToolStripMenuItem();
            AddPublisherToolStripMenuItem = new ToolStripMenuItem();
            ViewPublisherToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            nameToolStripMenuItem = new ToolStripMenuItem();
            addressToolStripMenuItem = new ToolStripMenuItem();
            finesToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            finesToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { bookToolStripMenuItem, PublisherDetailsToolStripMenuItem, finesToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 58);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddBookToolStripMenuItem1, searchToolStripMenuItem, deleteToolStripMenuItem });
            bookToolStripMenuItem.Image = (Image)resources.GetObject("bookToolStripMenuItem.Image");
            bookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(101, 54);
            bookToolStripMenuItem.Text = "Books";
            // 
            // AddBookToolStripMenuItem1
            // 
            AddBookToolStripMenuItem1.Image = (Image)resources.GetObject("AddBookToolStripMenuItem1.Image");
            AddBookToolStripMenuItem1.Name = "AddBookToolStripMenuItem1";
            AddBookToolStripMenuItem1.Size = new Size(180, 22);
            AddBookToolStripMenuItem1.Text = "Add Book";
            AddBookToolStripMenuItem1.Click += AddBookToolStripMenuItem1_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = (Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(180, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // PublisherDetailsToolStripMenuItem
            // 
            PublisherDetailsToolStripMenuItem.BackColor = Color.OldLace;
            PublisherDetailsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddPublisherToolStripMenuItem, ViewPublisherToolStripMenuItem1, updateToolStripMenuItem });
            PublisherDetailsToolStripMenuItem.Image = (Image)resources.GetObject("PublisherDetailsToolStripMenuItem.Image");
            PublisherDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            PublisherDetailsToolStripMenuItem.Name = "PublisherDetailsToolStripMenuItem";
            PublisherDetailsToolStripMenuItem.Size = new Size(118, 54);
            PublisherDetailsToolStripMenuItem.Text = "Publisher";
            PublisherDetailsToolStripMenuItem.Click += PublisherDetailsToolStripMenuItem_Click;
            // 
            // AddPublisherToolStripMenuItem
            // 
            AddPublisherToolStripMenuItem.Image = (Image)resources.GetObject("AddPublisherToolStripMenuItem.Image");
            AddPublisherToolStripMenuItem.Name = "AddPublisherToolStripMenuItem";
            AddPublisherToolStripMenuItem.Size = new Size(151, 22);
            AddPublisherToolStripMenuItem.Text = "Add Publisher";
            AddPublisherToolStripMenuItem.Click += AddPublisherToolStripMenuItem_Click;
            // 
            // ViewPublisherToolStripMenuItem1
            // 
            ViewPublisherToolStripMenuItem1.Image = (Image)resources.GetObject("ViewPublisherToolStripMenuItem1.Image");
            ViewPublisherToolStripMenuItem1.Name = "ViewPublisherToolStripMenuItem1";
            ViewPublisherToolStripMenuItem1.Size = new Size(151, 22);
            ViewPublisherToolStripMenuItem1.Text = "View Publisher";
            ViewPublisherToolStripMenuItem1.Click += ViewPublisherToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nameToolStripMenuItem, addressToolStripMenuItem });
            updateToolStripMenuItem.Image = (Image)resources.GetObject("updateToolStripMenuItem.Image");
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(151, 22);
            updateToolStripMenuItem.Text = "Update";
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            nameToolStripMenuItem.Image = (Image)resources.GetObject("nameToolStripMenuItem.Image");
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(116, 22);
            nameToolStripMenuItem.Text = "Name";
            nameToolStripMenuItem.Click += nameToolStripMenuItem_Click;
            // 
            // addressToolStripMenuItem
            // 
            addressToolStripMenuItem.Image = (Image)resources.GetObject("addressToolStripMenuItem.Image");
            addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            addressToolStripMenuItem.Size = new Size(116, 22);
            addressToolStripMenuItem.Text = "Address";
            // 
            // finesToolStripMenuItem
            // 
            finesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem1, finesToolStripMenuItem1 });
            finesToolStripMenuItem.Image = (Image)resources.GetObject("finesToolStripMenuItem.Image");
            finesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            finesToolStripMenuItem.Size = new Size(146, 54);
            finesToolStripMenuItem.Text = "Student Details";
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
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // DashboardofForm3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardofForm3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardofForm3";
            Load += DashboardofForm3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem AddBookToolStripMenuItem1;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem PublisherDetailsToolStripMenuItem;
        private ToolStripMenuItem AddPublisherToolStripMenuItem;
        private ToolStripMenuItem ViewPublisherToolStripMenuItem1;
        private ToolStripMenuItem finesToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem finesToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem nameToolStripMenuItem;
        private ToolStripMenuItem addressToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}