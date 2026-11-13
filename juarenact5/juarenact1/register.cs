
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace juarenact1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check empty fields
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Check password length
            if (password.Length < 8)
            {
                MessageBox.Show(
                    "Password must be at least 8 characters."
                );
                return;
            }

            // Hash password
            string hashedPassword =
                PasswordHelper.HashPassword(password);

            try
            {
                using (SqlConnection conn = Db.GetUserConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO users
                        (full_name, username, password_hash)
                        VALUES
                        (@name, @username, @password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Account created successfully! Please login.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Return to Login form
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Username already exists.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lnkLogin_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
