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


namespace fitness_app
{
  
        public partial class result : Form
        {
            public static string Username;
            public static double caloriesGoals = 0;

            public result()
            {
                InitializeComponent();
            }

            private void result_Load(object sender, EventArgs e)
            {


            this.Size = new Size(500, 530);

            this.StartPosition = FormStartPosition.CenterScreen;


            double caloriesgoals = caloriesGoals;

            // Update the target goal label with the initial value

            label_target_goal.Text = caloriesGoals.ToString();

                // Retrieve and display the calorie goal for the current user

                RetrieveAndDisplayCalorieGoal();

                // Retrieve and display the current calories burned

                double currentCalories = new CaloriesBurnedResult().GetCaloriesGoalsValue();

                label_current_calories.Text = currentCalories.ToString();

                // update progress bar ...

                UpdateProgressBar(currentCalories);
            }

            private void RetrieveAndDisplayCalorieGoal()
            {


                try
                {
                    Db_connection.Open_con();

                    string query = "SELECT calorie_goal FROM users WHERE username = @Username;";

                    using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() && dr["calorie_goal"] != DBNull.Value)
                            {
                                caloriesGoals = Convert.ToDouble(dr["calorie_goal"]);
                                label_target_goal.Text = caloriesGoals.ToString();
                            }
                            else
                            {
                                caloriesGoals = 0;
                                label_target_goal.Text = "0";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred while retrieving the calorie goal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Db_connection.Close_con();
                }
            }

            private void UpdateProgressBar(double currentCalories)
            {
                int progressBarValue = 0;

                if (caloriesGoals > 0)
                {
                    progressBarValue = (int)(currentCalories / caloriesGoals * 100);

                    if (progressBarValue > 100)
                    {
                        progressBarValue = 100;
                    }
                }

                // Set the progress bar value
                progress_bar.Value = progressBarValue;

                // Set the minimum and maximum values of the progress bar
                progress_bar.Minimum = 0;
                progress_bar.Maximum = 100;

                // Display the progress message based on the progress bar value
                if (progressBarValue >= 100)
                {
                    label_progress_msg.Text = "Congratulations! You are meeting your calorie goal.";
                }
                else
                {
                    label_progress_msg.Text = $"Keep up the good work! You got {progressBarValue}% calorie burned.";
                }

                // Display the progress bar value as a percentage
                label_percent.Text = $"{progressBarValue}%";
            }

            private void back_btn_Click(object sender, EventArgs e)
            {
                
            }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            // Going back to home
            this.Hide();
            home home_dash = new home();
            home_dash.Show();
        }
    }
    }


