using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Stacks;

/// <summary>
/// DTO for Stack responses (GET operations).
/// Includes Id and all stack properties.
/// </summary>
public class StackReadDto : StackCreateDto, IDto
{
    public Guid Id { get; set; }
}
