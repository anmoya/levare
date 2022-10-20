using AutoMapper;
using Levare.Dtos;
using Levare.Mediator.Queries;
using Levare.Repositories.ReportRepository;
using MediatR;

namespace Levare.Mediator.Handlers;

public class GetReportsQueryHandler : IRequestHandler<GetReportsQuery, IEnumerable<ReportDto>>
{
    private readonly IMapper _mapper;

    private readonly IReportRepository _reportRepository;

    public GetReportsQueryHandler(IMapper mapper, IReportRepository reportRepository)
    {
        _mapper = mapper;
        _reportRepository = reportRepository;
    }

    public async Task<IEnumerable<ReportDto>> Handle(GetReportsQuery request, CancellationToken cancellationToken)
    {
        var asdf = await _reportRepository.GetReportList(request.page, request.size);

        return _mapper.Map<IEnumerable<ReportDto>>(asdf);
    }
}