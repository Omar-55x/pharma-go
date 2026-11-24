using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using PharmaGo.Models;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmaGo
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

            // الأيام
            for (int d = 1; d <= 31; d++)
                comboBox2.Items.Add(d);

            // الشهور
            comboBox4.Items.AddRange(new string[] {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December" });

            // السنين
            for (int y = DateTime.Now.Year; y >= DateTime.Now.Year - 100; y--)
                comboBox3.Items.Add(y);

        }

       // private void createAccountBtn_Click(object sender, EventArgs e)
       // {
            /*if (string.IsNullOrEmpty(firstNameTextbox.Text))
            {
                MessageBox.Show("Please enter your first name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(lastNameTextbox.Text))
            {
                MessageBox.Show("Please enter your last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(phoneNumberTextbox.Text))
            {
                MessageBox.Show("Please enter your phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(pwdTextbox.Text))
            {
                MessageBox.Show("Please enter the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(confirmPwdTextbox.Text))
            {
                MessageBox.Show("Please confirm your password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pwdTextbox.Text != confirmPwdTextbox.Text)
            {
                MessageBox.Show("Passwords are not the same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainPage home = new MainPage();
                home.Show();
                this.Close();*/
            private void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextbox.Text)) { MessageBox.Show("Please enter your first name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (string.IsNullOrEmpty(lastNameTextbox.Text)) { MessageBox.Show("Please enter your last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (string.IsNullOrEmpty(phoneNumberTextbox.Text)) { MessageBox.Show("Please enter your phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (string.IsNullOrEmpty(textBox1.Text)) { MessageBox.Show("Please enter your username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (string.IsNullOrEmpty(pwdTextbox.Text)) { MessageBox.Show("Please enter the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (string.IsNullOrEmpty(confirmPwdTextbox.Text)) { MessageBox.Show("Please confirm your password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (pwdTextbox.Text != confirmPwdTextbox.Text) { MessageBox.Show("Passwords are not the same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                int day, year;
                if (!int.TryParse(comboBox2.Text, out day) ||
                    !int.TryParse(comboBox3.Text, out year))
                {
                    MessageBox.Show("Please enter a valid birth date");
                    return;
                }

                string[] months =
                {
        "January", "February", "March", "April",
        "May", "June", "July", "August",
        "September", "October", "November", "December"
    };
                int month = Array.FindIndex(
                    months,
                    m => m.Equals(comboBox4.Text,
                    StringComparison.OrdinalIgnoreCase)) + 1;

                if (month == 0)
                {
                    MessageBox.Show("Please select a valid month");
                    return;
                }

                DateOnly birthDate;

                try
                {
                    birthDate = new DateOnly(year, month, day);
                }
                catch
                {
                    MessageBox.Show("Please enter a valid birth date");
                    return;
                }

                try
                {
                    using (var db = new PharmagoContext())
                    {
                        string username = textBox1.Text.Trim();

                        bool usernameExists = db.Users.Any(
                            u => u.Username == username);

                        if (usernameExists)
                        {
                            MessageBox.Show("Username already exists");
                            return;
                        }

                        User newUser = new User
                        {
                            FirstName = firstNameTextbox.Text.Trim(),
                            LastName = lastNameTextbox.Text.Trim(),
                            Phone = phoneNumberTextbox.Text.Trim(),
                            BirthDate = birthDate,
                            Username = username,
                            Password = pwdTextbox.Text
                        };

                        db.Users.Add(newUser);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Account created successfully!");

                    MainPage home = new MainPage();
                    home.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error saving account: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
        }
    
