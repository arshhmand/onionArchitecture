using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

public abstract class MediatorController : ControllerBase
{
    protected readonly IMediator Mediator;

    protected MediatorController(IMediator mediator)
    {
        Mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }
}
