using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers;

public class UserGroupMemberReadDto : UserGroupMemberCreateDto, IDto
{
    public Guid Id { get; set; }
}