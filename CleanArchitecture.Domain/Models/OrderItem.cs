namespace MyFakeDatabaseProject.Models;

public class OrderItem
{
    public Guid Id { get; set; }
    public Order? Order { get; set; }
    public Product? Product { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? TotalPrice { get; set; }
}
