using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Outputs;

/// <summary>
/// DTO for updating an existing Output (PUT operations).
/// </summary>
public class OutputUpdateDto : OutputCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
