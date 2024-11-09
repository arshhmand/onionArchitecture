using AutoMapper;
using MediatR;
using MyFakeDatabaseProject.Abstraction;
using MyFakeDatabaseProject.Application.Customers.Dtos;
using MyFakeDatabaseProject.Commons.Bases;
using MyFakeDatabaseProject.Models;

namespace MyFakeDatabaseProject.Application.Customers.Queries;

public class GetByIdCustomerHandler : IRequestHandler<GetByIdCustomerQuery, BaseResponse<CustomerDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private IMapper _mapper;
    
    public GetByIdCustomerHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    public async Task<BaseResponse<CustomerDto>> Handle(GetByIdCustomerQuery request, CancellationToken cancellationToken)
    {
        var response = new BaseResponse<CustomerDto>();
        try
        {
            var customer = await _unitOfWork.Customers.GetAsync(request.Id);

            if (customer is not null)
            {
                response.Data = _mapper.Map<CustomerDto>(customer);
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
