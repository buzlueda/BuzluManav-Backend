using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class BuzluManavContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=BuzluManav;Trusted_Connection=True;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Order>? Orders { get; set; }
    public DbSet<OperationClaim>? OperationClaims { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<UserOperationClaim>? UserOperationClaims { get; set; }
}

