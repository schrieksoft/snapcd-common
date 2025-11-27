using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleBackendConfigs;

/// <summary>
/// DTO for ModuleBackendConfig responses (GET operations).
/// </summary>
public class ModuleBackendConfigReadDto : ModuleBackendConfigCreateDto, IDto
{
    public Guid Id { get; set; }
}
