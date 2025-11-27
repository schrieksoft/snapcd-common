using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers;

public class ServicePrincipalGroupMemberUpdateDto : ServicePrincipalGroupMemberCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
