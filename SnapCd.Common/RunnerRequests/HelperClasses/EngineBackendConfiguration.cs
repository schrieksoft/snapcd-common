using SnapCd.Common.Dto.ModuleBackendConfigs;
using SnapCd.Common.Dto.NamespaceBackendConfigs;

namespace SnapCd.Common.RunnerRequests.HelperClasses;

/// <summary>
/// Backend configuration for engine state management.
/// Used during Init operation.
/// </summary>
public class EngineBackendConfiguration
{
    // Terraform/OpenTofu backend configuration
    public bool IgnoreNamespaceBackendConfigs { get; set; }
    public List<NamespaceBackendConfigReadDto> NamespaceBackendConfigs { get; set; } = [];
    public List<ModuleBackendConfigReadDto> ModuleBackendConfigs { get; set; } = [];

    // Pulumi backend configuration
    public PulumiLoginType PulumiLoginType { get; set; }
    public string? PulumiCustomLoginUrl { get; set; }
    public string? PulumiStackName { get; set; }
}
