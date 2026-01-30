using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;

/// <summary>
/// Request sent from server to runner via SignalR to get Terraform outputs.
/// </summary>
public class OutputRequestBase : EngineJobRequestBase
{
    public string? OutputBeforeHook { get; set; }
    public string? OutputAfterHook { get; set; }
    public List<string>? ExtraFileNames { get; set; }
}
