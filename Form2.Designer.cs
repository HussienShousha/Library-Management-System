namespace Library_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            button2 = new Button();
            btnClose = new Button();
            txtUserName = new TextBox();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            txtUniversityEmail = new TextBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            txtAge = new TextBox();
            panel7 = new Panel();
            pictureBox8 = new PictureBox();
            panel3 = new Panel();
            txtStudentID = new TextBox();
            pictureBox9 = new PictureBox();
            panel8 = new Panel();
            txtPhoneNumber = new TextBox();
            pictureBox10 = new PictureBox();
            panel9 = new Panel();
            txtSSN = new TextBox();
            pictureBox11 = new PictureBox();
            panel10 = new Panel();
            txtAddress = new TextBox();
            pictureBox12 = new PictureBox();
            panel11 = new Panel();
            txtGender = new TextBox();
            pictureBox7 = new PictureBox();
            panel5 = new Panel();
            txtDepartmentName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(241, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(35, 35, 55);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(167, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(334, 27);
            txtName.TabIndex = 1;
            txtName.Text = "Name";
            txtName.MouseClick += txtName_MouseClick;
            txtName.TextChanged += textBox1_MouseEnter;
            txtName.MouseDown += txtName_MouseDown;
            txtName.MouseEnter += txtName_MouseEnter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 36, 55);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(166, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(335, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password";
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(106, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(106, 205);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(167, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 1);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(167, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 1);
            panel2.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(61, 681);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(182, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cyan;
            button2.Location = new Point(379, 681);
            button2.Name = "button2";
            button2.Size = new Size(182, 45);
            button2.TabIndex = 8;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(622, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 28);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(35, 36, 55);
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(167, 162);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(334, 27);
            txtUserName.TabIndex = 11;
            txtUserName.Text = "UserName";
            txtUserName.MouseClick += txtUserName_MouseClick;
            txtUserName.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(106, 159);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(167, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 1);
            panel4.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(96, 247);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // txtUniversityEmail
            // 
            txtUniversityEmail.BackColor = Color.FromArgb(35, 36, 55);
            txtUniversityEmail.BorderStyle = BorderStyle.FixedSingle;
            txtUniversityEmail.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUniversityEmail.ForeColor = Color.White;
            txtUniversityEmail.Location = new Point(166, 311);
            txtUniversityEmail.Name = "txtUniversityEmail";
            txtUniversityEmail.Size = new Size(334, 27);
            txtUniversityEmail.TabIndex = 18;
            txtUniversityEmail.Text = "University Email";
            txtUniversityEmail.MouseClick += txtUniversityEmail_MouseClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(166, 337);
            panel6.Name = "panel6";
            panel6.Size = new Size(334, 1);
            panel6.TabIndex = 19;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(96, 305);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(35, 36, 55);
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAge.ForeColor = Color.White;
            txtAge.Location = new Point(166, 441);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(335, 27);
            txtAge.TabIndex = 21;
            txtAge.Text = "Age";
            txtAge.MouseClick += txtAge_MouseClick;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(166, 467);
            panel7.Name = "panel7";
            panel7.Size = new Size(334, 1);
            panel7.TabIndex = 22;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(95, 435);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(46, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(166, 279);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 1);
            panel3.TabIndex = 28;
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.FromArgb(35, 36, 55);
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentID.ForeColor = Color.White;
            txtStudentID.Location = new Point(166, 253);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(334, 27);
            txtStudentID.TabIndex = 27;
            txtStudentID.Text = "Student ID";
            txtStudentID.MouseClick += txtStudentID_MouseClick;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(95, 495);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(46, 33);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 33;
            pictureBox9.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(166, 527);
            panel8.Name = "panel8";
            panel8.Size = new Size(334, 1);
            panel8.TabIndex = 32;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(35, 36, 55);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.White;
            txtPhoneNumber.Location = new Point(166, 501);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(335, 27);
            txtPhoneNumber.TabIndex = 31;
            txtPhoneNumber.Text = "Phone Number";
            txtPhoneNumber.MouseClick += txtPhoneNumber_MouseClick;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(95, 548);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(46, 33);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 36;
            pictureBox10.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(166, 580);
            panel9.Name = "panel9";
            panel9.Size = new Size(334, 1);
            panel9.TabIndex = 35;
            // 
            // txtSSN
            // 
            txtSSN.BackColor = Color.FromArgb(35, 36, 55);
            txtSSN.BorderStyle = BorderStyle.FixedSingle;
            txtSSN.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSSN.ForeColor = Color.White;
            txtSSN.Location = new Point(166, 554);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(335, 27);
            txtSSN.TabIndex = 34;
            txtSSN.Text = "SSN";
            txtSSN.MouseClick += txtSSN_MouseClick;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(94, 611);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(46, 33);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 39;
            pictureBox11.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(165, 643);
            panel10.Name = "panel10";
            panel10.Size = new Size(334, 1);
            panel10.TabIndex = 38;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(35, 36, 55);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(165, 617);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(335, 27);
            txtAddress.TabIndex = 37;
            txtAddress.Text = "Address";
            txtAddress.MouseClick += txtAddress_MouseClick;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(96, 396);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(46, 33);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 42;
            pictureBox12.TabStop = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(167, 428);
            panel11.Name = "panel11";
            panel11.Size = new Size(334, 1);
            panel11.TabIndex = 41;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.FromArgb(35, 36, 55);
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGender.ForeColor = Color.White;
            txtGender.Location = new Point(167, 402);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(335, 27);
            txtGender.TabIndex = 40;
            txtGender.Text = "Gender";
            txtGender.MouseClick += txtGender_MouseClick;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(96, 353);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(46, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(166, 385);
            panel5.Name = "panel5";
            panel5.Size = new Size(334, 1);
            panel5.TabIndex = 30;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.BackColor = Color.FromArgb(35, 36, 55);
            txtDepartmentName.BorderStyle = BorderStyle.FixedSingle;
            txtDepartmentName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDepartmentName.ForeColor = Color.White;
            txtDepartmentName.Location = new Point(166, 359);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(334, 27);
            txtDepartmentName.TabIndex = 29;
            txtDepartmentName.Text = "Department Name";
            txtDepartmentName.MouseClick += txtDepartmentName_MouseClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(680, 788);
            Controls.Add(pictureBox12);
            Controls.Add(panel11);
            Controls.Add(txtGender);
            Controls.Add(pictureBox11);
            Controls.Add(panel10);
            Controls.Add(txtAddress);
            Controls.Add(pictureBox10);
            Controls.Add(panel9);
            Controls.Add(txtSSN);
            Controls.Add(pictureBox9);
            Controls.Add(panel8);
            Controls.Add(txtPhoneNumber);
            Controls.Add(panel5);
            Controls.Add(txtDepartmentName);
            Controls.Add(panel3);
            Controls.Add(txtStudentID);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(panel7);
            Controls.Add(txtAge);
            Controls.Add(pictureBox6);
            Controls.Add(panel6);
            Controls.Add(txtUniversityEmail);
            Controls.Add(pictureBox5);
            Controls.Add(panel4);
            Controls.Add(pictureBox4);
            Controls.Add(txtUserName);
            Controls.Add(btnClose);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtName;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button btnLogin;
        private Button button2;
        private Button btnClose;
        private TextBox txtUserName;
        private PictureBox pictureBox4;
        private Panel panel4;
        private PictureBox pictureBox5;
        private TextBox txtUniversityEmail;
        private Panel panel6;
        private PictureBox pictureBox6;
        private TextBox txtAge;
        private Panel panel7;
        private PictureBox pictureBox8;
        private Panel panel3;
        private TextBox txtStudentID;
        private PictureBox pictureBox9;
        private Panel panel8;
        private TextBox txtPhoneNumber;
        private PictureBox pictureBox10;
        private Panel panel9;
        private TextBox txtSSN;
        private PictureBox pictureBox11;
        private Panel panel10;
        private TextBox txtAddress;
        private PictureBox pictureBox12;
        private Panel panel11;
        private TextBox txtGender;
        private PictureBox pictureBox7;
        private Panel panel5;
        private TextBox txtDepartmentName;
    }
}