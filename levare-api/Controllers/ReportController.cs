using Levare.Dtos;
using Levare.Mediator.Commands;
using Levare.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Levare.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportController : ControllerBase
{
    private readonly ISender _sender;

    public ReportController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    public async Task<ActionResult> Post(ReportCreateDto dto)
    {
        var asdf = await _sender.Send(new CreateReportCommand(dto));
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var asdf = await _sender.Send(new GetReportsQuery());

        return Ok(asdf);
    }
}