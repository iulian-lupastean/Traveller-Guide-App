using Domain;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure
{
    public class ImportData
    {
        string connectionString = @"Data Source=DESKTOP-4NUOG8A;Initial Catalog=DEMO_Database;Integrated Security=True";
        SqlConnection con;
        public ImportData()
        {
            con = new SqlConnection(connectionString);
        }

        public ConnectionState state()
        {
            return con.State;
        }

        public void open()
        {
            con.Open();
        }
        public List<City> readCities()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            List<City> cities = new List<City>();
            sql = " SELECT * from Cities";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cities.Add(new City
                {
                    ID = (int)dataReader.GetValue(0),
                    Name = (string)dataReader.GetValue(1),
                    Country = (string)dataReader.GetValue(2)
                });
            }
            return cities;
        }
        public List<Location> readLocations()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            List<Location> locations = new List<Location>();
            sql = " SELECT * from Locations";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                locations.Add(new Location
                {
                    ID = (int)dataReader.GetValue(0),
                    Name = (string)dataReader.GetValue(1),
                    City_ID = (int)dataReader.GetValue(2),
                    Address = (string)dataReader.GetValue(3),
                    Location_Type = (string)dataReader.GetValue(4),
                    Price = (double)dataReader.GetValue(5),
                    Latitude = (string)dataReader.GetValue(6),
                    Longitude = (string)dataReader.GetValue(7),
                });
            }

            return locations;
        }
        public List<User> readUsers()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            List<User> users = new List<User>();
            sql = " SELECT * from Users";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                users.Add(new User
                {
                    ID = (int)dataReader.GetValue(0),
                    FirstName = (string)dataReader.GetValue(1),
                    LastName = (string)dataReader.GetValue(2),
                    Email = (string)dataReader.GetValue(3),
                    Password = (string)dataReader.GetValue(4),
                    User_Type = (string)dataReader.GetValue(5)
                });
            }
            return users;
        }

        public List<Travels> readTravels()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            List<Travels> travels = new List<Travels>();
            sql = " SELECT * from Travels";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                travels.Add(new Travels
                {
                    ID = (int)dataReader.GetValue(0),
                    Location_ID = (int)dataReader.GetValue(1),
                    User_ID = (int)dataReader.GetValue(2),
                    Status = (string)dataReader.GetValue(3),
                    Travel_Date = (DateTime)dataReader.GetValue(4),
                });
            }
            return travels;
        }

        public void close()
        {
            con.Close();
        }
    }
}
