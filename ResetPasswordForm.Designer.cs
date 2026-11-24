namespace PharmaGo
{
    partial class ResetPasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            pictureBoxLogo = new PictureBox();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnReset = new Button();
            lblOr = new Label();
            btnBackToLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(253, 248, 240);
            pictureBoxLogo.Location = new Point(364, 46);
            pictureBoxLogo.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(336, 220);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 10;
            pictureBoxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.WindowFrame;
            lblTitle.Location = new Point(261, 283);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(533, 46);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Reset Password";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(58, 127, 122);
            lblUsername.Location = new Point(383, 346);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 25);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Comic Sans MS", 10F);
            txtUsername.Location = new Point(383, 378);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(282, 31);
            txtUsername.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(58, 127, 122);
            lblNewPassword.Location = new Point(383, 443);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(128, 25);
            lblNewPassword.TabIndex = 7;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Comic Sans MS", 10F);
            txtNewPassword.Location = new Point(383, 475);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(282, 31);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(58, 127, 122);
            lblConfirmPassword.Location = new Point(383, 540);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(156, 25);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Comic Sans MS", 10F);
            txtConfirmPassword.Location = new Point(383, 572);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(282, 31);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(58, 127, 122);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Comic Sans MS", 10.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(433, 654);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(181, 49);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset Password";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblOr
            // 
            lblOr.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            lblOr.ForeColor = Color.FromArgb(58, 127, 122);
            lblOr.Location = new Point(433, 708);
            lblOr.Margin = new Padding(4, 0, 4, 0);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(181, 31);
            lblOr.TabIndex = 5;
            lblOr.Text = "Or";
            lblOr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.FromArgb(58, 127, 122);
            btnBackToLogin.Cursor = Cursors.Hand;
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Font = new Font("Comic Sans MS", 10.5F, FontStyle.Bold);
            btnBackToLogin.ForeColor = Color.White;
            btnBackToLogin.Location = new Point(433, 743);
            btnBackToLogin.Margin = new Padding(4, 5, 4, 5);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(181, 49);
            btnBackToLogin.TabIndex = 4;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(364, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ResetPasswordForm
            // 
            AcceptButton = btnReset;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 248, 240);
            ClientSize = new Size(1045, 843);
            Controls.Add(pictureBox1);
            Controls.Add(btnBackToLogin);
            Controls.Add(lblOr);
            Controls.Add(btnReset);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Controls.Add(pictureBoxLogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnBackToLogin;
        private PictureBox pictureBox1;
    }
}
