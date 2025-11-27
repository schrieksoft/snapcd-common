using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers;

public class GroupGroupMemberReadDto : GroupGroupMemberCreateDto, IDto
{
    public Guid Id { get; set; }
}