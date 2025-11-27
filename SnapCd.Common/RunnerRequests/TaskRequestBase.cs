using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;


public abstract class TaskRequestBase
{
    public Guid JobId { get; set; }
    public Guid OrganizationId { get; set; }
    public JobMetadata Metadata { get; set; } = null!;

    public int ReportActiveJobFrequencySeconds { get; set; } = 60;
}
