using Arvio.DAL.Enums;

namespace Arvio.DAL.Models;

public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }  
    public User User { get; set; }  

    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }  
    
    public decimal TotalAmount { get; set; }

    public ICollection<Product> Products { get; set; }
}