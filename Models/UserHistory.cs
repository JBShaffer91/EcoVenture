namespace EcoVenture.Models
{
    public class UserHistory
    {
        public int HistoryID { get; set; }
        public int UserID { get; set; }
        public int LocationID { get; set; }
        public DateTime Date { get; set; }
    }
}