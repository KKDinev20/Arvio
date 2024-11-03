using Arvio.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Arvio.DAL;

public class ArvioDbContext : DbContext
{
    public ArvioDbContext(DbContextOptions<ArvioDbContext> options) : base(options) {}
    
    public DbSet<User> Users { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
}