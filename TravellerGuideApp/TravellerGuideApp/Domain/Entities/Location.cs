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
            return $"{ID} {Name} {City_ID} {Address} {Price} {Location_Type} {Latitude} {Longitude}";
        }
    }
}
