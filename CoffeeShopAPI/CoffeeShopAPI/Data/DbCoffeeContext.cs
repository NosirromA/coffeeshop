using CoffeeShopAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopAPI.Data;

public class DbCoffeeContext : DbContext
{
    public DbCoffeeContext(DbContextOptions<DbCoffeeContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var coffeeData = new List<CoffeeType>();
        coffeeData.Add(
            new CoffeeType { Id = 1, Name = "Latte", Description = "Coffee with milk", Stock = 10, Price = 4.50, Sku = 45 }
        );
        coffeeData.Add(
            new CoffeeType { Id = 2, Name = "Cappuccino", Description = "A cappuccino is an espresso-based coffee drink that originated in Italy", Stock = 1, Price = 2.50, Sku = 46 }
        );
        coffeeData.Add(
            new CoffeeType { Id = 3, Name = "Espresso", Description = "If you call it an Expresso you get barred for life", Stock = 0, Price = 13.99, Sku = 99 }
        );
        modelBuilder.Entity<CoffeeType>().HasData(coffeeData);

    }

    public DbSet<CoffeeType> CoffeeTypes => Set<CoffeeType>();

    public DbSet<Discount> Discounts => Set<Discount>();

    public DbSet<Payment> Payments => Set<Payment>();

    public DbSet<Receipt> Receipts => Set<Receipt>();

    public DbSet<Topping> Toppings => Set<Topping>();
}
