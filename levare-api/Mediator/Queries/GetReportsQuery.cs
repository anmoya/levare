using Levare.Dtos;
using MediatR;

namespace Levare.Mediator.Queries;

public record GetReportsQuery : IRequest<IEnumerable<ReportDto>>;