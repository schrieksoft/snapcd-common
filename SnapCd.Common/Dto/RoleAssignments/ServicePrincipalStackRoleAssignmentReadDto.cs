using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalStackRoleAssignmentReadDto : ServicePrincipalStackRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}