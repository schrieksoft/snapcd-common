using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;

/// <summary>
/// Request sent from server to runner via SignalR to create a Terraform plan.
/// Plan now receives pre-resolved Terraform variables from the server.
/// </summary>
public class PlanRequestBase : EngineJobRequestBase
{
    public string? PlanBeforeHook { get; set; }
    public string? PlanAfterHook { get; set; }

    public Dictionary<string, string> ResolvedParameters { get; set; } = null!;
}
