using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Modules;

/// <summary>
/// DTO for updating an existing Module (PUT operations).
/// </summary>
public class ModuleUpdateDto : ModuleCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
