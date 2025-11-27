using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;


public class GetDefinitiveRevisionRequest : TaskRequestBase
{
    public SourceType SourceType { get; set; }
    public SourceRevisionType SourceRevisionType { get; set; }
    public required string SourceUrl { get; set; }
    public required string SourceRevision { get; set; }
    public string? SourceDefinitiveRevision { get; set; }
    public string? SourceSemanticVersion { get; set; }
}
