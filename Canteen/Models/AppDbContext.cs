using Microsoft.EntityFrameworkCore;

namespace Canteen.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<User>()
                .HasMany(u => u.FoodItems)
                .WithOne(f => f.CreatedByUser)
                .HasForeignKey(f => f.CreatedByUserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Staffs)
                .WithOne(s => s.CreatedByUser)
                .HasForeignKey(s => s.CreatedByUserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.CreatedByUser)
                .HasForeignKey(o => o.CreatedByUserId)
                .OnDelete(DeleteBehavior.SetNull);
        }

    }
}
