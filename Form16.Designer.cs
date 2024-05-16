namespace Library_Management_System
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPublisherID = new TextBox();
            txtNewName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(270, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Wheat;
            button1.Location = new Point(530, 357);
            button1.Name = "button1";
            button1.Size = new Size(223, 57);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(739, 12);
            button2.Name = "button2";
            button2.Size = new Size(49, 45);
            button2.TabIndex = 3;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 66);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 4;
            label1.Text = "Update Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 193);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 5;
            label2.Text = "Publisher ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 269);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 6;
            label3.Text = "New Name";
            label3.Click += label3_Click;
            // 
            // txtPublisherID
            // 
            txtPublisherID.BorderStyle = BorderStyle.None;
            txtPublisherID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPublisherID.Location = new Point(287, 192);
            txtPublisherID.Name = "txtPublisherID";
            txtPublisherID.Size = new Size(282, 26);
            txtPublisherID.TabIndex = 7;
            txtPublisherID.Text = "Publisher ID";
            txtPublisherID.MouseClick += txtPublisherID_MouseClick;
            txtPublisherID.TextChanged += textBox1_TextChanged;
            // 
            // txtNewName
            // 
            txtNewName.BorderStyle = BorderStyle.None;
            txtNewName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewName.Location = new Point(287, 269);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(282, 26);
            txtNewName.TabIndex = 8;
            txtNewName.Text = "New Name";
            txtNewName.MouseClick += txtNewName_MouseClick;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNewName);
            Controls.Add(txtPublisherID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form16";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form16";
            Load += Form16_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPublisherID;
        private TextBox txtNewName;
    }
}