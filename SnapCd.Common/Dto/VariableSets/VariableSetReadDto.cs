using SnapCd.Common.Dto.Variables;
using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.VariableSets;

/// <summary>
/// DTO for VariableSet responses (GET operations).
/// </summary>
public class VariableSetReadDto : IDto
{
    public Guid Id { get; set; }

    public Guid ModuleId { get; set; }

    public long Timestamp { get; set; }

    public string Checksum { get; set; } = null!;

    public List<VariableReadDto>? Variables { get; set; }
}
