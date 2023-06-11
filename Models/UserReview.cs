namespace EcoVenture.Models
{
    public class UserReview
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public string? Review { get; set; }
        public int Rating { get; set; }
    }
}