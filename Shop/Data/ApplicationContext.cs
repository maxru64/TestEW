using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AutoPartsStore> AutoPartsStore { get; set; }
        public DbSet<Product> Product { get; set; }     

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoPartsStore>().HasData(
                new AutoPartsStore[]
                {
                    new AutoPartsStore { Id=1, Name="Minsk store"},
                    new AutoPartsStore { Id=2, Name="Brest store"},
                    new AutoPartsStore { Id=3, Name="Gomel store"},
                });
            
            modelBuilder.Entity<Product>().HasData(
                new Product[]
                {
                    new Product
                    {
                        Id = 1,
                        Price = 108.95,
                        Description = "Stopping support"
                                  
                    },
                    new Product
                    {
                        Id = 2,
                        Price = 98.17,
                        Description = "Clutch kit"
                    },
                    new Product
                    {
                        Id = 3,
                        Price = 85.05,
                        Description = "Bulb"
                    }
                });

            modelBuilder.Entity<AutoPartsStore>()
                .HasMany(x => x.Products)
                .WithMany(x => x.AutoPartsStores)
                .UsingEntity(j => j.HasData(
                    new { ProductsId = 1, AutoPartsStoresId = 2 },
                    new { ProductsId = 1, AutoPartsStoresId = 1 },
                    new { ProductsId = 2, AutoPartsStoresId = 3 },
                    new { ProductsId = 3, AutoPartsStoresId = 1 },
                    new { ProductsId = 3, AutoPartsStoresId = 2 }));
        }
    }
}
