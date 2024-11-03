namespace Arvio.DAL.Models;

public class Warehouse
{
    public int WarehouseId { get; set; }
    public string Location { get; set; }
    public int Capacity { get; set; }
    
    public ICollection<Inventory> Inventories { get; set; }
}