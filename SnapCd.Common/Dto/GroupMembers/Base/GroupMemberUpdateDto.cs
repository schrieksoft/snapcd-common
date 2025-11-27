using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers.Base;

public class GroupMemberUpdateDto : GroupMemberCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
