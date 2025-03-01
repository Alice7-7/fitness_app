using MySql.Data.MySqlClient;
using System;

namespace fitness_app
{
    internal class CaloriesBurnedResult
    {
        // Encapsulation
        private int id;
        private double result;
        private string activity;
        private double weight;
        private int duration;

        public static string Username { get; set; }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        public string Activity
        {
            get { return activity; }
            set { activity = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        // Calculates the total calories burned by a user
        public double GetCaloriesGoalsValue()
        {
            double currentCalorieValue = 0;

            string query = "SELECT SUM(result) FROM calories_burned_results WHERE username = @Username;";

            try
            {
                Db_connection.Open_con();

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            currentCalorieValue = reader.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Db_connection.Close_con();
            }

            return currentCalorieValue;
        }
    }
}
