using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceBackendConfigs;

[Obsolete("Use TerraformFlag entities instead.")]
public class NamespaceBackendConfigUpdateDto : NamespaceBackendConfigCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
