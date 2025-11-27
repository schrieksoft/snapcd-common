using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;

/// <summary>
/// Request sent from server to runner via SignalR to validate the Terraform/OpenTofu configuration.
/// </summary>
public class ValidateRequestBase : EngineJobRequestBase
{
    public string? ValidateBeforeHook { get; set; }
    public string? ValidateAfterHook { get; set; }
}
