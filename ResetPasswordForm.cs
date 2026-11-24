using System;
using System.Windows.Forms;

namespace PharmaGo
{
    public partial class ResetPasswordForm : Form
    {
        private readonly Form _loginForm;

        // Pass your login form so we can go back to it
        public ResetPasswordForm(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;

            // If the user closes this window with the X button, bring the login form back
            this.FormClosed += (s, e) => _loginForm?.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(newPass) ||
                string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.", "Reset Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Reset Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Reset Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            // TODO: update the password in your database here.
            // Check that the username exists, and store a HASHED password (never plain text).
            // Example idea:
            // bool ok = UserRepository.ResetPassword(username, PasswordHasher.Hash(newPass));

            MessageBox.Show("Your password has been reset successfully.", "Reset Password",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // FormClosed will show the login form again
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
