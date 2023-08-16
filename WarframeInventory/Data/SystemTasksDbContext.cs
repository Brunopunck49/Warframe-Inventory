using Microsoft.EntityFrameworkCore;
using WarframeInventory.Models;

namespace WarframeInventory.Data
{
    public class SystemTasksDbContext : DbContext
    {
        public SystemTasksDbContext(DbContextOptions<SystemTasksDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<WarframeModel> Warframes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
