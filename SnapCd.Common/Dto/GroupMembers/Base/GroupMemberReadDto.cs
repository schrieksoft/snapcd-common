using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers.Base;

public class GroupMemberReadDto : GroupMemberCreateDto, IDto
{
    public Guid Id { get; set; }
}