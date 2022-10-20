using Levare.Dtos;
using MediatR;

namespace Levare.Mediator.Queries;

public record GetReportQuery(int id) : IRequest<ReportDto> { }