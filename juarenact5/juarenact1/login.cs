
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace juarenact1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            
            LnkRegister.LinkClicked += LnkRegister_LinkClicked;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                using(SqlConnection conn = Db.GetUserConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT password_hash, full_name
                        FROM users
                        WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash =
                                    reader["password_hash"].ToString();

                                string fullName =
                                    reader["full_name"].ToString();

                                if (PasswordHelper.VerifyPassword(
                                    password, storedHash))
                                {
                                    MessageBox.Show(
                                        "Welcome, " + fullName + "!"
                                    );

                                    // Open MainMenu form
                                    MainMenu mainMenu = new MainMenu(this);
                                    mainMenu.Show();

                                    // Hide Login form
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void LnkRegister_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerForm = new register();

            registerForm.Show();
            this.Hide();

            registerForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
        }
    }
}
