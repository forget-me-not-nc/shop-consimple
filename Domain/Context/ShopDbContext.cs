using Domain.Configs.ModelConfigs;
using Domain.Configs.Seeding;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
    public class ShopDbContext: DbContext
    {
        public DbSet<Order> Orders {  get; set; }
        public DbSet<Product> Products {  get; set; }
        public DbSet<Category> Categories {  get; set; }
        public DbSet<OrderProduct> OrderProducts {  get; set; }
        public DbSet<Client> Clients {  get; set; }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderProductConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            DataSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
