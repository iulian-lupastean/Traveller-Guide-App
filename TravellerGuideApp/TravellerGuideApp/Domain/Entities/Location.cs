using System;

namespace Domain
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int City_ID { get; set; }

        public string Address { get; set; }
        public string Location_Type { get; set; }

        public double Price { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name} {City_ID} {Address} {Location_Type} {Price}  {Latitude} {Longitude}";
        }


        public override bool Equals(object obj)
        {
            Location location = obj as Location;
            if (location == null)
            {
                return false;
            }
            else
            {
                return ID == location.ID &&
                    Name == location.Name &&
                    City_ID == location.City_ID &&
                    Address == location.Address &&
                    Location_Type == location.Location_Type &&
                    Price == location.Price &&
                    Latitude == location.Latitude &&
                    Longitude == location.Longitude;

            }



        }
    }
}
