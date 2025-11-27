using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers;

public class GroupGroupMemberUpdateDto : GroupGroupMemberCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
