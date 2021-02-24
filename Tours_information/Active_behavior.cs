using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.tours_information
{
    public class Active_behavior : ITours_information
    {
        SqlConnection sql_connection;
        private string tour;

        public Active_behavior(string tour)
        {
            this.tour = tour;
        }

        public Tuple<double, double, double> Get_tours_information(string tour)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OOP\Travel_agency\tours_information\Tours_Database.mdf;Integrated Security=True";
            sql_connection = new SqlConnection(connection_string);
            sql_connection.Open();
            SqlDataReader sql_reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [ACTIVE] WHERE [tour] = @tour", sql_connection);
            command.Parameters.AddWithValue("tour", tour);
            sql_reader = command.ExecuteReader();
            while (sql_reader.Read())
            {
                a = Convert.ToDouble(sql_reader["intertainment"]);
                b = Convert.ToDouble(sql_reader["attraction"]);
                c = Convert.ToDouble(sql_reader["extreme"]);
            }

            if (sql_reader != null)
            {
                sql_reader.Close();
            }

            if (sql_connection != null && sql_connection.State != ConnectionState.Closed)
            {
                sql_connection.Close();
            }
            return Tuple.Create(a, b, c);
        }
    }
}
