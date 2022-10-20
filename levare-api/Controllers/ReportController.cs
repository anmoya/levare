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
    public async Task<ActionResult> GetList(int page, int size)
    {
        var asdf = await _sender.Send(new GetReportsQuery(page, size));

        return Ok(asdf);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        var report = await _sender.Send(new GetReportQuery(id));

        return Ok(report);
    }
}