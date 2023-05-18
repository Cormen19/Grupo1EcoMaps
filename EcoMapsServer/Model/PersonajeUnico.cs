namespace EcoMapsServer.Model
{

    public class PersonajeUnico
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public Origin1 origin { get; set; }
        public Location1 location { get; set; }
        public string image { get; set; }
        public string[] episode { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

    public class Origin1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Location1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
