namespace Library_Management_System
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtStudentID = new TextBox();
            txtBookID = new TextBox();
            label3 = new Label();
            txtDatetoday = new TextBox();
            label4 = new Label();
            btnReturn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 78);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 1;
            label1.Text = "Return Book....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 165);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 2;
            label2.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.BorderStyle = BorderStyle.None;
            txtStudentID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(220, 160);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(224, 26);
            txtStudentID.TabIndex = 3;
            txtStudentID.Text = "Student ID";
            txtStudentID.MouseClick += txtStudentID_MouseClick;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtBookID
            // 
            txtBookID.BorderStyle = BorderStyle.None;
            txtBookID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookID.Location = new Point(220, 237);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(224, 26);
            txtBookID.TabIndex = 5;
            txtBookID.Text = "Book ID";
            txtBookID.MouseClick += txtBookID_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 237);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Book ID";
            label3.Click += label3_Click;
            // 
            // txtDatetoday
            // 
            txtDatetoday.BorderStyle = BorderStyle.None;
            txtDatetoday.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDatetoday.Location = new Point(220, 318);
            txtDatetoday.Name = "txtDatetoday";
            txtDatetoday.Size = new Size(224, 26);
            txtDatetoday.TabIndex = 7;
            txtDatetoday.Text = "21-5-2024";
            txtDatetoday.TextChanged += txtDatetoday_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(92, 321);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 6;
            label4.Text = "Date today";
            label4.Click += label4_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Black;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.Wheat;
            btnReturn.Location = new Point(535, 353);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(193, 58);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(732, 12);
            button2.Name = "button2";
            button2.Size = new Size(44, 40);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnReturn);
            Controls.Add(txtDatetoday);
            Controls.Add(label4);
            Controls.Add(txtBookID);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtStudentID;
        private TextBox txtBookID;
        private Label label3;
        private TextBox txtDatetoday;
        private Label label4;
        private Button btnReturn;
        private Button button2;
    }
}