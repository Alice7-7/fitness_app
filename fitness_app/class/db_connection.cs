using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app
{
    internal class Db_connection
    {
        public static MySqlConnection cn = new MySqlConnection("Server=localhost;Database=fitness_app;Uid=root;Pwd=;");

       

        // Open the db connection
        public static void Open_con()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();

            }
        }

        public static void Close_con()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public static void ExecuteQuery(string query)
        {
            Open_con();
            using (MySqlCommand cmd = new MySqlCommand(query, cn))
            {
                cmd.ExecuteNonQuery();
            }
            Close_con();
        }

        public static MySqlDataReader ExecuteReader(string query)
        {
            Open_con();
            MySqlCommand cmd = new MySqlCommand(query, cn);
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

    }

}
