using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalStackRoleAssignmentUpdateDto : ServicePrincipalStackRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
