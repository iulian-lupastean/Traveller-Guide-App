using Domain;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure
{
    public class ImportData
    {
        string connectionString = @"Data Source=DESKTOP-4NUOG8A;Initial Catalog=UNIT_TESTING_ASSIGNMENT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
            sql = " SELECT * from City";
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
                    Price = (double)dataReader.GetValue(4),
                    Location_Type = (string)dataReader.GetValue(5),
                    Latitude = (string)dataReader.GetValue(6),
                    Longitude = (string)dataReader.GetValue(7),
                });
            }
            return locations;
        }

        public void close()
        {
            con.Close();
        }
    }
}
