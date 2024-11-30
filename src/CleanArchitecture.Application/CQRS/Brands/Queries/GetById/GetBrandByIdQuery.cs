using CleanArchitecture.Application.Commons.Bases;
using CleanArchitecture.Application.CQRS.Brands.Dtos;
using MediatR;

namespace CleanArchitecture.Application.CQRS.Brands.Queries.GetById;

public class GetBrandByIdQuery : IRequest<BaseResponse<BrandDto>>
{
    public Guid Id { get; set; }
}