namespace SnapCd.Common.Dto.Modules;

/// <summary>
/// DTO for creating a new Module (POST operations).
/// </summary>
public class ModuleCreateDto
{
    public string Name { get; set; } = null!;
    public Guid NamespaceId { get; set; }

    public string SourceRevision { get; set; } = null!;
    public string SourceUrl { get; set; } = null!;

    public string SourceSubdirectory { get; set; } = null!;

    public List<string>? DependsOnModules { get; set; }

    public SourceType SourceType { get; set; } = SourceType.Git;

    public SourceRevisionType SourceRevisionType { get; set; } = SourceRevisionType.Default;

    public WaitForApplyDependencies WaitForApplyDependencies { get; set; } = WaitForApplyDependencies.OnFirstApply;

    public WaitForDestroyDependencies WaitForDestroyDependencies { get; set; } = WaitForDestroyDependencies.Always;

    public int? ApplyApprovalThreshold { get; set; }

    public int? DestroyApprovalThreshold { get; set; }

    public int? ApprovalTimeoutMinutes { get; set; }

    public Guid RunnerId { get; set; }
    public string? RunnerInstanceName { get; set; }

    public string? InitBeforeHook { get; set; }
    public string? InitAfterHook { get; set; }

    public bool IgnoreNamespaceBackendConfigs { get; set; }
    public bool IgnoreNamespaceExtraFiles { get; set; }

    public bool? AutoUpgradeEnabled { get; set; }
    public bool? AutoReconfigureEnabled { get; set; }
    public bool? AutoMigrateEnabled { get; set; }
    public bool? CleanInitEnabled { get; set; }

    public string? PlanBeforeHook { get; set; }
    public string? PlanAfterHook { get; set; }

    public string? PlanDestroyBeforeHook { get; set; }
    public string? PlanDestroyAfterHook { get; set; }

    public string? ApplyBeforeHook { get; set; }
    public string? ApplyAfterHook { get; set; }
    public string? DestroyBeforeHook { get; set; }
    public string? DestroyAfterHook { get; set; }

    public string? OutputBeforeHook { get; set; }
    public string? OutputAfterHook { get; set; }

    public string? ValidateBeforeHook { get; set; }
    public string? ValidateAfterHook { get; set; }

    public StateManagementEngine? Engine { get; set; }

    public PulumiLoginType? PulumiLoginType { get; set; }
    public string? PulumiCustomLoginUrl { get; set; }
    public string? PulumiStackName { get; set; }

    public bool TriggerOnDefinitionChanged { get; set; }

    public bool TriggerOnUpstreamOutputChanged { get; set; }

    public bool TriggerOnSourceChanged { get; set; }

    public bool TriggerOnSourceChangedNotification { get; set; }

    public bool? DriftCheckEnabled { get; set; }
    public int? DriftCheckIntervalMinutes { get; set; }
}
