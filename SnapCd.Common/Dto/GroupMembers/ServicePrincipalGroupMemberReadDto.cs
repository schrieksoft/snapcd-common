using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.GroupMembers;

public class ServicePrincipalGroupMemberReadDto : ServicePrincipalGroupMemberCreateDto, IDto
{
    public Guid Id { get; set; }
}