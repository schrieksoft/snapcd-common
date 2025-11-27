using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Runners;

/// <summary>
/// DTO for updating an existing Runner (PUT operations).
/// </summary>
public class RunnerUpdateDto : RunnerCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
