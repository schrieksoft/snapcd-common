using SnapCd.Common.RunnerRequests.HelperClasses;

namespace SnapCd.Common.RunnerRequests;

public class ApplyFromPlanRequestBase : EngineJobRequestBase
{
    public string? ApplyBeforeHook { get; set; }
    public string? ApplyAfterHook { get; set; }

    public List<PulumiFlagEntry> PulumiFlags { get; set; } = [];
    public List<PulumiArrayFlagEntry> PulumiArrayFlags { get; set; } = [];
}
