using AutoMapper;
using Levare.Dtos;
using Levare.Mediator.Queries;
using Levare.Repositories.ReportRepository;
using MediatR;

namespace Levare.Mediator.Handlers;

public class GetReportQueryHandler : IRequestHandler<GetReportQuery, ReportDto>
{
    private readonly IMapper _mapper;

    private readonly IReportRepository _repository;

    public GetReportQueryHandler(IMapper mapper, IReportRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ReportDto> Handle(GetReportQuery request, CancellationToken cancellationToken)
    {
        var report = await _repository.GetReport(request.id);

        return _mapper.Map<ReportDto>(report);
    }
}