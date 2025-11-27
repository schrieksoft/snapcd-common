using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.DependsOnModules;

/// <summary>
/// DTO for DependsOnModule responses (GET operations).
/// </summary>
public class DependsOnModuleReadDto : DependsOnModuleCreateDto, IDto
{
    public Guid Id { get; set; }
}
