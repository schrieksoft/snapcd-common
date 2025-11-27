using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Outputs;

/// <summary>
/// DTO for Output responses (GET operations).
/// </summary>
public class OutputReadDto : OutputCreateDto, IDto
{
    public Guid Id { get; set; }
    
    public Guid OutputSetId { get; set; }
    
}
