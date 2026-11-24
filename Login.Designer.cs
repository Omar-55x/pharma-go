namespace PharmaGo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            userTextbox = new TextBox();
            pwdTextbox = new TextBox();
            loginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            signupBtn = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userTextbox
            // 
            userTextbox.AllowDrop = true;
            userTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTextbox.Font = new Font("Comic Sans MS", 8F);
            userTextbox.Location = new Point(287, 215);
            userTextbox.MaxLength = 8;
            userTextbox.Name = "userTextbox";
            userTextbox.Size = new Size(213, 26);
            userTextbox.TabIndex = 0;
            userTextbox.UseWaitCursor = true;
            // 
            // pwdTextbox
            // 
            pwdTextbox.Location = new Point(287, 277);
            pwdTextbox.MaxLength = 8;
            pwdTextbox.Name = "pwdTextbox";
            pwdTextbox.PasswordChar = '*';
            pwdTextbox.Size = new Size(212, 27);
            pwdTextbox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(60, 128, 125);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.White;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 80, 78);
            loginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 100, 98);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(343, 379);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 32);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 7F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(60, 128, 125);
            label1.Location = new Point(287, 195);
            label1.Name = "label1";
            label1.Size = new Size(64, 16);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 7F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(60, 128, 125);
            label2.Location = new Point(287, 257);
            label2.Name = "label2";
            label2.Size = new Size(59, 16);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 7F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(60, 128, 125);
            label3.Location = new Point(376, 417);
            label3.Name = "label3";
            label3.Size = new Size(23, 16);
            label3.TabIndex = 8;
            label3.Text = "Or";
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.FromArgb(60, 128, 125);
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.FlatAppearance.BorderColor = Color.White;
            signupBtn.FlatAppearance.BorderSize = 0;
            signupBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 80, 78);
            signupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 100, 98);
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            signupBtn.ForeColor = Color.White;
            signupBtn.Location = new Point(342, 437);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(94, 32);
            signupBtn.TabIndex = 10;
            signupBtn.Text = "SignUp";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Comic Sans MS", 6F);
            linkLabel1.LinkColor = Color.FromArgb(60, 128, 125);
            linkLabel1.Location = new Point(411, 309);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 14);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 247, 238);
            ClientSize = new Size(801, 533);
            Controls.Add(linkLabel1);
            Controls.Add(signupBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(pwdTextbox);
            Controls.Add(userTextbox);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox userTextbox;
        private TextBox pwdTextbox;
        private Button loginBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button signupBtn;
        private LinkLabel linkLabel1;
    }
}