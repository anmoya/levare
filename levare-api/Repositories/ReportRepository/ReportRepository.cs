using Levare.Data;
using Levare.Data.Entities;
using Microsoft.EntityFrameworkCore;

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
        await _context.Reports.AddAsync(dto);

        return dto;
    }

    public async Task DeleteReport(int id)
    {
        var reportToDelete = await _context.Reports.Where(w => w.Id == id).SingleAsync();

        _context.Reports.Remove(reportToDelete);
    }

    public async Task<Report> GetReport(int id)
    {
        var report = await _context.Reports.Where(w => w.Id == id).SingleAsync();

        return report;
    }

    public async Task<IEnumerable<Report>> GetReportList(int pageIndex, int pageSize)
    {
        var reports = await _context.Reports.Take(pageSize).Skip(pageSize * pageIndex).ToListAsync();

        return reports;
    }

    public async Task<IEnumerable<Report>> GetReportsByClient(int id)
    {
        var reports = await _context.Reports.Where(w => w.CustomerId == id).ToListAsync();

        return reports;
    }

    public async Task<IEnumerable<Report>> GetReportWithRevisions(int id)
    {
        // var reports = await _context.Reports.Include<Revision>().Where(w => w.Id == id).ToListAsync();
        throw new NotImplementedException();
    }

    public Task UpdateReport(int id, Report dto)
    {
        throw new NotImplementedException();
    }
}