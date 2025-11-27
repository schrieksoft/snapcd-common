using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Groups;

/// <summary>
/// DTO for Group responses (GET operations).
/// </summary>
public class GroupReadDto : GroupCreateDto, IDto
{
    public Guid Id { get; set; }
}
