using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace fitness_app
{
    public partial class Register : Form
    {
        // Database connection
        Db_connection cn = new Db_connection();

        bool mark = false;

        public Register()
        {
            InitializeComponent();
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form size

            this.Size = new Size(600, 550);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_in_ln_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Switch register to login

            this.Hide();

            login sign_in = new login();

            sign_in.Show();
        }



        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow letters and numbers in the password field

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; 
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void re_password_TextChanged(object sender, EventArgs e)
        {
            re_password.UseSystemPasswordChar = true;
        }


        // ====> Register function start here 

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            // Define pattern
            string usernamePattern = "^[a-zA-Z0-9]*$";
            string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z]).{12,}$";

            // Validate inputs
            string usernameInput = username.Text;
            string passwordInput = password.Text;
            string rePasswordInput = re_password.Text;

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput) || string.IsNullOrEmpty(rePasswordInput))
            {
                MessageBox.Show("Please fill all the input fields");
                return;
            }
            else
            {
                // Validate the username
                if (!Regex.IsMatch(usernameInput, usernamePattern))
                {
                    MessageBox.Show("Username contains invalid characters. Only letters and numbers are allowed.");
                    return;
                }

                // Validate the password
                if (!Regex.IsMatch(passwordInput, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 12 characters long and contain at least one lowercase letter and one uppercase letter.");
                    return;
                }

                // Check if password and confirm password match
                if (passwordInput != rePasswordInput)
                {
                    MessageBox.Show("Password and re-type password do not match");
                    return;
                }
            }

            // Check if the username already exists in the database

            try
            {
                Db_connection.Open_con();

                string query = "SELECT * FROM users WHERE username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", usernameInput);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Username is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                // Insert new user into the database

                query = "INSERT INTO users(username, password) VALUES (@Username, @Password)";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", usernameInput);
                    cmd.Parameters.AddWithValue("@Password", passwordInput);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    login signIn = new login();
                    signIn.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Db_connection.Close_con();
            }
        }



        private void hide_pass_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the password 
            mark = !mark;


            hide_pass.BackgroundImage = mark ? Properties.Resources.hide : Properties.Resources.eye;


            password.UseSystemPasswordChar = !mark;

        }

        private void hide_re_pass_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the confirm password 

            mark = !mark;


            hide_re_pass.BackgroundImage = mark ? Properties.Resources.hide : Properties.Resources.eye;


            re_password.UseSystemPasswordChar = !mark;
        }

      
    }
}
