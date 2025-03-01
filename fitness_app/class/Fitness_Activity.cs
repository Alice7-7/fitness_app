using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app
{
    internal class FitnessActivity
    {
        // Encapsulation ...

        private int activities_id;
        private string activityName;
        private string metric1;
        private string metric2;
        private string metric3;

        public int ActivityId
        {
            get { return activities_id; }
            set { activities_id = value; }
        }

        public string ActivityName
        {
            get { return activityName; }
            set { activityName = value; }
        }

        public string Metric1
        {
            get { return metric1; }
            set { metric1 = value; }
        }

        public string Metric2
        {
            get { return metric2; }
            set { metric2 = value; }
        }

        public string Metric3
        {
            get { return metric3; }
            set { metric3 = value; }
        }

        Db_connection cn = new Db_connection();

        // Method to get a list of metrics for a given activity name
        public List<string> GetMetricsForActivity(string activityName)
        {
            // Initialize an empty list to store the metrics

            List<string> metrics = new List<string>();

            try
            {
               
                Db_connection.Open_con();

             
                string query = "SELECT metric1, metric2, metric3 FROM fitness_activities WHERE activity_name = @ActivityName";

                using (MySqlCommand cmd = new MySqlCommand(query, Db_connection.cn))
                {
                    // Add the parameter to the query
                    cmd.Parameters.AddWithValue("@ActivityName", activityName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Read each row in the result and add each metric to the list
                        while (reader.Read())
                        {
                            metrics.Add(reader.GetString(0));
                            metrics.Add(reader.GetString(1));
                            metrics.Add(reader.GetString(2));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
               
                Db_connection.Close_con();
            }

            // Return the list of metrics
            return metrics;
        }

    }

}




