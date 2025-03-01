using MySql.Data.MySqlClient;
using System;

namespace fitness_app
{
    internal class Metric_Value
    {
        // Encapsulation for data hiding
        private int metricId;
        private string metricName;
        private double metsValue;

        public int MetricId
        {
            get { return metricId; }
            set { metricId = value; }
        }

        public string MetricName
        {
            get { return metricName; }
            set { metricName = value; }
        }

        public double MetsValue
        {
            get { return metsValue; }
            set { metsValue = value; }
        }

        Db_connection cn = new Db_connection();

        // Method to get a Metric value from the database by its name
        public double GetMetricsValue(string metricName)
        {
            double metricsValue = 0;

            try
            {
                Db_connection.Open_con();

                // Use a parameterized query to prevent SQL injection

                string query = "SELECT mets_value FROM metric_value WHERE metric_name = @metricName";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@metricName", metricName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            metricsValue = reader.GetDouble(0);
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

            return metricsValue;
        }
    }
}
