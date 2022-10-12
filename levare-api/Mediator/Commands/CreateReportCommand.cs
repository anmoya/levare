using Levare.Dtos;
using MediatR;

namespace Levare.Mediator.Commands;

public record CreateReportCommand(ReportCreateDto Report) : IRequest<ReportDto>;