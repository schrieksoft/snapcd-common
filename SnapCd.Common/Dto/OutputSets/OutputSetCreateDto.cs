using SnapCd.Common.Dto.Outputs;

namespace SnapCd.Common.Dto.OutputSets;

/// <summary>
/// DTO for creating a new OutputSet (POST operations).
/// </summary>
public class OutputSetCreateDto
{
    public long Timestamp { get; set; }

    public string Checksum { get; set; } = null!;
    
    public List<OutputCreateDto>? Outputs { get; set; }
}
