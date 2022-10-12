using AutoMapper;
using Levare.Data.Entities;
using Levare.Dtos;
using Levare.Mediator.Commands;
using Levare.Repositories.ReportRepository;
using MediatR;

namespace Levare.Mediator.Handlers;

public class CreateReportCommandHandler : IRequestHandler<CreateReportCommand, ReportDto>
{
    private readonly IReportRepository _reportRepository;
    private readonly IMapper _mapper;

    public CreateReportCommandHandler(IReportRepository reportRepository, IMapper mapper)
    {
        _reportRepository = reportRepository;
        _mapper = mapper;
    }

    public async Task<ReportDto> Handle(CreateReportCommand request, CancellationToken cancellationToken)
    {
        var reportMappedToEntity = _mapper.Map<Report>(request.Report);

        var asdf = await _reportRepository.CreateReport(reportMappedToEntity);

        return await Task.FromResult(_mapper.Map<ReportDto>(asdf));
    }
}