using Arvio.DAL.Enums;

namespace Arvio.DAL.Models;

public class Inventory
{
    public int InventoryId { get; set; }  
    public int ProductId { get; set; } 
    public Product Product { get; set; }  
    
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; }  

    public int Quantity { get; set; }
    public InventoryStatus Status { get; set; }  
}