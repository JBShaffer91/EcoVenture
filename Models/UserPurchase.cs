namespace EcoVenture.Models
{
    public class UserPurchase
    {
        public int PurchaseID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public DateTime Date { get; set; }
    }
}