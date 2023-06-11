namespace EcoVenture.Models
{
    public class Weather
    {
        public int WeatherID { get; set; }
        public int LocationID { get; set; }
        public DateTime Date { get; set; }
        public float Temperature { get; set; }
        public string? WeatherConditions { get; set; }
    }
}