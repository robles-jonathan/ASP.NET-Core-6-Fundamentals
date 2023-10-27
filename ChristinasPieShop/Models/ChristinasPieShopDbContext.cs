using Microsoft.EntityFrameworkCore;

namespace ChristinasPieShop.Models
{
    public class ChristinasPieShopDbContext : DbContext
    {
        public ChristinasPieShopDbContext(DbContextOptions<ChristinasPieShopDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
