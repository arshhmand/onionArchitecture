using AutoMapper;
using MediatR;
using MyFakeDatabaseProject.Abstraction;
using MyFakeDatabaseProject.Commons.Bases;
using MyFakeDatabaseProject.Models;

namespace MyFakeDatabaseProject.Application.Customers.Commands;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, BaseResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private IMapper _mapper;

    public CreateCustomerHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    public async Task<BaseResponse<bool>> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
    {
        var response = new BaseResponse<bool>();
        try
        {
            var customer = _mapper.Map<Customer>(command);
            response.Data = await _unitOfWork.Customers.InsertAsync(customer);

            if (response.Data)
            {
                response.Success = true;
                response.Message = "Customer created successfully";
            }
        }
        catch (Exception ex)
        {
            response.Message = ex.Message;
        }

        return response;
    }
}
