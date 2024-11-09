using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using MyFakeDatabaseProject.Application.Customers.Commands;
using MyFakeDatabaseProject.Application.Customers.Queries;

namespace MyFakeDatabaseProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] Guid id)
    {
        var response = await _mediator.Send(new GetByIdCustomerQuery() { Id = id });
        if (response.Success)
        {
            return Ok(response);
        }

        return BadRequest(response);
    }

    [HttpPost("Create")]
    public async Task<ActionResult> CreateAsync([FromBody] CreateCustomerCommand command)
    {

        var response = await _mediator.Send(command);

        if (response.Success)
        {
            return Ok(response);
        }

        return BadRequest(response);
    }
    
}