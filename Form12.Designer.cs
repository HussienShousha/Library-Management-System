namespace Library_Management_System
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            txtName = new TextBox();
            button1 = new Button();
            btnClose = new Button();
            txtAddress = new TextBox();
            txtPublisherID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtName.Location = new Point(220, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 33);
            txtName.TabIndex = 36;
            txtName.Text = "Name";
            txtName.MouseClick += txtName_MouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Wheat;
            button1.Location = new Point(504, 450);
            button1.Name = "button1";
            button1.Size = new Size(234, 60);
            button1.TabIndex = 35;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(734, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 37);
            btnClose.TabIndex = 34;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtAddress.Location = new Point(220, 371);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(268, 33);
            txtAddress.TabIndex = 30;
            txtAddress.Text = "Address";
            txtAddress.MouseClick += txtAddress_MouseClick;
            // 
            // txtPublisherID
            // 
            txtPublisherID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPublisherID.Location = new Point(220, 270);
            txtPublisherID.Name = "txtPublisherID";
            txtPublisherID.Size = new Size(268, 33);
            txtPublisherID.TabIndex = 29;
            txtPublisherID.Text = "Publisher ID";
            txtPublisherID.MouseClick += txtPublisherID_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 371);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 24;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 272);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 23;
            label3.Text = "Publisher ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 162);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 33);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 21;
            label1.Text = "Add Publisher...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(774, 550);
            Controls.Add(txtName);
            Controls.Add(button1);
            Controls.Add(btnClose);
            Controls.Add(txtAddress);
            Controls.Add(txtPublisherID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Button button1;
        private Button btnClose;
        private TextBox txtAddress;
        private TextBox txtPublisherID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}