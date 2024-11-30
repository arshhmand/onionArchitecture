using CleanArchitecture.Application.CQRS.Customers.Commands.Create;
using CleanArchitecture.Application.CQRS.Customers.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly IMediator mediator;
    
    public CustomerController(IMediator mediator)
    {
        mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }
    
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] Guid id)
    {
        var response = await mediator.Send(new GetByIdCustomerQuery() { Id = id });
        if (response.Success)
        {
            return Ok(response);
        }

        return BadRequest(response);
    }

    [HttpPost("Create")]
    public async Task<ActionResult> CreateAsync([FromBody] CreateCustomerCommand command)
    {

        var response = await mediator.Send(command);

        if (response.Success)
        {
            return Ok(response);
        }

        return BadRequest(response);
    }
}
