namespace CleanArchitecture.Domain.Models;

public class PaymentMethod
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
