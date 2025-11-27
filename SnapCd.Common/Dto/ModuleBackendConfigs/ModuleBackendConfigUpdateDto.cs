using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleBackendConfigs;

/// <summary>
/// DTO for updating an existing ModuleBackendConfig (PUT operations).
/// </summary>
public class ModuleBackendConfigUpdateDto : ModuleBackendConfigCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
