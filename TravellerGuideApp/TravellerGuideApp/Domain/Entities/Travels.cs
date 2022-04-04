using System;

namespace Domain
{
    public class Travels
    {
        public int ID { get; set; }
        public int Location_ID { get; set; }
        public int User_ID { get; set; }
        public string Status { get; set; }
        public DateTime Travel_Date { get; set; }
    }
}
