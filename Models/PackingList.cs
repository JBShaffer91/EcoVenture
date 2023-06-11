namespace EcoVenture.Models
{
    public class PackingList
    {
        public int PackingListID { get; set; }
        public int UserID { get; set; }
        public int LocationID { get; set; }
        public int SeasonID { get; set; }
        public int WeatherID { get; set; }
        public string? Items { get; set; }
    }
}