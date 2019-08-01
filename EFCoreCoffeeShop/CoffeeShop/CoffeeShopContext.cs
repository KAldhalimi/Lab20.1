using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCoffeeShop.CoffeeShop
{
    public class CoffeeShopContext :DbContext
    {
        public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options) : base(options)
        { }
        public DbSet<UserInfo> User { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(c => c.ProductId);

            #region OwnedTypeSeed
            modelBuilder.Entity<Product>().HasData(
                new { ProductId = 1, Name = "Hot Chocolate", Price = 2.50, Quantity= 10 },
                new { ProductId = 2, Name = "Coffee", Price = 1.50, Quantity = 10 },
                new { ProductId = 3, Name = "Latte", Price = 3.50, Quantity = 10 });
            #endregion
        }

    }
}
