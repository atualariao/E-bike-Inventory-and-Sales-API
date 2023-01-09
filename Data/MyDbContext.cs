using Microsoft.EntityFrameworkCore;

namespace E_bike_Inventory_and_Sales.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EBike> EBikes { get; set; }
        public DbSet<Debt> Debts { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Sale>()
        //        .HasOne(s => s.)
        //        .WithMany(c => c.Sales)
        //        .HasForeignKey(s => s.CustomerId);

        //    modelBuilder.Entity<Customer>()
        //        .HasOne(c => c.Debt)
        //        .WithOne(d => d.Customer)
        //        .HasForeignKey<Debt>(d => d.CustomerId);
        //}
    }
}
