namespace MyFakeDatabaseProject.Models;

public class Review
{
    public Guid Id { get; set; }
    public Product Product { get; set; }
    public Customer Customer { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
    public DateTime CreatedAt { get; set; }
}
