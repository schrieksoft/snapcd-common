using SnapCd.Common.Dto.Misc;
using SnapCd.Common.Dto;
using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;


public class GetModuleRequestBase : TaskRequestBase
{
    public SourceType SourceType { get; set; }
    public SourceRevisionType SourceRevisionType { get; set; }
    public required string SourceUrl { get; set; }
    public required string SourceRevision { get; set; }
    public string? SourceDefinitiveRevision { get; set; }
    public string? SourceSemanticVersion { get; set; }
    public string Engine { get; set; } = "tofu";
    public bool CleanInitEnabled { get; set; }
    public List<ExtraFileDto>? ExtraFiles { get; set; }
}
