using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fitness_app
{
    public partial class calorie_calculator : Form
    {
        //Static variable to hold the username of active current user

        public static string Username;

        public static double caloriesGoals;


        Db_connection cn = new Db_connection();

        public calorie_calculator()
        {
            InitializeComponent();
        }

        // Calorie Calculator Load

        private void calorie_calculator_Load(object sender, EventArgs e)
        {
            // calorie_calculator size

            this.Size = new Size(580, 590);

            this.StartPosition = FormStartPosition.CenterScreen;

            dp_description.Enabled = dp_activity.SelectedIndex != -1;
        }

        // Activity Section :::

        private void dp_activity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable or Disable [Description] dropdown list

            dp_description.Enabled = dp_activity.SelectedIndex != -1;

            if (!dp_description.Enabled)
            {
                return;
            }

            string activityName = dp_activity.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(activityName))
            {
                // Handle the case where the activity name is null or empty, if needed
                return;
            }

            List<string> metricsArray = new FitnessActivity().GetMetricsForActivity(activityName);

            // Clear existing items in the description dropdown list

            dp_description.Items.Clear();

            // Add items from metricsArray >> for the description list

            foreach (var metric in metricsArray)
            {
                dp_description.Items.Add(metric);
            }


        }


        private void dp_description_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dp_description.SelectedItem != null)
            {
                string selectedMetricName = dp_description.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(selectedMetricName))
                {
                    MessageBox.Show("Selected metric is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double metricsValue = new Metric_Value().GetMetricsValue(selectedMetricName);

                // Display the metrics value in a label

                label_met_result.Text = metricsValue.ToString();
            }
        }


        private void calculate_btn_Click(object sender, EventArgs e)
        {
            // Checking all fields are filled ...

            if (string.IsNullOrWhiteSpace(dp_weight_txt.Text) || string.IsNullOrWhiteSpace(dp_activity_time_txt.Text) ||
                dp_activity.SelectedIndex == -1 || dp_description.SelectedIndex == -1 || dp_weight.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the input fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if weight and activity time are valid numbers

            if (!double.TryParse(dp_weight_txt.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dp_activity_time_txt.Text, out int time))
            {
                MessageBox.Show("Please enter a valid activity time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the MET value from the 'Description' combobox list

            if (!double.TryParse(label_met_result.Text, out double metValue))
            {
                MessageBox.Show("Invalid MET value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Open the database connection
                Db_connection.Open_con();

                // Use parameterized query to prevent SQL injection

                string query = "SELECT calorie_goal FROM users WHERE username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (dr.IsDBNull(dr.GetOrdinal("calorie_goal")))
                            {
                                MessageBox.Show("Please set goals first", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            double caloriesGoal = dr.GetDouble(dr.GetOrdinal("calorie_goal"));

                            if (caloriesGoal == 0)
                            {
                                MessageBox.Show("Please set goals first", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Calculate the result based on the weight unit selected

                            double result;


                            if (dp_weight.SelectedIndex == 0) 
                            {
                                result = time * (metValue * 3.5 * weight) / 200;
                            }
                            else 
                            {
                                weight *= 0.45;
                                result = time * (metValue * 3.5 * weight) / 200;
                            }

                            // Display the result 

                            label_result_cal.Text = result.ToString("F2");
                        }
                        else
                        {
                            MessageBox.Show("Please set goals first", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error ! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the database connection is closed
                Db_connection.Close_con();
            }
        }

        // ===




        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            // Check if a result has been calculated before proceeding
            if (string.IsNullOrEmpty(label_result_cal.Text))
            {
                MessageBox.Show("Please calculate the result before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Get the selected activity name

                if (dp_activity.SelectedItem == null)
                {
                    MessageBox.Show("Please select an activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string activity = dp_activity.SelectedItem.ToString();

                // Check if weight and duration are valid numbers

                if (!double.TryParse(dp_weight_txt.Text, out double weight))
                {
                    MessageBox.Show("Please enter a valid weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(dp_activity_time_txt.Text, out int duration))
                {
                    MessageBox.Show("Please enter a valid duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(label_result_cal.Text, out double result))
                {
                    MessageBox.Show("Invalid result value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate the date and time the result was calculated

                DateTime dateTime = DateTime.Now;

                // Get the day of the week

                DayOfWeek dayOfWeek = dateTime.DayOfWeek;

                // Insert the result into the database

                string query = "INSERT INTO calories_burned_results (result, activity, weight, duration, date_time, day_of_week, username) " +
                               "VALUES (@result, @activity, @weight, @duration, @date_time, @day_of_week, @username)";

                Db_connection.Open_con();

                using (MySqlCommand command = new MySqlCommand(query, Db_connection.cn))
                {
                    command.Parameters.AddWithValue("@result", result);
                    command.Parameters.AddWithValue("@activity", activity);
                    command.Parameters.AddWithValue("@weight", weight);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@date_time", dateTime);
                    command.Parameters.AddWithValue("@day_of_week", dayOfWeek.ToString());

                    command.Parameters.AddWithValue("@username", Username);
                    command.ExecuteNonQuery();
                }

                Db_connection.Close_con();

                // Redirect to result form

                this.Hide();
                result resultForm = new result();
                resultForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Db_connection.Close_con();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_result_cal.Text))
            {
                try
                {
                    // Validate if the selected activity is not null
                    if (dp_activity.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Get the selected activity name
                    string activity = dp_activity.SelectedItem.ToString();

                    // Validate and parse weight
                    if (!double.TryParse(dp_weight_txt.Text, out double weight))
                    {
                        MessageBox.Show("Please enter a valid weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate and parse activity duration
                    if (!int.TryParse(dp_activity_time_txt.Text, out int duration))
                    {
                        MessageBox.Show("Please enter a valid duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate and parse result
                    if (!double.TryParse(label_result_cal.Text, out double result))
                    {
                        MessageBox.Show("Invalid result value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Calculate the date and time the result was calculated
                    DateTime dateTime = DateTime.Now;

                    // Get the day of the week
                    DayOfWeek dayOfWeek = dateTime.DayOfWeek;

                    // Open the database connection
                    Db_connection.Open_con();

                    // Insert the result into the database
                    string query = "INSERT INTO calories_burned_results (result, activity, weight, duration, date_time, day_of_week, username) " +
                                   "VALUES (@result, @activity, @weight, @duration, @date_time, @day_of_week, @username)";

                    using (MySqlCommand command = new MySqlCommand(query, Db_connection.cn))
                    {
                        command.Parameters.AddWithValue("@result", result);
                        command.Parameters.AddWithValue("@activity", activity);
                        command.Parameters.AddWithValue("@weight", weight);
                        command.Parameters.AddWithValue("@duration", duration);
                        command.Parameters.AddWithValue("@date_time", dateTime);
                        command.Parameters.AddWithValue("@day_of_week", dayOfWeek.ToString());

                        command.Parameters.AddWithValue("@username", Username);
                        command.ExecuteNonQuery();
                    }

                    // Close the database connection
                    Db_connection.Close_con();

                    // Redirect to Home (Dashboard)

                    this.Hide();
                    home homeForm = new home();
                    homeForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Db_connection.Close_con();
                }
            }
            else
            {
                // Redirect to Home (Dashboard)

                this.Hide();
                home homeForm = new home();
                homeForm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



