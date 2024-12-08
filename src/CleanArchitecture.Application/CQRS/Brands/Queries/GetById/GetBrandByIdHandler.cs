using AutoMapper;
using CleanArchitecture.Application.Abstraction;
using CleanArchitecture.Application.Commons.Bases;
using CleanArchitecture.Application.CQRS.Brands.Dtos;
using MediatR;

namespace CleanArchitecture.Application.CQRS.Brands.Queries.GetById;

public class GetBrandByIdHandler : IRequestHandler<GetBrandByIdQuery, BaseResponse<BrandDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private IMapper  _mapper;

    public GetBrandByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<BaseResponse<BrandDto>> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
    {
        var response = new BaseResponse<BrandDto>();
        try
        {
            var brand = await _unitOfWork.Brand.GetAsync(request.Id);

            if (brand is not null)
            {
                response.Data = _mapper.Map<BrandDto>(brand);
                response.Success = true;
                response.Message = "Query succeed!";
            }
        }
        catch (Exception ex)
        {
            response.Message = ex.Message;
        }

        return response;
    }
}
