using CleanArchitecture.Application.Commons.Bases;
using CleanArchitecture.Application.CQRS.Customers.Dtos;
using MediatR;

namespace CleanArchitecture.Application.CQRS.Customers.Queries.GetById;

public class GetByIdCustomerQuery : IRequest<BaseResponse<CustomerDto>>
{
    public Guid Id { get; set; }
}
