using SnapCd.Common.Dto.Outputs;
using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.OutputSets;

/// <summary>
/// DTO for updating an existing OutputSet (PUT operations).
/// </summary>
public class OutputSetUpdateDto : IUpdateDto
{
    public Guid Id { get; set; }
    
    public Guid ModuleId { get; set; }

    public long Timestamp { get; set; }

    public string Checksum { get; set; } = null!;
    
    public List<OutputUpdateDto>? Outputs { get; set; }
}
