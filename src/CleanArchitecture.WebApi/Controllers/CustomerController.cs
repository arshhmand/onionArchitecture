using CleanArchitecture.Application.CQRS.Customers.Commands.Create;
using CleanArchitecture.Application.CQRS.Customers.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : MediatorController
{
    public CustomerController(IMediator mediator) : base(mediator) { }

    
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] Guid id)
    {
        var response = await Mediator.Send(new GetByIdCustomerQuery() { Id = id });
        if (response.Success)
        {
            return Ok(response);
        }

        return BadRequest(response);
    }

    [HttpPost("Create")]
    public async Task<ActionResult> CreateAsync([FromBody] CreateCustomerCommand command)
    {

        var response = await Mediator.Send(command);

        if (response.Success)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }
}
