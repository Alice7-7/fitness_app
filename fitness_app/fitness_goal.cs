using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace fitness_app
{
    public partial class fitness_goal : Form
    {
        private string username;

        Db_connection cn = new Db_connection();

        public fitness_goal(string Username)
        {
            InitializeComponent();
            username = Username;
        }

        // Fitness Goal Load :::

        private void fitness_goal_Load(object sender, EventArgs e)
        {
            this.Size = new Size(530, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                Db_connection.Open_con();

                string query = "SELECT calorie_goal FROM users WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int currentCaloriesGoal = Convert.ToInt32(result);

                        err_msg.Text = $"You have already set your calories goal to {currentCaloriesGoal}.";

                        calorie_goal_input.Text = currentCaloriesGoal.ToString();

                        next_btn.Visible = true;
                        update_btn.Visible = true;
                        set_goal_btn.Visible = false;
                    }
                    else
                    {
                        err_msg.Text = "Please enter your calories goal.";
                        next_btn.Visible = false;
                        update_btn.Visible = false;
                    }
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

        // Setting Goal


        private void set_goal_btn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(calorie_goal_input.Text, out double caloriesGoals) || string.IsNullOrWhiteSpace(calorie_goal_input.Text))
            {
                MessageBox.Show("Please enter a valid number for Calories Goals.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Db_connection.Open_con();

                string updateQuery = "UPDATE users SET calorie_goal = @caloriesGoals WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@caloriesGoals", caloriesGoals);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(" Calories Goal set Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                calorie_calculator.caloriesGoals = caloriesGoals;
                result.caloriesGoals = caloriesGoals;

                next_btn.Visible = true;

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

        // Update :::

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(calorie_goal_input.Text, out double caloriesGoals) || string.IsNullOrWhiteSpace(calorie_goal_input.Text))
            {
                MessageBox.Show("Please enter a valid number for Calories Goals.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Db_connection.Open_con();

                string query = "SELECT calorie_goal FROM users WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        double currentCalorieGoal = Convert.ToDouble(result);
                        DialogResult dialogResult = MessageBox.Show($"You have already set your calories goal to {currentCalorieGoal}. Are you sure you want to change it to {caloriesGoals}?", "Change Calories Goal", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            string updateQuery = "UPDATE users SET calorie_goal = @caloriesGoals WHERE username = @username";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, Db_connection.cn))
                            {
                                updateCmd.Parameters.AddWithValue("@caloriesGoals", caloriesGoals);
                                updateCmd.Parameters.AddWithValue("@username", username);
                                updateCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Calories Goal Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            calorie_calculator.caloriesGoals = caloriesGoals;

                           // result.caloriesGoals = caloriesGoals;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existing calorie goal found for this user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            calorie_calculator cal = new calorie_calculator();
            cal.Show();
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            home homie = new home();
            homie.Show();
        }
    }

}
