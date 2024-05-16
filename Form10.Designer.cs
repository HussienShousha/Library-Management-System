namespace Library_Management_System
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAuthorName = new TextBox();
            txtCategory = new TextBox();
            txtAdminID = new TextBox();
            txtNumberOfCopies = new TextBox();
            txtPublisherID = new TextBox();
            btnClose = new Button();
            button1 = new Button();
            txtTitle = new TextBox();
            txtBookID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(279, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 1;
            label1.Text = "Add Book...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 187);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 243);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 3;
            label3.Text = "Author Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(114, 297);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 4;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(114, 348);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 5;
            label5.Text = "Book ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(114, 397);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 6;
            label6.Text = "Admin ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(114, 453);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 7;
            label7.Text = "Number Of Copies";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(114, 506);
            label8.Name = "label8";
            label8.Size = new Size(103, 21);
            label8.TabIndex = 8;
            label8.Text = "Publisher ID";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtAuthorName.Location = new Point(246, 241);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(268, 33);
            txtAuthorName.TabIndex = 10;
            txtAuthorName.Text = "Author Name";
            txtAuthorName.MouseClick += txtAuthorName_MouseClick;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtCategory.Location = new Point(246, 297);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(268, 33);
            txtCategory.TabIndex = 11;
            txtCategory.Text = "Category";
            txtCategory.MouseClick += txtCategory_MouseClick;
            // 
            // txtAdminID
            // 
            txtAdminID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdminID.Location = new Point(246, 397);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(268, 33);
            txtAdminID.TabIndex = 13;
            txtAdminID.Text = "Admin ID";
            txtAdminID.MouseClick += txtAdminID_MouseClick;
            // 
            // txtNumberOfCopies
            // 
            txtNumberOfCopies.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtNumberOfCopies.Location = new Point(279, 455);
            txtNumberOfCopies.Name = "txtNumberOfCopies";
            txtNumberOfCopies.Size = new Size(268, 33);
            txtNumberOfCopies.TabIndex = 14;
            txtNumberOfCopies.Text = "Number Of Copies";
            txtNumberOfCopies.TextChanged += txtNumberOfCopies_TextChanged;
            // 
            // txtPublisherID
            // 
            txtPublisherID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPublisherID.Location = new Point(246, 504);
            txtPublisherID.Name = "txtPublisherID";
            txtPublisherID.Size = new Size(268, 33);
            txtPublisherID.TabIndex = 15;
            txtPublisherID.Text = "Publisher ID";
            txtPublisherID.MouseClick += txtPublisherID_MouseClick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(872, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 37);
            btnClose.TabIndex = 16;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Wheat;
            button1.Location = new Point(626, 554);
            button1.Name = "button1";
            button1.Size = new Size(234, 60);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtTitle.Location = new Point(246, 189);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(268, 33);
            txtTitle.TabIndex = 18;
            txtTitle.Text = "Title";
            txtTitle.MouseClick += txtTitle_MouseClick;
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookID.Location = new Point(246, 350);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(268, 33);
            txtBookID.TabIndex = 19;
            txtBookID.Text = "Book ID";
            txtBookID.MouseClick += txtBookID_MouseClick;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(918, 656);
            Controls.Add(txtBookID);
            Controls.Add(txtTitle);
            Controls.Add(button1);
            Controls.Add(btnClose);
            Controls.Add(txtPublisherID);
            Controls.Add(txtNumberOfCopies);
            Controls.Add(txtAdminID);
            Controls.Add(txtCategory);
            Controls.Add(txtAuthorName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAuthorName;
        private TextBox txtCategory;
        private TextBox txtAdminID;
        private TextBox txtNumberOfCopies;
        private TextBox txtPublisherID;
        private Button btnClose;
        private Button button1;
        private TextBox txtTitle;
        private TextBox txtBookID;
    }
}