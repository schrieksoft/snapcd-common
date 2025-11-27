using SnapCd.Common.Dto.Variables;
using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.VariableSets;

/// <summary>
/// DTO for VariableSet responses (GET operations).
/// </summary>
public class VariableSetReadDto : VariableSetCreateDto, IDto
{
    public Guid Id { get; set; }
    
    public Guid ModuleId { get; set; }
    public new List<VariableReadDto>? Variables { get; set; }
}
