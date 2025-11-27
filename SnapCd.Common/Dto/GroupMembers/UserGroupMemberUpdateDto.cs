using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers;

public class UserGroupMemberUpdateDto : UserGroupMemberCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
