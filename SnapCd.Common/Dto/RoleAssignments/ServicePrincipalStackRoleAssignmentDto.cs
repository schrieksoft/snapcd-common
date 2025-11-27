using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalStackRoleAssignmentDto : ServicePrincipalStackRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}