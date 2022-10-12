using Levare.Data;
using Levare.Data.Entities;

namespace Levare.Repositories.ReportRepository;

public class ReportRepository : IReportRepository
{
    private readonly LevareDbContext _context;

    public ReportRepository(LevareDbContext context)
    {
        _context = context;
    }

    public async Task<Report> CreateReport(Report dto)
    {
        await _context.AddAsync(dto);
        await _context.SaveChangesAsync();

        return dto;
    }

    public Task DeleteReport(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Report> GetReport(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Report>> GetReportList(int pageIndex, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Report>> GetReportsByClient(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Report>> GetReportWithRevisions(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateReport(int id, Report dto)
    {
        throw new NotImplementedException();
    }
}