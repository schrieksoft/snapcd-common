namespace SnapCd.Common.Dto.GroupMembers;

public class UserGroupMemberCreateDto
{
    public Guid GroupId { get; set; }
    public Guid UserId { get; set; }
}
