using SnapCd.Common.Dto.ModuleBackendConfigs;
using SnapCd.Common.Dto.NamespaceBackendConfigs;

namespace SnapCd.Common.RunnerRequests.HelperClasses;

/// <summary>
/// Backend configuration for Terraform state management.
/// Used during Init operation.
/// </summary>
public class EngineBackendConfiguration
{
    public bool IgnoreNamespaceBackendConfigs { get; set; }
    public List<NamespaceBackendConfigReadDto> NamespaceBackendConfigs { get; set; } = [];
    public List<ModuleBackendConfigReadDto> ModuleBackendConfigs { get; set; } = [];
}
