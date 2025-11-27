using System.ComponentModel.DataAnnotations;

namespace SnapCd.Common.Dto.NamespaceBackendConfigs;

public class NamespaceBackendConfigCreateDto
{
    [Required] [MaxLength(255)] public string Name { get; set; } = string.Empty;

    [MaxLength(1000)] public string Value { get; set; } = null!;

    public Guid NamespaceId { get; set; }
}
