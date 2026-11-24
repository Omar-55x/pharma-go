namespace PharmaGo
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pwdTextbox = new TextBox();
            firstNameTextbox = new TextBox();
            label3 = new Label();
            confirmPwdTextbox = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lastNameTextbox = new TextBox();
            label9 = new Label();
            phoneNumberTextbox = new TextBox();
            createAccountBtn = new Button();
            label10 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(60, 128, 125);
            label2.Location = new Point(217, 502);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(60, 128, 125);
            label1.Location = new Point(217, 217);
            label1.Name = "label1";
            label1.Size = new Size(164, 29);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // pwdTextbox
            // 
            pwdTextbox.Location = new Point(215, 541);
            pwdTextbox.MaxLength = 12;
            pwdTextbox.Name = "pwdTextbox";
            pwdTextbox.PasswordChar = '*';
            pwdTextbox.Size = new Size(235, 27);
            pwdTextbox.TabIndex = 7;
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.AllowDrop = true;
            firstNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstNameTextbox.Font = new Font("Comic Sans MS", 8F);
            firstNameTextbox.Location = new Point(215, 249);
            firstNameTextbox.MaxLength = 10;
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.Size = new Size(235, 26);
            firstNameTextbox.TabIndex = 8;
            firstNameTextbox.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(60, 128, 125);
            label3.Location = new Point(217, 581);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 13;
            label3.Text = "Confirm Password";
            label3.Click += label3_Click;
            // 
            // confirmPwdTextbox
            // 
            confirmPwdTextbox.Location = new Point(215, 619);
            confirmPwdTextbox.MaxLength = 12;
            confirmPwdTextbox.Name = "confirmPwdTextbox";
            confirmPwdTextbox.PasswordChar = '*';
            confirmPwdTextbox.Size = new Size(235, 27);
            confirmPwdTextbox.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 7F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(217, 462);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(47, 23);
            comboBox2.TabIndex = 15;
            comboBox2.Text = "Day";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 7F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(370, 462);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(60, 23);
            comboBox3.TabIndex = 16;
            comboBox3.Text = "year";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 7F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(282, 462);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(75, 23);
            comboBox4.TabIndex = 17;
            comboBox4.Text = "Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(60, 128, 125);
            label4.Location = new Point(218, 440);
            label4.Name = "label4";
            label4.Size = new Size(32, 19);
            label4.TabIndex = 18;
            label4.Text = "Day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(60, 128, 125);
            label5.Location = new Point(282, 440);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 19;
            label5.Text = "Month";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(60, 128, 125);
            label6.Location = new Point(393, 440);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 20;
            label6.Text = "Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(60, 128, 125);
            label7.Location = new Point(217, 407);
            label7.Name = "label7";
            label7.Size = new Size(207, 25);
            label7.TabIndex = 21;
            label7.Text = "* Enter UR Birth Date.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(60, 128, 125);
            label8.Location = new Point(217, 278);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 23;
            label8.Text = "Last Name";
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.AllowDrop = true;
            lastNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastNameTextbox.Font = new Font("Comic Sans MS", 8F);
            lastNameTextbox.Location = new Point(215, 310);
            lastNameTextbox.MaxLength = 10;
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.Size = new Size(235, 26);
            lastNameTextbox.TabIndex = 22;
            lastNameTextbox.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(60, 128, 125);
            label9.Location = new Point(218, 341);
            label9.Name = "label9";
            label9.Size = new Size(130, 25);
            label9.TabIndex = 25;
            label9.Text = "Phone Number";
            label9.Click += label9_Click;
            // 
            // phoneNumberTextbox
            // 
            phoneNumberTextbox.AllowDrop = true;
            phoneNumberTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextbox.Font = new Font("Comic Sans MS", 8F);
            phoneNumberTextbox.Location = new Point(215, 378);
            phoneNumberTextbox.MaxLength = 11;
            phoneNumberTextbox.Name = "phoneNumberTextbox";
            phoneNumberTextbox.Size = new Size(235, 26);
            phoneNumberTextbox.TabIndex = 24;
            phoneNumberTextbox.UseWaitCursor = true;
            // 
            // createAccountBtn
            // 
            createAccountBtn.BackColor = Color.FromArgb(60, 128, 125);
            createAccountBtn.Cursor = Cursors.Hand;
            createAccountBtn.FlatAppearance.BorderColor = Color.White;
            createAccountBtn.FlatAppearance.BorderSize = 0;
            createAccountBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 80, 78);
            createAccountBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 100, 98);
            createAccountBtn.FlatStyle = FlatStyle.Flat;
            createAccountBtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            createAccountBtn.ForeColor = Color.White;
            createAccountBtn.Location = new Point(243, 661);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(163, 32);
            createAccountBtn.TabIndex = 26;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = false;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(60, 128, 125);
            label10.Location = new Point(215, 156);
            label10.Name = "label10";
            label10.Size = new Size(122, 29);
            label10.TabIndex = 27;
            label10.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Comic Sans MS", 8F);
            textBox1.Location = new Point(215, 188);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 26);
            textBox1.TabIndex = 28;
            textBox1.UseWaitCursor = true;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 247, 238);
            ClientSize = new Size(669, 714);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(createAccountBtn);
            Controls.Add(label9);
            Controls.Add(phoneNumberTextbox);
            Controls.Add(label8);
            Controls.Add(lastNameTextbox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(confirmPwdTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pwdTextbox);
            Controls.Add(firstNameTextbox);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox pwdTextbox;
        private TextBox firstNameTextbox;
        private Label label3;
        private TextBox confirmPwdTextbox;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox lastNameTextbox;
        private Label label9;
        private TextBox phoneNumberTextbox;
        private Button createAccountBtn;
        private Label label10;
        private TextBox textBox1;
    }
}