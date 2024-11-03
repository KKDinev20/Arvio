namespace Arvio.DAL.Models;

public class Supplier
{
    public int SupplierId { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public int Rating { get; set; }
    
    public ICollection<Product> Products { get; set; }
}