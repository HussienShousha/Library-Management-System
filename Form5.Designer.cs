namespace Library_Management_System
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStudentID = new TextBox();
            txtBookID = new TextBox();
            button1 = new Button();
            txtstart_date_borrowing = new TextBox();
            label4 = new Label();
            txtend_date_borrowing = new TextBox();
            label5 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 41);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 1;
            label1.Text = "Borrow...";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(218, 238);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(227, 301);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 3;
            label3.Text = "Book ID";
            // 
            // txtStudentID
            // 
            txtStudentID.BorderStyle = BorderStyle.None;
            txtStudentID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(322, 237);
            txtStudentID.Margin = new Padding(4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(268, 26);
            txtStudentID.TabIndex = 4;
            txtStudentID.Text = "Student ID";
            txtStudentID.MouseClick += txtStudentID_MouseClick;
            txtStudentID.TextChanged += textBox1_TextChanged;
            // 
            // txtBookID
            // 
            txtBookID.BorderStyle = BorderStyle.None;
            txtBookID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookID.Location = new Point(322, 301);
            txtBookID.Margin = new Padding(4);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(268, 26);
            txtBookID.TabIndex = 5;
            txtBookID.Text = "Book ID";
            txtBookID.MouseClick += txtBookID_MouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Wheat;
            button1.Location = new Point(393, 553);
            button1.Name = "button1";
            button1.Size = new Size(182, 45);
            button1.TabIndex = 6;
            button1.Text = "Borrow";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtstart_date_borrowing
            // 
            txtstart_date_borrowing.BorderStyle = BorderStyle.None;
            txtstart_date_borrowing.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtstart_date_borrowing.Location = new Point(322, 379);
            txtstart_date_borrowing.Margin = new Padding(4);
            txtstart_date_borrowing.Name = "txtstart_date_borrowing";
            txtstart_date_borrowing.Size = new Size(268, 26);
            txtstart_date_borrowing.TabIndex = 8;
            txtstart_date_borrowing.Text = "start_date_borrowing";
            txtstart_date_borrowing.MouseClick += txtstart_date_borrowing_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(142, 382);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 21);
            label4.TabIndex = 7;
            label4.Text = "start_date_borrowing";
            label4.Click += label4_Click;
            // 
            // txtend_date_borrowing
            // 
            txtend_date_borrowing.BorderStyle = BorderStyle.None;
            txtend_date_borrowing.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtend_date_borrowing.Location = new Point(322, 441);
            txtend_date_borrowing.Margin = new Padding(4);
            txtend_date_borrowing.Name = "txtend_date_borrowing";
            txtend_date_borrowing.Size = new Size(268, 26);
            txtend_date_borrowing.TabIndex = 10;
            txtend_date_borrowing.Text = "end_date_borrowing";
            txtend_date_borrowing.MouseClick += txtend_date_borrowing_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(142, 444);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 9;
            label5.Text = "end_date_borrowing";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(192, 0, 0);
            btnClose.Location = new Point(1061, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 34);
            btnClose.TabIndex = 11;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseClick += btnClose_MouseClick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1143, 630);
            Controls.Add(btnClose);
            Controls.Add(txtend_date_borrowing);
            Controls.Add(label5);
            Controls.Add(txtstart_date_borrowing);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtBookID);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentID;
        private TextBox txtBookID;
        private Button button1;
        private TextBox txtstart_date_borrowing;
        private Label label4;
        private TextBox txtend_date_borrowing;
        private Label label5;
        private Button btnClose;
    }
}