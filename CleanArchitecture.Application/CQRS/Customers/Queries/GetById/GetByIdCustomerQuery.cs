using MediatR;
using MyFakeDatabaseProject.Application.Customers.Dtos;
using MyFakeDatabaseProject.Commons.Bases;

namespace MyFakeDatabaseProject.Application.Customers.Queries;

public class GetByIdCustomerQuery : IRequest<BaseResponse<CustomerDto>>
{
    public Guid Id { get; set; }
}
