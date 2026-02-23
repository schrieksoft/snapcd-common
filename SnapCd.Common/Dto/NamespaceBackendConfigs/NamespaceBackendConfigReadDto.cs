using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceBackendConfigs;

[Obsolete("Use TerraformFlag entities instead.")]
public class NamespaceBackendConfigReadDto : NamespaceBackendConfigCreateDto, IDto
{
    public Guid Id { get; set; }
}