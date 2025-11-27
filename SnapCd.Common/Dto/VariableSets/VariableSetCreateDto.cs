using SnapCd.Common.Dto.Variables;

namespace SnapCd.Common.Dto.VariableSets;

/// <summary>
/// DTO for creating a new VariableSet (POST operations).
/// </summary>
public class VariableSetCreateDto
{
    public long Timestamp { get; set; }

    public string Checksum { get; set; } = null!;
    public List<VariableCreateDto>? Variables { get; set; }
}
