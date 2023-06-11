namespace EcoVenture.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public float Price { get; set; }
    }
}