using Ozon.ReportProvider.Domain.Entities;
using Ozon.ReportProvider.Domain.Events;

namespace Ozon.ReportProvider.Domain.Interfaces.Services;

public interface IReportRequestService
{
    Task StoreReportRequests(ReportRequestEvent[] reportRequestEvents, CancellationToken token);
    Task<ReportRequestEntityV1[]> GetUncompletedReportRequests(int limit, CancellationToken token);
}