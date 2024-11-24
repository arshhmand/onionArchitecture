using AutoMapper;
using CleanArchitecture.Application.Abstraction;
using CleanArchitecture.Application.Commons.Bases;
using CleanArchitecture.Application.CQRS.Customers.Dtos;
using CleanArchitecture.Domain.Models;
using MediatR;

namespace CleanArchitecture.Application.CQRS.Customers.Commands.Create;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, BaseResponse<bool>>
{
    private readonly ICustomerRepository _customerRepository;

    public CreateCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<BaseResponse<bool>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var customer = new Customer
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                PreferredPaymentMethod = request.PreferredPaymentMethod,
                DateOfBirth = request.DateOfBirth
            };

            await _customerRepository.InsertAsync(customer);

            return new BaseResponse<bool>
            {
                Success = true,
                Data = true,
                Message = "Customer created successfully."
            };
        }
        catch (Exception ex)
        {
            return new BaseResponse<bool>
            {
                Success = false,
                Data = false,
                Message = "An error occurred while creating the customer.",
                Errors = new List<BaseError>
                {
                    new BaseError
                    {
                        PropertyMessage = "CustomerCreation",
                        ErrorMessage = ex.Message
                    }
                }
            };
        }
    }
}