using Levare.Dtos;
using MediatR;

namespace Levare.Mediator.Queries;

public record GetReportsQuery(int page, int size) : IRequest<IEnumerable<ReportDto>>;