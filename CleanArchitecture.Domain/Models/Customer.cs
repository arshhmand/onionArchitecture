namespace CleanArchitecture.Domain.Models;

public class Customer
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Address Address { get; set; }
    public DateTime CreatedAt { get; set; }
    public PaymentMethod PreferredPaymentMethod { get; set; }
    public DateTime DateOfBirth { get; set; }
    public ICollection<Order> Orders { get; set; }
}
