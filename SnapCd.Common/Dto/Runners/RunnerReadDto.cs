using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Runners;

/// <summary>
/// DTO for Runner responses (GET operations).
/// </summary>
public class RunnerReadDto : RunnerCreateDto, IDto
{
    public Guid Id { get; set; }
}
