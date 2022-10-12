using Levare.Data.Entities;
using Levare.Dtos;

namespace Levare.Repositories.ReportRepository;

public interface IReportRepository
{
    Task<Report> GetReport(int id);

    Task<IEnumerable<Report>> GetReportList(int pageIndex, int pageSize);

    Task<IEnumerable<Report>> GetReportWithRevisions(int id);

    Task<IEnumerable<Report>> GetReportsByClient(int id);

    Task<Report> CreateReport(Report dto);

    Task UpdateReport(int id, Report dto);

    Task DeleteReport(int id);
}