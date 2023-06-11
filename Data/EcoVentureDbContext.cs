using Microsoft.EntityFrameworkCore;
using EcoVenture.Models;

namespace EcoVenture.Data
{
    public class EcoVentureDbContext : DbContext
    {
        public EcoVentureDbContext(DbContextOptions<EcoVentureDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<PackingList> PackingLists { get; set; } = null!;
        public DbSet<ProductRecommendation> ProductRecommendations { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Season> Seasons { get; set; } = null!;
        public DbSet<UserHistory> UserHistories { get; set; } = null!;
        public DbSet<UserPurchase> UserPurchases { get; set; } = null!;
        public DbSet<UserReview> UserReviews { get; set; } = null!;
        public DbSet<Weather> WeatherConditions { get; set; } = null!;
    }
}
