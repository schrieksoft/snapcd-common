using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;

public class DestroyFromPlanRequestBase : EngineJobRequestBase
{
    public string? DestroyBeforeHook { get; set; }
    public string? DestroyAfterHook { get; set; }
}
