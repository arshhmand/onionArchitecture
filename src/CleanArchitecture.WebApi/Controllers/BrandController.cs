using CleanArchitecture.Application.CQRS.Brands.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrandController : MediatorController
{
    public BrandController(IMediator mediator) : base(mediator) { }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBrandById(Guid id)
    {
        var response = await Mediator.Send(new GetBrandByIdQuery { Id = id });
        return Ok(response);
    }
}