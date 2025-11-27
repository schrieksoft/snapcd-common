using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.DependsOnModules;

/// <summary>
/// DTO for updating an existing DependsOnModule (PUT operations).
/// </summary>
public class DependsOnModuleUpdateDto : DependsOnModuleCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
