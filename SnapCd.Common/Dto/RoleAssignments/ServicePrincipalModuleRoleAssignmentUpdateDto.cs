using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalModuleRoleAssignmentUpdateDto : ServicePrincipalModuleRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
