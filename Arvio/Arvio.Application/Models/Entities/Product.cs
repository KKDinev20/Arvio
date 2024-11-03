using Arvio.DAL.Enums;

namespace Arvio.DAL.Models;

public class Product
{
    public int ProductId { get; set; }  
    public string Name { get; set; }
    public string SKU { get; set; }
    public decimal Price { get; set; }
    public ProductCategory Category { get; set; }  

    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } 

    public ICollection<Inventory> Inventories { get; set; } 
    public ICollection<Order> Orders { get; set; }
}