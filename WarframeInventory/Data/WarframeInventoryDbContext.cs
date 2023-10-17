using Microsoft.EntityFrameworkCore;
using WarframeInventory.Data.Map;
using WarframeInventory.Models;

namespace WarframeInventory.Data
{
    public class WarframeInventoryDbContext : DbContext
    {
        public WarframeInventoryDbContext(DbContextOptions<WarframeInventoryDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<WarframeModel> Warframes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new WarframeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
