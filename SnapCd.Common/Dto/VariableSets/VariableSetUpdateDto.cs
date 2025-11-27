using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.VariableSets;

/// <summary>
/// DTO for updating an existing VariableSet (PUT operations).
/// </summary>
public class VariableSetUpdateDto : VariableSetCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
