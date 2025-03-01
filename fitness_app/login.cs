using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;





// Login Form

namespace fitness_app
{
    public partial class login : Form
    {

        // login fail time

        private int fail_times = 0;

        private Timer timer = new Timer();

        public login()
        {
            InitializeComponent();
            timer.Tick += Login_timer;
        }

        // Database connection
        Db_connection cn = new Db_connection();

        bool mark = false;


        private void login_Load(object sender, EventArgs e)
        {
            // login form size

            this.Size = new Size(600, 420);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // ===> Login Timer :::

        private void Login_timer(object sender, EventArgs e)
        {
            username.ReadOnly = false;
            password.ReadOnly = false;
            sign_in_btn.Enabled = true;
            fail_times = 0;
            timer.Stop();
        }



        // =====> Logging in ....
        private void sign_in_btn_Click(object sender, EventArgs e)
        {

            string Username = username.Text;
            string Password = password.Text;
   

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill all the fields!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string login_query = "SELECT * FROM users WHERE username = @username AND password = @password;";

                using (var cn = new MySqlConnection("Server=localhost;Database=fitness_app;Uid=root;Pwd=;"))
                {
                    try
                    {
                        // Connection Open --->

                        cn.Open();

                        using (var cmd = new MySqlCommand(login_query, cn))
                        {
                            // Parameters to prevent SQL injection

                            cmd.Parameters.AddWithValue("@username", Username);
                            cmd.Parameters.AddWithValue("@password", Password);

                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Hide();

                                    home.Username = Username;

                                    calorie_calculator.Username = Username;
                                    CaloriesBurnedResult.Username = Username;

                                    result.Username = Username;

                                    // Hide current form and show home form
                                    home home_form = new home();
                                    home_form.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Username or password is incorrect . Please try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    fail_times++;

                                    if (fail_times >= 3)
                                    {
                                        // Start a timer to disable the login button for 10 seconds

                                        timer.Interval = 10000; 
                                        timer.Start();

                                        username.ReadOnly = true;
                                        password.ReadOnly = true;
                                        sign_in_btn.Enabled = false;

                                        MessageBox.Show("Too many failed attempts . Please wait for 10 seconds.", "Error");

                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      


        // Close button ---->

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sign Up link --->

        private void sign_up_ln_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Switch login to register

            this.Hide();

            Register sign_up = new Register();

            sign_up.Show();
        }

        // password input hide character --->

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }


        private void hide_pass_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the password 
            mark = !mark;


            hide_pass.BackgroundImage = mark ? Properties.Resources.hide : Properties.Resources.eye;


            password.UseSystemPasswordChar = !mark;
        }

       
    }
}
