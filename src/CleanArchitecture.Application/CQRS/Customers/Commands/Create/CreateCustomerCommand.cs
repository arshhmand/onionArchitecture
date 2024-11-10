using CleanArchitecture.Application.Commons.Bases;
using CleanArchitecture.Domain.Models;
using MediatR;

namespace CleanArchitecture.Application.CQRS.Customers.Commands.Create;

public class CreateCustomerCommand : IRequest<BaseResponse<bool>>
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
