using System.ComponentModel.DataAnnotations;

namespace SnapCd.Common.Dto.ModuleBackendConfigs;

/// <summary>
/// DTO for creating a new ModuleBackendConfig (POST operations).
/// </summary>
public class ModuleBackendConfigCreateDto
{
    [Required] [MaxLength(255)] public string Name { get; set; } = string.Empty;

    [MaxLength(1000)] public string Value { get; set; } = null!;

    public Guid ModuleId { get; set; }
}
