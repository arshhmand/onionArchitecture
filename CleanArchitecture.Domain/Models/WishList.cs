namespace MyFakeDatabaseProject.Models;

public class WishList
{
    public Guid Id { get; set; }
    public Customer Customer { get; set; }
    public ICollection<Product> Products { get; set; }
    public DateTime CreatedAt { get; set; }
}