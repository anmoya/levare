using AutoMapper;
using Levare.Data.Entities;
using Levare.Dtos;

namespace Levare.Repositories.ReportRepository;

public class FakeReportRepository : IReportRepository
{
    private readonly IMapper _mapper;


    private static List<Report> _reports;

    public FakeReportRepository(IMapper mapper)
    {
        _reports = new List<Report>();
        _mapper = mapper;
    }

    public Task<Report> GetReport(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Report>> GetReportList(int pageIndex, int pageSize)
    {
        return await Task.FromResult(_reports);
    }

    public Task<IEnumerable<Report>> GetReportWithRevisions(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Report>> GetReportsByClient(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Report> CreateReport(Report dto)
    {
        try
        {

            _reports.Add(dto);

            dto.CreatedAt = DateTime.UtcNow;
            dto.CreatedBy = 1;

            return await Task.FromResult(dto);
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public Task UpdateReport(int id, Report dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteReport(int id)
    {
        throw new NotImplementedException();
    }
}