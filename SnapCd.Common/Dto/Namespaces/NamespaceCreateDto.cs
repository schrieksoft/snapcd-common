namespace SnapCd.Common.Dto.Namespaces;

public class NamespaceCreateDto
{

    public string Name { get; set; } = null!;

    public Guid? StackId { get; set; }

    public string? DefaultInitBeforeHook { get; set; }
    public string? DefaultInitAfterHook { get; set; }
    
    public bool? DefaultAutoUpgradeEnabled { get; set; }
    
    public bool? DefaultAutoReconfigureEnabled { get; set; }
    public bool? DefaultAutoMigrateEnabled { get; set; }
    public bool? DefaultCleanInitEnabled { get; set; }

    public string? DefaultPlanBeforeHook { get; set; }
    public string? DefaultPlanAfterHook { get; set; }

    public string? DefaultPlanDestroyBeforeHook { get; set; }
    public string? DefaultPlanDestroyAfterHook { get; set; }

    public string? DefaultApplyBeforeHook { get; set; }
    public string? DefaultApplyAfterHook { get; set; }

    public string? DefaultOutputBeforeHook { get; set; }
    public string? DefaultOutputAfterHook { get; set; }

    public string? DefaultDestroyBeforeHook { get; set; }
    public string? DefaultDestroyAfterHook { get; set; }

    public string? DefaultValidateBeforeHook { get; set; }
    public string? DefaultValidateAfterHook { get; set; }

    public int? DefaultApplyApprovalThreshold { get; set; }

    public int? DefaultDestroyApprovalThreshold { get; set; }

    public int? DefaultApprovalTimeoutMinutes { get; set; }

    public StateManagementEngine? DefaultEngine { get; set; }

    public PulumiLoginType? DefaultPulumiLoginType { get; set; }
    public string? DefaultPulumiCustomLoginUrl { get; set; }
    public string? DefaultPulumiStackName { get; set; }

    public NamespaceTriggerBehaviour? TriggerBehaviourOnModified { get; set; }

    public bool? DefaultDriftCheckEnabled { get; set; }
    public int? DefaultDriftCheckIntervalMinutes { get; set; }
}