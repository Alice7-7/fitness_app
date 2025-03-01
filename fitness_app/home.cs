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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fitness_app
{
    public partial class home : Form
    {
        //  ====> Variables

        public static string Username;
        public static double Calorie_goal;
        public static double Current_calorie_goal;

        Db_connection cn = new Db_connection();

        public home()
        {
            InitializeComponent();
        }


        // Main Home Load :::

        private void home_Load(object sender, EventArgs e)
        {
            // Home form size
            this.Size = new Size(570, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            username_inp.Text = Username;

            // Get the calories goal value from the database
            try
            {
                Db_connection.Open_con();

                string query = "SELECT calorie_goal FROM users WHERE username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (dr["calorie_goal"] == DBNull.Value)
                            {
                                Calorie_goal = 0;
                            }
                            else
                            {
                                Calorie_goal = Convert.ToDouble(dr["calorie_goal"]);
                            }
                        }
                        else
                        {
                            Calorie_goal = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Db_connection.Close_con();
            }

            calorie_goal_inp.Text = Convert.ToString(Calorie_goal);


            // ======================


            // Get the current calorie value from the database
            Db_connection.Open_con();

            double currentCalorieGoal = 0;

            string currentQuery = "SELECT SUM(result) FROM calories_burned_results WHERE username = @Username;";

            using (MySqlCommand cmd = new MySqlCommand(currentQuery, Db_connection.cn))
            {
                cmd.Parameters.AddWithValue("@Username", CaloriesBurnedResult.Username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        currentCalorieGoal = reader.GetDouble(0);
                    }
                }
            }

            Db_connection.Close_con();

            // Display current calorie goal !

            current_calorie_burned.Text = currentCalorieGoal.ToString();

            // Count the number of days the user has used the app
            int daysUsed = 0;

            Db_connection.Open_con();

            string dayQuery = "SELECT COUNT(DISTINCT DATE(date_time)) FROM calories_burned_results WHERE username = @Username;";

            using (MySqlCommand cmd = new MySqlCommand(dayQuery, Db_connection.cn))
            {
                cmd.Parameters.AddWithValue("@Username", CaloriesBurnedResult.Username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        daysUsed = reader.GetInt32(0);
                    }
                }
            }

            Db_connection.Close_con();

            // Display the number of days used
            day_used.Text = daysUsed.ToString();

        }





        // Set Goal button :::

        private void goal_btn_Click(object sender, EventArgs e)
        {
            // To Set Goal

            fitness_goal set_goal = new fitness_goal(Username);
            set_goal.Show();
            this.Hide();
        }

        // Calculate button :::

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            // To calculator

            calorie_calculator calculator = new calorie_calculator();

            calculator.Show();
            this.Hide();
        }

     

        // Result button function ::

        private void result_btn_Click(object sender, EventArgs e)
        {
          
            Db_connection.Open_con();

      
            string query = "SELECT calorie_goal FROM users WHERE username = @Username;";

          
            using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
            {
                cmd.Parameters.AddWithValue("@Username", CaloriesBurnedResult.Username);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Check if the "calorie_goal" field is empty
                        if (string.IsNullOrEmpty(dr["calorie_goal"].ToString()))
                        {
                            MessageBox.Show("Please set your calorie goals first.");
                        }
                        else
                        {
                            // Hide the current form and show the result form
                            this.Hide();
                            result result_form = new result();
                            result_form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please set your calorie goals first.");
                    }
                }
            }

            Db_connection.Close_con();

        }





        // Sign Out button :::

        private void sign_out_btn_Click(object sender, EventArgs e)
        {
            // Redirect to login page

            login signIn = new login();
            signIn.Show();
            this.Hide();
        }


        // Close button :::


        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
