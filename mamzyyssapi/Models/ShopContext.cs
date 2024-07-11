using Microsoft.EntityFrameworkCore;

namespace mamzyyssapi.Models
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clothing>()
                .HasMany(c => c.Products)
                .WithOne(a => a.Clothing)
                .HasForeignKey(a => a.ClothingId);

            modelBuilder.Seed();
        }

        public DbSet<Items> Products { get; set; }
        public DbSet<Clothing> Categories { get; set; }
    }
}
