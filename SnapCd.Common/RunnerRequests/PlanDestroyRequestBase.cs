using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;

/// <summary>
/// Request sent from server to runner via SignalR to create a Terraform destroy plan.
/// PlanDestroy now receives pre-resolved Terraform variables from the server.
/// </summary>
public class PlanDestroyRequestBase : EngineJobRequestBase
{
    public string? PlanDestroyBeforeHook { get; set; }
    public string? PlanDestroyAfterHook { get; set; }

    public Dictionary<string, string> ResolvedParameters { get; set; } = null!;
}
